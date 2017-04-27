using System;
using System.Collections.Generic;

namespace BlackJackWcfService.Model
{
    public class CDeck
    {
        public Queue<Ccard> deck;

        public CDeck()
        {
            Ccard[] deckTemp = new Ccard[52];
            int count=0;//кол-во карт в колоде
            int sum=0;//количество очков по картам
            for (int i = 0; i < 4; i++)
            {
                for (int n = 0; n < 13; n++)
                {
                    deckTemp[i * 13 + n].suit = (Suit)(i + 3);
                    if (n < 9) { deckTemp[i * 13 + n].name = (Fase)(n + 50); deckTemp[i * 13 + n].points = n + 2; }
                    if (n == 9) { deckTemp[i * 13 + n].name = (Fase)(n + 65); deckTemp[i * 13 + n].points = 10; }
                    if (n == 10) { deckTemp[i * 13 + n].name = (Fase)(n + 71); deckTemp[i * 13 + n].points = 10; }
                    if (n == 11) { deckTemp[i * 13 + n].name = (Fase)(n + 64); deckTemp[i * 13 + n].points = 10; }
                    if (n == 12) { deckTemp[i * 13 + n].name = (Fase)(n + 72); deckTemp[i * 13 + n].points = 11; }
                    count++;
                    sum += deckTemp[i * 13 + n].points;
                }
            }
            //if (count != 52 && sum != 66) //
            //    new Exception();

            Random rand = new Random();
            Ccard temp;
            int j;
            for (int i = 0; i < 52; i++)
            {
                j = rand.Next(52);
                temp = deckTemp[i];
                deckTemp[i] = deckTemp[j];
                deckTemp[j] = temp;
            }
            deck = new Queue<Ccard>(deckTemp);
        }
    }
}
