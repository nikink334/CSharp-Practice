namespace functionalProgramming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for airthmetic operation class
            airthmeticOperation obj = new airthmeticOperation();

            obj.accept();
            obj.add();
            obj.sub();
            obj.multi();
            obj.div();

            Console.WriteLine("\n\n");


            // for simple intrest class
            simpleIntrest objSI = new simpleIntrest();

            objSI.AcceptSI();
            objSI.Calculate();

            Console.WriteLine("\n\n");


            // for area and perimeter of rectangle

            rectangle objRect = new rectangle();

            objRect.acceptRect();
            objRect.areaRect();
            objRect.perimeterReact();

        }
    }
}