using System;
using System.Collections.Generic;

namespace Coding_Games
{
    internal class War
    {
        static List <int> deck1 = new List<int>();
        static List <int> deck2 = new List<int>();
        static int playCardNumber = 0;
        static int roundsAmount = 0;
        
        public static void Main(string[] args)
        {
            deck1 = GetCards();
            deck2 = GetCards();
            int winnerNum = 5;


            while (deck1.Count > 0 && deck2.Count > 0 && winnerNum != 0)  
            {
                winnerNum = Move();
                Console.WriteLine(roundsAmount);
                foreach(int card in deck1)
                {
                     Console.WriteLine(card);
                }
                foreach(int card in deck2)
                {
                    Console.WriteLine(card);
                }
            }
            
            if (winnerNum != 0)
            {
                Console.WriteLine($"{winnerNum} {roundsAmount}");
            }
            else Console.WriteLine("PAT");

        }

        static void MoveResult(List<int> winnerCards, List<int> looserCards, int playedCardsAmount)
        {
            for (int i = 0; i < playedCardsAmount; i++)
            {
                winnerCards.Add(deck1[0]);
                winnerCards.Add(deck2[0]);
                looserCards.Remove(looserCards[0]);
                winnerCards.Remove(winnerCards[0]);
            }
        }

        static int Move()
        {
            int winnerNum = 5;
            if (deck1.Count > playCardNumber && deck2.Count > playCardNumber)
            {
                if (deck1[playCardNumber] > deck2[playCardNumber])
                {
                    MoveResult(deck1, deck2, playCardNumber + 1);
                    winnerNum = 1;
                    playCardNumber = 0;
                    roundsAmount++;
                }
                else if (deck1[playCardNumber] < deck2[playCardNumber])
                {
                    MoveResult(deck2, deck1, playCardNumber + 1);
                    winnerNum = 2;
                    playCardNumber = 0;
                    roundsAmount++;
                }
                else playCardNumber += 4;
            }
            else winnerNum = 0;
            return winnerNum;
        }

        static List<int> GetCards()
        {
            List<int> cards = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string card = Console.ReadLine();
                card = card.Substring(0, card.Length - 1);
                
                int cardNumber;
                
                if (Int32.TryParse(card, out cardNumber))
                    cardNumber=Int32.Parse(card);
                else if (card[card.Length - 1] == 'J')
                {
                    cardNumber = 11;
                }
                else if (card[card.Length - 1] == 'Q')
                {
                    cardNumber = 12;
                }
                else if (card[card.Length - 1] == 'K')
                {
                    cardNumber = 13;
                }
                else if (card[card.Length - 1] == 'A')
                {
                    cardNumber = 14;
                }

                cards.Add(cardNumber);
            }

            return cards;
        }
    }
}