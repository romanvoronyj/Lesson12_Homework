using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework
{
    class XMLHandler : AbstractHandler
    {
        protected internal override void Open()
        {
            Console.WriteLine("Файл XML відкрито.");
        }
        protected internal override void Create()
        {
            Console.WriteLine("Файл XML створено.");
        }

        protected internal override void Change()
        {
            Console.WriteLine("Файл XML змінено.");
        }

        protected internal override void Save()
        {
            Console.WriteLine("Файл XML збережено.");
        }

    }
}
