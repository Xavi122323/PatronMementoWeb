using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Originator
{
   public class Memento
    {
        public double zacuvanaVrednost;
        public Memento(double vrednost)
        {
            zacuvanaVrednost = vrednost;
        }
    }

      double vrednostVoRegistarot;
    public  Originator(double vrednostVoRegistarot)
	{
        this.vrednostVoRegistarot = vrednostVoRegistarot;
	}
    public void DodadiVrednostVoRegistarot(double vrednost)
    {
        this.vrednostVoRegistarot += vrednost;
    }
    public void OdzemiVrednostOdRegistarot(double vrednost)
    {
        this.vrednostVoRegistarot -= vrednost;
    }

   
    public double VrednostVoRegisterot()
    {

        return vrednostVoRegistarot;
    
    }
    public Memento save()
    {

        Memento memento = new Memento(vrednostVoRegistarot);
        return memento;
    }

    public void restore(Object objMemento)
    {
        Memento memento = (Memento)objMemento;
        vrednostVoRegistarot = memento.zacuvanaVrednost;
    }



}


