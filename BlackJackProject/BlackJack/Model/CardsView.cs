using BlackJackWcfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    class CardsView
    {
        public CardsView instance;
        public CardsView Instance
        {
            get
            {
                if (instance == null) instance = new CardsView();
                return instance;
            }
        }
        public string GetFileName(Suit s, Fase f)
        {
            string str = "";

            switch (s)
            {
                case Suit.Club:
                    str = "1";
                    break;
                case Suit.Diamond:
                    str = "4";
                    break;
                case Suit.Heart:
                    str = "3";
                    break;
                case Suit.Spade:
                    str = "2";
                    break;

                    switch (f)
                    {
                        case Fase.Deuce:
                            str += "2";
                            break;
                        case Fase.Three:
                            str += "3";
                            break;
                        case Fase.Four:
                            str += "4";
                            break;
                        case Fase.Five:
                            str += "5";
                            break;
                        case Fase.Six:
                            str += "6";
                            break;
                        case Fase.Seven:
                            str += "7";
                            break;
                        case Fase.Eight:
                            str += "8";
                            break;
                        case Fase.Nine:
                            str += "9";
                            break;
                        case Fase.Ten:
                            str += "10";
                            break;
                        case Fase.Jack:
                            str += "11";
                            break;
                        case Fase.Queen:
                            str += "12";
                            break;
                        case Fase.King:
                            str += "13";
                            break;
                        case Fase.Ace:
                            str += "14";
                            break;
                        case Fase.Zero:
                            break;
                        default:
                            break;
                    }
            }            

            return str+".jpg";
        }
        private CardsView() { }
        
    }
}
