using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
namespace game_flight
{
    class enemy
    {
        public Point pt = new Point(0,0);
        public Rectangle s;//用長方形框整個圖
        public int dir_y = 0;//移動方向
        public int dir_x = 10;
        Bitmap btmp;
        public bool live = true;//存在與否
        Random var_enemy = new Random();
        public enemy(Image img, int var)//傳回圖片和亂數
        {
            Random var_enemy = new Random(var);//建立亂數
            btmp = new Bitmap(img);
            btmp.MakeTransparent(Color.White);//將Bitmap 的指定色彩變為透明
            this.pt.X = var_enemy.Next(0, 400);//用亂數決定敵機開始座標
            this.pt.Y = 0;
            s = new Rectangle(pt.X, pt.Y, img.Width, img.Height);
            this.dir_x = var_enemy.Next(-5, 5);//用亂數決定移動的方向
            this.dir_y = var_enemy.Next(5, 20);
        }
        public void Draw(Graphics g)
        {
            if (live == true)
                g.DrawImage(btmp, pt);
        }
        public void attack(ArrayList emenyboomList)
        {
            int test = var_enemy.Next(0, 100);
            if(test<5)
            {
                if (emenyboomList.Count > 10)
                    return;
                enemy_boom boom;
                boom = new enemy_boom(Properties.Resources.boom_2, new Point(0, 0), this.dir_y);
                boom.pt.X = this.pt.X + (this.s.Width / 2) - (boom.s.Width / 2);
                boom.pt.Y = this.pt.Y + boom.s.Height;//定位飛彈的位置
                boom.live = true;
                emenyboomList.Add(boom);
            }
        }
        public void Move()
        {
            pt.X += dir_x;
            pt.Y += dir_y;//朝移動的方向
            s.X = pt.X;
            s.Y = pt.Y;
            //if (pt.Y >=800)
            if(pt.Y>=780)
                live = false;//當飛彈飛出去 就設false 表不存在
        }
        public bool check_boom(ArrayList boomList)
        {
            for (int i = 0; i < boomList.Count; i++)
            {
                boom b = boomList[i] as boom;//將陣列list中的第i個設為boom 物件
                if (s.IntersectsWith(b.s))//判斷是否碰到主機所射出的子彈
                {
                    b.live = false;
                    boomList.Remove(b);
                    live = false;
                    return true;
                }
            }
            return false;
        }
        public bool check_crash(Rectangle ss)//將使用者user的Rectangle傳入
        {
            if (s.IntersectsWith(ss)) //判斷是否主機與敵對飛機有撞到
                return true;
            return false;
        }
    }
}
