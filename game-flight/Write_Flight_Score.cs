using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace game_flight
{
    public partial class Write_Flight_Score : Form
    {
        public Write_Flight_Score(string Score_total,string time_total,double grade)
        {
            InitializeComponent();
            score.Text = Score_total;
            time.Text = time_total;
            Grade.Text = Convert.ToString(grade);
            return;
        }
        public string Score_total
        {
            set
            {
                score.Text = value;
            }
            get
            {
                return score.Text;
            }
        }
        public string time_total
        {
            set
            {
                time.Text = value;
            }
            get
            {
                return time.Text;
            }
        }
        public string grade
        {
            set
            {
                Grade.Text = value;
            }
            get
            {
                return Grade.Text;
            }
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();//建立dataset物件
            ds.ReadXml(System.Windows.Forms.Application.ExecutablePath.Substring(0, System.Windows.Forms.Application.ExecutablePath.IndexOf("bin")) + @"Flight.xml");//將文件讀入ds物件內
            DataColumn dc = ds.Tables["飛機"].Columns["ID"];
            ds.Tables["飛機"].Constraints.Add("PK_ID", dc, true);//設定ID為主建
            DataRow dr = ds.Tables["飛機"].Rows.Find(user.Text);//使用row屬性find找尋主鍵搜尋Id
            if (dr == null)
            {
                DataRow temp = ds.Tables["飛機"].NewRow();
                temp["ID"] = user.Text;
                temp["分數"] = score.Text;
                temp["時間"] = time.Text;
                temp["總成績"] = Grade.Text;
                ds.Tables["飛機"].Rows.Add(temp);
                // ....\bin\XXX.exe 但我只要 ~ bin 之後 我都不要 所以用 substring 去取得我要的資訊
                // xml 要 跟著執行黨 
            }
            else
            {
                int a = int.Parse(dr["分數"].ToString());
                int b = int.Parse(score.Text);
                if (b > a)
                {
                    dr["分數"] = score.Text;
                    dr["時間"] = time.Text;
                    dr["總成績"] = Grade.Text;
                }
            }
            ds.WriteXml(System.Windows.Forms.Application.ExecutablePath.Substring(0, System.Windows.Forms.Application.ExecutablePath.IndexOf("bin")) + @"\Flight.xml");
            dataGridView1.DataSource = ds.Tables["飛機"];
            //dataGridView1.Sort(dataGridView1.Columns[2], System.ComponentModel.ListSortDirection.Descending);
            File.Visible = false;
            back.Visible = true;//顯示返回畫面的案件
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Write_Flight_Score_Load(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
