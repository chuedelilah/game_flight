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
    public partial class Flight_Menu : Form
    {
        public Flight_Menu()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            GameForm f1 = new GameForm();
            f1.Show();
        }

        private void Charts_Click(object sender, EventArgs e)
        {
            See_Charts f1 = new See_Charts();
            f1.Show();
        }
    }
}
