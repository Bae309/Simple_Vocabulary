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
    public partial class Choose1Of4 : Form
    {
        private List<Question_A> questions; // 문제 목록을 저장하는 리스트
        private int currentQuestionIndex; // 현재 문제의 인덱스
        private int correctAnswerCount; // 정답 개수
        public Choose1Of4(List<Question_A> questions)
        {
            InitializeComponent();
            this.questions = questions; // 주어진 문제 목록을 멤버 변수에 저장
            this.currentQuestionIndex = 0; // 현재 문제 인덱스 초기화
            this.correctAnswerCount = 0; // 정답 개수 초기화
            ShowCurrentQuestion(); // 현재 문제를 화면에 표시
        }

        private void ShowCurrentQuestion()
        {
            Question_A currentQuestion = questions[currentQuestionIndex]; // 현재 문제를 가져옴
            QuestionLabel.Text = currentQuestion.Word; // 문제의 단어를 화면에 표시

            // 선택지를 각 라디오 버튼에 표시
            RadioChoice1.Text = currentQuestion.Choices[0];
            RadioChoice2.Text = currentQuestion.Choices[1];
            RadioChoice3.Text = currentQuestion.Choices[2];
            RadioChoice4.Text = currentQuestion.Choices[3];
        }

        private void CheckAnswer()
        {
            Question_A currentQuestion = questions[currentQuestionIndex]; // 현재 문제를 가져옴
            string selectedChoice = GetSelectedChoice(); // 사용자가 선택한 답을 가져옴

            string correctChoice = currentQuestion.Meaning; // 현재 문제의 정답을 가져옴

            if (selectedChoice == correctChoice)
            {
                // 정답인 경우
                MessageBox.Show("정답입니다!");
                correctAnswerCount++;
            }
            else
            {
                // 오답인 경우
                MessageBox.Show($"오답입니다. 정답은 {correctChoice}입니다.");
            }

            // 다음 문제로 이동
            currentQuestionIndex++; // 다음 문제 인덱스로 이동
            if (currentQuestionIndex < questions.Count)
            {
                ShowCurrentQuestion();  // 다음 문제를 화면에 표시
            }
            else
            {
                // 모든 문제를 푼 경우 결과 출력
                ShowResult();
            }
        }

        private string GetSelectedChoice()
        {
            // 사용자가 선택한 라디오 버튼의 선택지를 반환
            if (RadioChoice1.Checked)
                return RadioChoice1.Text;
            if (RadioChoice2.Checked)
                return RadioChoice2.Text;
            if (RadioChoice3.Checked)
                return RadioChoice3.Text;
            if (RadioChoice4.Checked)
                return RadioChoice4.Text;

            return null;
        }

        private void ShowResult()
        {
            // 문제 풀이 결과를 출력
            if (correctAnswerCount >= 9)
            {
                MessageBox.Show($"문제 풀이가 끝났습니다. 정답 개수: {correctAnswerCount}/{questions.Count}  (A등급)", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (correctAnswerCount >= 8)
            {
                MessageBox.Show($"문제 풀이가 끝났습니다. 정답 개수: {correctAnswerCount}/{questions.Count}  (B등급)", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (correctAnswerCount >= 6)
            {
                MessageBox.Show($"문제 풀이가 끝났습니다. 정답 개수: {correctAnswerCount}/{questions.Count}  (C등급)", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (correctAnswerCount >= 4)
            {
                MessageBox.Show($"문제 풀이가 끝났습니다. 정답 개수: {correctAnswerCount}/{questions.Count}  (D등급)", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show($"문제 풀이가 끝났습니다. 정답 개수: {correctAnswerCount}/{questions.Count}\n 더 분발하세요!", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            // 폼을 닫음
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (GetSelectedChoice() != null)
            {
                CheckAnswer();
            }
            else
            {
                MessageBox.Show("선택지를 선택해주세요.");
            }
        }

        private void Choose1in4Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 부모 폼의 이벤트 핸들러를 호출하여 인스턴스 제거
            TestSelectForm parentForm = (TestSelectForm)this.Owner;
            parentForm.Choose1of4_FormClosed(this, null);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("시험 화면에서 나가시겠습니까?", "시험 종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }

            else if (result == DialogResult.No)
            {

            }
        }
    }
}
