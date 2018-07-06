namespace GenomeDataFetcher
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
            this.button1 = new System.Windows.Forms.Button();
            this.savePath_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bedFilePath_textBox = new System.Windows.Forms.TextBox();
            this.resume_chkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upstream_textBox = new System.Windows.Forms.TextBox();
            this.downstream_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uppercase_radio = new System.Windows.Forms.RadioButton();
            this.lowerCase_radio = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mRepeats_N_radio = new System.Windows.Forms.RadioButton();
            this.mRepeats_lower_radio = new System.Windows.Forms.RadioButton();
            this.maskRepeats_checkBox = new System.Windows.Forms.CheckBox();
            this.revComplement_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Genome data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // savePath_textBox
            // 
            this.savePath_textBox.Location = new System.Drawing.Point(117, 12);
            this.savePath_textBox.Name = "savePath_textBox";
            this.savePath_textBox.Size = new System.Drawing.Size(391, 22);
            this.savePath_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bed File Path";
            // 
            // bedFilePath_textBox
            // 
            this.bedFilePath_textBox.Location = new System.Drawing.Point(117, 57);
            this.bedFilePath_textBox.Name = "bedFilePath_textBox";
            this.bedFilePath_textBox.Size = new System.Drawing.Size(391, 22);
            this.bedFilePath_textBox.TabIndex = 3;
            // 
            // resume_chkBox
            // 
            this.resume_chkBox.AutoSize = true;
            this.resume_chkBox.Location = new System.Drawing.Point(64, 348);
            this.resume_chkBox.Name = "resume_chkBox";
            this.resume_chkBox.Size = new System.Drawing.Size(175, 21);
            this.resume_chkBox.TabIndex = 6;
            this.resume_chkBox.Text = "Resume Downloading?";
            this.resume_chkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.downstream_textBox);
            this.groupBox1.Controls.Add(this.upstream_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sequence Retrieval Region Options:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "extra bases upstream (5\') and";
            // 
            // upstream_textBox
            // 
            this.upstream_textBox.Location = new System.Drawing.Point(49, 33);
            this.upstream_textBox.Name = "upstream_textBox";
            this.upstream_textBox.Size = new System.Drawing.Size(99, 22);
            this.upstream_textBox.TabIndex = 8;
            // 
            // downstream_textBox
            // 
            this.downstream_textBox.Location = new System.Drawing.Point(49, 71);
            this.downstream_textBox.Name = "downstream_textBox";
            this.downstream_textBox.Size = new System.Drawing.Size(99, 22);
            this.downstream_textBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "extra downstream (3\') ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(531, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 174);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sequence Formatting Options:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lowerCase_radio);
            this.groupBox3.Controls.Add(this.uppercase_radio);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 147);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Case";
            // 
            // uppercase_radio
            // 
            this.uppercase_radio.AutoSize = true;
            this.uppercase_radio.Checked = true;
            this.uppercase_radio.Location = new System.Drawing.Point(7, 22);
            this.uppercase_radio.Name = "uppercase_radio";
            this.uppercase_radio.Size = new System.Drawing.Size(119, 21);
            this.uppercase_radio.TabIndex = 0;
            this.uppercase_radio.TabStop = true;
            this.uppercase_radio.Text = "All upper case";
            this.uppercase_radio.UseVisualStyleBackColor = true;
            // 
            // lowerCase_radio
            // 
            this.lowerCase_radio.AutoSize = true;
            this.lowerCase_radio.Location = new System.Drawing.Point(7, 50);
            this.lowerCase_radio.Name = "lowerCase_radio";
            this.lowerCase_radio.Size = new System.Drawing.Size(115, 21);
            this.lowerCase_radio.TabIndex = 1;
            this.lowerCase_radio.Text = "All lower case";
            this.lowerCase_radio.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.revComplement_checkBox);
            this.groupBox4.Controls.Add(this.maskRepeats_checkBox);
            this.groupBox4.Controls.Add(this.mRepeats_N_radio);
            this.groupBox4.Controls.Add(this.mRepeats_lower_radio);
            this.groupBox4.Location = new System.Drawing.Point(224, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 147);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mask Repeats";
            // 
            // mRepeats_N_radio
            // 
            this.mRepeats_N_radio.AutoSize = true;
            this.mRepeats_N_radio.Location = new System.Drawing.Point(6, 78);
            this.mRepeats_N_radio.Name = "mRepeats_N_radio";
            this.mRepeats_N_radio.Size = new System.Drawing.Size(39, 21);
            this.mRepeats_N_radio.TabIndex = 1;
            this.mRepeats_N_radio.TabStop = true;
            this.mRepeats_N_radio.Text = "N";
            this.mRepeats_N_radio.UseVisualStyleBackColor = true;
            // 
            // mRepeats_lower_radio
            // 
            this.mRepeats_lower_radio.AutoSize = true;
            this.mRepeats_lower_radio.Checked = true;
            this.mRepeats_lower_radio.Location = new System.Drawing.Point(6, 51);
            this.mRepeats_lower_radio.Name = "mRepeats_lower_radio";
            this.mRepeats_lower_radio.Size = new System.Drawing.Size(62, 21);
            this.mRepeats_lower_radio.TabIndex = 0;
            this.mRepeats_lower_radio.TabStop = true;
            this.mRepeats_lower_radio.Text = "lower";
            this.mRepeats_lower_radio.UseVisualStyleBackColor = true;
            // 
            // maskRepeats_checkBox
            // 
            this.maskRepeats_checkBox.AutoSize = true;
            this.maskRepeats_checkBox.Location = new System.Drawing.Point(6, 21);
            this.maskRepeats_checkBox.Name = "maskRepeats_checkBox";
            this.maskRepeats_checkBox.Size = new System.Drawing.Size(115, 21);
            this.maskRepeats_checkBox.TabIndex = 2;
            this.maskRepeats_checkBox.Text = "Mask repeats";
            this.maskRepeats_checkBox.UseVisualStyleBackColor = true;
            // 
            // revComplement_checkBox
            // 
            this.revComplement_checkBox.AutoSize = true;
            this.revComplement_checkBox.Location = new System.Drawing.Point(9, 105);
            this.revComplement_checkBox.Name = "revComplement_checkBox";
            this.revComplement_checkBox.Size = new System.Drawing.Size(322, 21);
            this.revComplement_checkBox.TabIndex = 3;
            this.revComplement_checkBox.Text = "Reverse complement (get \'-\' strand sequence)";
            this.revComplement_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resume_chkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bedFilePath_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savePath_textBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox savePath_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bedFilePath_textBox;
        private System.Windows.Forms.CheckBox resume_chkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox downstream_textBox;
        private System.Windows.Forms.TextBox upstream_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox maskRepeats_checkBox;
        private System.Windows.Forms.RadioButton mRepeats_N_radio;
        private System.Windows.Forms.RadioButton mRepeats_lower_radio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton lowerCase_radio;
        private System.Windows.Forms.RadioButton uppercase_radio;
        private System.Windows.Forms.CheckBox revComplement_checkBox;
    }
}

