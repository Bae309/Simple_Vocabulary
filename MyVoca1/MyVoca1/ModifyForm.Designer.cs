namespace MyVoca1
{
    partial class ModifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyForm));
            CancelButton = new Button();
            ModifyButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(265, 239);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(100, 23);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "취소";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += BackButton_Click;
            // 
            // ModifyButton
            // 
            ModifyButton.Location = new Point(382, 239);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(100, 23);
            ModifyButton.TabIndex = 1;
            ModifyButton.Text = "단어 수정";
            ModifyButton.UseVisualStyleBackColor = true;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(174, 20);
            label1.Name = "label1";
            label1.Size = new Size(170, 37);
            label1.TabIndex = 2;
            label1.Text = "Revise Word";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 98);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Word : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 148);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "Meaning : ";
            // 
            // ModifyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 286);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(ModifyButton);
            Controls.Add(CancelButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModifyForm";
            Text = "ChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button ModifyButton;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}