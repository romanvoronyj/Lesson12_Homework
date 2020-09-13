using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework_Task4
{
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Play");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop");
        }


        void IRecodable.Record()
        {
            Console.WriteLine("Record");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Pause");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
