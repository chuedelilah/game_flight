using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using 
namespace game_flight
{
    public partial class See_Charts : Form
    {
        public See_Charts()
        {
            InitializeComponent();
        }

        private void See_Charts_Load(object sender, EventArgs e)
        {
            DataSet ds1= new DataSet();
            ds1.ReadXml(System.Windows.Forms.Application.ExecutablePath.Substring(0, System.Windows.Forms.Application.ExecutablePath.IndexOf("bin")) + @"Flight.xml");//將文件讀入ds物件內
            dataGridView1.DataSource = ds1.Tables["飛機"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1.ReadXml(System.Windows.Forms.Application.ExecutablePath.Substring(0, System.Windows.Forms.Application.ExecutablePath.IndexOf("bin")) + @"Flight.xml");//將文件讀入ds物件內
            dataGridView1.DataSource = ds1.Tables["飛機"];
            //dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Descending);
            for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (int.Parse(dataGridView1.Rows[j].Cells[3].Value.ToString()) < int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                    {
                        string a;
                        a = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        dataGridView1.Rows[i].Cells[0].Value = dataGridView1.Rows[j].Cells[0].Value.ToString();
                        dataGridView1.Rows[j].Cells[0].Value = a;

                        a = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dataGridView1.Rows[j].Cells[1].Value.ToString();
                        dataGridView1.Rows[j].Cells[1].Value = a;

                        a = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dataGridView1.Rows[j].Cells[2].Value.ToString();
                        dataGridView1.Rows[j].Cells[2].Value = a;

                        a = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dataGridView1.Rows[j].Cells[3].Value.ToString();
                        dataGridView1.Rows[j].Cells[3].Value = a;
                    }
                }
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1.ReadXml(System.Windows.Forms.Application.ExecutablePath.Substring(0, System.Windows.Forms.Application.ExecutablePath.IndexOf("bin")) + @"Flight.xml");//將文件讀入ds物件內
            dataGridView1.DataSource = ds1.Tables["飛機"];
            //dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Descending);
            for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (int.Parse(dataGridView1.Rows[j].Cells[1].Value.ToString()) < int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                    {
                        string a;
                        a = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        dataGridView1.Rows[i].Cells[0].Value = dataGridView1.Rows[j].Cells[0].Value.ToString();
                        dataGridView1.Rows[j].Cells[0].Value = a;

                        a = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dataGridView1.Rows[j].Cells[1].Value.ToString();
                        dataGridView1.Rows[j].Cells[1].Value = a;

                        a = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dataGridView1.Rows[j].Cells[2].Value.ToString();
                        dataGridView1.Rows[j].Cells[2].Value = a;

                        a = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dataGridView1.Rows[j].Cells[3].Value.ToString();
                        dataGridView1.Rows[j].Cells[3].Value = a;
                    }
                }
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1.ReadXml(System.Windows.Forms.Application.ExecutablePath.Substring(0, System.Windows.Forms.Application.ExecutablePath.IndexOf("bin")) + @"Flight.xml");//將文件讀入ds物件內
            dataGridView1.DataSource = ds1.Tables["飛機"];
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Descending);           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
