using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers;

public class GeometryController : Controller
{
    //https://localhost:7013/geometry/Square?rectangles[0].width=20&rectangles[0].height=15&rectangles[1].width=25&rectangles[1].height=80%20//%20/Geometry/Square?Width=20&Height=40

    // /Geometry/Square?
    // rectangles[0].width=20&
    // rectangles[0].height=15&
    // rectangles[1].width=25&
    // rectangles[1].height=80

    public string Square(Rectangle[] rectangles)
    {
        string temp = "";
        foreach (Rectangle item in rectangles)
        {
            temp = temp + $"Площадь прямоугольника с основанием {item.Width} и высотой {item.Height} равна {item.CalculateSquare()} \n";
        }
        return temp;
    }

    public string Square2(Rectangle rectangle)
    {
        return $"Площадь прямоугольника с основанием " +
            $"{rectangle.Width} и высотой " +
            $"{rectangle.Height} равна " +
            $"{rectangle.CalculateSquare()}";
    }


    // /Geometry/Sum?numbers=1&numbers=2&numbers=3
    public string Sum(int[] numbers)
    {
        return "Сумма чисел равна " + numbers.Sum();
    }

}
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public double CalculateSquare() // вычисление площади треугольника
    {
        return Width * Height;
    }
    public double CalculateSquare2() // вычисление площади треугольника
    {
        return Width + Height;
    }
}