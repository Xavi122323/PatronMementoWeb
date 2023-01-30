using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
public partial class _Default : System.Web.UI.Page
{
   public static Invoker invoke = new Invoker();
   public  static Caretaker caretaker = new Caretaker();
  public static  Originator originator;
    
    string Displaytext;
    static bool counter = false;
    static bool snimaj;
    static int brojac;
    static bool lenta_visible = true;
    static bool old_result;
    static bool znak;
    double operand1;
    double operand2;
    double rezultat;
    char operacija;
    public double rez;
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Number_Btn_Click(Object sender, EventArgs e)
    {
        if (old_result == true)
        {
            txtDisplej.Text = "";
            old_result = false;
            DodadiVoLenta("Entering...");
        }
            if (counter == true) { counter = false; txtDisplej.Text = ""; }
            Button clickedButton = (Button)sender;
            txtDisplej.Text += clickedButton.Text;
           
        
       
    }
    public void Znak_BtnClick(Object sender, EventArgs e)
    {
        if (old_result == true) { old_result = false; }
        

            Button clickedButton = (Button)sender;
            char s = Convert.ToChar(clickedButton.Text.Trim());

            txtDisplej.Text += " " + s.ToString() + " ";
            counter = false;
            znak = true;
        
        
    }
    public void Ednakvo_Btn_Click(Object sender, EventArgs e)
    {
        if (txtDisplej.Text != "")
        {
            string[] clenovi = (txtDisplej.Text.Trim()).Split(' ');
            if (clenovi.Length == 1) { txtDisplej.Text = txtDisplej.Text; }
            else if (clenovi.Length==2||(clenovi.Length>3)){ txtDisplej.Text = "ERROR"; }
            else
            {
                try
                {
                    operand1 = Convert.ToDouble(clenovi[0]);
                    operacija = Convert.ToChar(clenovi[1]);
                    operand2 = Convert.ToDouble(clenovi[2]);
                }
                catch (Exception a)
                {

                    txtDisplej.Text = "ERROR" + a.ToString().Trim();
                }


                double rezultat = invoke.compute(operand1, operand2, operacija);
                DodadiVoLenta(operand1.ToString() + " " + operacija.ToString() + " " + operand2.ToString());
                if ((snimaj == true) && (brojac <= 10))
                {
                    invoke.addCommand(operand1, operand2, operacija);
                    brojac++;
                    lblsnimka.Text = "R";
                }
                else if (brojac > 10 || (brojac == null)) { snimaj = false; lblsnimka.Text = ""; }



                if ((operacija == '/') && (rezultat == -5)) { txtDisplej.Text = "Delenje so 0"; DodadiVoLenta("Rezultat= " + txtDisplej.Text); }
                else if (rezultat == -0.0001)
                {

                    if (operacija == '\0') { txtDisplej.Text = operand1.ToString(); }
                    else
                    {
                        txtDisplej.Text = "ERROR";
                        DodadiVoLenta("Rezultat= " + txtDisplej.Text);
                    }
                }
                else
                {
                    txtDisplej.Text = rezultat.ToString();
                    DodadiVoLenta("Rezultat= " + txtDisplej.Text);
                }
            }
            counter = true;
            old_result = true;
            znak = false;
        }
    }

    public void Clear_Displej(Object sender, EventArgs e)

    {
        txtDisplej.Text = "";
        DodadiVoLenta("Display cleared...");
    }

    public void Undo(Object sender, EventArgs e)
    {
        txtDisplej.Text=Convert.ToString(invoke.undo());
        DodadiVoLenta("Undo operacija...");
        DodadiVoLenta("Rezultat= "+txtDisplej.Text);

    
    }

    public void Redo(Object sender, EventArgs e)
    {
        txtDisplej.Text = Convert.ToString(invoke.redo());
        DodadiVoLenta("Redo operacija...");
        DodadiVoLenta("Rezultat= " + txtDisplej.Text);
    }

    public void MemoryOpButtons(Object sender, EventArgs e)
    {
        
        Button clickedButton = (Button)sender;
        if (clickedButton.Text.ToString() == "MS")
        {

             DodadiVoLenta("Set in Memory ");
            DodadiVoLenta(txtDisplej.Text.Trim().ToString());
            try { rez = Convert.ToDouble(txtDisplej.Text.Trim().ToString());
            originator = new Originator(rez);
            caretaker.saveState(originator);
            txtDisplej.Text = "";
            lblMemory.Text = "M";
            
            }
            catch (Exception ex) { DodadiVoLenta("Input Format Error..."); }

           
        }else
            if (clickedButton.Text.ToString() == "MC")
            { 
            //stava 0 vo memorijata
                double nula=0;
                originator=new Originator(nula);
                caretaker.saveState(originator);
                lblMemory.Text = "";
                txtDisplej.Text = "0";
                old_result = true;
                DodadiVoLenta(" Memory cleared,  Memory= " +nula.ToString());
            }
            else if (clickedButton.Text.ToString() == "MR")
            {
                if (originator != null)
                {
                   string t = Convert.ToString(caretaker.restoreState(originator));
                   if (znak)
                   { txtDisplej.Text += t; }
                   else { txtDisplej.Text = t; }
                    lblMemory.Text = "M";
                    old_result = true;
                    DodadiVoLenta(" Memory Recall, vaulue= " + t);
                }
            }
            else if (clickedButton.Text.ToString() == "M+")
            {                                                  
                if (originator != null)
                {
                    caretaker.restoreState(originator);
                   
                    try { rez=Convert.ToDouble(txtDisplej.Text.Trim().ToString());
                    originator.DodadiVrednostVoRegistarot(rez);
                    caretaker.saveState(originator);
                    caretaker.restoreState(originator);
                    txtDisplej.Text = Convert.ToString(originator.VrednostVoRegisterot());
                    old_result = true;
                    lblMemory.Text = "M";
                    DodadiVoLenta("Added to Memory , Memory= " + txtDisplej.Text);
                    }
                    catch (Exception ex) {DodadiVoLenta("Input Format Error..."); }
                    
                }
           
            }
        else if (clickedButton.Text.ToString() == "M-")
        {
            if (originator != null)
            {
                caretaker.restoreState(originator);

                originator.OdzemiVrednostOdRegistarot(Convert.ToDouble(txtDisplej.Text.Trim().ToString()));
                caretaker.saveState(originator);
                caretaker.restoreState(originator);
                txtDisplej.Text = Convert.ToString(originator.VrednostVoRegisterot());
                old_result = true;
                lblMemory.Text = "M";
                DodadiVoLenta("Substracted from Memory , Memory= " + txtDisplej.Text);
            }

        }




    }

    public void SnimajPrograma(Object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;
        if (snimaj == false||(snimaj==null))
        { snimaj = true;
        lblsnimka.Text = "R";
        brojac = 0;
        clickedButton.BorderColor = Color.Orange;
        DodadiVoLenta("Program Recording Started...");
        } else if (snimaj = true)
        { 
            snimaj = false;
            lblsnimka.Text = "";
            clickedButton.BorderColor = Color.Black;
            DodadiVoLenta("Program Recording finished...");
        }
    
        
    }
    public void IzvrsiPrograma(Object sender, EventArgs e)
    {
        if (snimaj == true) {

            snimaj = false;
            DodadiVoLenta("Program Recording finished...");
        }
        DodadiVoLenta("Executing program...");
       double rezultatKraj= invoke.izvrsiPrograma();
      
        if ((old_result == false) && (znak==true))
       {
           txtDisplej.Text += rezultatKraj.ToString();
           

       }
       else {
           txtDisplej.Text = rezultatKraj.ToString();
           DodadiVoLenta("Recorded Program  Result= " + txtDisplej.Text);
       }
               

    }

    public void  LentaONOFF(Object sender, EventArgs e)
    {
        if (lenta_visible == true)
        {
            lenta_visible = false;
            listboxLenta.Visible = false;
                
        
        }
        else if (lenta_visible == false)
        {

            lenta_visible = true;
            listboxLenta.Visible = true;
        
        }


    }
    public void DodadiVoLenta(string tekst)
    {     if (lenta_visible == true )
        {listboxLenta.Items.Add(tekst);
        listboxLenta.SelectedIndex = listboxLenta.Items.Count - 1;
        }
       
    }


   
}