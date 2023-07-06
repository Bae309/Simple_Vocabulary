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
    public partial class AddForm : Form
    {
        private Dictionary<string, string> wordList; // 단어와 뜻을 저장하는 사전
        private ShowForm showForm; // 단어 목록을 표시하는 폼에 대한 참조
        public AddForm(Dictionary<string, string> wordList, ShowForm showForm)
        {
            this.wordList = wordList; // 주어진 단어 목록을 지역 변수에 할당
            this.showForm = showForm; // 주어진 표시 폼을 지역 변수에 할당
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddWordButton_Click(object sender, EventArgs e)
        {
            // "단어 추가" 버튼이 클릭되었을 때 트리거되는 이벤트.
            string Word = WordBox.Text; // WordBox 컨트롤에 입력된 텍스트를 가져옴.
            string Meaning = MeaningBox.Text; // MeaningBox 컨트롤에 입력된 텍스트를 가져옴.

            if (!string.IsNullOrEmpty(Word) && !string.IsNullOrEmpty(Meaning)) //Word와 Meaning이 Null이 아닐 때
            {
                // 단어와 뜻이 모두 비어 있거나 null이 아닌지 확인.
                if (!wordList.ContainsKey(Word))
                {
                    // 단어가 이미 wordList 사전에 없는지 확인.
                    wordList.Add(Word, Meaning); //단어와 정의를 wordList에 추가 및 저장
                    WordBox.Clear(); // WordBox 컨트롤의 텍스트를 지움.
                    MeaningBox.Clear(); // MeaningBox 컨트롤의 텍스트를 지움.
                    MessageBox.Show("단어가 등록완료되었습니다.", "단어 등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // 단어 등록이 성공적으로 완료되었다는 메시지 상자를 표시.
                }
                else //WordList에 저장되어 있는 단어와 정의가 입력한 단어와 정의가 같을 경우 
                {
                    // 단어가 이미 wordList 사전에 있는 경우, 오류 메시지를 표시.
                    MessageBox.Show("이미 추가된 단어입니다.", "이미 추가된 단어", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else // 단어랑 정의 아무것도 적지 않았을 떄
            {
                // 단어나 뜻 중 하나라도 비어 있거나 null인 경우, 오류 메시지를 표시.
                MessageBox.Show("단어와 정의를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // 현재 폼을 숨김.
        }
    }
}
