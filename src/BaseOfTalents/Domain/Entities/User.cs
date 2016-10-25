﻿using System;
using System.Collections.Generic;
using Domain.Entities.Enum.Setup;

namespace Domain.Entities
{
    public class User : BaseEntity, IComparable
    {
        public User()
        {
            PhoneNumbers = new List<PhoneNumber>();
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool isMale { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public virtual File Photo { get; set; }

        public int? CityId { get; set; }
        public virtual City City { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Comment> UserComments { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            User otherUser = obj as User;
            if (otherUser != null)
                return (this.LastName + this.FirstName).CompareTo(otherUser.LastName + otherUser.FirstName);
            else
                throw new ArgumentException("Object is not a User");
        }
    }
}