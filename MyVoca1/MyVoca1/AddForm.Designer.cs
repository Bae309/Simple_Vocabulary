namespace MyVoca1
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            label1 = new Label();
            CancelButton = new Button();
            AddWordButton = new Button();
            WordBox = new TextBox();
            MeaningBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 54);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Word\r\n";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(242, 289);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(106, 30);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "취소";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddWordButton
            // 
            AddWordButton.Location = new Point(372, 289);
            AddWordButton.Name = "AddWordButton";
            AddWordButton.Size = new Size(106, 30);
            AddWordButton.TabIndex = 2;
            AddWordButton.Text = "단어 추가";
            AddWordButton.UseVisualStyleBackColor = true;
            AddWordButton.Click += AddWordButton_Click;
            // 
            // WordBox
            // 
            WordBox.Location = new Point(146, 136);
            WordBox.Name = "WordBox";
            WordBox.Size = new Size(268, 23);
            WordBox.TabIndex = 3;
            // 
            // MeaningBox
            // 
            MeaningBox.Location = new Point(146, 189);
            MeaningBox.Name = "MeaningBox";
            MeaningBox.Size = new Size(268, 23);
            MeaningBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 144);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Word :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 192);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Meaning :";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 348);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MeaningBox);
            Controls.Add(WordBox);
            Controls.Add(AddWordButton);
            Controls.Add(CancelButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CancelButton;
        private Button AddWordButton;
        private TextBox WordBox;
        private TextBox MeaningBox;
        private Label label2;
        private Label label3;
    }
}