using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework_Task1
{
    /*Потрібно: Змінити 12 приклад 9 уроку (робота з документом) і створити загальний абстрактний клас для всіх частин документа.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Document title = new Title();
            title.Show();

            Document body = new Body();
            body.Show();

            Document footer = new Footer();
            footer.Show();


            Console.ReadKey();

        }
    }
}
