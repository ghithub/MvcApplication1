using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class FinAidRegViewModel
    {
        private IList<Student> students;
        private IList<FinAid> finaids;

        public IList<Student> Students
        {
            get
            {
                if (students == null)
                {
                    students = new List<Student>
            {
                new Student{Id = 1, FirstName = "Abbie", ProgramId = 1},
                new Student{Id = 2, FirstName = "Cathy", ProgramId = 2},
                new Student{Id = 3, FirstName = "Erin", ProgramId = 3},
                new Student{Id = 4, FirstName = "Gary", ProgramId = 1},
                new Student{Id = 5, FirstName = "Ian", ProgramId = 2},
                new Student{Id = 6, FirstName = "Kathrin", ProgramId = 3}
            };
                }

                return students;
            }
        }
        public IList<FinAid> FinAids
        {
            get
            {
                if (finaids == null)
                {
                    finaids = new List<FinAid>{
               new FinAid{Id = 1, Name = "Gandalf"},
               new FinAid{Id = 2, Name = "Frodo"},
               new FinAid{Id = 3, Name = "Gimli"},
               new FinAid{Id = 4, Name = "Bilbo"}
            };
        }

                return finaids;
            }
        }

        [Range(1, Int32.MaxValue, ErrorMessage = "You must select a student.")]
        public int SelectedStudentId { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "You must select a fin aid type.")]
        public int SelectedFinAidId { get; set; }

        public FinAidRegViewModel()
        {

        }
    }

    public class Student
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }
        public int ProgramId { get; set; }
    }

    public class FinAid
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}