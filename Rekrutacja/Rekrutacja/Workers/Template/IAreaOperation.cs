using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja.Workers.Template
{
    public interface IAreaOperation
    {
        int A {  get; set; }

        int B { get; set; }

        int Execute();
        
    }
}
