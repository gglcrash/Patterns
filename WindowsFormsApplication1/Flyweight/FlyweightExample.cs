using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Flyweight
{
    class FlyweightExample
    {
        private String[] colors = { "Red", "Green", "Blue", "White", "Black" };
        Random rand;
        String result;

        public String start()
        {
            
            rand = new Random();
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.setX(getRandomX());
                circle.setY(getRandomY());
                circle.draw();
                result += circle.getState() + circle.getInfo();
            }
            return result;
        }

        private String getRandomColor()
        {
            return colors[(int)(rand.Next(colors.Length))];
        }
        private int getRandomX()
        {
            return (int)(rand.Next(100));
        }
        private int getRandomY()
        {
            return (int)(rand.Next(100));
        }

    }
}
        


