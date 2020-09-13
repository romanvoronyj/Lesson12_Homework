using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler myXML = new XMLHandler();
            AbstractHandler myTXT = new TXTHandler();
            AbstractHandler myDOC = new DOCHandler();


            Console.WriteLine("Оберіть тип файлу із доступних нижче:\nDOC\nTXT\nXML");
            Console.Write("Введіть тип файлу: ");
            string choiceDoc = Console.ReadLine();

            switch(choiceDoc)
            {
                case "XML":
                    {
                        myXML.Open();
                        myXML.Create();
                        myXML.Change();
                        myXML.Save();
                        break;
                    }
                case "TXT":
                    {
                        myTXT.Open();
                        myTXT.Create();
                        myTXT.Change();
                        myTXT.Save();
                        break;
                    }

                case "DOC":
                    {
                        myDOC.Open();
                        myDOC.Create();
                        myDOC.Change();
                        myDOC.Save();
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
