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
    public partial class MainForm : Form
    {
        List<string> lstWords = new List<string>();
        List<string> lstBukva = new List<string>();
        List<string> lstGlasnye = new List<string>();
        List<string> lstZagadWords = new List<string>();
        List<string> lstBukvaZagad = new List<string>();
        Random myrnd = new Random();
        Nastroyki nastroykiFrm = new Nastroyki();
        int m = 0, s = 0, mas=0,sekunda = 0;
        int z = 0, kolv = 0, k = 0;
        string zzSl = "";
        public int points = 0;
        public string finalnoeslovo = "", finalllal = "";

        public MainForm()
        {
            InitializeComponent();
        }

        public void zanovo()
        {
            btnStart.Enabled = false;
            kolv = 0;
            HelloForm hi = new HelloForm();
            hi.ShowDialog();
            kolv = hi.kk;
            timer1.Stop();
            s = hi.dddddd;
            points = 0;
            points = hi.mmm;
            hi.Dispose();
            sekunda = 0;
            sekunda = s;
            mas = 0;
            txt11.Text = "";
            this.Visible = true;
            lblTimer.Text = "";

            lstBukvaZagad.Clear();
            lstZagadWords.Clear();
            btnStart.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zanovo();

            lstBukva.Clear();
            lstBukva.Add("Й");
            lstBukva.Add("Ц");
            lstBukva.Add("У");
            lstBukva.Add("К");
            lstBukva.Add("Е");
            lstBukva.Add("Н");
            lstBukva.Add("Г");
            lstBukva.Add("Ш");
            lstBukva.Add("Щ");
            lstBukva.Add("З");
            lstBukva.Add("Х");
            lstBukva.Add("Ъ");
            lstBukva.Add("Ф");
            lstBukva.Add("Ы");
            lstBukva.Add("В");
            lstBukva.Add("А");
            lstBukva.Add("П");
            lstBukva.Add("Р");
            lstBukva.Add("О");
            lstBukva.Add("Л");
            lstBukva.Add("Д");
            lstBukva.Add("Ж");
            lstBukva.Add("Э");
            lstBukva.Add("Я");
            lstBukva.Add("Ч");
            lstBukva.Add("С");
            lstBukva.Add("М");
            lstBukva.Add("И");
            lstBukva.Add("Т");
            lstBukva.Add("Ь");
            lstBukva.Add("Б");
            lstBukva.Add("Ю");

            lstGlasnye.Clear();
            lstGlasnye.Add("А");
            lstGlasnye.Add("У");
            lstGlasnye.Add("Е");
            lstGlasnye.Add("Ы");
            lstGlasnye.Add("О");
            lstGlasnye.Add("Э");
            lstGlasnye.Add("Я");
            lstGlasnye.Add("И");
            lstGlasnye.Add("Ю");

            lstWords.Clear();
            lstWords.Add("ПРОГРАММА");
            lstWords.Add("СОЧИНЕНИЕ");
            lstWords.Add("ПАРОХОД");
            lstWords.Add("РЕВОЛЮЦИЯ");
            lstWords.Add("ТРАПЕЦИЯ");
            lstWords.Add("ЖИВОТНОЕ");
            lstWords.Add("ПЕСНЯ");
            lstWords.Add("КВАРТИРА");
            lstWords.Add("КОНФЛИКТ");
            lstWords.Add("ПРОЦЕСС");
            lstWords.Add("ЭКСКУРСИЯ");
            lstWords.Add("ИМПЕРАТОР");
            lstWords.Add("ЛЕСТНИЦА");
            lstWords.Add("СОЛНЦЕ");
            lstWords.Add("ЛАБИРИНТ");

            //генерация кнопок (клавиш на клавиатуре)
            int x = 0, y = 0;
            for (int stolb = 1; stolb <= 3; stolb++)
            {
                for (int stroka = 1; stroka <= 12 - stolb + 1; stroka++)
                {
                    Button btn = new Button();
                    m++;
                    btn.Text = lstBukva[m - 1].ToString();
                    btn.Width = 56;
                    btn.Height = 56;
                    btn.Left = x;
                    btn.Top = y;
                    btn.Click += new System.EventHandler(bbb_Click);
                    pnlKlaviatura.Controls.Add(btn);
                    x += 56;
                    btn.Enabled = false;
                }

                if (m == 23) { x = 0 + ((stolb) * 56) - 28; }
                else { x = 0 + ((stolb) * 28); }
                y += 56;
                
            }
            
        }

        private void bbb_Click(object sender, EventArgs e)
        {
            //при нажатии на нужную кнопнку меняется цвет кнопки, и если буква угадана, то клавиша зеленая
            Button a = (Button)sender;
            if (lstBukvaZagad.Contains(a.Text))
            {

                a.BackColor = Color.Green;
                a.Enabled = false;
            }
            else
            {
                a.BackColor = Color.Red;
                a.Enabled = false;
            }

            //если БУКВА ЕСТЬ В СЛОВЕ, она ПОКАЗЫВАТСЯ в текст поле.
            for (int im = 0; im < txt11.Text.Length / 5; im++)
            {
                if (a.Text == lstBukvaZagad[im].ToString())
                {
                    string sl = txt11.Text.Substring(0, im * 5) + a.Text + txt11.Text.Substring(im * 5 + 1);
                    txt11.Text = sl;
                    k++;
                }
            }

            //если СЛОВО ПОЛНОСТЬЮ УГАДАНО, появляется MessageBox.
            if (k == zzSl.Length)
            {
                mas++;
                timer1.Stop();
                lblTimer.Text = "Вы справились за " + sekunda.ToString() + " секунд.";
                points = points * mas; 
                foreach (Button button in pnlKlaviatura.Controls)
                {
                    button.Enabled = false;
                }
                MessageBox.Show("Вы выиграли! У Вас " + points.ToString() + " баллов!");
                btnStart.Enabled = true;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            sekunda = s;
            btnStart.Enabled = false;
            txt11.Text = "";

            //кнопки на панели белые.
            foreach (Button but in pnlKlaviatura.Controls)
            {
                but.Enabled = true;
                but.BackColor = Color.White;
            }

            //ПЕРЕМЕШИВАЕМ СЛОВА и ПОКАЗЫВАЕМ В ТЕКСТ ПОЛЕ в виде зведочек.
            do
            {
                z = myrnd.Next(0, lstWords.Count);
            } while (lstZagadWords.Contains(lstWords[z]));
            lstZagadWords.Add(lstWords[z]);
            lstBukvaZagad.Clear();
            zzSl = lstWords[z];
            k = 0;
            foreach (char elem in lstWords[z])
            {
                lstBukvaZagad.Add(elem.ToString());
            }
            int len = lstWords[z].Length;
            txt11.Text = "";
            for (int i = 1; i <= len; i++)
            {
                txt11.Text += "*    ";
            }
            //

            //генерация labels
            pnlLabels.Controls.Clear();
            int cv = 0;
            int x = 0, y = 0;
            for (int i = 0; i < txt11.Text.Length / 5; i++)
            {
                Label lbl = new Label();
                m++;
                cv++;
                lbl.Width = 45;
                lbl.Height = 45;
                lbl.Left = x;
                lbl.Top = y;
                lbl.Tag = lstBukvaZagad[i].ToString();
                pnlLabels.Controls.Add(lbl);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                x += 45;

                //если гласная то лэйбел красного цвета
                if (lstGlasnye.Contains(lbl.Tag))
                {

                    lbl.BackColor = Color.LightPink;
                }
                else
                {
                    lbl.BackColor = Color.Azure;
                }
            }


            //если ОТГАДАНЫ ВСЕ СЛОВА, то ИГРА ЗАКАНЧИВАЕТСЯ, переход на последнюю форму.
            if (lstZagadWords.Count > kolv)
            {
                this.Visible = false;
                finalllal = "У Вас " + points.ToString() + "  баллов!";
                FinalForm final = new FinalForm();
                finalnoeslovo = finalllal;
                final.lblFinal.Text = finalnoeslovo;
                final.ShowDialog();
                final.Dispose();
                btnStart.Enabled = true;
                zanovo();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //работа таймера
            sekunda--;
            if (sekunda > 0)
            {
                lblTimer.Visible = true;
                lblTimer.Text = "Осталось " + sekunda.ToString() + " секунд.";
            }
            else
            {
                timer1.Enabled = false;
                timer1.Stop();
                lblTimer.Text = "";
                MessageBox.Show("Время вышло. Загаданное слово " + lstWords[z]);
                foreach (Button btn in pnlKlaviatura.Controls)
                {
                    btn.Enabled = false;
                }
                btnStart.Enabled = true;
                sekunda = s;
            }
        }
    }
}
