
startProgram:
    Console.WriteLine();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1-> Geometry Guru:");
    Console.WriteLine("2-> Simple Calculator");
    Console.WriteLine("0-> exit");
    string userInput=Console.ReadLine()!;
    if (userInput=="1")
    {
        geometryStart:
        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1-> Find the volume of the cylinder");
        Console.WriteLine("2-> Calculation of the surface area of a circle");
        Console.WriteLine("0-> exit");
        string userInputGeometry=Console.ReadLine()!;
        if (userInputGeometry=="1")
        {
            Console.WriteLine("V =(1/3)*Pi*h*R^2");
            Console.WriteLine("R = ");
            int radius=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("h = ");
            int height=Convert.ToInt32(Console.ReadLine());
            double volume =(1.0d/3)*Math.PI*radius*radius*height;
            Console.WriteLine($" V = {volume} m^3");
            goto geometryStart;
        }
        else if (userInputGeometry=="2")
        {
            Console.WriteLine("S = Pi*R^2");
            Console.WriteLine("R=");
            int radius=Convert.ToInt32(Console.ReadLine());
            double surface= Math.PI*radius*radius;
            Console.WriteLine($" S = {surface} m^2");
             goto geometryStart;
        }
        else if (userInputGeometry=="0")
        {
            Console.Clear();
           goto startProgram; 
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input");
            goto geometryStart;
        }
    }
    else if(userInput=="2")
    {
        simpleCalculatorStart:
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. +, -, *, / ");
            Console.WriteLine("2-> Quadratic equation");
            Console.WriteLine("0-> Back");
            string userInputCalculator=Console.ReadLine()!;
              
    if (userInputCalculator=="1")
    {
        Console.Clear();
        Console.WriteLine("Enter arthimetic expression");
        string userInputExpression = Console.ReadLine()!;
        int signIndex=0;

        int indexOfAdd = userInputExpression.IndexOf('+'); 
        if (indexOfAdd!= -1)
        {
            signIndex=indexOfAdd;
            goto countExpression;
        } 

        int indexOfMul = userInputExpression.IndexOf('*');
        if(indexOfMul!= -1)
        {
            signIndex=indexOfMul;
            goto countExpression;
        }

        int indexOfDiv = userInputExpression.IndexOf('/'); 
        if (indexOfDiv!= -1)
        {
            signIndex=indexOfDiv;
            goto countExpression;
        }

        int indexOfSub = userInputExpression.IndexOf('-'); 
        if(indexOfSub!= -1)
        {
            signIndex=indexOfSub;
            goto countExpression;
        }

        int indexOfSquare = userInputExpression.IndexOf('^'); 
        if (indexOfSquare!= -1)
        {
            signIndex=indexOfSquare;
            goto countExpression;
        }
        countExpression:
            int number1 = Convert.ToInt32(userInputExpression.Substring(0,signIndex));
            int number2 = Convert.ToInt32(userInputExpression.Substring(signIndex));
            int result = userInputExpression[signIndex] switch 
            {
                '+'=>number1+number2,
                '-'=>number1-number2,
                '*'=>number1*number2,
                '/'=>number1/number2,
                '^'=>(int)Math.Pow(number1,number2),
            };
            Console.WriteLine(userInputExpression+$"={result}");
        goto startProgram;
    }
    
    else if(userInputCalculator=="2")
    {
        Console.Clear();
        Console.WriteLine("ax^2 + bx + c = 0");
        Console.WriteLine("a=");
        int a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b=");
        int b= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("c=");
        int c= Convert.ToInt32(Console.ReadLine());
        double d = b*b-4*a*c;
        if (d<0)
        {
            Console.WriteLine("A quadratic equation has no solution  (D<0)");
        }
        if (d==0)
        {
            double x = b/(2*a);
            System.Console.WriteLine($" x= {x}"); 
        }
        else
        {
            double x1=(-b-Math.Sqrt(d))/(2*a);
            double x2=(-b+Math.Sqrt(d))/(2*a);
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        goto simpleCalculatorStart;

    }
    
    else if (userInputCalculator=="0")
    {
      Console.Clear();
      goto startProgram;  
    }
    }
    else if (userInput=="0")
    {
        Console.Clear();
        goto endProgram;  
    }
    else
    {
        Console.WriteLine("Invalid input !!!");
        goto startProgram;
    }
   
        
        
endProgram:
    Console.WriteLine("-----Program ended-----");
