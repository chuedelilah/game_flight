using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace game_flight
{
    class user
    {
        public Point pt = new Point(0,0);//使用者座標
        public Rectangle s;
        public int dir=10;
        Bitmap btmp;//處理像素資料所定義影像的物件
        public user (Image img,Point pt)//傳入將使用者以及開始座標
        {
            btmp = new Bitmap(img);//將圖片存成Bitmap
            btmp.MakeTransparent(Color.White);//將Bitmap 的指定色彩變為透明
            this.pt.X = pt.X;
            this.pt.Y = pt.Y;
            s = new Rectangle(pt.X, pt.Y,img.Width, img.Height);
        }
        public void Draw(Graphics g)//封裝 GDI+ 繪圖介面，此類別無法被繼承
        {
            g.DrawImage(btmp, pt);//以原始大小，在指定之位置繪製指定的 Image
        }
        public void Move(int x)//移動時改變的方向
        {
            if (x == 1)//上
            {
                dir = x;
                if (pt.Y - 10 >= 0)
                {
                    pt.Y -= 10;
                    s.Y -= 10;
                }
            }
            if (x == 2)//下
            {
                dir = x;
                if (pt.Y + s.Height + 10 < 780)
                {
                    pt.Y += 10;
                    s.Y += 10;
                }
            }
            if (x == 3)//左
            {
                dir = x;
                if (pt.X - 10 > 0)
                {
                    pt.X -= 10;
                    s.X -= 10;
                }
            }
            if (x == 4)//右
            {
                dir = x;
                if (pt.X + s.Width + 10 < 600)
                {
                    pt.X += 10;
                    s.X += 10;
                }
            }
        }
        public void Move()//移動
        {
            if (dir == 1)
            {
                if (pt.Y - 10 >= 0)
                {
                    pt.Y -= 10;
                    s.Y -= 10;
                }
            }
            if (dir == 2)
            {
                if (pt.Y + s.Height + 10 < 780)
                {
                    pt.Y += 10;
                    s.Y += 10;
                }
            }
            if (dir == 3)
            {
                if (pt.X - 10 > 0)
                {
                    pt.X -= 10;
                    s.X -= 10;
                }
            }
            if (dir == 4)
            {
                if (pt.X + s.Width + 10 < 600)
                {
                    pt.X += 10;
                    s.X += 10;
                }
            }

        }
    }
}
