namespace algorithm_test
{
    partial class GradeForm
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
            this.calcButton = new System.Windows.Forms.Button();
            this.homeworkBox = new System.Windows.Forms.ComboBox();
            this.mockBox = new System.Windows.Forms.ComboBox();
            this.mtgBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.previousResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(18, 95);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(112, 35);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeworkBox
            // 
            this.homeworkBox.FormattingEnabled = true;
            this.homeworkBox.Items.AddRange(new object[] {
            "A*",
            "A",
            "B",
            "C",
            "D",
            "E",
            "U"});
            this.homeworkBox.Location = new System.Drawing.Point(20, 54);
            this.homeworkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeworkBox.Name = "homeworkBox";
            this.homeworkBox.Size = new System.Drawing.Size(94, 28);
            this.homeworkBox.TabIndex = 1;
            // 
            // mockBox
            // 
            this.mockBox.FormattingEnabled = true;
            this.mockBox.Items.AddRange(new object[] {
            "A*",
            "A",
            "B",
            "C",
            "D",
            "E",
            "U"});
            this.mockBox.Location = new System.Drawing.Point(124, 54);
            this.mockBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mockBox.Name = "mockBox";
            this.mockBox.Size = new System.Drawing.Size(94, 28);
            this.mockBox.TabIndex = 2;
            // 
            // mtgBox
            // 
            this.mtgBox.FormattingEnabled = true;
            this.mtgBox.Items.AddRange(new object[] {
            "A*",
            "A",
            "B",
            "C",
            "D",
            "E",
            "U"});
            this.mtgBox.Location = new System.Drawing.Point(230, 54);
            this.mtgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtgBox.Name = "mtgBox";
            this.mtgBox.Size = new System.Drawing.Size(94, 28);
            this.mtgBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Homework";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "MTG";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(22, 165);
            this.gradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(134, 20);
            this.gradeLabel.TabIndex = 7;
            this.gradeLabel.Text = "Predicted grade: -";
            // 
            // previousResultButton
            // 
            this.previousResultButton.Location = new System.Drawing.Point(140, 95);
            this.previousResultButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousResultButton.Name = "previousResultButton";
            this.previousResultButton.Size = new System.Drawing.Size(186, 35);
            this.previousResultButton.TabIndex = 8;
            this.previousResultButton.Text = "Add Previous Result";
            this.previousResultButton.UseVisualStyleBackColor = true;
            this.previousResultButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 229);
            this.Controls.Add(this.previousResultButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtgBox);
            this.Controls.Add(this.mockBox);
            this.Controls.Add(this.homeworkBox);
            this.Controls.Add(this.calcButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.ComboBox homeworkBox;
        private System.Windows.Forms.ComboBox mockBox;
        private System.Windows.Forms.ComboBox mtgBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button previousResultButton;
    }
}

