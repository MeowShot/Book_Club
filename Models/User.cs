using System;

namespace BookClub2.Models
{
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя</param>
        public User(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
