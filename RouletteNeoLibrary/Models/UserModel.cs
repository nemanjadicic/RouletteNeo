using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoLibrary.Models
{
    /// <summary>
    /// Represents the user playing Roulette.
    /// </summary>
    public class UserModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Determines whether the 1st Roulette session has been won by this user.
        /// </summary>
        public bool Won { get; set; } = false;
        /// <summary>
        /// When 1st Roulette session had been won, this is set as false and the user then is prompted to buy a monthly subscription.
        /// </summary>
        public bool BoughtSub { get; set; }



        public UserModel(string firstname, string lastname, string email, string user, string pass)
        {
            FirstName = firstname;
            LastName = lastname;
            EmailAdress = email;
            Username = user;
            Password = pass;
        }

        public UserModel()
        {

        }
    }
}
