using System;

namespace EnumerationProject {
    enum GradStatus { SummaCumLaude, MagnaCumLaude, CumLaude }; // defines a type.  The semi-colon unnecessary?




    class Program {
        static void Main(string[] args) {

            /*
            GradStatus gs = GradStatus.SummaCumLaude; //the name of the value, a dot, then the ?value?
            // gs = 1; //un-comment this, hover:  Error message
            // gs = "SummaCumLaude"  hover.  Same thing, for different reasons.  Thisis is a string.  The enum DEFINES a type.  It ?isn't a string?
            // we are ONLY allowed to assign a few things to it.  Restrction  jR  Restriction.
            // enums are USUALLY integer values, behind the scenes

            var i = (int)gs;
            */
            
            // going to take the variabel gs....   This is something called CASTING.  turn one type into another
                             // we will need to do this occasionally.  Not often
                             //one way is to put type th   to change TO in parenths, that's called casting.   (What's another way?)
                             //
                             /* versus:  int i = 123;
                             int j = 7;
                             int k = i/j;
                             int divided by an int == an int
                             So, instead:
                             var k =  (double)i/j;  // as long as one of i or j is a doulbe, this evalsuates to doubele  //treat i and k as doubles, not integers
                             //int can always be cast to a doulbe.  NOT vice versa though.  Truncation happens
                             casting ==  type you want in parenths before the variabel



                              */

            GradStatus gs = GradStatus.SummaCumLaude; //the name of the value, a dot, then the ?value?
            // gs = 1; //un-comment this, hover:  Error message
            // gs = "SummaCumLaude"  hover.  Same thing, for different reasons.  Thisis is a string.  The enum DEFINES a type.  It ?isn't a string?
            // we are ONLY allowed to assign a few things to it.  Restrction  jR  Restriction.
            // enums are USUALLY integer values, behind the scenes

            var i = (int)gs; // going to take the variabel gs....   This is something called CASTING.  turn one type into another


            //fsdfdjjsakljfklsjklfljkl
            if(gs == GradStatus.MagnaCumLaude) {

            }
            // Enums do two things:
            // 1. enums limit values what values the fjsdfsdjfl  can have. 
            // 2. the names of the enumeration items can be very self-descriptive .  Better the old fashioned way, with codes such as 'C' for CumLaude
        }
    }
}
