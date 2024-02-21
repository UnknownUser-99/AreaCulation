using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaСalculation
{
    class Calculator
    {
        public static double CalculateArea(IShape shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape), "Фигура не может быть равной null.");
            }

            return shape.CalculateArea();
        }
    }
}
