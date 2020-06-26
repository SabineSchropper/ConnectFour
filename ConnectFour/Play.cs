using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectFourData;
using ConnectFourLogic;

namespace ConnectFour
{
    public partial class Play : Form
    {
        Controller controller = new Controller();
        public Play()
        {
            var form = new Player(controller);
            form.Show();          
            form.TopMost = true;
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
          
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }
    }
}
