using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParsing
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsMen { get; set; }
        public override string ToString()
        {
            return $"{Id};{FirstName};{LastName};{Patronymic};{Phone};{Email};" +
                $"{Birthday.ToShortDateString()};{RegistrationDate.ToShortDateString()};{(IsMen ? "мужской" : "женский")}";
        }
    }
}
