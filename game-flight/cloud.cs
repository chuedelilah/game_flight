using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
namespace game_flight
{
    class cloud//跟使用者飛機類似
    {
        public Point pt = new Point(0, 0);
        public Rectangle s;//用長方形框整個圖
        public int dir_y = 0;
        public int dir_x = 10;
        Bitmap btmp;
        public bool live = true;//存在與否
        Random var_cloud = new Random();
        public cloud(Image img1,Image img2, int var)
        {
            Random var_cloud = new Random(var);//建立亂數
            if (var_cloud.Next(10, 200) % 2 == 0)//min 10 ~ Max 200 
            {
                btmp = new Bitmap(img1);
            }
            else btmp = new Bitmap(img2);
            btmp.MakeTransparent(Color.White);//將Bitmap 的指定色彩變為透明
            this.pt.X = var_cloud.Next(0, 400);//用亂數決定敵機開始座標
            this.pt.Y = 0;
            s = new Rectangle(pt.X, pt.Y, img1.Width, img1.Height);
            this.dir_y = var_cloud.Next(5, 20);//用亂數決定移動的方向
            this.dir_x = var_cloud.Next(-5, 5);
        }
        public void Draw(Graphics g)
        {
            if (live == true)
                g.DrawImage(btmp, pt);
        }
        public void Move(ArrayList CloudboomList)
        {
            pt.X += dir_x;
            pt.Y += dir_y;
            s.X = pt.X;
            s.Y = pt.Y;
            if (pt.Y >= 780)
                live = false;//當飛彈飛出去 就設false 表不存在
        }
    }
}
