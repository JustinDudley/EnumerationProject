using System;

namespace EnumerationProject {
    enum GradStatus { SummaCumLaude, MagnaCumLaude, CumLaude }  // defines a type called GradStatus.   (just like a class defines a type)   -And GradStatus is an enum.
                                                                // This type has a range of only 3 values, each of which has an underlying int value
                                                                // A string type has gazillions of values.  An int type has ~2 billion.  A bool has 2.  GradStatus has 3.
                                                                // It's like an extension of bool.  Bool for 3,4,5,...
    class Program {
        static void Main(string[] args) {
           
            GradStatus gs1 = GradStatus.MagnaCumLaude; // MUST ALWAYS ASSIGN VALUE IN THIS QUIRKY WAY, I THINK:  type.value            
            GradStatus gsZero = GradStatus.SummaCumLaude;

            // gs1 = 1; //un-comment this, hover:  Error message
            // gs1 = "SummaCumLaude"  hover.  Same thing, for different reasons.  This is a string. 
            // we are ONLY allowed to assign a few things to it. Restricted range.

            var i = (int)gs1; // this is casting 




            if(gs1 == GradStatus.MagnaCumLaude) {
                Console.WriteLine(gs1);
                Console.WriteLine(gs1.ToString());  // Console.WriteLine implicitly calls the ToString() method. Here it is, but explicit.  
                Console.WriteLine((int)gs1);        // by default, the first member of an enum has value 0, the second value 1, ...

            }
            // An enum is a set of named constants
            // An enum has a set range
            // Every enumeration type has an UNDERLYING TYPE, which can be any integral numeric type.
            // enums are USUALLY integer values, behind the scenes. Is always a value-type variable, but not all such variables are allowed.
            //    -int is the default type.  Can be other numberic types. Cannot be char
            //
            // Enums do two things:
            //    1. If your variable can only ever have certain meaningful values, such as the days of the week, or Cube Squarity, enums limit the values.  
            //    2. the names of the enumeration items can be very self-descriptive .  Better than the old fashioned way, with codes such as 'C' for CumLaude
            // Enum is mainly used to make code more readable by giving related constants a meaningful name. It also improves maintainability.
            // Enums:  Modular design.  Easier.  Fewer bugs.
           
            // Another ex.:  Days of the week. 
            // enum DaysOfWeek {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
            // enum CubeSquarity {even, odd, evenSpecial, oddSpecial}
            // enum ColorsOfFlower {purple, blue, yellow, pink, red}


            /*
              CASTING
              Casting is one way (Eexist others I think) to change variable types.
              casting syntax:  the type you want in parenths before the variable.  double myDub = (double)i;
              int can always be cast to a double.  Cast double to an int? --> truncation
              We will need to cast occasionally, not often.
              
                int i = 123;
                int j = 7;
                int k = i/j;  // int divided by an int == an int.  
                //So, instead:
                var k =  (double)i/j;  // as long as one of i or j is a double, this evaluates to double    [in this case var k = double k] 

                */

        }
    }
}

    
        