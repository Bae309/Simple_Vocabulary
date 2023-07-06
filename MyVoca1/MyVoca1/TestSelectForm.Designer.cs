namespace MyVoca1
{
    partial class TestSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSelectForm));
            label1 = new Label();
            SpellingButton = new Button();
            Choose1of4Button = new Button();
            CancelButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(189, 44);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 0;
            label1.Text = "Select Mode";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // SpellingButton
            // 
            SpellingButton.Location = new Point(42, 112);
            SpellingButton.Name = "SpellingButton";
            SpellingButton.Size = new Size(102, 28);
            SpellingButton.TabIndex = 1;
            SpellingButton.Text = "철자 맞추기";
            SpellingButton.UseVisualStyleBackColor = true;
            SpellingButton.Click += SpellingButton_Click;
            // 
            // Choose1of4Button
            // 
            Choose1of4Button.Location = new Point(42, 168);
            Choose1of4Button.Name = "Choose1of4Button";
            Choose1of4Button.Size = new Size(102, 28);
            Choose1of4Button.TabIndex = 2;
            Choose1of4Button.Text = "사지선다형";
            Choose1of4Button.UseVisualStyleBackColor = true;
            Choose1of4Button.Click += Choose1of4Button_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(42, 230);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 28);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "취소";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 119);
            label2.Name = "label2";
            label2.Size = new Size(322, 15);
            label2.TabIndex = 4;
            label2.Text = "단어 철자를 직접 타이핑하는 방식으로 시험을 시작합니다.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 175);
            label3.Name = "label3";
            label3.Size = new Size(198, 15);
            label3.TabIndex = 5;
            label3.Text = "사지선다형으로 시험을 시작합니다.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 237);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 6;
            label4.Text = "메인 화면으로 돌아갑니다.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 302);
            label5.Name = "label5";
            label5.Size = new Size(324, 15);
            label5.TabIndex = 7;
            label5.Text = "시험을 시작하시려면 단어를 10개 이상 등록하셔야 합니다.";
            // 
            // TestSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 357);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CancelButton);
            Controls.Add(Choose1of4Button);
            Controls.Add(SpellingButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TestSelectForm";
            Text = "시험 모드 선택";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SpellingButton;
        private Button Choose1of4Button;
        private Button CancelButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}