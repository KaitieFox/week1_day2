using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //What data types have we talked about so far?
            //An int is a whole number (no decimals)
            //A string is a collection of characters.

            char firstInitial = 'K';
            //Characters or chars are single letters or numbers or symbols.

            bool isTired = true;
            //Boolean or bool is true or false

            //Other number data types
            float number = 2.789324893274820847289f;
            decimal partialNum = 2.789324893274820847289m;
            double someNumber = 2.789324893274820847289d;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //Now let's talk about operators!
            // ARIMETIC OPERATORS
            // + adds two operands 
            // - subtracts the second operand from the first
            // * multiplies both operands
            // / divides the first operand by second
            // % - Modulus - divides and checks remainder
            // ++ increments operand by one. used for ints 
            // -- decrements operand by one. ints
            // == checks if the values of two operands are equal.

            // RELATIONAL OPERATORS
            // if they are, returns bool true.
            // != checks if two values are unequal.
            // if they are unequal, returns bool true. 

            int jarrydAge = 29;
            int danielAge = 32;

            Console.WriteLine(jarrydAge == danielAge);
            Console.WriteLine(jarrydAge != danielAge);

            /* MOAR RELATIONAL OPERATORS
             * > Checks if the value of the left operand is greater than the value of the right operand.
             * if yes, then condition is true
             * 
             * < Checks if the vale of the left operand is less than the value of the right operand.
             * if yes, then condition is true.
             * 
             * >= checks if value of left is greater or equal to right.
             * if yes returns bool true
             * 
             * <= checks if left is less or equal to right
             * if yes return bool true
             * 
             */

            // LOGICAL OPERATORS
            /*
             * && is called AND operator. If both operands are non zero, then condition comes true.
             * if both things are things, then there's an action that we do.
             * 
             * || OR operator. If any of the two operands are non zero then condition comes true.
             * if either thing is a thing, then there's an action we do.
             * 
             * ! NOT operator. Used to reverse the logical state of an operand. 
             * If the condition is true, then logical NOT operator will make it false.
             */

        }
    }
}
