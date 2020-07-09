using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace game_flight
{
    class boom
    {
        public Point pt = new Point(250, 500);
        public Rectangle s;//用長方形框整個圖
        public int dir_y = -10;//移動方向 ↑
        public int dir_x = 0;
        Bitmap btmp;
        public bool live = true;//存在與否
        public boom(Image img, Point pt)
        {
            btmp = new Bitmap(img);
            btmp.MakeTransparent(Color.White);//將Bitmap 的指定色彩變為透明
            this.pt.X = pt.X;//把傳入的位置傳給 this
            this.pt.Y = pt.Y;
            s = new Rectangle(pt.X, pt.Y, img.Width, img.Height);
        }
        public void Draw(Graphics g)
        {
            if (live == true)
                g.DrawImage(btmp, pt);
        }
        public void Move()
        {
            if (live != true)
                return;
            pt.X += dir_x;
            pt.Y += dir_y;
            s.X = pt.X;//代表要移動的方向
            s.Y = pt.Y;
            if (pt.Y <= 0)
                live = false;//當飛彈飛出去 就設false 表不存在
        }
    }
}
