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
    public partial class HelloForm : Form
    {
        public int kk = 0, dddddd = 0, mmm = 0;
        public HelloForm()
        {
            InitializeComponent();
        }
      
        private void Button2_Click(object sender, EventArgs e)
        {
            //показываем ФОРМУ НАСТРОЕК
            this.Visible = false;
            Nastroyki nastroykifrm = new Nastroyki();
            DialogResult dlg = nastroykifrm.ShowDialog();        
            dddddd = nastroykifrm.sek;
            mmm = nastroykifrm.urovPoint;
            kk = Convert.ToInt32(numSlova.Value);
            
            //если закрываем форму через крестик, то возвращаемся на первую форму.
            if (dlg == DialogResult.OK)
            {
                nastroykifrm.Dispose();

            }
            else
            {
                this.Visible = true;
            }

        }

        private void HelloForm_Load(object sender, EventArgs e)
        {
            kk = Convert.ToInt32(numSlova.Value);
        }
    }
}
