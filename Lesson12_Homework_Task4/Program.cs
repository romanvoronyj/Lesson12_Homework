using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework_Task4
{
    class Program
    {
        /* Створіть 2 інтерфейсу IPlayable і IRecodable. У кожному з інтерфейсів створіть по 3 методу 
         * voidPlay () / voidPause () / voidStop () і voidRecord () / voidPause () / voidStop () відповідно.
         * Створіть похідний клас Player від базових інтерфейсів IPlayable і IRecodable. Написати програму, яка виконує програвання і запис.*/

        static void Main(string[] args)
        {
            Player myPlay = new Player();

            IPlayable myPlayer = myPlay as IPlayable;
            myPlayer.Play();
            myPlayer.Pause();
            myPlayer.Stop();

            IRecodable myRecorder = myPlay as IRecodable;
            myRecorder.Record();
            myRecorder.Pause();
            myRecorder.Stop();

            Console.ReadKey();

        }
    }
}
