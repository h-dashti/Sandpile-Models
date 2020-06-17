namespace SandPile
{
    partial class FormSand
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAvalanche = new System.Windows.Forms.Button();
            this.trackBar_Latency = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIt = new System.Windows.Forms.NumericUpDown();
            this.labelNumTopple = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxStructure = new System.Windows.Forms.GroupBox();
            this.textBox_Ly = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_epsilon = new System.Windows.Forms.GroupBox();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonEliptic = new System.Windows.Forms.RadioButton();
            this.radioButtonDirectal = new System.Windows.Forms.RadioButton();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_Lx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEpsilonMethod = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSnapshot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Latency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIt)).BeginInit();
            this.groupBoxStructure.SuspendLayout();
            this.groupBox_epsilon.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(117, 27);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAvalanche
            // 
            this.buttonAvalanche.Location = new System.Drawing.Point(15, 27);
            this.buttonAvalanche.Name = "buttonAvalanche";
            this.buttonAvalanche.Size = new System.Drawing.Size(75, 23);
            this.buttonAvalanche.TabIndex = 3;
            this.buttonAvalanche.Text = "Avalanche";
            this.buttonAvalanche.UseVisualStyleBackColor = true;
            this.buttonAvalanche.Click += new System.EventHandler(this.buttonAvalanche_Click);
            // 
            // trackBar_Latency
            // 
            this.trackBar_Latency.Location = new System.Drawing.Point(608, 27);
            this.trackBar_Latency.Name = "trackBar_Latency";
            this.trackBar_Latency.Size = new System.Drawing.Size(126, 45);
            this.trackBar_Latency.TabIndex = 33;
            this.trackBar_Latency.Value = 9;
            this.trackBar_Latency.Scroll += new System.EventHandler(this.trackBar_Latency_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Take a sample every";
            // 
            // numericUpDownIt
            // 
            this.numericUpDownIt.Location = new System.Drawing.Point(484, 35);
            this.numericUpDownIt.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownIt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIt.Name = "numericUpDownIt";
            this.numericUpDownIt.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownIt.TabIndex = 34;
            this.numericUpDownIt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelNumTopple
            // 
            this.labelNumTopple.AutoSize = true;
            this.labelNumTopple.Location = new System.Drawing.Point(258, 59);
            this.labelNumTopple.Name = "labelNumTopple";
            this.labelNumTopple.Size = new System.Drawing.Size(62, 13);
            this.labelNumTopple.TabIndex = 37;
            this.labelNumTopple.Text = "NumTopple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Number of  falled sands :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "waves";
            // 
            // groupBoxStructure
            // 
            this.groupBoxStructure.Controls.Add(this.textBox_Ly);
            this.groupBoxStructure.Controls.Add(this.label7);
            this.groupBoxStructure.Controls.Add(this.groupBox_epsilon);
            this.groupBoxStructure.Controls.Add(this.textBox_m);
            this.groupBoxStructure.Controls.Add(this.textBox_e);
            this.groupBoxStructure.Controls.Add(this.textBox_Lx);
            this.groupBoxStructure.Controls.Add(this.label6);
            this.groupBoxStructure.Controls.Add(this.label5);
            this.groupBoxStructure.Controls.Add(this.label4);
            this.groupBoxStructure.Location = new System.Drawing.Point(464, 78);
            this.groupBoxStructure.Name = "groupBoxStructure";
            this.groupBoxStructure.Size = new System.Drawing.Size(138, 256);
            this.groupBoxStructure.TabIndex = 40;
            this.groupBoxStructure.TabStop = false;
            this.groupBoxStructure.Text = "Structure";
            // 
            // textBox_Ly
            // 
            this.textBox_Ly.Location = new System.Drawing.Point(67, 42);
            this.textBox_Ly.Name = "textBox_Ly";
            this.textBox_Ly.Size = new System.Drawing.Size(65, 20);
            this.textBox_Ly.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ly";
            // 
            // groupBox_epsilon
            // 
            this.groupBox_epsilon.Controls.Add(this.radioButtonRandom);
            this.groupBox_epsilon.Controls.Add(this.radioButtonEliptic);
            this.groupBox_epsilon.Controls.Add(this.radioButtonDirectal);
            this.groupBox_epsilon.Location = new System.Drawing.Point(6, 118);
            this.groupBox_epsilon.Name = "groupBox_epsilon";
            this.groupBox_epsilon.Size = new System.Drawing.Size(119, 128);
            this.groupBox_epsilon.TabIndex = 6;
            this.groupBox_epsilon.TabStop = false;
            this.groupBox_epsilon.Text = "Epsilon Distribution";
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(6, 96);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRandom.TabIndex = 2;
            this.radioButtonRandom.Text = "Random";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            // 
            // radioButtonEliptic
            // 
            this.radioButtonEliptic.AutoSize = true;
            this.radioButtonEliptic.Location = new System.Drawing.Point(6, 73);
            this.radioButtonEliptic.Name = "radioButtonEliptic";
            this.radioButtonEliptic.Size = new System.Drawing.Size(63, 17);
            this.radioButtonEliptic.TabIndex = 1;
            this.radioButtonEliptic.Text = "Elliptical";
            this.radioButtonEliptic.UseVisualStyleBackColor = true;
            // 
            // radioButtonDirectal
            // 
            this.radioButtonDirectal.AutoSize = true;
            this.radioButtonDirectal.Checked = true;
            this.radioButtonDirectal.Location = new System.Drawing.Point(6, 51);
            this.radioButtonDirectal.Name = "radioButtonDirectal";
            this.radioButtonDirectal.Size = new System.Drawing.Size(65, 17);
            this.radioButtonDirectal.TabIndex = 0;
            this.radioButtonDirectal.TabStop = true;
            this.radioButtonDirectal.Text = "Directed";
            this.radioButtonDirectal.UseVisualStyleBackColor = true;
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(67, 84);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(65, 20);
            this.textBox_m.TabIndex = 6;
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(67, 63);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(65, 20);
            this.textBox_e.TabIndex = 5;
            // 
            // textBox_Lx
            // 
            this.textBox_Lx.Location = new System.Drawing.Point(67, 21);
            this.textBox_Lx.Name = "textBox_Lx";
            this.textBox_Lx.Size = new System.Drawing.Size(65, 20);
            this.textBox_Lx.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "m (0  1000)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "e (0  1000)";
            // 
            // labelEpsilonMethod
            // 
            this.labelEpsilonMethod.AutoSize = true;
            this.labelEpsilonMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpsilonMethod.Location = new System.Drawing.Point(12, 59);
            this.labelEpsilonMethod.Name = "labelEpsilonMethod";
            this.labelEpsilonMethod.Size = new System.Drawing.Size(87, 13);
            this.labelEpsilonMethod.TabIndex = 41;
            this.labelEpsilonMethod.Text = "EpsionMethod";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonSnapshot
            // 
            this.buttonSnapshot.Location = new System.Drawing.Point(245, 27);
            this.buttonSnapshot.Name = "buttonSnapshot";
            this.buttonSnapshot.Size = new System.Drawing.Size(75, 23);
            this.buttonSnapshot.TabIndex = 43;
            this.buttonSnapshot.Text = "Snapshot";
            this.buttonSnapshot.UseVisualStyleBackColor = true;
            this.buttonSnapshot.Click += new System.EventHandler(this.buttonSnapshot_Click);
            // 
            // FormSand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(860, 718);
            this.Controls.Add(this.buttonSnapshot);
            this.Controls.Add(this.labelEpsilonMethod);
            this.Controls.Add(this.groupBoxStructure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumTopple);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownIt);
            this.Controls.Add(this.trackBar_Latency);
            this.Controls.Add(this.buttonAvalanche);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSand";
            this.Text = "Sand Pile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSand_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Latency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIt)).EndInit();
            this.groupBoxStructure.ResumeLayout(false);
            this.groupBoxStructure.PerformLayout();
            this.groupBox_epsilon.ResumeLayout(false);
            this.groupBox_epsilon.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAvalanche;
        private System.Windows.Forms.TrackBar trackBar_Latency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIt;
        private System.Windows.Forms.Label labelNumTopple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxStructure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_Lx;
        private System.Windows.Forms.GroupBox groupBox_epsilon;
        private System.Windows.Forms.RadioButton radioButtonEliptic;
        private System.Windows.Forms.RadioButton radioButtonDirectal;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.Label labelEpsilonMethod;
        private System.Windows.Forms.TextBox textBox_Ly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonSnapshot;
    }
}

