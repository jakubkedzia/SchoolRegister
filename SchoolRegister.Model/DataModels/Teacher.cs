﻿using System;


namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public virtual IList<Subject> ?Subjects { get; set; }
        public string Title { get; set; } = null!; 
        public Teacher()
        {
            
        }
    }
}
