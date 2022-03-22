using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Model
{
    public class lesson
    {
        [Key]

        public  int lId { get; set; }

        [Required]
        public string lCode { get; set; }

        [Required]
        public string lName { get; set; }

        [Required]
        public int lClass { get; set; }

        [Required]
        public string lTeacherName { get; set; }

        [Required]
        public int lTeacherSurname { get; set; }

    }
}
