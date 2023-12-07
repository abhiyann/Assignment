using Assignment;

class Program
{
    //Exercise 1:
     static void Main(string[] args)
    {
     Car myCar = new Car("Toyota", 2022, 25000.50f);

       Console.WriteLine($"Brand: {myCar.GetBrand()}");
       Console.WriteLine($"Year: {myCar.GetYear()}");
       Console.WriteLine($"Price: {myCar.GetPrice()}");
    }

    //Exercise 2:
    //static void Main(string[] args)
    // {
    //BankAccount myAccount = new BankAccount("1234567890");

    // myAccount.Deposit(1000); 
    // myAccount.Withdraw(500); 

    //  decimal finalBalance = myAccount.GetBalance();
    //  Console.WriteLine($"Final Balance: {finalBalance}");
    // }

    //Exercise 3:
    // static void Main(string[] args)
    // {
    //   Rectangle myRectangle = new Rectangle(4.5f, 3.2f);

    //  float area = myRectangle.CalculateArea();

    //   Console.WriteLine($"Area of the rectangle: {area}");
    // }

    //Exercise 4:
    //static void Main(string[] args)
    // {
    //Circle myCircle = new Circle(5);

    //   float area = myCircle.CalculateArea();

    //   Console.WriteLine($"Area of the circle: {area}");
    // }

    //Exercise 5:
    //static void Main(string[] args)
    //{
    //  Student johnDoe = new Student("John Doe", 20, "Computer Science");
    //  johnDoe.Introduce();
    //  }

    //Exercise 6:
    /* static void Main(string[] args)
     {
         Assignment.Stack<int> myStack = new Assignment.Stack<int>();

         myStack.Push(5);
         myStack.Push(10);
         myStack.Push(15);

         Console.WriteLine("Items in the stack after push operations:");
         PrintStack(myStack);

         int poppedItem = myStack.Pop();
         Console.WriteLine($"\nPopped item: {poppedItem}");
         Console.WriteLine("Items in the stack after pop operation:");
         PrintStack(myStack);

         int peekedItem = myStack.Peek();
         Console.WriteLine($"\nPeeked item: {peekedItem}");
         Console.WriteLine("Items in the stack after peek operation:");
         PrintStack(myStack);
     }

     static void PrintStack<T>(Assignment.Stack<T> stack)
     {
         if (stack.IsEmpty())
         {
             Console.WriteLine("Stack is empty");
             return;
         }

         foreach (T item in Stack)
         {
             Console.Write($"{item} ");
         }
         Console.WriteLine();
     }
    */

    //Exercise 7:
    // static void Main(string[] args)
    //{
    //  Calendar myCalendar = new Calendar();
    //myCalendar.PrintWeekdays();
    //}

    //Exercise 8:
   /* static void Main(string[] args)
    {
        Point2D pointA;
        pointA.x = 3.0f;
        pointA.y = 4.0f;

        Point2D pointB;
        pointB.x = 6.0f;
        pointB.y = 8.0f;

        float distance = DistanceCalculator.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Distance between the points: {distance}");
    }
   */
}







