namespace MyVoca1
{
    partial class Choose1Of4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose1Of4));
            QuestionLabel = new Label();
            RadioChoice1 = new RadioButton();
            RadioChoice2 = new RadioButton();
            RadioChoice3 = new RadioButton();
            RadioChoice4 = new RadioButton();
            CancelButton = new Button();
            NextButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Location = new Point(224, 115);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(83, 15);
            QuestionLabel.TabIndex = 0;
            QuestionLabel.Text = "QuestionLabel";
            // 
            // RadioChoice1
            // 
            RadioChoice1.AutoSize = true;
            RadioChoice1.Location = new Point(224, 147);
            RadioChoice1.Name = "RadioChoice1";
            RadioChoice1.Size = new Size(71, 19);
            RadioChoice1.TabIndex = 1;
            RadioChoice1.TabStop = true;
            RadioChoice1.Text = "Answer1";
            RadioChoice1.UseVisualStyleBackColor = true;
            // 
            // RadioChoice2
            // 
            RadioChoice2.AutoSize = true;
            RadioChoice2.Location = new Point(224, 183);
            RadioChoice2.Name = "RadioChoice2";
            RadioChoice2.Size = new Size(71, 19);
            RadioChoice2.TabIndex = 2;
            RadioChoice2.TabStop = true;
            RadioChoice2.Text = "Answer2";
            RadioChoice2.UseVisualStyleBackColor = true;
            // 
            // RadioChoice3
            // 
            RadioChoice3.AutoSize = true;
            RadioChoice3.Location = new Point(224, 217);
            RadioChoice3.Name = "RadioChoice3";
            RadioChoice3.Size = new Size(71, 19);
            RadioChoice3.TabIndex = 3;
            RadioChoice3.TabStop = true;
            RadioChoice3.Text = "Answer3";
            RadioChoice3.UseVisualStyleBackColor = true;
            // 
            // RadioChoice4
            // 
            RadioChoice4.AutoSize = true;
            RadioChoice4.Location = new Point(224, 254);
            RadioChoice4.Name = "RadioChoice4";
            RadioChoice4.Size = new Size(71, 19);
            RadioChoice4.TabIndex = 4;
            RadioChoice4.TabStop = true;
            RadioChoice4.Text = "Answer4";
            RadioChoice4.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(308, 315);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(92, 27);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "취소";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(427, 315);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(92, 27);
            NextButton.TabIndex = 6;
            NextButton.Text = "다음 문제";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(194, 46);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 7;
            label1.Text = "Voca Test";
            // 
            // Choose1Of4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 375);
            Controls.Add(label1);
            Controls.Add(NextButton);
            Controls.Add(CancelButton);
            Controls.Add(RadioChoice4);
            Controls.Add(RadioChoice3);
            Controls.Add(RadioChoice2);
            Controls.Add(RadioChoice1);
            Controls.Add(QuestionLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Choose1Of4";
            Text = "Voca Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionLabel;
        private RadioButton RadioChoice1;
        private RadioButton RadioChoice2;
        private RadioButton RadioChoice3;
        private RadioButton RadioChoice4;
        private Button CancelButton;
        private Button NextButton;
        private Label label1;
    }
}