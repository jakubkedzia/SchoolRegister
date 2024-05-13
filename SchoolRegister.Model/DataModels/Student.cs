using System;
using System.Text.RegularExpressions;


namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public virtual Group ?Group { get; set; }
        public int ?GroupId { get; set; }
        public virtual IList<Grade> ?Grades { get; set; }
        public virtual Parent ?Parent { get; set; }
        public int ?ParentId { get; set; }
        public double AvarageGrade 
        { 
            get;
        }
        public IDictionary<string,double> ?AvarageGradePerSubject 
        { 
            get;
        }
        public IDictionary<string,List<GradeScale>> ?GradesPerSubject 
        { 
            get; 
        }
        public Student()
        {
            
        }

    }
}
