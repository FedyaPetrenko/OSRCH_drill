namespace OSRCH_drill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveLogBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.resetLogBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wearoutBtn = new System.Windows.Forms.Button();
            this.poweroffBtn = new System.Windows.Forms.Button();
            this.overheightBtn = new System.Windows.Forms.Button();
            this.overheatBtn = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 524);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(370, 130);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // saveLogBtn
            // 
            this.saveLogBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveLogBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.saveLogBtn.Location = new System.Drawing.Point(383, 524);
            this.saveLogBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveLogBtn.Name = "saveLogBtn";
            this.saveLogBtn.Size = new System.Drawing.Size(75, 28);
            this.saveLogBtn.TabIndex = 1;
            this.saveLogBtn.Text = "Save Log";
            this.saveLogBtn.UseVisualStyleBackColor = false;
            this.saveLogBtn.Click += new System.EventHandler(this.saveLogBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.loadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loadBtn.Location = new System.Drawing.Point(462, 524);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(79, 28);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load instr.";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.startBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.startBtn.Location = new System.Drawing.Point(383, 556);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 66);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.stopBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.stopBtn.Location = new System.Drawing.Point(462, 556);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(79, 66);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPictureBox.BackgroundImage")));
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPictureBox.Location = new System.Drawing.Point(9, 10);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(525, 487);
            this.mainPictureBox.TabIndex = 5;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPictureBox_Paint);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.BackgroundImage")));
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profilePictureBox.Location = new System.Drawing.Point(538, 10);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(225, 487);
            this.profilePictureBox.TabIndex = 6;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.profilePictureBox_Paint);
            // 
            // resetLogBtn
            // 
            this.resetLogBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.resetLogBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.resetLogBtn.Location = new System.Drawing.Point(383, 626);
            this.resetLogBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetLogBtn.Name = "resetLogBtn";
            this.resetLogBtn.Size = new System.Drawing.Size(158, 28);
            this.resetLogBtn.TabIndex = 7;
            this.resetLogBtn.Text = "Reset Log";
            this.resetLogBtn.UseVisualStyleBackColor = false;
            this.resetLogBtn.Click += new System.EventHandler(this.resetLogBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wearoutBtn);
            this.groupBox1.Controls.Add(this.poweroffBtn);
            this.groupBox1.Controls.Add(this.overheightBtn);
            this.groupBox1.Controls.Add(this.overheatBtn);
            this.groupBox1.Location = new System.Drawing.Point(545, 523);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(217, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interrupts";
            // 
            // wearoutBtn
            // 
            this.wearoutBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.wearoutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.wearoutBtn.Location = new System.Drawing.Point(111, 69);
            this.wearoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.wearoutBtn.Name = "wearoutBtn";
            this.wearoutBtn.Size = new System.Drawing.Size(102, 55);
            this.wearoutBtn.TabIndex = 3;
            this.wearoutBtn.Text = "Wearout";
            this.wearoutBtn.UseVisualStyleBackColor = false;
            this.wearoutBtn.Click += new System.EventHandler(this.wearoutBtn_Click);
            // 
            // poweroffBtn
            // 
            this.poweroffBtn.BackColor = System.Drawing.Color.Red;
            this.poweroffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poweroffBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.poweroffBtn.Location = new System.Drawing.Point(4, 70);
            this.poweroffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.poweroffBtn.Name = "poweroffBtn";
            this.poweroffBtn.Size = new System.Drawing.Size(103, 55);
            this.poweroffBtn.TabIndex = 2;
            this.poweroffBtn.Text = "PowerOff";
            this.poweroffBtn.UseVisualStyleBackColor = false;
            this.poweroffBtn.Click += new System.EventHandler(this.poweroffBtn_Click);
            // 
            // overheightBtn
            // 
            this.overheightBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.overheightBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.overheightBtn.Location = new System.Drawing.Point(111, 17);
            this.overheightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.overheightBtn.Name = "overheightBtn";
            this.overheightBtn.Size = new System.Drawing.Size(102, 48);
            this.overheightBtn.TabIndex = 1;
            this.overheightBtn.Text = "OverHeight";
            this.overheightBtn.UseVisualStyleBackColor = false;
            this.overheightBtn.Click += new System.EventHandler(this.overheightBtn_Click);
            // 
            // overheatBtn
            // 
            this.overheatBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.overheatBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.overheatBtn.Location = new System.Drawing.Point(4, 17);
            this.overheatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.overheatBtn.Name = "overheatBtn";
            this.overheatBtn.Size = new System.Drawing.Size(103, 48);
            this.overheatBtn.TabIndex = 0;
            this.overheatBtn.Text = "Overheating";
            this.overheatBtn.UseVisualStyleBackColor = false;
            this.overheatBtn.Click += new System.EventHandler(this.overheatBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetLogBtn);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveLogBtn);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mein Drill";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveLogBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button resetLogBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button poweroffBtn;
        private System.Windows.Forms.Button overheightBtn;
        private System.Windows.Forms.Button overheatBtn;
        private System.Windows.Forms.Button wearoutBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

