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
    public partial class ShowForm : Form
    {
        private Dictionary<string, string> wordList; // 단어와 뜻을 저장하는 사전

        public ShowForm(Dictionary<string, string> wordList)
        {
            InitializeComponent();
            this.wordList = wordList;
            InitializeDataGridView();
        }

        // 데이터 그리드 뷰 초기화
        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = wordList.ToList();

            // 단어 열 생성
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Key",
                Name = "Word",
                HeaderText = "Word"
            });

            // 뜻 열 생성
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Value",
                Name = "Meaning",
                HeaderText = "Meaning"
            });
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 단어 수정 버튼 클릭 이벤트 핸들러
        private void ModifyWordButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                // 선택된 행이 없는 경우 오류 메시지를 표시하고 함수를 종료.
                MessageBox.Show("수정할 단어를 선택해주세요.", "선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 선택한 행 가져오기
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // 선택한 행의 단어와 정의 가져오기
            string word = selectedRow.Cells["Word"].Value.ToString(); // "Word"로 열 이름 수정
            string meaning = selectedRow.Cells["Meaning"].Value.ToString(); // "Meaning"으로 열 이름 수정

            // 단어와 정의를 수정하기 위한 ModifyForm 생성
            ModifyForm modifyForm = new ModifyForm(word, meaning);
            DialogResult result = modifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // 수정된 단어와 정의 받아오기
                string modifiedWord = modifyForm.ModifiedWord;
                string modifiedMeaning = modifyForm.ModifiedMeaning;

                if (wordList.ContainsKey(modifiedWord) && modifiedWord != word)
                {
                    // 수정된 단어가 이미 존재하는 경우 오류 메시지 표시
                    MessageBox.Show("이미 존재하는 단어입니다.", "중복 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 선택한 행의 단어와 정의 수정
                selectedRow.Cells["Word"].Value = modifiedWord;
                selectedRow.Cells["Meaning"].Value = modifiedMeaning;

                // wordList 딕셔너리도 업데이트
                wordList.Remove(word);
                wordList[modifiedWord] = modifiedMeaning;

                // DataGridView 업데이트
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = wordList.ToList();
            }
        }


        // 단어 삭제 버튼 클릭 이벤트 핸들러
        private void DeleteWordButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 단어를 선택해주세요.", "선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("단어를 삭제하시겠습니까?", "단어 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (AllCheckBox.Checked)
                {
                    // 모든 단어 삭제
                    wordList.Clear();
                    dataGridView1.DataSource = null;
                }
                else
                {
                    // 선택한 행의 단어 삭제
                    List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        selectedRows.Add(row);
                    }

                    foreach (DataGridViewRow row in selectedRows)
                    {
                        string word = row.Cells["Word"].Value.ToString();
                        wordList.Remove(word);
                    }

                    dataGridView1.DataSource = wordList.ToList();
                }
            }
        }

        // 단어 추가 및 수정을 위한 ModifyForm에서 호출하는 메서드
        public void AddWordAndMeaning(string word, string meaning)
        {
            // 새로운 단어 추가
            if (!wordList.ContainsKey(word))
            {
                wordList.Add(word, meaning);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = wordList.ToList();
            }
            else
            {
                // 기존 단어 수정
                wordList[word] = meaning;

                // 기존 단어가 표시되는 행을 찾아 업데이트
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string rowWord = row.Cells["Word"].Value.ToString();
                    if (rowWord == word)
                    {
                        row.Cells["Meaning"].Value = meaning;
                        break;
                    }
                }
            }
        }

        // 이전으로 버튼 클릭 이벤트 핸들러
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


