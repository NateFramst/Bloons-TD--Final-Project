using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloons_TD__Final_Project
{
    public class Highscore
    {
        public string userName, password;

        public int highscore, levelNumber, score;


        public Highscore(string _username, string _password, int _highscore)
        {
            userName = _username;
            password = _password;
            highscore = _highscore;
            score = 0;
        }
    }
}
