using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers;

public class GeometryController : Controller
{
    public string Square(Rectangle rectangle)
    {
        return $"Площадь прямоугольника с основанием {rectangle.Width }\n" +
            $" и высотой {rectangle.Height}\n" +
            $" равна {rectangle.CalculateSquare()}";
    }
    // остальное содержимое
}
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public double CalculateSquare() // вычисление площади треугольника
    {
        return Width * Height;
    }
}