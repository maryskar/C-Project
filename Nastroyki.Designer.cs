namespace Pole_Chudes
{
    partial class Nastroyki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nastroyki));
            this.label1 = new System.Windows.Forms.Label();
            this.rdEasy = new System.Windows.Forms.RadioButton();
            this.rdUsual = new System.Windows.Forms.RadioButton();
            this.rdHard = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки:";
            // 
            // rdEasy
            // 
            this.rdEasy.AutoSize = true;
            this.rdEasy.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdEasy.Location = new System.Drawing.Point(60, 22);
            this.rdEasy.Name = "rdEasy";
            this.rdEasy.Size = new System.Drawing.Size(80, 22);
            this.rdEasy.TabIndex = 2;
            this.rdEasy.Text = "Легкий";
            this.rdEasy.UseVisualStyleBackColor = true;
            this.rdEasy.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rdUsual
            // 
            this.rdUsual.AutoSize = true;
            this.rdUsual.Checked = true;
            this.rdUsual.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdUsual.Location = new System.Drawing.Point(60, 65);
            this.rdUsual.Name = "rdUsual";
            this.rdUsual.Size = new System.Drawing.Size(95, 22);
            this.rdUsual.TabIndex = 3;
            this.rdUsual.TabStop = true;
            this.rdUsual.Text = "Обычный";
            this.rdUsual.UseVisualStyleBackColor = true;
            this.rdUsual.CheckedChanged += new System.EventHandler(this.RdUsual_CheckedChanged);
            // 
            // rdHard
            // 
            this.rdHard.AutoSize = true;
            this.rdHard.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdHard.Location = new System.Drawing.Point(60, 108);
            this.rdHard.Name = "rdHard";
            this.rdHard.Size = new System.Drawing.Size(95, 22);
            this.rdHard.TabIndex = 4;
            this.rdHard.Text = "Сложный";
            this.rdHard.UseVisualStyleBackColor = true;
            this.rdHard.CheckedChanged += new System.EventHandler(this.RdHard_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rdEasy);
            this.panel1.Controls.Add(this.rdHard);
            this.panel1.Controls.Add(this.rdUsual);
            this.panel1.Location = new System.Drawing.Point(42, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 157);
            this.panel1.TabIndex = 5;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lavender;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPlay.Location = new System.Drawing.Point(65, 311);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(166, 83);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Начать игру";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберете уровень сложности:";
            // 
            // Nastroyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nastroyki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поле чудес";
            this.Load += new System.EventHandler(this.Nastroyki_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton rdEasy;
        public System.Windows.Forms.RadioButton rdUsual;
        public System.Windows.Forms.RadioButton rdHard;
    }
}