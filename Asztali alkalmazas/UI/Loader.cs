using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asztali_alkalmazas.UI
{
    public partial class Loader : Form
    {
        int move = 2;
        public Loader()
        {
            InitializeComponent();
        }
        private void Loader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;

            if(panelSlide.Left > 385)
            {
                panelSlide.Left= 0;
            }
            if(panelSlide.Left < 0)
            {
                move = 2;
            }
        }
    }
}
