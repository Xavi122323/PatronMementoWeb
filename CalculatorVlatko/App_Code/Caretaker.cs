using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Caretaker
{
    Object objMemento;
    public void saveState(Originator originator)
    {
        objMemento = originator.save();
    }
    public double restoreState(Originator originator)
    {
        originator.restore(objMemento);
        return originator.VrednostVoRegisterot();
    }

}