using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class Calculator
{
       double delenje_so_0 = (double) -5;
   double greska = (double) -0.0001;

    public double tmp= 0;

    public double izvrsiOperacija(double operand1, double operand2, char znak_operator) {
        
		if(znak_operator=='+')  tmp = operand1 + operand2;
		 if(znak_operator=='-')  tmp = operand1 - operand2;
		 if(znak_operator=='*')  tmp = operand1 * operand2;
		 if(znak_operator=='/')
{ if(operand2 == 0){  tmp = delenje_so_0;}
     if(operand2!=0) { tmp = operand1 / operand2;}
		};

         if ((znak_operator != '+') && (znak_operator != '-') && (znak_operator != '*') && (znak_operator != '/'))		
{     tmp = greska;}
         
            return tmp;
    }

}



