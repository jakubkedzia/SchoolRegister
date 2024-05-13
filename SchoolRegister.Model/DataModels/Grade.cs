using System;


namespace SchoolRegister.Model.DataModels
{
    public class Grade
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        public virtual Subject Subject { get; set; } = null!;   
        public int SubjectId { get; set; }
        public virtual Student Student { get; set; } = null!;
        public int StudentId { get; set; }
        public Grade()
        {
            
        }
    }
}
