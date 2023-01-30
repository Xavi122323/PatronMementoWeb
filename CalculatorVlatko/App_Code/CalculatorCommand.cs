using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class CalculatorCommand : Command
{
    private char znak_operator;
    private double operand1;
    private double operand2;
    private double rezultat;
    private Calculator calculator;
	  public CalculatorCommand(Calculator calculator,double operand1, double operand2,char znak_operator) {
        this.calculator = calculator;
        this.operand1 = operand1;
        this.operand2 = operand2;
        this.znak_operator = znak_operator;
        
    }
public char Operator
  {
   set{ znak_operator = value; }
  }
 public int Operand1
  {
   set{ operand1 = value; }
  }
 public int Operand2
  {
   set{ operand2 = value; }
  }
  public override double execute() {
        rezultat = calculator.izvrsiOperacija(operand1,operand2,znak_operator);
        return rezultat;
    }
    public override double unExecute() {
        rezultat = calculator.izvrsiOperacija(rezultat,operand2,undo(znak_operator));
        return rezultat;
    }
private char undo(char znak_operator) {
        char undo;
        switch (znak_operator) {
            case '+':
                undo = '-';
                break;
            case '-':
                undo = '+';
                break;
            case '*':
                undo = '/';
                break;
            case '/':
                undo = '*';
                break;
            default:
                undo = ' ';
                break;
        }
        return undo;
    }
}



  
 
 
  

 



  

  

   

    