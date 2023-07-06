namespace MyVoca1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            AddButton = new Button();
            ShowButton = new Button();
            VocaTestButton = new Button();
            ExitButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("맑은 고딕", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(340, 24);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 0;
            label1.Text = "My Voca\r\n";
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ButtonHighlight;
            AddButton.Location = new Point(81, 102);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(120, 26);
            AddButton.TabIndex = 1;
            AddButton.Text = "단어 추가";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.Location = new Point(81, 183);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(120, 26);
            ShowButton.TabIndex = 2;
            ShowButton.Text = "단어 보기";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // VocaTestButton
            // 
            VocaTestButton.Location = new Point(81, 269);
            VocaTestButton.Name = "VocaTestButton";
            VocaTestButton.Size = new Size(120, 26);
            VocaTestButton.TabIndex = 3;
            VocaTestButton.Text = "단어 시험";
            VocaTestButton.UseVisualStyleBackColor = true;
            VocaTestButton.Click += VocaTestButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(81, 348);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(120, 26);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "My Voca 종료";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 108);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 5;
            label2.Text = "새로운 단어를 등록 및 저장합니다.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 189);
            label3.Name = "label3";
            label3.Size = new Size(369, 15);
            label3.TabIndex = 6;
            label3.Text = "등록한 단어를 보여줍니다. 등록한 단어를 수정 및 삭제 가능합니다.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 275);
            label4.Name = "label4";
            label4.Size = new Size(278, 15);
            label4.TabIndex = 7;
            label4.Text = "등록된 단어를 이용해 단어 시험을 칠 수 있습니다.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 354);
            label5.Name = "label5";
            label5.Size = new Size(210, 15);
            label5.TabIndex = 8;
            label5.Text = "My Voca 애플리케이션을 종료합니다.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ExitButton);
            Controls.Add(VocaTestButton);
            Controls.Add(ShowButton);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "My Voca";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddButton;
        private Button ShowButton;
        private Button VocaTestButton;
        private Button ExitButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}