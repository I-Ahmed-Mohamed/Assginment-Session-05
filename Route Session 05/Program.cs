namespace Route_Session_05
{
    internal class Program
    {

        public static void PrintShape( string  Pramter = " Mohamed" ,int Count = 6 )
        {
            for(int i = 0; i < 10; i++) 
            Console.WriteLine(Pramter);
        }

        static void SWAP(ref int x , ref int y )
        {
            int Temp = x;
            x = y;
            y = Temp;
        }


        static int Sumarray( params int[] Arr)
        {
            int Sum = 0;

            if (Arr != null)
            {
                for (int i = 0; i < Arr.Length; i++)
                { 
                    Sum += Arr[i];
                }
                return Sum;
            }
        }



        //static Data SumMul(int x , int y , out int Sum , int Mul)
        //{
        //     Sum =  x + y;
        //     Mul = x * y;
             

        //    // invlaid

        //    //Data D = new Data();
        //    //D.Sum = Sum;
        //    //D.Mul = Mul;
        //    //return D;
        //}




        //class Data
        //{
        //    public int Sum { get; set; }
        //    public int Mul { get; set; }
        //}

        static void Main(string[] args)
        {


            #region Casting Boxing, UnBoxing
            // Boxing => casting from value type to reference type
            // UnBoxing => Casting from Reference Type to Value Type

            #region Boxing
            // object o1;
            //  o1 = "Ahmed"; // Casting
            // o1 = 1;   // Casting [Value Type -> Reference Type] Boxing
            // o1 = "a"; // Casting [Value Type -> Reference Type] Boxing

            #endregion

            #region UnBoxing
            // Boxing [Safe Casting]

            //int x = 10; 
            //object y = x;

            // Casting UnBoxing [UnSafe Casting ]
            // invalidCastExcprtion
            // new object (10) -> 10
            // Dog = (Dog) Animal ()

            //object obj01 = 10;
            //int y01 = (int) obj01; 



            #endregion


            #endregion

            #region  Value Types

            #region  Nullable  Value Types

            #region Value Type C# 2.0 2005
            #region Ex01
            // Null As a  Value is Valid only With Reference Type

            // int x = null // invalid
            // int x => x Allow only int numbers

            // int? x = null // Valid
            // int? y => Allow int Values  + null 

            //int? y = null;
            //int? x = null;

            //// int? x = y : // valid
            //int? z = x; // valid

            //Console.WriteLine(z);
            //Console.WriteLine(y);


            //int? number; // Nallable <int> Number;
            //             // Nallable -> Allow Null + Values


            //// decimal Num01 = 1.1m
            //// decimal Num02 = Num01

            //decimal? Num01;
            //decimal? Num02 = Num01; // invalid  
            #endregion

            #region EX02
            // valid implicit Casting
            // Safe Casting 

            //int x = 0;
            //int? y = x ; // (int) 

            // Explicit Casting 
            // Unsafe Casting 
            // invalid operation Exception

            //int? Num01 =  null;
            //int Num02 = (int) Num01;


            #endregion

            #region EX03
            //int? k = null;
            //int l;

            //// l = (int)k // Unsafe
            //if (k != null)
            //{
            //   l = (int) k; // Casting
            //} 
            //else
            //{
            //    l = 0;
            //}

            //if (k.HasValue)

            //{ l = k.Value;}

            //else { l = 0; }

            //l = k.HasValue ? k.Value : 0;
            //l = k != null ? (int)k : 0;




            #endregion

            #endregion



            #endregion


            #region  Nullable - Reference Types [C# 8.0 2019]

            #region EX01
            // null is default Value of Reference type  

            //string massge = "Ahmed";
            //massge = null; // Valid With Warning

            //massge = null!; // ! -> null Forgiveness Operator

            //string? massge01 = null; //valid Without Warning

            //Console.WriteLine(massge);
            //Console.WriteLine(massge01); 
            #endregion

            #region EX02

            //string notnull = " hello";
            //string?nullbale = default; // null

            ////nullbale = notnull; // valid
            //notnull = nullbale!;// vlaid


            #endregion

            #endregion

            #region  Null Propagation Operator
            #region EX01
            //int[] numbers = default; // Null
            //                         // NullReference EXceptions

            ////for(int u =0; u (numbers != null ) && (u < numbers.Length); u++) 

            //// invalid
            //for (int i = 0; i < numbers?.Length; i++)
            //    Console.WriteLine(numbers[i]);


            //// Valid
            //if (numbers != null)
            //{
            //    for (int i = 0; i < numbers?.Length; i++)
            //        Console.WriteLine(numbers[i]);
            //}


            // Numbres != null
            // i < numbers.Length


            //numbers?.Length
            // numbers = null -> (Numbers?.Length)=> Null 
            // numbers != null -> (Numbers?.Length)=> Null  
            #endregion

            #region EX02
            // Employee employee = new Employee(); 
            //// employee { id = 0, Name = Null , Department = Null}

            // employee.Debaptment = new Debaptment();
            // employee.Debaptment.Name = "it";
            // if (employee != null)
            // {
            //     if(employee.Debaptment != null)
            //     {
            //         Console.WriteLine(employee.Debaptment.Name); // Safe
            //     }
            // }

            // Console.WriteLine(employee?.Debaptment?.Name ?? "department Not Found");
            #endregion




            #endregion


            #endregion

            #region  Functions (Prototype, Calling)
            #region Function
            // PrintShape(); // Without Parameter 
            // PrintShape( 5 , "Mohamed"); // Passing Parameter With Order
            // PrintShape("Mohamed" , 5 ); // invalid
            // PrintShape( Pramter: "Mohamed" ,  Count : 5 );// Passing Parameter By Name
            // PrintShape(); // using Default 

            //  Console.WriteLine("Hello\nRoute Welcome\tTo");
            // \n => new line
            // \t => Tap


            //string path = "C:\\Users\\ELTANANY 01062856027\\AppData\\Local\\Bandicam";
            //string path = @"C:\\Users\\ELTANANY 01062856027\\AppData\\Local\\Bandicam";

            //Console.WriteLine(path);

            //PrintShape(@"/*\" , 10 );

            // Skip \ => \\ 
            // Skip \ => @ 
            #endregion

            #region  Functions - ValueType Parameters
            #region  Passing By Value


            //int a = 10, b = 20;

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //SWAP(a, b); // Passing By Value - input Parameter
            //Console.WriteLine("SWAP");
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            #endregion

            #region Passing By Reference
            //int a = 10, b = 20;

            //Console.WriteLine($"A = {a}"); //10
            //Console.WriteLine($"B = {b}"); // 20
            //SWAP(ref a, ref b); // Passing By ref [input Parameter - Out ParaMeter]
            //Console.WriteLine("SWAP");
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            #endregion

            #endregion

            #region  Functions - ReferenceType Parameters (Example 01)
            #region Passing By Value
            //int[] Numbers = null;
            //int result = Sumarray(Numbers);
            //Console.WriteLine(result); // Passing By Value 
            #endregion

            #region Passing By Reference
            //int[] Numbers = [1,2,3];
            //int result = Sumarray(ref Numbers);
            //Console.WriteLine(result);  // Passing by Reference 

            #endregion


            #endregion

            #region  Functions - ReferenceType Parameters (Example 02)
            #region Ex1
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[0]);
            //int Result =  Sumarray(numbers);  // passsing By Vlaue [input Parameter]
            //                                  // Addres of Array
            //                                  // Arr = numbers

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(Result);

            #endregion
            #region EX2
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[0]);
            //int Result = Sumarray(ref numbers);  // passsing By Reference [input And output Parameter] 
            //                                 // Addres of Array
            //                                 // Arr = numbers

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(Result);

            #endregion
            #endregion

            #region  Functions - Passing By Out
           // int A = 10, b = 20;
            //int SumResult = 0 , MulResult = 0 ;
            //SumMul(A , b  , out SumResult , out MulResult ); // Passing By out
            //SumMul(A, b, ref SumResult, ref MulResult); // Passing By ref
            // ref => Variable Must be initialized
            // Out => Output  Parameter 
            // ref => input output parameter



            Console.WriteLine( SumResult );
            Console.WriteLine(MulResult);
            #endregion

            #region Part 11 Functions - Params
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //int Result = Sumarray(1, 2, 3, 4, 5, 6);
            //Console.WriteLine(Result);

            int a = 10, b = 20, c = 30, d = 40;
            string Name = "texst";
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} " , a ,b , c , d , Name);
            #endregion






       
















            #region  Assignment 4: Functions


        
                         #region Question 1
            // Explain the difference between passing (Value type parameters) by value and by reference
            // then write a suitable C# example.

            // Passing by value means a copy of the variable is passed to the method. Changes to the parameter
            // inside the method do not affect the original variable.
            // Passing by reference means a reference to the variable is passed to the method. Changes to the parameter
            // inside the method affect the original variable.



class Example1
        {
            public static void ModifyByValue(int valueParam)
            {
                valueParam += 10;
            }

            public static void ModifyByReference(ref int refParam)
            {
                refParam += 10;
            }

            public static void Main()
            {
                int valueVar = 5;
                int refVar = 5;

                ModifyByValue(valueVar);
                Console.WriteLine("Value after passing by value: " + valueVar);

                ModifyByReference(ref refVar);
                Console.WriteLine("Value after passing by reference: " + refVar);
            }
        }
#endregion

                         #region Question 2
// Explain the difference between passing (Reference type parameters) by value and by reference
// then write a suitable C# example.

// When passing reference type by value, the reference itself is passed by value. Changes to the object's
// properties affect the original object, but reassigning the reference does not.
// When passing reference type by reference, the reference itself can also be modified.

class Example2
    {
        public static void ModifyRefByValue(string[] array)
        {
            array[0] = "Modified"; // This changes the original object
            array = new string[] { "New Array" }; // This does not change the original reference
        }

        public static void ModifyRefByReference(ref string[] array)
        {
            array[0] = "Modified";
            array = new string[] { "New Array" }; // This changes the original reference
        }

        public static void Main()
        {
            string[] refByValueArray = { "Original" };
            string[] refByRefArray = { "Original" };

            ModifyRefByValue(refByValueArray);
            Console.WriteLine("After passing reference by value: " + refByValueArray[0]);

            ModifyRefByReference(ref refByRefArray);
            Console.WriteLine("After passing reference by reference: " + refByRefArray[0]);
        }
    }
#endregion

                         #region Question 3
// Write a C# Function that accepts 4 parameters from the user and returns the result of
// summation and subtraction of two numbers.



class Example3
    {
        public static (int sum, int diff) Calculate(int a, int b, int c, int d)
        {
            return (a + b, c - d);
        }

        public static void Main()
        {
            Console.Write("Enter 4 numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            var result = Calculate(a, b, c, d);
            Console.WriteLine($"Sum: {result.sum}, Difference: {result.diff}");
        }
    }
#endregion

                         #region Question 4
// Write a program in C# to create a function to calculate the sum of the individual digits of a given number.



class Example4
    {
        public static int SumDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of the digits of the number {number} is: {SumDigits(number)}");
        }
    }
#endregion

                         #region Question 5
// Create a function named "IsPrime" to check if a number is prime.


class Example5
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is {number} prime? {IsPrime(number)}");
        }
    }
#endregion

                         #region Question 6
// Create a function named MinMaxArray to return the minimum and maximum values in an array.


class Example6
    {
        public static void MinMaxArray(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];
            foreach (int num in array)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }

        public static void Main()
        {
            int[] array = { 5, 1, 8, 3, 2 };
            MinMaxArray(array, out int min, out int max);
            Console.WriteLine($"Minimum: {min}, Maximum: {max}");
        }
    }
#endregion

                         #region Question 7
// Create an iterative (non-recursive) function to calculate the factorial of a number.


class Example7
    {
        public static int Factorial(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {number} is: {Factorial(number)}");
        }
    }
#endregion

                         #region Question 8
// Create a function named "ChangeChar" to modify a letter in a certain position (0-based) of a string.


class Example8
    {
        public static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
            {
                throw new ArgumentOutOfRangeException("Position is out of range.");
            }

            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }

        public static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter position to change: ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Enter new character: ");
            char newChar = Console.ReadKey().KeyChar;

            Console.WriteLine($"\nModified string: {ChangeChar(input, position, newChar)}");
        }
    }
        #endregion

        #endregion




















    }
}
}
