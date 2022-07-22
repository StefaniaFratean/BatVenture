using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserDataAccess;

namespace BatventureServer.Controllers
{
    public class UserController : ApiController
    {
        public IEnumerable<User> getAll()
        {
            using (batventureEntities model = new batventureEntities())
            {
                return model.Users.ToList();
            }
        }

        public User GetUserAndPassword(string Username, string Password)
        {
            using (batventureEntities model = new batventureEntities())
            {
                 User userInstance = model.Users.Find(Username);
                if(userInstance != null)
                {
                    if(userInstance.Password == Password)
                    {
                        return userInstance;
                    }
                }
                return null;
            }
        }

        [HttpPost]
        public User CreateUser(string Username, string Password)
        {
            using (batventureEntities model = new batventureEntities())
            {
                User newUser = new User();
                newUser.HighScore = 0;
                newUser.Password = Password;
                newUser.UserName = Username;

                model.Users.Add(newUser);
                try
                {
                    model.SaveChanges();
                } catch (Exception)
                {
                    return null;
                }
                return newUser;
            }
        }

        [HttpPost]
        [Route("api/user/highscore")]
        public User UpdateHighscore(string Username, int Highscore)
        {
            using(batventureEntities model = new batventureEntities())
            {
                User userInstance = model.Users.Find(Username);
                if(userInstance.HighScore < Highscore)
                {
                    userInstance.HighScore = Highscore;
                }
                model.SaveChanges();
                return userInstance;
            }
        }

        [HttpGet]
        [Route("api/user/scoreboard")]
        public IEnumerable<User> GetScoreboard()
        {
            using (batventureEntities model = new batventureEntities())
            {
                IEnumerable<User> userList = model.Users.ToList();
                IEnumerable<User> orderedUsers = userList.OrderByDescending(u => u.HighScore).ToList().GetRange(0, userList.Count() >= 10 ? 10 : userList.Count());
                return orderedUsers;

            }
        }


    }
}
