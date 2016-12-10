using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Flyweight
{
    class FlyweightExample
    {
        //задаем возможные цвета
        private String[] colors = { "Red", "Green", "Blue", "White", "Black" };
        Random rand;
        String result;

        public String start()
        {
            rand = new Random();
            //генерируем 20 кругов
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.setX(getRandomX());
                circle.setY(getRandomY());
                circle.draw();
                result += circle.getState() + circle.getInfo();  //формируем итоговую строку с информацией о всех кругах для вывода на форму
            }
            return result;
        }

        private String getRandomColor()   //случайный цвет
        {
            return colors[(int)(rand.Next(colors.Length))];
        }
        private int getRandomX()   //случайная координата Х
        {
            return (int)(rand.Next(100));
        }
        private int getRandomY()    //случайная координата Y
        {
            return (int)(rand.Next(100));
        }

    }
}
        


