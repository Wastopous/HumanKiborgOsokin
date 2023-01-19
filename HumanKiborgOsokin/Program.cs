using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanKiborgOsokin
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int rost;
                int tors;
                int kiborgtors;
                int hr = Human._headrad;
                int th = Human._torsoheight;
                int tw = Human._torsowidth;
                int lh = Human._legheight;
                int kth = Kiborg._torsoheight;
                int ktw = Kiborg._torsoweight;
                Console.WriteLine("Введите радиус головы человека:");
                hr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину туловища человека:");
                th = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ширину туловища человека: ");
                tw = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину ног человека:");
                lh = Convert.ToInt32(Console.ReadLine());
                rost = 2 * hr + th + lh;
                tors = th * tw;
                Console.WriteLine("Рост человека:" + " " + rost);
                Console.WriteLine("Площадь туловища человека:" + " " + tors);
                Console.WriteLine("Введите длину туловища киборга:");
                kth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ширину туловища киборга:");
                ktw = Convert.ToInt32(Console.ReadLine());
                kiborgtors = kth * ktw;
                Console.WriteLine("Площадь туловища киборга:"+" "+kiborgtors);


                    if (kth >= th && ktw >= tw)
                    {
                        Console.WriteLine("Да, этот человек может быть киборгом");
                    }
                    else
                    {
                        Console.WriteLine("Этот человек не может быть киборгом, его  туловище меньше");
                    }
                Console.ReadKey();
                

            }
        }
    }

