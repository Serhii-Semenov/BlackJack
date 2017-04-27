using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWcfService.Model
{
    public class CDeck
    {
        Ccard[] deck = new Ccard[52];
        int count;//кол-во карт в колоде
        int sum;//количество очков по картам

        public CDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int n = 0; n < 13; n++)
                {
                    deck[i * 13 + n].suit = (Suit)(i + 3);
                    if (n < 9) { deck[i * 13 + n].name = (Fase)(n + 50); deck[i * 13 + n].points = n + 2; }
                    if (n == 9) { deck[i * 13 + n].name = (Fase)(n + 65); deck[i * 13 + n].points = 10; }
                    if (n == 10) { deck[i * 13 + n].name = (Fase)(n + 71); deck[i * 13 + n].points = 10; }
                    if (n == 11) { deck[i * 13 + n].name = (Fase)(n + 64); deck[i * 13 + n].points = 10; }
                    if (n == 12) { deck[i * 13 + n].name = (Fase)(n + 72); deck[i * 13 + n].points = 11; }
                    count++;
                    sum += deck[i * 13 + n].points;
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
                temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
    } 
}
