using CaloriProject.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Repostory.Abstract
{
    public abstract class Entity : IEntity
    {
        public int Id { get ; set ; }
        public DateTime CreatedDate { get ; set ; } = DateTime.Now;
        public DateTime? UpdatedDate{ get ; set ; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; } = Status.Created;


    }
}
