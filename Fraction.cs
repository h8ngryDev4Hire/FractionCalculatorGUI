using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculatorGUI
{
    internal class Fraction : IComparable
    {

        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        
        private int num = 0;
        private int den = 1;

        public void Set(int n, int d)
        {
            this.num = n;
            this.den = d;
        }



         override public string ToString()
         {
             return num.ToString() + "/" + den.ToString();
         }




         public static Fraction Parse(string str)
         {
            Fraction newFrac = new Fraction(0, 1);

            int indexSlash = str.IndexOf("/");


                if (indexSlash == -1)
                    throw new ArgumentException("No '/' character in input");
                newFrac.num = int.Parse(str.Substring(0, indexSlash));
                newFrac.den = int.Parse(str.Substring(indexSlash + 1));



            return newFrac;

         }



             public static Fraction operator +(Fraction leftFrac, Fraction rightFrac)
         {
             Fraction sum = new Fraction(0, 1);
             
             sum.num = (leftFrac.num * rightFrac.den) + (rightFrac.num * leftFrac.den);
             sum.den = leftFrac.den * rightFrac.den;

             return sum;
         }

            public static Fraction operator -(Fraction leftFrac, Fraction rightFrac)
            {
                Fraction difference  = new Fraction(0, 1);

                difference.num = (leftFrac.num * rightFrac.den) - (rightFrac.num * leftFrac.den);
                difference.den = (leftFrac.den * rightFrac.den);

                return difference;
            }

            public static Fraction operator *(Fraction leftFrac, Fraction rightFrac)
            {
                Fraction product = new Fraction(0, 1);

                product.num = (leftFrac.num * rightFrac.num);
                product.den = (leftFrac.den * rightFrac.den);

                return product;
            }

            public static Fraction operator /(Fraction leftFrac, Fraction rightFrac)
            {
                Fraction quotient = new Fraction(0, 1);

                quotient.num = (leftFrac.num * rightFrac.den);
                quotient.den = (leftFrac.den * rightFrac.num);

                return quotient;
            }

            public static bool operator ==(Fraction leftFrac, Fraction rightFrac)
            {
                return (leftFrac.num == rightFrac.num) && (leftFrac.den == rightFrac.den);
            }


            public static bool operator!=(Fraction leftFrac, Fraction rightFrac)
            {
                return (leftFrac.num != rightFrac.num) && (leftFrac.den != rightFrac.den);
            }

            public static double denominatorCheck(Fraction subjectFraction)
            {
                return subjectFraction.den;
            }

            public int CompareTo(object fracNum)
            {
                Fraction fractionNumerator = (Fraction)fracNum;

                double f1 = (double) (this.num) / (double) (this.den);
                double f2 = (double) (fractionNumerator.num) / (double) (fractionNumerator.den);

                int retVal = 0;
                if (f1 < f2)
                    retVal = -1;
                else if (f1 == f2)
                    retVal = 0;
                else 
                    retVal = 1;
                    
                return retVal;
            }

            public static bool operator >(Fraction leftFrac, Fraction rightFrac)
            {
                if ((leftFrac.num / leftFrac.den) > (rightFrac.num / rightFrac.den))
                    return true;

                else
                    return false;
            }

            public static bool operator <(Fraction leftFrac, Fraction rightFrac)
            {
                if ((leftFrac.num / leftFrac.den) < (rightFrac.num / rightFrac.den))
                    return true;
                
                else
                    return false;
            }




    }





}