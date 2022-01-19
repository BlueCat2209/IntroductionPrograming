using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Mark
    {
        public string SubjectName;
        public float LearningMark; 
        public float PracticingMark;
        public float AverageMark;
        public Mark(string subjectName, float learningMark, float praticingMark, float averageMark)
        {
            this.SubjectName = subjectName;
            this.LearningMark = learningMark;
            this.PracticingMark = praticingMark;
            this.AverageMark = averageMark;
        }
        public void PrintSubjectMark()
        {
            Console.WriteLine($"Thong Tin Mon Hoc: {SubjectName}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Diem ly thuyet la: {LearningMark}");
            Console.WriteLine($"Diem thuc hanh la: {PracticingMark}");
            Console.WriteLine($"Diem trung binh la: {AverageMark}");
            Console.WriteLine("====================================");
        }
    }
}
