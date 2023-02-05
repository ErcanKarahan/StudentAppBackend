using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentENTITIES
{
    public abstract class BaseEntity
    {
     
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ActiveType IsActive { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;

        }
    }
}
