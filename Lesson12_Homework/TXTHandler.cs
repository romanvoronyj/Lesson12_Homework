using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework
{
    class TXTHandler : AbstractHandler
    {
        protected internal override void Open()
        {
            Console.WriteLine("Файл TXT відкрито.");
        }
        protected internal override void Create()
        {
            Console.WriteLine("Файл TXT створено.");
        }

        protected internal override void Change()
        {
            Console.WriteLine("Файл TXT змінено.");
        }

        protected internal override void Save()
        {
            Console.WriteLine("Файл TXT збережено.");
        }


    }
}
