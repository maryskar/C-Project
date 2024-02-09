using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole_Chudes
{
    public partial class Nastroyki : Form
    {
        public int sek = 40, urovPoint = 5;
        public Nastroyki()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sek = 50;
            urovPoint = 2;
        }

        private void RdUsual_CheckedChanged(object sender, EventArgs e)
        {
            sek = 40;
            urovPoint = 6;
        }

        private void RdHard_CheckedChanged(object sender, EventArgs e)
        {
            sek = 25;
            urovPoint = 10;
        }

        private void Nastroyki_Load(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
