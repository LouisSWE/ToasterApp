using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toaster
{
    public class Toaster
    {
      public Toaster(String? farbe, Int32 schaechte)
      {
        Farbe=farbe;
        Schaechte=schaechte;

      }

    /// <summary>
    /// Farbe des Toasters.
    /// </summary>
    public String? Farbe { get; set; }

    /// <summary>
    /// Anzahl der Schächte.
    /// </summary>
    public Int32 Schaechte { get; set; }

    /// <summary>
    /// Die Anzahl der Toasts im Toaster.
    /// </summary>
    public Int32 Toastanzahl { get; set; }

    /// <summary>
    /// Der Zustand des Toasts.
    /// </summary>
    public Int32 Zeit { get; set; }

    /// <summary>
    /// Der Zustand des Toasts.
    /// </summary>
    public String ToastZustand { get; set; }

    public Boolean ToastReintun(Int32 toastanzahl)
    {
      if (toastanzahl > Schaechte)
      {
        Console.WriteLine("Sorry so viele Toasts passen leider nicht in den Toaster");
        return false;
      }
      else
      {
        Toastanzahl = toastanzahl;
        Console.WriteLine("Du hast nun " + Toastanzahl + "Toast im Toaster.");
      }
      return true;
    }
    public String Toasten()
    {
      if (Zeit == 0)
      {
        Console.WriteLine("Keine Zeit ausgewählt, Toastvorgang kann nicht gestartet werden!");
        ToastZustand = "Ungetoastet";
      }

      if (Zeit > 1 && Zeit < 70)
      {
        Thread.Sleep(2000);
        ToastZustand = "Leicht getoastet";
      }

      if (Zeit > 70)
      {
        Thread.Sleep(2000);
        ToastZustand = "Verbrannt";
      }


      Console.WriteLine("Dein Toast ist fertig getoastet");

      return ToastZustand;
    }

    public Int32 ToasterZeitEinstellen(Int32 zeit)
    {
      Zeit = zeit;
      Console.WriteLine("Alles klar der Vorgang wird nun " + Zeit + " Sekunden gehen");
      return Zeit;
    }
    public String Toastauswerfen()
    {
      Console.WriteLine("\"Du siehst das Toast rauskommen\" und es ist " + ToastZustand);
      return ToastZustand;
    }

    }
}
