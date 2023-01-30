using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
public class Invoker
{
	 
    private Calculator calculator = new Calculator();    
    private  static ArrayList commands = new ArrayList();    
    private  ArrayList commandsInProgram = new ArrayList();   
    public static int MAX_COUNT = 10;
    private static int brVoLista = 0;

    public double redo()
    {
        double temp=0;
            if (brVoLista < commands.Count) {
                Command command = commands[brVoLista++] as Command;
                temp = command.execute();
            }
        return temp;
    }

    public double undo() {
        double temp=0;
            if (brVoLista > 0) {        
                
                                             
               Command command = commands[--brVoLista] as Command;               
                temp = command.unExecute();
            }
        return temp;
    }

    public double compute(double operand1, double operand2,char znak_operator) {
        Command command = new CalculatorCommand(calculator, operand1,operand2,znak_operator);
        double temp = command.execute();
        commands.Add((Command)command);
        ++brVoLista;
        return temp;
    }
    
    public void addCommand(double operand1, double operand2,char znak_operator) {
        if(commandsInProgram.Count<=MAX_COUNT) {
            Command command = new CalculatorCommand(calculator, operand1,operand2,znak_operator);
            commandsInProgram.Add(command);

        }
               
    }
   
    public double izvrsiPrograma(){
        double temp =0;
        for(int i=0;i<commandsInProgram.Count;i++){
            Command command = (Command)commandsInProgram[i];
            temp = command.execute();
        }
        return temp;
        
    }
}