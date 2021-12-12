using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача");
            Console.WriteLine("Ардрес здания: ");
            string adress = Console.ReadLine();
            Console.WriteLine("Длина здания: ");
            input(out int L);
            Console.WriteLine("Ширина здания: ");
            input(out int W);
            Console.WriteLine("Высота здания: ");
            input(out int H);
            Console.WriteLine("Этажность здания: ");
            input(out int F);
            Console.WriteLine("для завершения нажмитее любую клавишу");
            MultiBuilding multiBuilding = new MultiBuilding(adress, L, W, H, F);
            multiBuilding.Print(adress, L, W, H, F);
            Console.ReadKey();
        }
        static void input(out int number)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных! Введите значение заново");
                input(out number);
            }
        }
    }
    public class Bulding
    {
        public string adress { get; set; }
        public int L { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public Bulding(string adress, int L, int W, int H)
        {
            this.adress = adress;
            this.L = L;
            this.W = W;
            this.H = H;
        }
        public void Print(string adress, int L, int W, int H)
        {
            Console.WriteLine($"Адрес здания {adress}");
            Console.WriteLine($"Длина здания {L}");
            Console.WriteLine($"Ширина здания {W}");
            Console.WriteLine($"Высота здания {H}");
        }
    }
    class MultiBuilding : Bulding
    {
        public int F { get; set; }
        public MultiBuilding(string adress, int L, int W, int H, int F) :
            base(adress, L, W, H)
        {
            this.F = F;
        }
        public void Print(string adress, int L, int W, int H, int F)
        {
            base.Print(adress, L, W, H);
            Console.WriteLine($"Этажность здания {F}");
        }
    }
}

