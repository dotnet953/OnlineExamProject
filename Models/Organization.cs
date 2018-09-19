using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Models
{
    public class Organization
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Code { get; set; }
        public string Address { get; set; }
        [Required]
        public int ContactNo { get; set; }
        public string About { get; set; }
        public string LogoName { get; set; }
        public string LogoUrl { get; set; }

        public List<Course> Courses { get; set; }
    }
}