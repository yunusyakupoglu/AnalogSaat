namespace AnalogSaat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxSaat = new System.Windows.Forms.PictureBox();
            this.pictureBoxAkrep = new System.Windows.Forms.PictureBox();
            this.pictureBoxYelkovan = new System.Windows.Forms.PictureBox();
            this.pictureBoxSaniye = new System.Windows.Forms.PictureBox();
            this.pictureBoxMili = new System.Windows.Forms.PictureBox();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSaat = new System.Windows.Forms.TextBox();
            this.textBoxDakika = new System.Windows.Forms.TextBox();
            this.labelSaat = new System.Windows.Forms.Label();
            this.labelDakika = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAkrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYelkovan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaniye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMili)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxSaat
            // 
            this.pictureBoxSaat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSaat.Image = global::AnalogSaat.Properties.Resources.kadran;
            this.pictureBoxSaat.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSaat.Name = "pictureBoxSaat";
            this.pictureBoxSaat.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSaat.TabIndex = 0;
            this.pictureBoxSaat.TabStop = false;
            // 
            // pictureBoxAkrep
            // 
            this.pictureBoxAkrep.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAkrep.Image = global::AnalogSaat.Properties.Resources.akrep;
            this.pictureBoxAkrep.Location = new System.Drawing.Point(507, 0);
            this.pictureBoxAkrep.Name = "pictureBoxAkrep";
            this.pictureBoxAkrep.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxAkrep.TabIndex = 2;
            this.pictureBoxAkrep.TabStop = false;
            // 
            // pictureBoxYelkovan
            // 
            this.pictureBoxYelkovan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxYelkovan.Image = global::AnalogSaat.Properties.Resources.yelkovan;
            this.pictureBoxYelkovan.Location = new System.Drawing.Point(507, 121);
            this.pictureBoxYelkovan.Name = "pictureBoxYelkovan";
            this.pictureBoxYelkovan.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxYelkovan.TabIndex = 3;
            this.pictureBoxYelkovan.TabStop = false;
            // 
            // pictureBoxSaniye
            // 
            this.pictureBoxSaniye.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSaniye.Image = global::AnalogSaat.Properties.Resources.saniye;
            this.pictureBoxSaniye.Location = new System.Drawing.Point(506, 200);
            this.pictureBoxSaniye.Name = "pictureBoxSaniye";
            this.pictureBoxSaniye.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSaniye.TabIndex = 4;
            this.pictureBoxSaniye.TabStop = false;
            // 
            // pictureBoxMili
            // 
            this.pictureBoxMili.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMili.Image = global::AnalogSaat.Properties.Resources.mili;
            this.pictureBoxMili.Location = new System.Drawing.Point(506, 296);
            this.pictureBoxMili.Name = "pictureBoxMili";
            this.pictureBoxMili.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxMili.TabIndex = 5;
            this.pictureBoxMili.TabStop = false;
            this.pictureBoxMili.Visible = false;
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxSaat);
            this.groupBox1.Controls.Add(this.textBoxDakika);
            this.groupBox1.Controls.Add(this.labelSaat);
            this.groupBox1.Controls.Add(this.labelDakika);
            this.groupBox1.Location = new System.Drawing.Point(0, 506);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarla";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "DURDUR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "BAŞLAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSaat
            // 
            this.textBoxSaat.Location = new System.Drawing.Point(134, 102);
            this.textBoxSaat.Name = "textBoxSaat";
            this.textBoxSaat.Size = new System.Drawing.Size(125, 27);
            this.textBoxSaat.TabIndex = 3;
            // 
            // textBoxDakika
            // 
            this.textBoxDakika.Location = new System.Drawing.Point(134, 51);
            this.textBoxDakika.Name = "textBoxDakika";
            this.textBoxDakika.Size = new System.Drawing.Size(125, 27);
            this.textBoxDakika.TabIndex = 2;
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Location = new System.Drawing.Point(69, 105);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(44, 20);
            this.labelSaat.TabIndex = 1;
            this.labelSaat.Text = "SAAT";
            // 
            // labelDakika
            // 
            this.labelDakika.AutoSize = true;
            this.labelDakika.Location = new System.Drawing.Point(69, 54);
            this.labelDakika.Name = "labelDakika";
            this.labelDakika.Size = new System.Drawing.Size(62, 20);
            this.labelDakika.TabIndex = 0;
            this.labelDakika.Text = "DAKİKA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 682);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxMili);
            this.Controls.Add(this.pictureBoxSaniye);
            this.Controls.Add(this.pictureBoxYelkovan);
            this.Controls.Add(this.pictureBoxAkrep);
            this.Controls.Add(this.pictureBoxSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAkrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYelkovan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaniye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMili)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSaat;
        private System.Windows.Forms.PictureBox pictureBoxAkrep;
        private System.Windows.Forms.PictureBox pictureBoxYelkovan;
        private System.Windows.Forms.PictureBox pictureBoxSaniye;
        private System.Windows.Forms.PictureBox pictureBoxMili;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSaat;
        private System.Windows.Forms.TextBox textBoxDakika;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Label labelDakika;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
