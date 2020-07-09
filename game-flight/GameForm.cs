using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
// 有把屬性 DoubleBuffer 改成 true 讓畫面不會閃爍 
namespace game_flight
{
    public partial class GameForm : Form
    {
        user airplane; //主角飛機
        ArrayList boomList = new ArrayList();//飛彈們
        ArrayList emenyList= new ArrayList();//敵人們
        ArrayList emenyboomList = new ArrayList();//敵人子彈
        ArrayList cloudList = new ArrayList();//動態雲
        Random rd= new Random();
        SoundPlayer laser, explosion,music;
        public bool isGameOver= false;
        int score = 0;
        int time_h=0,time_s=0;
        public GameForm()
        {
            InitializeComponent();
            airplane = new user(Properties.Resources.flight1, new Point(250,600));
            laser = new SoundPlayer(Properties.Resources.LASER);
            explosion = new SoundPlayer(Properties.Resources.explosion);
            this.axWindowsMediaPlayer1.settings.autoStart = false;
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
            music = new SoundPlayer(Properties.Resources.YMCA);
            this.Invalidate();//重新繪製控制項 讓他持續有畫面
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (isGameOver == true) //若已經Game Over就畫字就好..
            {
                e.Graphics.DrawString("Game Over", new Font("標楷體", 24),Brushes.Red, new Point(200, 300));
                timer1.Stop();//讓timer暫停 
                string time_total =time_h + "分" + time_s + "秒";
                double total=(int.Parse(Flight_Score.Text))*10+(time_h*60+time_s)*(-1)+10;//計算所花時間與分數加總成績為何
                Write_Flight_Score B = new Write_Flight_Score(Flight_Score.Text,time_total,total);//傳入寫黨頁面  
                B.ShowDialog();//顯示
                this.Close();//關掉GameForm 
            }
            else// 主機還未死亡
            {
                Flight_Score.Text = score.ToString();//用一個textbox去接score
                e.Graphics.DrawString("SCORE:"+score, new Font("標楷體", 24), Brushes.Red, new Point(420, 0));
                e.Graphics.DrawString("Time:" + time_h+"分"+time_s+"秒", new Font("標楷體",20), Brushes.Red, new Point(420, 50));
                airplane.Draw(e.Graphics);//畫主機的圖
                for (int i = 0; i < cloudList.Count; i++) //畫出雲                                                                                                   
                {
                    cloud c = cloudList[i] as cloud;
                    c.Draw(e.Graphics);
                }
                for (int i = 0; i < boomList.Count; i++)
                {
                    boom bm = boomList[i] as boom;
                    bm.Draw(e.Graphics);
                }
                for (int i = 0; i < emenyList.Count; i++)//敵人飛機
                {
                    enemy em = emenyList[i] as enemy;
                    em.Draw(e.Graphics);
                    if (!em.live)//若敵人碰到了 則消失
                        emenyList.Remove(em);
                }
                for (int i = 0; i < emenyboomList.Count; i++)
                {
                    if (isGameOver == true)
                        break;//若已經結束了 就不用射子彈
                    enemy_boom eb = emenyboomList[i] as enemy_boom;
                    eb.Draw(e.Graphics);
                    if (!eb.live) 
                        emenyboomList.Remove(eb);
                    if (eb.CheckBoom(airplane))//表主機碰到敵軍的子彈
                    {
                        explosion.PlaySync();
                        emenyboomList.Remove(eb);
                        isGameOver = true;
                    }
                }
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && !isGameOver)//上
            {
                airplane.Move(1);
                this.Invalidate();
            }
            if (e.KeyCode == Keys.Down && !isGameOver)//下
            {
                airplane.Move(2);
                this.Invalidate();
            }
            if (e.KeyCode == Keys.Left && !isGameOver)//左
            {
                airplane.Move(3);
                this.Invalidate();
            }
            if (e.KeyCode == Keys.Right && !isGameOver)//右
            {
                airplane.Move(4);
                this.Invalidate();
            }
            if (e.KeyCode == Keys.Space && !isGameOver)
            {
                if (boomList.Count > 10)//主機飛彈只能射10個
                    return;
                boom boom;
                //boom = new boom(Properties.Resources.boom, new Point(0,400));
                boom = new boom(Properties.Resources.boom, new Point(0,0));
                boom.pt.X = airplane.pt.X + (airplane.s.Width / 2) - (boom.s.Width / 2);
                boom.pt.Y = airplane.pt.Y - boom.s.Height;
                boom.live = true;
                boomList.Add(boom);
                laser.Play();
                this.Invalidate();
                
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;//開始計時
            axWindowsMediaPlayer1.URL = @"https://www.youtube.com/watch?v=AGizmgReKcw";
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int test = rd.Next(0, 100);
            if(test<5&&!isGameOver)
            {
                enemy em = new enemy(Properties.Resources.flight_2, test);//新增敵人飛機
                emenyList.Add(em);
            }
            if (test >= 95 && !isGameOver)
            {
                cloud c = new cloud(Properties.Resources.cloud, Properties.Resources.cloud2, test);//新增動態雲
                cloudList.Add(c);
            }
            airplane.Move();//使用者飛機移動
            for (int i = 0; i < boomList.Count; i++)//使用者子彈
            {
                boom bm = boomList[i] as boom;
                bm.Move();//使用者子彈移動
                if (!bm.live) 
                    boomList.Remove(bm);
            }
            for (int i = 0; i < emenyList.Count; i++)
            {
                if (isGameOver == true)//若遊戲結束了則不用再做射擊
                    break;
                enemy em = emenyList[i] as enemy;
                em.Move();
                em.attack(emenyboomList);//新增敵軍的子彈
                if (em.check_crash(airplane.s))//敵軍飛機是否碰到使用者飛機
                {
                    explosion.PlaySync();
                    this.timer1.Enabled = false;//表timer不再跑
                    isGameOver = true;
                }
                if (em.check_boom(boomList))//打到就加十分 
                {
                    emenyList.Remove(em);
                    explosion.Play();
                    score += 10;
                }
               
            }
            for (int i = 0; i < emenyboomList.Count; i++)//敵人子彈
            {
                if (isGameOver == true)
                    break;
                enemy_boom eb = emenyboomList[i] as enemy_boom;
                eb.Move();
                if (!eb.live) 
                    emenyboomList.Remove(eb);//如果敵人飛機已經死掉那就不用再新增子彈 
            }
            if (emenyboomList.Count > 10)//若敵人子彈多於10則跳出
                return;
            for (int i = 0; i < cloudList.Count; i++)
            {
                cloud c = cloudList[i] as cloud;
                c.Move(cloudList);//雲層移動
                if (!c.live)
                    cloudList.Remove(c);
            }
            this.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time_s == 59)
            {
                time_s = 0;//歸零 重0開始計時秒數
                time_h++;//表一分鐘
            }
            time_s++;
        }
    }
}
