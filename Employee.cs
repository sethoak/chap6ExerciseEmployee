using System;
using System.Collections.Generic;

namespace CorpExercise
{
    public class Employee
    {
        public Employee(string first, string last, string title, DateTime startDate)
        {
            _firstName = first;
            _lastName = last;
            _title = title;
            _startDate = startDate;
        }

        public string _firstName { get; }
        public string _lastName { get; }
        public string _title { get; }
        public string _startDate { get; }
        public GroupPeople CurrentGroup { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
    };
}