using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Flyweight
{
    class Circle : Shape
    {
        private String color;
        private int x;
        private int y;
        private String info;
        private String state;

        public Circle(String color)
        {
            this.color = color;
        }

        public void setState(String str)
        {
            this.state = str;
        }

        public String getState()
        {
            return state;
        }

        public String getInfo()
        {
            return info;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void draw()
        {
            info = "Circle: Draw() [Color : " + color + ", x : " + x + ", y :" + y + "]\n\n";
        }

    }
}
