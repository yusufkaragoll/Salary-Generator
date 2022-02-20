
namespace SalaryGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.monthsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSoftware = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkDesigner = new System.Windows.Forms.CheckBox();
            this.checkBackend = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkJunior = new System.Windows.Forms.CheckBox();
            this.checkSenior = new System.Windows.Forms.CheckBox();
            this.Experience = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.fullnameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(409, 13);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(230, 20);
            this.salaryLabel.TabIndex = 0;
            this.salaryLabel.Text = "Salary (without Tax (Junior Salary)";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(422, 48);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(197, 27);
            this.salaryBox.TabIndex = 1;
            // 
            // monthsBox
            // 
            this.monthsBox.Location = new System.Drawing.Point(422, 125);
            this.monthsBox.Name = "monthsBox";
            this.monthsBox.Size = new System.Drawing.Size(197, 27);
            this.monthsBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many months?";
            // 
            // checkSoftware
            // 
            this.checkSoftware.AutoSize = true;
            this.checkSoftware.Location = new System.Drawing.Point(149, 205);
            this.checkSoftware.Name = "checkSoftware";
            this.checkSoftware.Size = new System.Drawing.Size(152, 24);
            this.checkSoftware.TabIndex = 4;
            this.checkSoftware.Text = "Software Engineer";
            this.checkSoftware.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Major";
            // 
            // checkDesigner
            // 
            this.checkDesigner.AutoSize = true;
            this.checkDesigner.Location = new System.Drawing.Point(325, 205);
            this.checkDesigner.Name = "checkDesigner";
            this.checkDesigner.Size = new System.Drawing.Size(133, 24);
            this.checkDesigner.TabIndex = 6;
            this.checkDesigner.Text = "UI/UX Designer";
            this.checkDesigner.UseVisualStyleBackColor = true;
            // 
            // checkBackend
            // 
            this.checkBackend.AutoSize = true;
            this.checkBackend.Location = new System.Drawing.Point(479, 205);
            this.checkBackend.Name = "checkBackend";
            this.checkBackend.Size = new System.Drawing.Size(160, 24);
            this.checkBackend.TabIndex = 7;
            this.checkBackend.Text = "Backend Developer";
            this.checkBackend.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "(for every job tax rate is different)";
            // 
            // checkJunior
            // 
            this.checkJunior.AutoSize = true;
            this.checkJunior.Location = new System.Drawing.Point(280, 322);
            this.checkJunior.Name = "checkJunior";
            this.checkJunior.Size = new System.Drawing.Size(70, 24);
            this.checkJunior.TabIndex = 9;
            this.checkJunior.Text = "Junior";
            this.checkJunior.UseVisualStyleBackColor = true;
            // 
            // checkSenior
            // 
            this.checkSenior.AutoSize = true;
            this.checkSenior.Location = new System.Drawing.Point(404, 322);
            this.checkSenior.Name = "checkSenior";
            this.checkSenior.Size = new System.Drawing.Size(73, 24);
            this.checkSenior.TabIndex = 10;
            this.checkSenior.Text = "Senior";
            this.checkSenior.UseVisualStyleBackColor = true;
            // 
            // Experience
            // 
            this.Experience.AutoSize = true;
            this.Experience.Location = new System.Drawing.Point(335, 288);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(81, 20);
            this.Experience.TabIndex = 11;
            this.Experience.Text = "Experience";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(199, 374);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(350, 49);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Age";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(137, 125);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(197, 27);
            this.ageBox.TabIndex = 15;
            // 
            // fullnameBox
            // 
            this.fullnameBox.Location = new System.Drawing.Point(137, 48);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.Size = new System.Drawing.Size(197, 27);
            this.fullnameBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Full Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(609, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.fullnameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.checkSenior);
            this.Controls.Add(this.checkJunior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBackend);
            this.Controls.Add(this.checkDesigner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkSoftware);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthsBox);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.salaryLabel);
            this.Name = "Form1";
            this.Text = "SalaryGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.TextBox monthsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkSoftware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkDesigner;
        private System.Windows.Forms.CheckBox checkBackend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkJunior;
        private System.Windows.Forms.CheckBox checkSenior;
        private System.Windows.Forms.Label Experience;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox fullnameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

