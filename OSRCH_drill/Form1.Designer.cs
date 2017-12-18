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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveLogBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.resetLogBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overheatBtn = new System.Windows.Forms.Button();
            this.overheightBtn = new System.Windows.Forms.Button();
            this.poweroffBtn = new System.Windows.Forms.Button();
            this.wearoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 553);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(483, 160);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // saveLogBtn
            // 
            this.saveLogBtn.Location = new System.Drawing.Point(501, 553);
            this.saveLogBtn.Name = "saveLogBtn";
            this.saveLogBtn.Size = new System.Drawing.Size(100, 34);
            this.saveLogBtn.TabIndex = 1;
            this.saveLogBtn.Text = "Save Log";
            this.saveLogBtn.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(607, 553);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(105, 34);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load instr.";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(607, 639);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(105, 34);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(607, 679);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(105, 34);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(700, 535);
            this.mainPictureBox.TabIndex = 5;
            this.mainPictureBox.TabStop = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(718, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(276, 535);
            this.profilePictureBox.TabIndex = 6;
            this.profilePictureBox.TabStop = false;
            // 
            // resetLogBtn
            // 
            this.resetLogBtn.Location = new System.Drawing.Point(501, 679);
            this.resetLogBtn.Name = "resetLogBtn";
            this.resetLogBtn.Size = new System.Drawing.Size(100, 34);
            this.resetLogBtn.TabIndex = 7;
            this.resetLogBtn.Text = "Reset Log";
            this.resetLogBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wearoutBtn);
            this.groupBox1.Controls.Add(this.poweroffBtn);
            this.groupBox1.Controls.Add(this.overheightBtn);
            this.groupBox1.Controls.Add(this.overheatBtn);
            this.groupBox1.Location = new System.Drawing.Point(718, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 160);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interrupts";
            // 
            // overheatBtn
            // 
            this.overheatBtn.Location = new System.Drawing.Point(6, 21);
            this.overheatBtn.Name = "overheatBtn";
            this.overheatBtn.Size = new System.Drawing.Size(123, 59);
            this.overheatBtn.TabIndex = 0;
            this.overheatBtn.Text = "Overheating";
            this.overheatBtn.UseVisualStyleBackColor = true;
            // 
            // overheightBtn
            // 
            this.overheightBtn.Location = new System.Drawing.Point(147, 21);
            this.overheightBtn.Name = "overheightBtn";
            this.overheightBtn.Size = new System.Drawing.Size(123, 59);
            this.overheightBtn.TabIndex = 1;
            this.overheightBtn.Text = "OverHeight";
            this.overheightBtn.UseVisualStyleBackColor = true;
            // 
            // poweroffBtn
            // 
            this.poweroffBtn.ForeColor = System.Drawing.Color.Red;
            this.poweroffBtn.Location = new System.Drawing.Point(6, 86);
            this.poweroffBtn.Name = "poweroffBtn";
            this.poweroffBtn.Size = new System.Drawing.Size(123, 68);
            this.poweroffBtn.TabIndex = 2;
            this.poweroffBtn.Text = "PowerOff";
            this.poweroffBtn.UseVisualStyleBackColor = true;
            // 
            // wearoutBtn
            // 
            this.wearoutBtn.ForeColor = System.Drawing.Color.Black;
            this.wearoutBtn.Location = new System.Drawing.Point(147, 86);
            this.wearoutBtn.Name = "wearoutBtn";
            this.wearoutBtn.Size = new System.Drawing.Size(123, 68);
            this.wearoutBtn.TabIndex = 3;
            this.wearoutBtn.Text = "Wearout";
            this.wearoutBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetLogBtn);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveLogBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Mein Drill";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button poweroffBtn;
        private System.Windows.Forms.Button overheightBtn;
        private System.Windows.Forms.Button overheatBtn;
        private System.Windows.Forms.Button wearoutBtn;
    }
}

