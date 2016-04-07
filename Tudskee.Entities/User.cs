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
            Person = new Person();
            IsActive = true;
        }

        //User Fields
        public int ID { get; set; }

        public string Username { get; set; }
        
        public string AvatarPicPath { get; set; }

        public string ProfilePicPath { get; set; }

        public string ProfileQuote { get; set; }

        public string HashedPassword { get; set; }
        public string Salt { get; set; }

        public bool IsLocked { get; set; }

        //Person Reference
        public int PersonID { get; set; }
        public Person Person { get; set; }

        //IEntityBase Fields
        public DateTime DateCreated { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool IsActive { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
