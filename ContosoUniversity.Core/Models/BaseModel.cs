using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Core.Models
{
    public class BaseModel
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public BaseModel()
        {
            this.CreatedDate = DateTime.Now;
            this.UpdatedDate = DateTime.Now;
        }
    }
}
