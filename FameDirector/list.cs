using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace FameDirector
{
    public class List
    {
        List<User> Account = new List<User>();
        public List()
        {
            CreateUserData();
        }

        private void CreateUserData()
        {
            User user1 = new User
            {
                userName = "Karyle"
                
            };
            User user2 = new User
            {
                userName = "Anne"
            };
            User user3 = new User
            {
                userName = "Joana"
            };




            Account.Add(user1);
            Account.Add(user2);
            Account.Add(user3);

        }

        public User GetUser(string userName)
        {
            User foundUser = new User();

            foreach (var user in Account)
            {
                if (userName == user.userName )
                {
                    foundUser = user;
                }
            }

            return foundUser;

        }
    }
    }
