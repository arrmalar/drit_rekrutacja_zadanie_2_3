using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja.Workers.Template
{
    public class AreaOperationSquare : IAreaOperation
    {
        public int A { get; set; }

        public int B { get; set; }

        public int Execute()
        {
            if (A <= 0 || B <= 0 || A != B)
            {
                throw new ArgumentException("Boki kwadratu nie mogą być mniejsze lub równe zero i muszą być takiej samej długości!");
            }

            return A * B;
        }

    }
}
