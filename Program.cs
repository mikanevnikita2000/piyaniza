using System;
using System.Collections.Generic;

namespace piyaniza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = CardsInit();
            (List<string> player1, List<string> player2) = SplitCards(cards);
      
            int s1 = 0;
            int s2 = 0;

            Console.WriteLine("имя 1 игрока:");

            string name1 = Console.ReadLine();

            Console.WriteLine("имя 2 игрока:");

            string name2 = Console.ReadLine();

            for (int i = 0; i < 26; i++)
            {

            }
            
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(player1[i]);
            }
           
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(player2[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            int count1 = player1.Count;
            int count2 = player2.Count;

            //while (((player1[0] != null) || (player1[0] != "")) || ((player2[0] != null) || (player2[0] != "")))
            int f = 1;
            int h = 0;
            while (f!=0)
            {
                
                int pl1 =0;
                int pl2= 0;
                if (player1[0] == "2 крести" || player1[0] == "2 буби" || player1[0] == "2 пики" || player1[0] == "2 черви") 
                {
                     pl1 = 1;
                }

                if (player1[0] == "3 крести" || player1[0] == "3 буби" || player1[0] == "3 пики" || player1[0] == "3 черви")
                {
                     pl1 = 2;
                }

                if (player1[0] == "4 крести" || player1[0] == "4 буби" || player1[0] == "4 пики" || player1[0] == "4 черви")
                {
                     pl1 = 3;
                }

                if (player1[0] == "5 крести" || player1[0] == "5 буби" || player1[0] == "5 пики" || player1[0] == "5 черви")
                {
                    pl1 = 4;
                }

                if (player1[0] == "6 крести" || player1[0] == "6 буби" || player1[0] == "6 пики" || player1[0] == "6 черви")
                {
                    pl1 = 5;
                }
                if (player1[0] == "7 крести" || player1[0] == "7 буби" || player1[0] == "7 пики" || player1[0] == "7 черви")
                {
                    pl1 = 6;
                }
                if (player1[0] == "8 крести" || player1[0] == "8 буби" || player1[0] == "8 пики" || player1[0] == "8 черви")
                {
                    pl1 = 7;
                }
                if (player1[0] == "9 крести" || player1[0] == "9 буби" || player1[0] == "9 пики" || player1[0] == "9 черви")
                {
                    pl1 = 8;
                }
                if (player1[0] == "10 крести" || player1[0] == "10 буби" || player1[0] == "10 пики" || player1[0] == "10 черви")
                {
                    pl1 = 9;
                }
                if (player1[0] == "валет крести" || player1[0] == "валет буби" || player1[0] == "валет пики" || player1[0] == "валет черви")
                {
                    pl1 = 10;
                }
                if (player1[0] == "дама крести" || player1[0] == "дама буби" || player1[0] == "дама пики" || player1[0] == "дама черви")
                {
                    pl1 = 11;
                }
                if (player1[0] == "король крести" || player1[0] == "король буби" || player1[0] == "король пики" || player1[0] == "король черви")
                {
                    pl1 = 12;
                }
                if (player1[0] == "туз крести" || player1[0] == "туз буби" || player1[0] == "туз пики" || player1[0] == "туз черви")
                {
                    pl1 = 13;
                }



                if (player2[0] == "2 крести" || player2[0] == "2 буби" || player2[0] == "2 пики" || player2[0] == "2 черви")
                {
                    pl2 = 1;
                }
                if (player2[0] == "3 крести" || player2[0] == "3 буби" || player2[0] == "3 пики" || player2[0] == "3 черви")
                {
                    pl2 = 2;
                }
                if (player2[0] == "4 крести" || player2[0] == "4 буби" || player2[0] == "4 пики" || player2[0] == "4 черви")
                {
                    pl2 = 3;
                }
                if (player2[0] == "5 крести" || player2[0] == "5 буби" || player2[0] == "5 пики" || player2[0] == "5 черви")
                {
                    pl2 = 4;
                }
                if (player2[0] == "6 крести" || player2[0] == "6 буби" || player2[0] == "6 пики" || player2[0] == "6 черви")
                {
                    pl2 = 5;
                }
                if (player2[0] == "7 крести" || player2[0] == "7 буби" || player2[0] == "7 пики" || player2[0] == "7 черви")
                {
                    pl2 = 6;
                }
                if (player2[0] == "8 крести" || player2[0] == "8 буби" || player2[0] == "8 пики" || player2[0] == "8 черви")
                {
                    pl2 = 7;
                }
                if (player2[0] == "9 крести" || player2[0] == "9 буби" || player2[0] == "9 пики" || player2[0] == "9 черви")
                {
                    pl2 = 8;
                }
                if (player2[0] == "10 крести" || player2[0] == "10 буби" || player2[0] == "10 пики" || player2[0] == "10 черви")
                {
                    pl2 = 9;
                }
                if (player2[0] == "валет крести" || player2[0] == "валет буби" || player2[0] == "валет пики" || player2[0] == "валет черви")
                {
                    pl2 = 10;
                }
                if (player2[0] == "дама крести" || player2[0] == "дама буби" || player2[0] == "дама пики" || player2[0] == "дама черви")
                {
                    pl2 = 11;
                }
                if (player2[0] == "король крести" || player2[0] == "король буби" || player2[0] == "король пики" || player2[0] == "король черви")
                {
                    pl2 = 12;
                }
                if (player2[0] == "туз крести" || player2[0] == "туз буби" || player2[0] == "туз пики" || player2[0] == "туз черви")
                {
                    pl2 = 13;
                }

                if (pl1 == 1 || pl2 == 13)
                {
                    string perecid1 = player1[0];
                    string perecid2 = player2[0];
                    Console.WriteLine($"{name1} кладёт {perecid1},а {name2} кладёт {perecid2}");
                    Console.WriteLine($"забирает: {name1}");
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                    player1.Add(perecid1);
                    player1.Add(perecid2);
                    s1 = s1 + 1;
                }
                if (pl2 == 1 || pl1 == 13)
                {
                    string perecid1 = player1[0];
                    string perecid2 = player2[0];
                    Console.WriteLine($"{name1} кладёт {perecid1},а {name2} кладёт {perecid2}");
                    Console.WriteLine($"забирает: {name1}");
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                    player1.Add(perecid1);
                    player1.Add(perecid2);
                    s1 = s1 + 1;
                }

                if (pl1>pl2)
                {
                    
                    string perecid1 = player1[0];
                    string perecid2 = player2[0];
                    Console.WriteLine($"{name1} кладёт {perecid1},а {name2} кладёт {perecid2}");
                    Console.WriteLine($"забирает: {name1}");
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                    player1.Add(perecid1);
                    player1.Add(perecid2);
                    s1 = s1 + 1;
                }
                
                   

                if (pl1 < pl2)
                {

                    string perecid1 = player1[0];
                    string perecid2 = player2[0];
                    Console.WriteLine($"{name1} кладёт {perecid1},а {name2} кладёт {perecid2}");
                    Console.WriteLine($"забирает: {name2}");
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                    player2.Add(perecid1);
                    player2.Add(perecid2);
                    s2 = s2 + 1;
                }
                if (pl1 == pl2)
                {
                    Random netf = new Random(); 
                    int ran = netf.Next(1,3);
                    if (ran==1)
                    {
                        string perecid1 = player1[0];
                        string perecid2 = player2[0];
                        Console.WriteLine($"{name1} кладёт {perecid1},а {name2} кладёт {perecid2}");
                        Console.WriteLine($"забирает: {name1}");
                        player1.RemoveAt(0);
                        player2.RemoveAt(0);
                        player1.Add(perecid1);
                        player1.Add(perecid2);
                        s1 = s1 + 1;
                    }
                    if (ran==2)
                    {
                        string perecid1 = player1[0];
                        string perecid2 = player2[0];
                        Console.WriteLine($"{name1} кладёт {perecid1},а {name2} кладёт {perecid2}");
                        Console.WriteLine($"забирает: {name2}");
                       
                        
                        player1.RemoveAt(0);
                        player2.RemoveAt(0);
                        player2.Add(perecid1);
                        player2.Add(perecid2);
                        s2 = s2 + 1;
                    }
                    
                    
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(string.Join(" ", player1));
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(string.Join(" ",player2));
                Console.WriteLine();
                Console.WriteLine();

                int n1 = player1.Count;
                int n2 = player2.Count;
                if (n1 == 0)
                {
                    f = 0;
                }
                if (n2 == 0)
                {
                    f = 0;
                }
                h = h + 1;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(h);
            if (s1 > s2)
            {
                Console.WriteLine($"победил: {name1}");
                Console.ReadLine();
            }

            if (s1 < s2)
            {
                Console.WriteLine($"победил: {name2}");
                Console.ReadLine();
            }
            if (s1 == s2)
            {
                Console.WriteLine("ничья");
                Console.ReadLine();
            }
            
        }

        static List<string> CardsInit()
        {
            List<string> cardsinit = new List<string>() {"2 буби", "2 черви", "2 пики", "2 крести", "3 буби", "3 крести", "3 пики", "3 черви",
             "4 буби", "4 крести", "4 пики", "4 черви", "5 крести", "5 черви", "5 пики", "5 крести", "6 пики",
             "6 крести", "6 черви", "6 буби", "7 крести", "7 буби", "7 пики", "7 черви", "8 крести", "8 пики",
             "8 черви", "8 буби", "9 крести", "9 буби", "9 черви", "9 пики", "10 пики", "10 буби", "10 крести",
             "10 черви" , "валет буби", "валет крести", "валет пики", "валет черви", "дама черви", "дама пики",
             "дама крести", "дама буби", "король буби", "король черви", "король пики", "король крести",
             "туз крести", "туз буби", "туз пики", "туз черви" };

            //перемешивыем элементы массива
            Random rnd = new Random();
            for (int i = 0; i < cardsinit.Count; i++)
            {
                int k = rnd.Next(0, i);
                string card = cardsinit[k];
                cardsinit[k] = cardsinit[i];
                cardsinit[i] = card;
            }
            return(cardsinit);
        }
        static (List<string> cardsplayer1, List<string> cardsplayer2) SplitCards(List<string> cards)
        {
            List<string> cardsplayer1 = new List<string>();
            List<string> cardsplayer2 = new List<string>();
            for (int i = 0; i < 26; i++)
            {
                cardsplayer1.Add(cards[0]);
                cardsplayer2.Add(cards[1]);
                cards.RemoveAt(0);
                cards.RemoveAt(0);
            }
            return (cardsplayer1, cardsplayer2);
        }
    } 
}
