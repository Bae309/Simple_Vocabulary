namespace MyVoca1
{
    partial class SpellingTestForm_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellingTestForm_1));
            CancelButton = new Button();
            CheckButton = new Button();
            QuestionLabel = new Label();
            AnswerTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(391, 334);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(91, 29);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "취소";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(511, 334);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(91, 29);
            CheckButton.TabIndex = 1;
            CheckButton.Text = "다음 문제";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Location = new Point(208, 163);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(83, 15);
            QuestionLabel.TabIndex = 2;
            QuestionLabel.Text = "QuestionLabel";
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Location = new Point(271, 236);
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.Size = new Size(162, 23);
            AnswerTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 239);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Answer : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 65);
            label2.Name = "label2";
            label2.Size = new Size(135, 37);
            label2.TabIndex = 5;
            label2.Text = "Voca Test";
            // 
            // SpellingTestForm_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 387);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AnswerTextBox);
            Controls.Add(QuestionLabel);
            Controls.Add(CheckButton);
            Controls.Add(CancelButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SpellingTestForm_1";
            Text = "Voca Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button CheckButton;
        private Label QuestionLabel;
        private TextBox AnswerTextBox;
        private Label label1;
        private Label label2;
    }
}