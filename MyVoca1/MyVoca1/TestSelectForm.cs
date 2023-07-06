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

    public partial class TestSelectForm : Form
    {
        private Dictionary<string, string> wordList; // wordList 변수를 선언
        private Choose1Of4 choose1of4; // Choose1Of4Form 인스턴스 변수 선언

        public TestSelectForm(Dictionary<string, string> wordList)
        {
            InitializeComponent();
            this.wordList = wordList;
        }

        private SpellingTestForm_1 spellingTestForm1;
        private void SpellingButton_Click(object sender, EventArgs e)
        {
            if (wordList.Count < 10)
            {
                MessageBox.Show($"단어를 10개 이상 채워주세요! (등록 단어수 :{wordList.Count})", "단어수 부족", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // 철자 테스트 폼(SpellingTestForm_1)을 열기 위한 버튼 클릭 이벤트 핸들러입니다.
                if (spellingTestForm1 == null || spellingTestForm1.IsDisposed)
                {
                    spellingTestForm1 = new SpellingTestForm_1(wordList);
                    spellingTestForm1.FormClosed += SpellingTestForm1_FormClosed; // 폼이 닫힐 때 인스턴스 제거를 위해 이벤트 핸들러 등록
                }

                if (!spellingTestForm1.Visible)
                {
                    spellingTestForm1.Show();
                }
            }

        }

        private void SpellingTestForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            spellingTestForm1 = null; // 철자 폼이 닫힐 때 인스턴스 제거
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Choose1of4Button_Click(object sender, EventArgs e)
        {
            if (wordList.Count < 10)
            {
                MessageBox.Show($"단어를 10개 이상 채워주세요! (등록 단어수 :{wordList.Count})", "단어수 부족", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // 1:4 선택 문제 폼(Choose1Of4)을 열기 위한 버튼 클릭 이벤트 핸들러입니다.
                List<Question_A> questions = GenerateRandomQuestions(10); // 10개의 랜덤 문제 생성

                choose1of4 = new Choose1Of4(questions); // 인스턴스 변수에 할당
                choose1of4.FormClosed += Choose1of4_FormClosed; // FormClosed 이벤트 핸들러 등록
                choose1of4.Show();
            }

        }

        public void Choose1of4_FormClosed(object sender, FormClosedEventArgs e)
        {
            choose1of4 = null; // 사지선다형 폼이 닫힐 때 인스턴스 제거
        }

        private List<Question_A> GenerateRandomQuestions(int count)
        {
            // 랜덤한 문제를 생성하는 메서드.
            List<Question_A> questions = new List<Question_A>();

            // 단어 목록에서 임의로 문제를 선택
            Random random = new Random();
            List<string> words = wordList.Keys.ToList();
            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(words.Count);
                string word = words[randomIndex];
                string meaning = wordList[word];

                // 랜덤으로 정답을 섞음
                List<string> choices = GetRandomChoices(wordList.Values.ToList(), meaning, 3);
                choices.Add(meaning);
                choices = choices.OrderBy(c => random.Next()).ToList();

                Question_A question = new Question_A(word, choices, meaning);
                questions.Add(question);
            }

            return questions;
        }

        private List<string> GetRandomChoices(List<string> allChoices, string correctChoice, int count)
        {
            // 주어진 선택지에서 랜덤한 선택지를 반환하는 메서드
            List<string> randomChoices = new List<string>();
            Random random = new Random();

            while (randomChoices.Count < count)
            {
                int randomIndex = random.Next(allChoices.Count);
                string choice = allChoices[randomIndex];

                if (choice != correctChoice && !randomChoices.Contains(choice))
                {
                    randomChoices.Add(choice);
                }
            }

            return randomChoices;
        }
    }
}
