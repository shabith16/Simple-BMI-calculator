namespace BMI_Calculator
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AGE = new System.Windows.Forms.TextBox();
            this.HEIGHT = new System.Windows.Forms.TextBox();
            this.WEIGHT = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.FEMALE = new System.Windows.Forms.RadioButton();
            this.CALCULATE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CLEAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "US UNITS: in and lbs",
            "METRIC UNITS: cm and kg"});
            this.comboBox1.Location = new System.Drawing.Point(18, 19);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(319, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AGE
            // 
            this.AGE.Location = new System.Drawing.Point(141, 108);
            this.AGE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AGE.Name = "AGE";
            this.AGE.Size = new System.Drawing.Size(148, 30);
            this.AGE.TabIndex = 1;
            this.AGE.Text = "0";
            this.AGE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HEIGHT
            // 
            this.HEIGHT.Location = new System.Drawing.Point(141, 180);
            this.HEIGHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HEIGHT.Name = "HEIGHT";
            this.HEIGHT.Size = new System.Drawing.Size(148, 30);
            this.HEIGHT.TabIndex = 2;
            this.HEIGHT.Text = "0";
            this.HEIGHT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // WEIGHT
            // 
            this.WEIGHT.Location = new System.Drawing.Point(141, 239);
            this.WEIGHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WEIGHT.Name = "WEIGHT";
            this.WEIGHT.Size = new System.Drawing.Size(148, 30);
            this.WEIGHT.TabIndex = 3;
            this.WEIGHT.Text = "0";
            this.WEIGHT.TextChanged += new System.EventHandler(this.WEIGHT_TextChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(141, 302);
            this.male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(88, 29);
            this.male.TabIndex = 4;
            this.male.TabStop = true;
            this.male.Text = "MALE";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // FEMALE
            // 
            this.FEMALE.AutoSize = true;
            this.FEMALE.Location = new System.Drawing.Point(272, 302);
            this.FEMALE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FEMALE.Name = "FEMALE";
            this.FEMALE.Size = new System.Drawing.Size(113, 29);
            this.FEMALE.TabIndex = 5;
            this.FEMALE.TabStop = true;
            this.FEMALE.Text = "FEMALE";
            this.FEMALE.UseVisualStyleBackColor = true;
            this.FEMALE.CheckedChanged += new System.EventHandler(this.FEMALE_CheckedChanged);
            // 
            // CALCULATE
            // 
            this.CALCULATE.Location = new System.Drawing.Point(18, 373);
            this.CALCULATE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CALCULATE.Name = "CALCULATE";
            this.CALCULATE.Size = new System.Drawing.Size(172, 36);
            this.CALCULATE.TabIndex = 6;
            this.CALCULATE.Text = "CALCULATE";
            this.CALCULATE.UseVisualStyleBackColor = true;
            this.CALCULATE.Click += new System.EventHandler(this.CALCULATE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "AGE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "HEIGHT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "WEIGHT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "GENDER:";
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(284, 373);
            this.CLEAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(112, 36);
            this.CLEAR.TabIndex = 11;
            this.CLEAR.Text = "Clear";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 441);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CALCULATE);
            this.Controls.Add(this.FEMALE);
            this.Controls.Add(this.male);
            this.Controls.Add(this.WEIGHT);
            this.Controls.Add(this.HEIGHT);
            this.Controls.Add(this.AGE);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "BMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox AGE;
        private System.Windows.Forms.TextBox HEIGHT;
        private System.Windows.Forms.TextBox WEIGHT;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton FEMALE;
        private System.Windows.Forms.Button CALCULATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CLEAR;
    }
}

