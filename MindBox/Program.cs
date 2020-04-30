using System;
using Area;
using Area.Handler;

namespace MindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите стороны фигуры через запятую: ");
            string input = Console.ReadLine();


                InputHandler inputHandler = new InputHandler();
                var digitList = inputHandler.TransformInput(input);

                ShapeCreator shapeCreator = new ShapeCreator();
                var shapeForm = shapeCreator.GetShape(digitList);

                ShapeChooser shapeChooser = new ShapeChooser();
                var area = shapeChooser.GetShape(shapeForm);

                Console.WriteLine("Площадь фигуры = " + area);
                Console.ReadLine();
        }
    }
}
