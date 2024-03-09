using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048.Common
{
    public class UsersResultStorage
    {
        private static string path = "game results.json";

        public UsersResultStorage()
        {
            var users = new List<User>();
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(path))
            {
                return new List<User>();
            }

            var fileData = FileProvider.GetValue(path);
            var usersResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return usersResults;
        }

        public static void Append(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults);
        }

        public static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }

        public static int GetBestResult()
        {
            var userResults = GetAll();
            if (userResults.Count > 0)
            {
                var sortedUserResults = userResults.OrderByDescending(user => user.Score).ToList();
                return sortedUserResults[0].Score;
            }
            else
                return 0;
        }
    }
}
