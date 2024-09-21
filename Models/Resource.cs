using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public enum ResourceType { Video , Presentation , Document }
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }


    }
    //ResourceType(enum – can be Video, Presentation, Document or Other)    

}
