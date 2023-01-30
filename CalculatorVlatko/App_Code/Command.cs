using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public abstract class Command
{
   public abstract double execute();
   public abstract double unExecute();
}