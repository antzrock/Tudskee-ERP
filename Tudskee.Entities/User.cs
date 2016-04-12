using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public class User : IEntityBase
    {
        public User()
        {
            IsActive = true;
        }

        //User Fields
        public virtual int Id { get; set; }

        public virtual string Username { get; set; }

        public virtual string AvatarPicPath { get; set; }

        public virtual string ProfilePicPath { get; set; }

        public virtual string ProfileQuote { get; set; }

        public virtual string HashedPassword { get; set; }
        public virtual string Salt { get; set; }

        public virtual bool IsLocked { get; set; }

        //IEntityBase Fields
        public virtual DateTime DateCreated { get; set; }

        public virtual int CreatedBy { get; set; }

        public virtual DateTime CreatedDate { get; set; }

        public virtual int? UpdatedBy { get; set; }

        public virtual DateTime? UpdatedDate { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual byte[] RowVersion { get; set; }
    }
}
