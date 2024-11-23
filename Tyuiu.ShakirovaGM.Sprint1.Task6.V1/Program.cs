using Tyuiu.ShakirovaGM.Sprint1.Task6.V1.Lib;
namespace Tyuiu.ShakirovaGM.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Шакирова Г. М. | РППб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:Работа со строками класс String                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Шакирова Гузель Мансуровна | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем        *");
            Console.WriteLine("* символа.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string x;
            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine("Для завершения введите точку. ");
         
            x = Console.ReadLine();
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Символ: "+x+" Код: "+ds.SymbolCode(x));
            Console.ReadLine();
        }
    }
}
