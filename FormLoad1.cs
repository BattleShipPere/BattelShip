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
            
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (count > 30)
            {
                timerLoad.Stop();
                Form3 form3 = new Form3(barcosColocados);
                form3.Show();
                this.Hide();

            }
            else
            {
                count++;
            }
        }
    }
}
