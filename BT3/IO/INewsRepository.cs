using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public interface INewsRepository
    {
        List<Publisher> GetNews();


        void Save(List<Publisher> publishers);
    }
}
