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
    public partial class SpellingTestForm_1 : Form
    {
        private Dictionary<string, string> wordList;
        private List<string> testWords; //시험에 사용될 단어 목록
        private int currentQuestionIndex;   //현재 문제의 인덱스
        private int score; //점수

        public SpellingTestForm_1(Dictionary<string, string> wordList)
        { //예외처리오류를 발생시키지 않게 하기 위해 try catch 구문 사용
            try
            {
                InitializeComponent();
                this.wordList = wordList;
                testWords = GetRandomTestWords(wordList, 10); // 10개의 랜덤한 단어 선택
                currentQuestionIndex = 0;
                score = 0;
                ShowQuestion();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void ShowQuestion() //문제를 보여주는 매서드
        {
            if (currentQuestionIndex < testWords.Count)
            {
                string word = testWords[currentQuestionIndex];
                string meaning = wordList[word];
                QuestionLabel.Text = $"Question {currentQuestionIndex + 1}. {meaning}";
                AnswerTextBox.Clear();
                AnswerTextBox.Focus();
            }

            else
            {
                // 시험 종료
                if (score >= 9)
                {
                    MessageBox.Show($"문제 풀이가 끝났습니다.\n 정답 개수: {score}/{testWords.Count}  (A등급)", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (score >= 8)
                {
                    MessageBox.Show($"문제 풀이가 끝났습니다.\n 정답 개수: {score}/{testWords.Count}  (B등급)", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (score >= 6)
                {
                    MessageBox.Show($"문제 풀이가 끝났습니다.\n 정답 개수: {score}/{testWords.Count}  (C등급)", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (score >= 4)
                {
                    MessageBox.Show($"문제 풀이가 끝났습니다.\n 정답 개수: {score}/{testWords.Count}  (D등급)", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"문제 풀이가 끝났습니다.\n 정답 개수: {score}/{testWords.Count} \n 더 분발하세요!", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }


        private void CancelButton_Click(object sender, EventArgs e) //취소 버튼
        {
            // 취소 버튼 클릭 이벤트
            DialogResult result = MessageBox.Show("시험 화면에서 나가시겠습니까?", "시험 종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }

            else if (result == DialogResult.No)
            {
                // 취소 버튼 클릭 후 동작할 내용
            }

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            // 정답 확인 버튼 클릭 이벤트 핸들러.
            if (currentQuestionIndex >= 0 && currentQuestionIndex < testWords.Count)
            {
                string word = testWords[currentQuestionIndex];
                string userAnswer = AnswerTextBox.Text.Trim();

                if (userAnswer.ToLower() == word.ToLower()) // 대소문자 구분 없이 정답 확인
                {
                    // 정답인 경우
                    MessageBox.Show("정답입니다!", "정답", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    score++;
                }
                else
                {
                    // 오답인 경우
                    MessageBox.Show($"오답입니다. 정답은 {word}입니다.", "오답", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                currentQuestionIndex++;
                ShowQuestion();
            }
        }

        private List<string> GetRandomTestWords(Dictionary<string, string> wordList, int numWords)
        {
            // 랜덤한 단어 목록을 반환하는 메서드.
            List<string> allWords = new List<string>(wordList.Keys);
            Random random = new Random();
            List<string> randomWords = new List<string>();

            while (randomWords.Count < numWords && allWords.Count > 0)
            {
                int index = random.Next(allWords.Count);
                string word = allWords[index];
                randomWords.Add(word);
                allWords.RemoveAt(index);
            }

            return randomWords;
        }

    }
}
