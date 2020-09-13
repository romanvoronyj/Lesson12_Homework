using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework_Task1
{
    class Title : Document
    {
        string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок відсутній.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
