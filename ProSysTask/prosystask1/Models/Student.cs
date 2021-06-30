using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prosystask1.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [DisplayName("Şagirdin nömrəsi")]

        [Column(TypeName = "decimal(5,0)")]
        public int StudentId { get; set; }
        [Column(TypeName = "varchar(30)")]
        [DisplayName("Adı")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(30)")]
        [DisplayName("Soyadı")]
        public string Surname { get; set; }
        [Column(TypeName = "decimal(2,0)")]
        [DisplayName("Sinif")]
        public int Form { get; set; }
        public IList<Exam> Exams { get; set; }
    }
}
