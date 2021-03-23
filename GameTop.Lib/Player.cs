using GameTop.Interface;

namespace GameTop.Lib
{
    public class Player:IPlayer
    {
        public readonly string _Name;
        public Player(string name)
        {
            _Name = name;
        }
        public string Kick()
        {
            return $"{_Name} are kicking \n";
        }
        public string Pass()
        {
            return $"{_Name} are passing \n";
        }
        public string Run()
        {
            return $"{_Name} are runing \n";
        }
    }
}