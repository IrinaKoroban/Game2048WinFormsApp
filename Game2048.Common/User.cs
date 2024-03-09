namespace Game2048.Common
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }

        // необходим для десериализации данных в UsersResultStorage
        public User()
        {}

        public User(string name)
        {
            Name = name;
            Score = 0;
        }

        public User(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public void AddScore(int score)
        { 
            Score = score;
        }

    }
}