using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            String month1;
            

            Console.WriteLine("태어난 월을 입력하세요.");
            month1 = Console.ReadLine();
           
            switch (month1)
            {
                case "12": 
                case "12월":
                case "1":
                case "01":
                case "1월":
                case "2":
                case "02":
                case "2월":
                    Console.WriteLine("겨울에 태어나셨군요");
                    break;

                case "3":
                case "03월":
                case "3월":
                case "4":
                case "04":
                case "4월":
                case "5":
                case "05":
                case "5월":
                    Console.WriteLine("봄에 태어나셨군요");
                    break;

                case "6":
                case "06월":
                case "6월":
                case "7":
                case "07":
                case "7월":
                case "8":
                case "08":
                case "8월":
                    Console.WriteLine("여름에 태어나셨군요");
                    break;

                case "9":
                case "09월":
                case "9월":
                case "10":
                case "10월":
                case "11":
                case "11월":
                    Console.WriteLine("가을에 태어나셨군요");
                    break;

                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    break;
            }
        }
    }
}
