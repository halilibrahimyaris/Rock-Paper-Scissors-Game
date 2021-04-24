using System;

namespace Rock_Paper_Scissors
{
    enum Choices
    {
        rock,
        paper,
        scissors
    }

    class Game
    {

        int playerAwinCount;
        int playerBwinCount;
        int tieCount;

        Choices playerAchoice;
        Choices playerBchoice;

        void Play(Choices _playerAchoice, Choices _playerBchoice)
        {

            if (_playerAchoice == Choices.rock && _playerBchoice == Choices.rock)
            {
                tieCount++;
            }
            else if (_playerAchoice == Choices.rock && _playerBchoice == Choices.paper)
            {
                playerBwinCount++;
            }
            else if (_playerAchoice == Choices.rock && _playerBchoice == Choices.scissors)
            {
                playerAwinCount++;
            }
            else if (_playerAchoice == Choices.paper && _playerBchoice == Choices.rock)
            {
                playerAwinCount++;
            }
            else if (_playerAchoice == Choices.paper && _playerBchoice == Choices.paper)
            {
                tieCount++;
            }
            else if (_playerAchoice == Choices.paper && _playerBchoice == Choices.scissors)
            {
                playerBwinCount++;
            }
            else if (_playerAchoice == Choices.scissors && _playerBchoice == Choices.rock)
            {
                playerBwinCount++;
            }
            else if (_playerAchoice == Choices.scissors && _playerBchoice == Choices.paper)
            {
                playerAwinCount++;
            }
            else if (_playerAchoice == Choices.scissors && _playerBchoice == Choices.scissors)
            {
                tieCount++;
            }

        }

        Choices RandomChoice(int i)
        {
            if (i == 0)
                return Choices.rock;
            else if (i == 1)
                return Choices.paper;
            else
                return Choices.scissors;
        }

        static void Main(string[] args)
        {
            Game g = new Game();
            g.playerAchoice = Choices.paper;
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                g.playerBchoice = g.RandomChoice(rnd.Next(0, 3));
                g.Play(g.playerAchoice, g.playerBchoice);
            }

            Console.WriteLine("Player A wins " + g.playerAwinCount + " of 100 games");
            Console.WriteLine("Player B wins " + g.playerBwinCount + " of 100 games");
            Console.WriteLine("Tie: " + g.tieCount + " of 100 games");
        }


    }
}
