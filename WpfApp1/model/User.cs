using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1
{
    [Table("usr")]
    class User :IFIO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string name { get; set; }
        [StringLength(50)]
        public string lastName { get; set; }
        [StringLength(50)]
        public string patronymic { get; set; }
        [StringLength(10)]
        public string phone { get; set; }
        [StringLength(50)]
        public string email { get; set; }
    }
}
