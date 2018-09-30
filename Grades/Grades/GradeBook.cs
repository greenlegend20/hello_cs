using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty"; 
            grades = new List<float>();
        }

        public void AddGrade(float grade){
            grades.Add(grade);
        }

        public GradeStats ComputeStats()
        {
            GradeStats stats = new GradeStats();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value!=_name){
                    NameChangeEventArgs args = new NameChangeEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }

                if(!String.IsNullOrEmpty(value)){
                    _name = value;
                }
            }
        }

        private string _name;
        public event NameChangeDelegate NameChanged;
        private List<float> grades;
    }
}
