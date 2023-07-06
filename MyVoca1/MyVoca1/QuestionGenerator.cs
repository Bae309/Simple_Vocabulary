using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVoca1
{
    public class QuestionGenerator
    {
        private Dictionary<string, string> wordList; // 단어 목록을 저장하는 private 필드

        public QuestionGenerator(Dictionary<string, string> wordList)
        {
            this.wordList = wordList;
        }

        public List<Question_A> GenerateQuestions(int count)
        {
            List<Question_A> questions = new List<Question_A>(); // 생성된 질문들을 저장할 List
            List<string> words = wordList.Keys.ToList(); // 단어 목록을 리스트로 변환
            Random random = new Random(); // 랜덤 숫자 생성기


            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(words.Count); // 단어 목록에서 랜덤한 인덱스 선택
                string word = words[randomIndex]; // 선택된 단어
                string meaning = wordList[word]; // 선택된 단어의 의미

                List<string> choices = GetRandomChoices(wordList.Values.ToList(), meaning, 3); // 랜덤한 선택지 생성
                choices.Add(meaning);  // 정답 선택지를 추가
                choices = choices.OrderBy(c => random.Next()).ToList(); // 선택지를 랜덤하게 섞음

                Question_A question = new Question_A(word, choices, meaning); // 질문 객체 생성
                questions.Add(question); // 생성된 질문을 리스트에 추가

                words.RemoveAt(randomIndex); // 사용된 단어는 목록에서 제거
            }

            return questions; // 생성된 질문 목록 반환
        }

        private List<string> GetRandomChoices(List<string> allChoices, string correctChoice, int count)
        {
            List<string> randomChoices = new List<string>(); // 랜덤한 선택지를 저장하는 리스트
            Random random = new Random(); // 랜덤 숫자 생성기

            while (randomChoices.Count < count)
            {
                int randomIndex = random.Next(allChoices.Count); // 선택지 목록에서 랜덤한 인덱스 선택
                string choice = allChoices[randomIndex]; // 선택된 선택지

                if (choice != correctChoice && !randomChoices.Contains(choice)) // 정답이 아니고 중복되지 않은 경우
                {
                    randomChoices.Add(choice); // 선택지 목록에 추가
                }
            }

            return randomChoices; // 랜덤한 선택지 목록 반환
        }
    }
}
