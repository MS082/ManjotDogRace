namespace ManjotDogRace
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lstPlayer = new System.Windows.Forms.ComboBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.nmAmount = new System.Windows.Forms.NumericUpDown();
            this.lstDog = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.frthDog = new System.Windows.Forms.PictureBox();
            this.scndDog = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.thrdDog = new System.Windows.Forms.PictureBox();
            this.frstDog = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frthDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scndDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thrdDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frstDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Choose the Player";
            // 
            // lstPlayer
            // 
            this.lstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayer.FormattingEnabled = true;
            this.lstPlayer.Items.AddRange(new object[] {
            "Sona has 90  Dollar ",
            "Manjot has 70 Dollar",
            "Sabhi has 80 Dollar"});
            this.lstPlayer.Location = new System.Drawing.Point(3, 335);
            this.lstPlayer.Name = "lstPlayer";
            this.lstPlayer.Size = new System.Drawing.Size(250, 32);
            this.lstPlayer.TabIndex = 22;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player1.Location = new System.Drawing.Point(302, 313);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(317, 27);
            this.Player1.TabIndex = 23;
            this.Player1.Text = "1                   Choose the Player";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player2.Location = new System.Drawing.Point(302, 339);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(317, 27);
            this.Player2.TabIndex = 24;
            this.Player2.Text = "2                   Choose the Player";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player3.Location = new System.Drawing.Point(302, 366);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(317, 27);
            this.Player3.TabIndex = 25;
            this.Player3.Text = "3                   Choose the Player";
            // 
            // nmAmount
            // 
            this.nmAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmAmount.Location = new System.Drawing.Point(4, 468);
            this.nmAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAmount.Name = "nmAmount";
            this.nmAmount.Size = new System.Drawing.Size(120, 31);
            this.nmAmount.TabIndex = 26;
            this.nmAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstDog
            // 
            this.lstDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDog.FormattingEnabled = true;
            this.lstDog.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstDog.Location = new System.Drawing.Point(3, 405);
            this.lstDog.Name = "lstDog";
            this.lstDog.Size = new System.Drawing.Size(158, 32);
            this.lstDog.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(21, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Choose the Dog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(21, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Enter the Amount";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(646, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 38);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frthDog
            // 
            this.frthDog.Image = global::ManjotDogRace.Properties.Resources.dog4;
            this.frthDog.Location = new System.Drawing.Point(0, 224);
            this.frthDog.Name = "frthDog";
            this.frthDog.Size = new System.Drawing.Size(74, 37);
            this.frthDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frthDog.TabIndex = 20;
            this.frthDog.TabStop = false;
            // 
            // scndDog
            // 
            this.scndDog.Image = global::ManjotDogRace.Properties.Resources.dog2;
            this.scndDog.Location = new System.Drawing.Point(0, 144);
            this.scndDog.Name = "scndDog";
            this.scndDog.Size = new System.Drawing.Size(74, 36);
            this.scndDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scndDog.TabIndex = 17;
            this.scndDog.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox9.Location = new System.Drawing.Point(792, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 285);
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // thrdDog
            // 
            this.thrdDog.Image = global::ManjotDogRace.Properties.Resources.dog3;
            this.thrdDog.Location = new System.Drawing.Point(0, 183);
            this.thrdDog.Name = "thrdDog";
            this.thrdDog.Size = new System.Drawing.Size(74, 36);
            this.thrdDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thrdDog.TabIndex = 15;
            this.thrdDog.TabStop = false;
            // 
            // frstDog
            // 
            this.frstDog.Image = global::ManjotDogRace.Properties.Resources.dog1;
            this.frstDog.Location = new System.Drawing.Point(0, 105);
            this.frstDog.Name = "frstDog";
            this.frstDog.Size = new System.Drawing.Size(74, 35);
            this.frstDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frstDog.TabIndex = 14;
            this.frstDog.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(278, 405);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(504, 103);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDog);
            this.Controls.Add(this.nmAmount);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.lstPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frthDog);
            this.Controls.Add(this.scndDog);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.thrdDog);
            this.Controls.Add(this.frstDog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frthDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scndDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thrdDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frstDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox thrdDog;
        private System.Windows.Forms.PictureBox frstDog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox scndDog;
        private System.Windows.Forms.PictureBox frthDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstPlayer;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.NumericUpDown nmAmount;
        private System.Windows.Forms.ComboBox lstDog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

