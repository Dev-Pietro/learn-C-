using System;

namespace CalcNotaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAssignments = 5;

            string[] students = {"Sophia", "Andrew", "Emma", "Logan"};
            int[] studentScores = new int[5];

            int[] sophiaScores = {90, 86, 87, 98, 100};
            int[] andrewScores = {92, 89, 81, 96, 90};
            int[] emmaScores = {90, 85, 87, 98, 68};
            int[] loganScores = {90, 95, 87, 88, 96};

            Console.WriteLine("Student\t\tGrade\n");

            foreach (string name in students)
            {
                string currentStudent = name;
                int currentSum = 0;
                decimal currentStudentGrade = 0;
                string currentStudentLetterGrade = "";

                if(currentStudent == "Sophia") {
                    studentScores = sophiaScores;
                } else if(currentStudent == "Andrew") {
                    studentScores = andrewScores;
                } else if(currentStudent == "Emma") {
                    studentScores = emmaScores;
                } else if(currentStudent == "Logan") {
                    studentScores = loganScores;
                }

                foreach(int score in studentScores) {
                    currentSum += score;
                }

                currentStudentGrade = (decimal)(currentSum) / currentAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }
        }
    }
}