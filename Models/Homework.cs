using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public enum ContentType { Application, pdf , zip }
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public string SubmissionTime { get; set; }

        // relations 
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }


        //Content(string, linking to a file, not unicode)   linking to a file ?????
        
       

    }
}
