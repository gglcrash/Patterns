using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Flyweight
{
    //интерфейс "фигура", от него можем реализовывать не только круги, но и всякие квадраты, треугольники итд
    public interface Shape
    {
        void draw();
    }
}
