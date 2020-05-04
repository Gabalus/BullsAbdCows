using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   public class Playgame
    {
        private Game _game;

        public Playgame(Game game)
        {
            _game = game;
        }
        public string nextStep(string number)
        {
            if (!_game.isfinished)
            {
                GameRun.isfinished = false;
                try
                {
                    _game.acceptAnswer(number);
                    return _game.checkAnswer();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }


            }
            else
            {
                GameRun.isfinished = true;
                throw new Exception("Игра закончена");
            }
        }

    }
}
