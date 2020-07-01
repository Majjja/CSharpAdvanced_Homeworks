using QuizApp.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizApp.Helpers
{
    public static class UserHelper
    {
        public static void GetQuiz()
        {
            foreach (var question in DataBase.MultipleChoiceQuestions)
            {
                Console.WriteLine(question.Key);
                foreach (var answer in question.Value)
                {
                    Console.WriteLine(answer.EndsWith('*') ? $"    {answer.ToString().Substring(0, answer.Length - 1)}" : $"    {answer}");
                }
            }
        }

        public static int CheckAnswers(string useranswer)
        {
            var theAnswer = useranswer.ToList();
            int grade = 0;
            for (int i = 0; i < theAnswer.Count; i++)
            {
                for (int j = 0; j < RightAnswers().Count; j++)
                {
                    if (RightAnswers()[j].StartsWith(theAnswer[i]) && i == j)
                    {
                        if (RightAnswers()[j].EndsWith('*'))
                        {
                            grade++;
                            break;
                        }
                    }
                }
            }
            return grade;
        }

        private static List<string> RightAnswers()
        {
            List<string> rightAnswers = new List<string>();

            foreach (var question in DataBase.MultipleChoiceQuestions)
            {
                foreach (var item in question.Value)
                {
                    if (item.EndsWith('*'))
                        rightAnswers.Add(item);
                }
            }
            return rightAnswers;
        }
    }
}
