using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace game_flight
{
    class enemy_boom
    {
        public Point pt = new Point(250, 500);
        public Rectangle s;//用長方形框整個圖
        public int dirY = 10;//移動方向
        public int dirX = 0;
        Bitmap btmp;
        public bool live = true;//存在與否
        public enemy_boom(Image img, Point pt,int dirY)//傳y方向
        {
            btmp = new Bitmap(img);
            btmp.MakeTransparent(Color.White);
            this.pt.X = pt.X;
            this.pt.Y = pt.Y;
            this.dirY = dirY;
            s = new Rectangle(pt.X, pt.Y ,img.Width, img.Height);
        }
        public void Draw(Graphics g)
        {
            if(live)
                g.DrawImage(btmp, pt);
        }
        public bool CheckBoom(user airplane)
        {

            if (s.IntersectsWith(airplane.s))//表敵軍飛機子彈碰到主機
            {
                live = false;
                return true;
            }
            return false;
        }
        public void Move()
        {

            pt.X += dirX;
            pt.Y += dirY;
            s.X = pt.X;
            s.Y = pt.Y;
            if(pt.Y>780)
                live=false;
        }

    }
}
