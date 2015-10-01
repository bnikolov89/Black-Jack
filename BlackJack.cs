using System;

namespace BlackJack
{
    class BlackJack
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            char choice;
            int chips = 1000,bet;
            do
            {
                Console.WriteLine("Enter the ammount of chips you want to bet(you have {0}):", chips);
                bet = int.Parse(Console.ReadLine());
                chips = chips - bet;
                //should print the dealer card and the player card
                gameStart();
                do
                {
                    Console.WriteLine("Do you want another card ? (Y/N): ");
                    choice = char.Parse(Console.ReadLine());
                    //should print another card for the player
                    playOn();
                    
                } while (choice == 'Y');
                //this method should define the winner(gets weight of cards of the dealer and the player,returns win or lose)
                getWinner();
                //this method should get the ammount of chips you have after the game(gets win or lose and bet ammount, returns chips)
                getChips();
                Console.WriteLine("Do you want to play another game ? (Y/N): ");
                choice = char.Parse(Console.ReadLine());
                if (choice == 'Y') gameOver = false;
                if (choice == 'N') gameOver = true;
            } while (gameOver == false);
        }
    }
}
