using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework
{
    class DOCHandler : AbstractHandler
    {
        protected internal override void Open()
        {
            Console.WriteLine("Файл DOC відкрито.");
        }
        protected internal override void Create()
        {
            Console.WriteLine("Файл DOC створено.");
        }

        protected internal override void Change()
        {
            Console.WriteLine("Файл DOC змінено.");
        }

        protected internal override void Save()
        {
            Console.WriteLine("Файл DOC збережено.");
        }

    }
}
