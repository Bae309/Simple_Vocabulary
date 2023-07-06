namespace MyVoca1
{
    partial class ShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowForm));
            label1 = new Label();
            GoBackButton = new Button();
            ModifyWordButton = new Button();
            DeleteWordButton = new Button();
            dataGridView1 = new DataGridView();
            AllCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(322, 42);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 0;
            label1.Text = "Saved Words";
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(420, 406);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(91, 27);
            GoBackButton.TabIndex = 3;
            GoBackButton.Text = "뒤로";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // ModifyWordButton
            // 
            ModifyWordButton.Location = new Point(537, 406);
            ModifyWordButton.Name = "ModifyWordButton";
            ModifyWordButton.Size = new Size(91, 27);
            ModifyWordButton.TabIndex = 4;
            ModifyWordButton.Text = "단어 수정";
            ModifyWordButton.UseVisualStyleBackColor = true;
            ModifyWordButton.Click += ModifyWordButton_Click;
            // 
            // DeleteWordButton
            // 
            DeleteWordButton.Location = new Point(651, 406);
            DeleteWordButton.Name = "DeleteWordButton";
            DeleteWordButton.Size = new Size(91, 27);
            DeleteWordButton.TabIndex = 5;
            DeleteWordButton.Text = "단어 삭제";
            DeleteWordButton.UseVisualStyleBackColor = true;
            DeleteWordButton.Click += DeleteWordButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(662, 267);
            dataGridView1.TabIndex = 6;
            // 
            // AllCheckBox
            // 
            AllCheckBox.AutoSize = true;
            AllCheckBox.Location = new Point(80, 92);
            AllCheckBox.Name = "AllCheckBox";
            AllCheckBox.Size = new Size(78, 19);
            AllCheckBox.TabIndex = 7;
            AllCheckBox.Text = "전체 선택";
            AllCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllCheckBox);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteWordButton);
            Controls.Add(ModifyWordButton);
            Controls.Add(GoBackButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowForm";
            Text = "단어 보기";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GoBackButton;
        private Button ModifyWordButton;
        private Button DeleteWordButton;
        public DataGridView dataGridView1;
        private CheckBox AllCheckBox;
    }
}