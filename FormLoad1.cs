using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattelShip
{
    public partial class FormLoad1 : Form
    {
        private int count = 0;
        List<Object> barcosColocados;

        public FormLoad1(List<Object> barcos)
        {
            InitializeComponent();
            barcosColocados = barcos;
        }

        private void FormLoad1_Load(object sender, EventArgs e)
        {
            pic_Box_Load.Load(@"../img/load1.gif");
            //pic_Box_Load.SizeMode =
            //pic_Box_Load.Location = new Point(this.Width / 2 - pic_Box_Load.Width / 2,
               //this.Height / 2 - pic_Box_Load.Height / 2);
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (count > 30)
            {
                timerLoad.Stop();
                Hide();
                Form3 form3 = new Form3(barcosColocados);
                form3.Show();

            }
            else
            {
                count++;
            }
        }
    }
}
