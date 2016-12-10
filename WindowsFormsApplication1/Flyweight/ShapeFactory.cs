using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Flyweight
{
    public class ShapeFactory
    {
        private static Dictionary<String, Shape> circleMap = new Dictionary<String,Shape>();
        static Circle circle;
        public static Shape getCircle(String color)
        {
            try
            {
                circle = (Circle)circleMap[color];
                circle.setState("Circle with color '"+color+"' was created from existing one \n");
            }
            catch (KeyNotFoundException)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                circle.setState("New circle of color '" + color + "' was created! \n");
            }
            return circle;
        }
        public static void resetDictionary()
        {
            circleMap = new Dictionary<string, Shape>();
        }
    }
}
