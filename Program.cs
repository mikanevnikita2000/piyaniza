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

            
            int f = 1;
            int h = 0;
            while (f!=0)
            {
                (int pl1, int pl2) = TheValueOfTheCard( player1, player2);



                if (pl1 == 2 || pl2 == 14)
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
                if (pl2 == 2 || pl1 == 14)
                {
                    string perecid1 = player1[0];
                    string perecid2 = player2[0];
                    Console.WriteLine($"{name1} кладёт {perecid1},а {name2} кладёт {perecid2}");
                    Console.WriteLine($"забирает: {name2}");
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                    player1.Add(perecid1);
                    player1.Add(perecid2);
                    s2 = s2 + 1;
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
        static (int play1, int play2) TheValueOfTheCard(List<string> player1, List<string> player2)
        {
            int play1 = 0;
            int play2 = 0;
            string nulindx1 = player1[0];
            string nulindx2 = player2[0];
            while (play1 >0 && play2 > 0)
            {
                List<string> ch1 = new List<string> {null,null, "2", "3", "4", "5", "6", "7", "8", "9", "10", "в", "д", "к", "т" };
                for (int i = 2; i < 15; i++)
                {
                    int indexplyer1 = nulindx1.IndexOf(ch1[i]);
                    int indexplyer2 = nulindx2.IndexOf(ch1[i]);
                    if (indexplyer1 == 1)
                    {
                        play1 = i;
                    }
                    if (indexplyer2 == 1)
                    {
                        play2 = i;
                    }
                }
            }
            return (play1, play2);
        }
        static(int su1, int su2, string per1, string per2) WinPlayer(List<string> player1, List<string> player2,int pl1, int pl2)
        {
            string per1="";
            string per2 = "";
            int s1 = 0;
            int s2 = 0;
            return (s1, s2,per1,per2);
        }
    } 
}
