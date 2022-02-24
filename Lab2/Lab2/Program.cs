using System;

namespace Lab2
{
	class Program
	{ 
		static void Main(string[] args)
		{
			try
			{
                RomanNumber r1 = new RomanNumber(77);
                RomanNumber r2 = new RomanNumber(100);
                RomanNumber r3 = new RomanNumber(33);
                RomanNumber r4 = new RomanNumber(54);
                RomanNumber r5 = new RomanNumber(25);
                Console.WriteLine($"Сложение: {r1.ToString()} + {r3.ToString()} = {RomanNumber.Add(r1, r3).ToString()}");
                Console.WriteLine($"Вычитание: {r4.ToString()} - {r5.ToString()} = {RomanNumber.Sub(r4, r5).ToString()}");
                Console.WriteLine($"Умножение: {r2.ToString()} * {r4.ToString()} = {RomanNumber.Mul(r2, r4).ToString()}");
                Console.WriteLine($"Деление: {r2.ToString()} / {r5.ToString()} = {RomanNumber.Div(r2, r5).ToString()}");
                
                RomanNumber[] r = { r1, r2, r3, r4, r5};
                Array.Sort(r);
                Console.WriteLine("Результат сортировки");
                foreach (var item in r)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
	}
}
