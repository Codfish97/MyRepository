using System;

namespace TestHockeyPlayer
{
    class HockeyPlayer
    {
        public string name { get; set; }
        public int num { get; set; }
        public int goals { get; set; }

        public HockeyPlayer(string NAME, int NUM, int GOALS)
        {
            this.name = NAME;
            this.num = NUM;
            this.goals = GOALS;
        }

        public static void Display(HockeyPlayer player)
        {
            Console.WriteLine("Name: {0}", player.name);
            Console.WriteLine("Jersey #: {0}", player.num);
            Console.WriteLine("Goals: {0}", player.goals);
        }
    }
}
