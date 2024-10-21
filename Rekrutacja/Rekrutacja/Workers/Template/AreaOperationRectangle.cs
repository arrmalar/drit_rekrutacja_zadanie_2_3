using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja.Workers.Template
{
    public class AreaOperationRectangle : IAreaOperation
    {
        public int A { get; set; }

        public int B { get; set; }

        public int Execute()
        {
            if (A <= 0 || B <= 0) {
                throw new ArgumentException("Boki prostokąta nie mogą być mniejsze lub równe zero!");
            }

            return A * B;
        }
    }
}
