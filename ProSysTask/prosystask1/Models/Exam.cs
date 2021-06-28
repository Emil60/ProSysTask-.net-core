using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prosystask1.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public string Courseid { get; set; }
        public Course Course { get; set; }
        public int Studentid { get; set; }
        public Student Student { get; set; }
        [Column(TypeName = "datetime2(7)")]
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(1,0)")]
        public int Grade { get; set; }
    }
}
