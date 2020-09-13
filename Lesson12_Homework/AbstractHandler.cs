using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Homework
{
    public abstract class AbstractHandler
    {
        protected internal abstract void Open();
        protected internal abstract void Create();
        protected internal abstract void Change();
        protected internal abstract void Save();
    }
}
