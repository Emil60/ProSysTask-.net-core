using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prosystask1.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [DisplayName("Dərsin kodu")]
        [Column(TypeName = "char(3)")]
        public string code { get; set; }
        [Column(TypeName = "varchar(30)")]
        [DisplayName("Dərsin adı")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(2,0)")]
        [DisplayName("Sinif")]
        public int Form { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Müəllimin adı")]
        public string TeacherName { get; set; }
        [DisplayName("Müəllimin Soyadı")]
        [Column(TypeName = "varchar(20)")]
        public string TeacherSurname { get; set; }
        public IList<Exam> Exams { get; set; }
    }
}
