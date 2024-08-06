//# Concatenation Method
/* using System;
namespace FormIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your HName: ");
            string hname = Console.ReadLine();

            Console.WriteLine("Enter Your LName: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter Your Age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Enter Your Height: ");
            string height = Console.ReadLine();

            Console.WriteLine("Enter Your Weight: ");
            string weight = Console.ReadLine();

            Console.WriteLine("Enter Your BColor: ");
            string color = Console.ReadLine();

            Console.WriteLine("Enter Your HColor: ");
            string Hcolor = Console.ReadLine();

            Console.WriteLine("Your Name Is: "+name);// Concatenate Method
            Console.WriteLine("Your HName Is: "+hname);
            Console.WriteLine("Your LName Is: "+lname);
            Console.WriteLine("Your Age Is: "+age);
            Console.WriteLine("Your Height Is: "+height);
            Console.WriteLine("Your Weight Is: "+weight);
            Console.WriteLine("Your BColor Is: "+color);
            Console.WriteLine("Your HColor Is: "+Hcolor);

            Console.ReadLine();

        }
    }
} */


//#PlaceHolder  Method
/* 
using System;
namespace Plm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your Name {0}",name);
        }
    }
} */

//Adding Two Numbers
/* using System;
namespace Adding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num + num2;

            Console.WriteLine("Addition Of Two Numbers {0} ",sum);
            Console.ReadLine();

        }
    }
} */

/* 
using System;
namespace Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number: ");
            int num1 =  int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sub = num1-num2;
            Console.WriteLine("The Subraction Of Two Numbers Is: " +sub);
            Console.ReadLine();
        }
    }
} */

/* 
using System;
namespace Mult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number: ");
            int num1 = int.Parse(Console.ReadLine());

            int Mult = num * num1;
            Console.WriteLine("Multiplication Of Two Numbers Is {0}:" +Mult);
            Console.ReadLine();
        }
    }
} */


//#Built In DataTypes
/* using System;
namespace DataTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.ReadLine();
        }
    }
} */

/* using System;
namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MinValue);
            Console.ReadLine();
        }
    }
} */

/* using System;
namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.ReadLine();
        }
    }
} */

/* using System;
namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.ReadLine();
        }
    }
} */

/* 
using System;
namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;

            bool c = a > b;
            Console.WriteLine(c);
        }
    }
} */


//#String And Character Data Type
/* using System;
namespace SCdt
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Vishal"; //normal string Value
            string c = "\"Welcome To CSharp:\""; //forward \ used for show the text with quotetion
            string d = "Nine\nTwelve\nTwo Thousand One";  //n represent next line

            char b = 'B';

            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
} */


/* using System;
namespace DataTypesConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20.444;
            float b = a; //Implicit Data Type Conversion 
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
} */


/* using System;
namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10.445f;
            int b = (int)a; //Explicit Data Type Conversion
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
} */


//#Constant Variable In CSharp
/* using System;
namespace ConstantVar
{
    class Program
    {
        public const double PI = 3.14; //When We Create  a class under the variable then we use public,protected,private accessfier
        static void Main(string[] args)
        {
            Console.WriteLine(PI);
            Console.ReadLine();
        }
    }
} */

/* using System;
namespace ConstantVar
{
    class Program
    {
        public const string  company_name = "TCS";
        static void Main(string[] args)
        {
            Console.WriteLine(company_name);
            Console.ReadLine();
        }
    }
} */

//# Standard Date And Time Format Specifiers In C#.. A Date and time format is a special character that enables you to display the date & time value in different forms

/* using System;
namespace DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            //Console.WriteLine("Today Date And Time Is {0:d}",dt);//small d represent short date
            Console.WriteLine("Today Date And Time Is {0:D}",dt);//capital d represent long date
            Console.ReadLine();
        }
    }
} */



/* using System;
namespace DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0:f}",dt);// small f represent full date (short time)
            Console.WriteLine("{0:F}",dt);//Capital F represent Full Date full Time
            Console.WriteLine("{0:g}",dt);// small g represent general date time short
            Console.WriteLine("{0:G}",dt);//general date long time
            Console.WriteLine("{0:m}",dt);//M represent Mnth Of the Year
            Console.WriteLine("{0:M}",dt);
            Console.WriteLine("{0:t}",dt);//small t represent short time without showing seconds
            Console.WriteLine("{0:T}",dt);// it represent full Time 
            Console.WriteLine("{0:y}",dt);//it represent month and the year
            Console.WriteLine("{0:yyy}",dt);//it represnt only only year like 2024
            Console.WriteLine("{0:yy}",dt);//it represent only the late number of the year like 24
            
            Console.WriteLine("{0:ddd}",dt);//represent the abbrevated name of the day of the week
            Console.WriteLine("{0:dddd}",dt);// represent the full name of the day of the week
            Console.WriteLine("{0:FF}",dt);//represent the two digits of the second fraction
            Console.WriteLine("{0:HH}",dt);//represent the hour from 00 to 23 and it also show time in 24 hour and small hh show time in 12 hour
            Console.WriteLine("{0:MM}",dt);//represent the month as a number from 01 to 12
            Console.WriteLine("{0:MMM}",dt);// represent the the abbrevated name of the month
            Console.WriteLine("{0:ss}",dt);// represent the second as a number from 0 to 59
            Console.WriteLine("{0:dd:mm:hh tt}",dt);
            Console.WriteLine("{0:hh:mm:ss tt}",dt);
            Console.WriteLine("{0:dd-MM-yyyy}",dt);
            Console.ReadLine();
        }
    }
} */


//#Statements Expression And Operations In C#

//Arithmetic Operators
/* using System;
namespace StmtExpression
{
    class Program
    {
        static void Main(string[] args)
        {
             int a = 10, b = 20,c,d,e,f,g;

             c = a + b;
             Console.WriteLine("The Sum Of Two Numbers Is {0} ",c);

             d = a - b;
             Console.WriteLine("The Subraction Of Two Numbers Is {0} ",d);

             e = a * b;
             Console.WriteLine("The Multiplication Of Two Numbers Is {0} ",e);

             f = a / b;
             Console.WriteLine("The Division Of Two Numbers Is {0} ",f);

             g = a % b;
             Console.WriteLine("The Mod Of Two Numbers Is {0} ",g);
             Console.ReadLine();
             
        }
    }
} */


//#Relational Operator Ro Make a comparison btn two operands and return a bol value True Or False
/* using System;
namespace EqualsToOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            
            bool c = a==b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
} */

/* 
using System;
namespace NotEqualsTo
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 20;
           int b =  20;
           bool c =  a!=b;

           Console.WriteLine(c);
           Console.ReadLine();
        }
    }
}
 */

/* using System;
namespace  Less
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 45;

            bool c = a < b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
} */

/* using System;
namespace Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = 44;
            bool c = a > b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
} */

/* using System;
namespace GreaterThan
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            bool c = a>=b;
            Console.WriteLine(c);
            Console.ReadLine(); 
        }
    }
} */

/* using System;
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            bool c = a==b;
            Console.WriteLine(c);

            bool d = a!=b;
            Console.WriteLine(d);

            bool e = a < b;
            Console.WriteLine(e);

            bool f = a > b;
            Console.WriteLine(f);

            bool g = a>=b;
            Console.WriteLine(g);

            bool h = a<=b;
            Console.WriteLine(h);
            Console.ReadLine();

        }
    }
}
 */

//#Logical Or Conditional Operator In C#
/* using System;
namespace AndOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 26;
            bool c = (a > b) && (b < a);

            int d = 222;
            int e = 55;
            bool f = (d > e) && (e < d);
            Console.WriteLine(f);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
} */

/* using System;
namespace OrOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = 44;
            bool c = (a > b) || (a < b);

            int d = 50;
            int e = 50;
            bool f = (d > e) || (e < d);
            Console.WriteLine(c);
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
} */


//# Assignment Operators In c#
/* using System;
namespace AssOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a += 5; //it means the a = a + 5
            Console.WriteLine(a);

            int b = 20;
            b -= 2;// it means the a = a - 2
            Console.WriteLine(b);

            int c = 30;
            c*= 5;// it means the c = c * 5
            Console.WriteLine(c);

            int d = 40;
            d %= 2;// it means the d = d % 2
            Console.WriteLine(d);

            int e = 55;
            e/=2;//it means the e = e / 2
            Console.WriteLine(e);

            Console.ReadLine();
        }
    }
} */

//#Increament And Decreament Operator 
/* using System;
namespace IncreamentOpt
{
    class Program
    {
        static void Main(string[] args)
        {
             int a = 55; 
             //Console.WriteLine(a++);//Post increament
             //Console.WriteLine(a);//In this line execution  Will Done
             Console.WriteLine(++a);//Pre Increament in Preincreament no need to declare the variable name again
             Console.ReadLine();
        }
    }
}
 */

/* 
using System;
namespace DecreamentOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55;
            Console.WriteLine(--a);
            Console.ReadLine();
        }
    }
}
 */

//#Ternary Or Conditional Operator In C#// C# includes a special type of decision making operator ?: called the ternary operator
//Syntax: Boolean Expression ? First Statement:Second Statement 
/* using System;
namespace TerOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            string b = ( a > 10)?"a is greater":"a is lesser";

            int c = 54;
            string d = (a>=18)?"A Is Greater Than Or Equals To":"A Is Lesser Than Or Equals To";
            Console.WriteLine(d);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
} */

//#Precendence Of Operators In C#
/* using System;
namespace PreCenOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8 / 2 - 3 + 2 * 2; // Highest Level -- / * , + -
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
} */


//#Selection StateMents in C#
/* using System;
namespace IfElseStmt
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("enter any number");
            int a = int.Parse(Console.ReadLine());
            if (a>10)
            {
                Console.WriteLine("a is greater no");
            }
            else
            {
                Console.WriteLine("a is lesser no");
            }
        }
    }
} */ 


/* using System;
namespace IfElseStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            if (name == "Vishal")
            {
                Console.WriteLine("Welcome To C#");
            }
            else
            {
                Console.WriteLine("Welcome To JavaScript");
            }
        }
    }
}
 */

/* using System;
namespace IfElseStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string username = Console.ReadLine();

            Console.WriteLine("Enter PassWord");
            string Pass = Console.ReadLine();

            if(username == "Vishal" && Pass == "Vishal@123")
            {
                Console.WriteLine("Welcome To C#");
            }
            else
            {
                Console.WriteLine("Welcome To Java");
            }
        }
    }
} 
 */

//# If-Else-If Statement Condition
/* using System;
namespace IfElseIfCond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your percentage:");
            int percentage = int.Parse(Console.ReadLine());

            if (percentage >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade C");
            }
            else if (percentage >= 45)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
} */


//#Nested IF-Decision Making Statements
//The Nested If Construct Consists Of Multiple If Stmt
/* using System;
namespace NesTedIf
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter Any Number ");
            int a = int.Parse(Console.ReadLine());
            if (a > 9)
            {
                if(a == 10)
                {
                    Console.WriteLine("A Is 10");
                }
                else
                {
                    Console.WriteLine("A Is Not 10");
                }
            }
            else
            {
                Console.WriteLine("A Is Lesser");
            }
        }
    }
} */

/* using System;
namespace NesTedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 2, b = 33,c = 7;
            Console.WriteLine("Enter Value For a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Value For b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Value For c: ");
            int c = int.Parse(Console.ReadLine());

            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("{0} is largest",a);
                }
                else
                {
                    Console.WriteLine("{0} is largest",c);
                }
            }
            else
            {
                if(b>c)
                {
                    Console.WriteLine("{0} is largest",b);
                }
                else
                {
                    Console.WriteLine("c is largest",c);
                }
            }
        }
    }
} */

//#Switch Case In CSharp
/* using System;
namespace SwitchCse
{
    class Program
    {
        static void Main(string[] args)
        {   
            int Week_no = 2;

            switch(Week_no)
            {
                case 1:
                Console.WriteLine("Monday");
                break;

                case 2:
                Console.WriteLine("Tuesday");
                break;

                case 3:
                Console.WriteLine("Wednesday");
                break;

                case 4:
                Console.WriteLine("Thursday");
                break;

                case 5:
                Console.WriteLine("Friday");
                break;

                case 6:
                Console.WriteLine("Saturday");
                break;

                case 7:
                Console.WriteLine("Sunday");
                break;

                default:
                Console.WriteLine("Invalid Week No");
                break;
            }
        }
    }
}
 */


/* using System;
namespace MonYrstmt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start:
            Console.WriteLine("Enter any year no");
            int Calendar = int.Parse(Console.ReadLine());

            switch(Calendar)
            {
                case 1:
                Console.WriteLine("Jan");
                break;

                case 2:
                Console.WriteLine("Feb");
                break;

                case 3:
                Console.WriteLine("Mar");
                break;

                case 4:
                Console.WriteLine("Arp");
                break;

                case 5:
                Console.WriteLine("May");
                break;

                case 6:
                Console.WriteLine("Jun");
                break;

                case 7:
                Console.WriteLine("Jul");
                break;

                case 8:
                Console.WriteLine("Aug");
                break;

                case 9:
                Console.WriteLine("Sep");
                break;

                case 10:
                Console.WriteLine("Oct");
                break;

                case 11:
                Console.WriteLine("Nov");
                break;

                case 12:
                Console.WriteLine("Dec");
                break;

                default:
                Console.WriteLine("invalid Month");
                break;
            }
            Console.WriteLine("\n\n");
            //goto Start;
        }
    }
}
 */

//#Nested Switch Case In CSharp
/* using System;
namespace NestedCse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();
            switch(name)
            {
                case "Ajay":
                Console.WriteLine("Ajay Is A HardWork Student");
                break;

                case "Pooja":
                Console.WriteLine("Pooja Is A Kind Heart Student");
                break;

                case "Vishal":
                Console.WriteLine("Vishal Is A Smart Student");
                break;

                case "Shivanya":
                Console.WriteLine("Shivanya Is A Cute Student");
                break;

                default:
                Console.WriteLine("Student Name Not Exist");
                break;
            }
            Console.WriteLine("\n");
        }
    }
}
 */

//# Creating MArkSheet Application Using C#
using System;
namespace MrkSht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Rollno: ");
            string rollno = Console.ReadLine();

            Console.WriteLine("Enter Your Class: ");
            string standard = Console.ReadLine();

            Console.WriteLine("Enter English Mark: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Sanskrit Mark: ");
            int Sa = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Urdu Mark: ");
            int u = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Math Mark: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Science Mark: ");
            int s = int.Parse(Console.ReadLine());

            int obt = e + Sa + u + m + s;
            int per = obt * 100 / 500;

            Console.WriteLine("Your Name Is {0}",name);
            Console.WriteLine("Your Rollno Is {0}",rollno);
            Console.WriteLine("Your Standard Is {0}",standard);
            Console.WriteLine("Your Obtained Mark Is {0} ",obt);
            Console.WriteLine("Your Percentage Is {0} ",per);

            if (per >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade C");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Grade D");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Grade F");
            }
            else
            {
                Console.WriteLine("Fail");
                Console.ReadLine();
            }

            if (per >= 80)
            {
                Console.WriteLine("Excellent");
            }
            else if (per >= 70)
            {
                Console.WriteLine("VeryGood");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Good");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Average");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Fair");
            }
            else
            {
                Console.WriteLine("Call Your Parents");
                Console.ReadLine();
            }

        }
    }
}

