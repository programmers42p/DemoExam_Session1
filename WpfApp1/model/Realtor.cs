using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.model
{
    [Table("realtor")]
    class Realtor : IFIO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        [StringLength(50)]
        public string name { get; set; }
        [StringLength(50)]
        public string lastName { get; set; }
        [StringLength(50)]
        public string patronymic { get; set; }

        public int procent { get; set; }
    }
}
