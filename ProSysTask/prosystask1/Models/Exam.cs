using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Dərsin kodu")]
        public string Courseid { get; set; }
        public Course Course { get; set; }
        [DisplayName("Şagirdin nömrəsi")]
        public int Studentid { get; set; }
        public Student Student { get; set; }
        [Column(TypeName = "datetime2(7)")]
        [DisplayName("Tarix")]
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(1,0)")]
        [DisplayName("Qiymət")]
        public int Grade { get; set; }
    }
}
