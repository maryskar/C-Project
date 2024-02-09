namespace Pole_Chudes
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlKlaviatura = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlLabels = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlKlaviatura
            // 
            this.pnlKlaviatura.BackColor = System.Drawing.Color.Transparent;
            this.pnlKlaviatura.Location = new System.Drawing.Point(47, 163);
            this.pnlKlaviatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlKlaviatura.Name = "pnlKlaviatura";
            this.pnlKlaviatura.Size = new System.Drawing.Size(678, 185);
            this.pnlKlaviatura.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightBlue;
            this.btnStart.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(548, 379);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 73);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "СТАРТ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // pnlLabels
            // 
            this.pnlLabels.BackColor = System.Drawing.Color.Transparent;
            this.pnlLabels.Location = new System.Drawing.Point(145, 37);
            this.pnlLabels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLabels.Name = "pnlLabels";
            this.pnlLabels.Size = new System.Drawing.Size(537, 51);
            this.pnlLabels.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Black;
            this.lblTimer.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTimer.Location = new System.Drawing.Point(55, 379);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(88, 30);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "label1";
            this.lblTimer.Visible = false;
            // 
            // txt11
            // 
            this.txt11.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt11.Location = new System.Drawing.Point(145, 106);
            this.txt11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(439, 36);
            this.txt11.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Pole_Chudes.Properties.Resources.main_picture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 494);
            this.ControlBox = false;
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pnlLabels);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlKlaviatura);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поле чудес";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlKlaviatura;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlLabels;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txt11;
    }
}

