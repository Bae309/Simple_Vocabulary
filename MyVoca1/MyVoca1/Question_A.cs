using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVoca1
{
    public class Question_A
    {
        public string Word { get; set; } // 질문에 해당하는 단어
        public List<string> Choices { get; set; } // 선택지 목록
        public string Meaning { get; set; } // 정답의 의미

        public Question_A(string word, List<string> choices, string meaning)
        {
            Word = word;
            Choices = choices;
            Meaning = meaning;
        }
    }
}
