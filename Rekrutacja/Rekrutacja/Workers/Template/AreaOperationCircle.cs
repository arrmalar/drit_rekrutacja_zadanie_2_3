using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja.Workers.Template
{
    public class AreaOperationCircle : IAreaOperation
    {
        public int A { get; set; }

        public int B { get; set; }

        public int Execute() {
            if (A <= 0)
            {
                throw new ArgumentException("Promień nie może być mniejszy lub równy zero!");
            }

            return (int)(Math.PI * A * A);
        }
    }
}
