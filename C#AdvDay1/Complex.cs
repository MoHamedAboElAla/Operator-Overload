using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvDay1
{
    internal class Complex
    {
        int real;
        int img;
        public int Real
        {
            get => real; 
            set => real = value;
        }
        public int Img
        {
            get => img;
            set => img = value;
        }

        public Complex()
        {
            
        }
        public Complex(int _real, int _img)
        {
            real = _real;
            img = _img;
        }

        // Overloading the + operator
        public static Complex operator +(Complex c1,Complex c2)
        =>new Complex(c1.real + c2.real, c1.img + c2.img);

        // Overloading the - operator
        public static Complex operator -(Complex c1, Complex c2)
            => new Complex(c1.real - c2.real, c1.img - c2.img);

        // Overloading the * operator
        public static Complex operator * (Complex c1, Complex c2)
        => new Complex(c1.real * c2.real - c1.img * c2.img, c1.real * c2.img + c1.img * c2.real);

        // Overloading the / operator
        public static Complex operator /(Complex c1, Complex c2)
        {
            int denominator = c2.real * c2.real + c2.img * c2.img;
            if (denominator == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return new Complex(0,0);
            }
            return new Complex((c1.real * c2.real + c1.img * c2.img) / denominator, (c1.img * c2.real - c1.real * c2.img) / denominator);
        }
        //  Overloading the % operator
        public static Complex operator %(Complex c1, Complex c2)
        {
            int denominator = c2.real * c2.real + c2.img * c2.img;
            if (denominator == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return new Complex(0, 0);
            }
            return new Complex((c1.real * c2.real + c1.img * c2.img) % denominator, (c1.img * c2.real - c1.real * c2.img) % denominator);
        }
        // Overloading the == operator
        public static bool operator ==(Complex c1, Complex c2)
         => c1.real == c2.real && c1.img == c2.img;

        // Overloading the != operator
        public static bool operator !=(Complex c1, Complex c2)
         => !(c1 == c2);

        // Overloading the < operator
        public static bool operator <(Complex c1, Complex c2)
         => (c1.real * c1.real + c1.img * c1.img) < (c2.real * c2.real + c2.img * c2.img);
        // Overloading the > operator
        public static bool operator >(Complex c1, Complex c2)
         => (c1.real * c1.real + c1.img * c1.img) > (c2.real * c2.real + c2.img * c2.img);

        // Overloading the <= operator
        public static bool operator <=(Complex c1, Complex c2)
         => (c1.real * c1.real + c1.img * c1.img) <= (c2.real * c2.real + c2.img * c2.img);

        // Overloading the >= operator
        public static bool operator >=(Complex c1, Complex c2)
         => (c1.real * c1.real + c1.img * c1.img) >= (c2.real * c2.real + c2.img * c2.img);

        // Overloading the ++ operator
        public static Complex operator ++(Complex c)
        {
            c.real++;
            return c;
        }
        // Overloading the -- operator
        public static Complex operator --(Complex c)
        {
            c.real--;
            return c;
        }

       public static Complex operator +(Complex c , int right)
       => new Complex(c.real + right, c.img);

        public static Complex operator +(int left, Complex c)
       => new Complex(left + c.real,c.img); 





      public void Print()
        {

            if(img<0)
            Console.WriteLine($"{real} {img}i");
            else if(img>0)
                Console.WriteLine($"{real} + {img}i");
            else
                Console.WriteLine($"{real}");
        }


    }

    internal class abc : Complex
    {

        public abc(int _real, int _img) : base(_real, _img)
        {
        }
        public void Print()
        {
            Console.WriteLine("abc");
        }
    }
}
