using System;
using System.Collections.Generic;
using System.Linq;

namespace Rekrutacja.Workers.Template
{
    public class AreaOperationHandler
    {
        private static readonly Dictionary<Shape,IAreaOperation> operations = new Dictionary<Shape, IAreaOperation>()
        {
            { Shape.Circle, new AreaOperationCircle() },
            { Shape.Square, new AreaOperationSquare() },
            { Shape.Rectangle, new AreaOperationRectangle() },
            { Shape.Triangle, new AreaOperationTriangle() }
        };

        public static IAreaOperation GetAreaOperation(Shape shape)
        {
            return operations[shape];
        }
    }
}
