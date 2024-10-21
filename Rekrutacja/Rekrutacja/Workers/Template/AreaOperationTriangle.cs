using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja.Workers.Template
{
    public class AreaOperationTriangle : IAreaOperation
    {
        public int A { get; set; }

        public int B { get; set; }

        public int Execute()
        {
            if (A <= 0)
            {
                throw new ArgumentException("Podstawa trójkąta nie może być mniejsza lub równa zero!");
            }

            if (B <= 0)
            {
                throw new ArgumentException("Wysokość trójkąta nie może być mniejsza lub równa zero!");
            }

            return (int)(0.5 * A * B);
        }

    }
}
