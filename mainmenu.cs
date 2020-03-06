using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 game = new Form1();
            game.Show();
        }

        
        private void mainmenu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
