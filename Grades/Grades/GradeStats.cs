using System;
namespace Grades
{
    public class GradeStats
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStats(){
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
    }
}
