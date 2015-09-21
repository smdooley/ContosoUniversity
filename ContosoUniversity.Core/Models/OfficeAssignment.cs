using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Core.Models
{
    public class OfficeAssignment : BaseModel
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
