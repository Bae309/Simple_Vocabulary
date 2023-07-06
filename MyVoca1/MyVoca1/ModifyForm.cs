using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVoca1
{
    public partial class ModifyForm : Form
    {
        // 수정된 단어와 뜻을 저장하기 위한 공용 속성.
        public string ModifiedWord { get; private set; }
        public string ModifiedMeaning { get; private set; }

        // ModifyForm 클래스의 생성자로, 단어와 뜻을 매개변수로 받습니다.
        // 폼을 초기화하고, 텍스트 상자에 제공된 단어와 뜻을 설정합니다.
        public ModifyForm(string word, string meaning)
        {
            InitializeComponent();
            textBox1.Text = word;
            textBox2.Text = meaning;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // 뒤로 가기 버튼을 클릭하면, DialogResult를 Cancel로 설정하고 폼을 닫음.
            this.Close();
        }

        // 수정 버튼을 클릭하면, 텍스트 상자에서 수정된 단어와 뜻을 가져옴.
        // 수정된 단어나 뜻이 비어 있거나 null인 경우, 오류 메시지를 표시하고 반환.
        // 그렇지 않으면, ModifiedWord와 ModifiedMeaning 속성을 수정된 값으로 설정.
        // 또한, DialogResult를 OK로 설정하고 폼을 닫음.
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            string modifiedWord = textBox1.Text.Trim();
            string modifiedMeaning = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(modifiedWord) || string.IsNullOrEmpty(modifiedMeaning))
            {
                MessageBox.Show("단어와 정의를 모두 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModifiedWord = modifiedWord;
            ModifiedMeaning = modifiedMeaning;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

