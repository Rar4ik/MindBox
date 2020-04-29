using System;

namespace MindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите стороны фигуры через запятую: ");
            string imput = Console.ReadLine();
            //Console.WriteLine("Ваши числа: " + imput + "? /n Нажимате 'Д', если они совпадают. " +
            //                  "В противном случае нажмите любую другую клавишу" );
            //string confirm = Console.ReadLine();
            //if(confirm == "Д")
            InputHandler inputHandler = new InputHandler();
            var digitList = inputHandler.TransformInput(imput);

            ShapeCreator shapeCreator = new ShapeCreator();
            var shapeForm = shapeCreator.GetShape(digitList);

            ShapeChooser shapeChooser = new ShapeChooser();
            var area = shapeChooser.GetShape(shapeForm);

            Console.WriteLine("Площадь фигуры = " + area);
            Console.ReadLine();
        }
    }
}
