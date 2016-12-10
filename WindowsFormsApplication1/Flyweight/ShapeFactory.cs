using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Flyweight
{
    public class ShapeFactory      //фабрика для порождения наших кругов
    {
        //словарь цвет - круг, если внутри будет круг нужного цвета - новый создаваться не будет, а из словарявозьмется имеющийся
        //если нужного нет - он создастся и добавится в словарь и потом уже снова создаваться не будет
        private static Dictionary<String, Shape> circleMap = new Dictionary<String,Shape>();  
        static Circle circle;
        public static Shape getCircle(String color)
        {
            try
            {
                circle = (Circle)circleMap[color]; //пробуем достать круг из словаря
                circle.setState("Circle with color '"+color+"' was created from existing one \n");  //если все круто - отмечаем это в "состоянии" круга
            }
            catch (KeyNotFoundException)  //если круга в словаре нет
            {
                circle = new Circle(color);  //создаем новый
                circleMap.Add(color, circle);  //кладем его в словарь
                circle.setState("New circle of color '" + color + "' was created! \n");  //пишем, что круг создан
            }
            return circle;
        }
        public static void resetDictionary()
        {
            circleMap = new Dictionary<string, Shape>();  //очищаем словарь на случай повторного запуска "симуляции"
        }
    }
}
