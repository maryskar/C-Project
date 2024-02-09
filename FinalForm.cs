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
    public partial class FinalForm : Form
    {
        public string slslsl;
        public FinalForm()
        {
            InitializeComponent();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            //label3.Text="У Вас "+
            //slslsl=label3.Text
            //MainForm main = new MainForm();
            //main.ShowDialog();
            //label1.Text = "Игра закончена. Количество набранных Вами баллов " +main.points.ToString();
            //main.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // при нажатии на кнопку заново запускается игра т е нач форма
            //this.Dispose();
            //HelloForm hello = new HelloForm();
            //hello.ShowDialog();
            //hello.Dispose();
            
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Увы! Игра закончена. Хорошего дня!");
            Application.Exit();
            //при нажатии на кнопку завершить игра заканчивается
            //this.Close();
            //this.Dispose();
        }
    }
}
