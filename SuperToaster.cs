using System.Diagnostics.CodeAnalysis;

namespace Toaster
{
  public class SuperToaster : Toaster
  {
    #region Constructors

    /// <inheritdoc />
    public SuperToaster(String? farbe, Int32 schaechte) : base(farbe, schaechte)
    {
      Farbe = farbe;
      Schaechte = schaechte;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Farbe des Toasters.
    /// </summary>
    public new String? Farbe { get; set; }

    /// <summary>
    /// Anzahl der Schächte.
    /// </summary>
    public new Int32 Schaechte { get; set; }

    /// <summary>
    /// Die Temperatur des Toasters.
    /// </summary>
    public Int32 Temperatur => Zeit * 3;

    /// <summary>
    /// Der Temperatursensor.
    /// </summary>
    public Int32 Temperatursensor { get; set; }

    /// <summary>
    /// Die Anzahl der Toasts im Toaster.
    /// </summary>
    public new Int32 Toastanzahl { get; set; }

    /// <summary>
    /// Der Zustand des Toasts.
    /// </summary>
    public new String ToastZustand { get; set; }

    /// <summary>
    /// Der Zustand des Toasts.
    /// </summary>
    public new Int32 Zeit { get; set; }

    #endregion

    #region Public Methods

    /// <summary>
    /// Funktion zum auswerfen des Toastes, dazu wird dabei dem Benutzer der Zustand seines Toasters gegeben.
    /// </summary>
    /// <returns></returns>
    public new String Toastauswerfen()
    {
      Console.WriteLine("\"Du siehst das Toast rauskommen\" und es ist " + ToastZustand);
      return ToastZustand;
    }

    /// <summary>
    /// Funktion die den Prozess des Toastens beschreibt. Erhalten tut man nach diesem Prozess den Zustand des Toasts. Sollte
    /// der Toaster zu lange laufen und die Temperatur zu hoch werden wird der Vorgang abgebrochen.
    /// </summary>
    /// <returns></returns>
    public new String? Toasten()
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


      Temperatursensor = Temperatur;

      if (Temperatursensor > 500)
      {
        Console.WriteLine("WARNUNG!!!! Der Supertoaster ist zu heiß. Zur Sicherheit wird der Vorgang abgebrochen!!");
        return null;
      }

      Console.WriteLine("Dein Toast ist fertig getoastet");

      return ToastZustand;
    }

    /// <summary>
    /// Funktion mit der sich die Zeit einstellen lässt wie lange der Toastvorgang gehen soll.
    /// </summary>
    /// <param name="zeit"></param>
    /// <returns></returns>
    public new Int32 ToasterZeitEinstellen(Int32 zeit)
    {
      Zeit = zeit;
      Console.WriteLine("Alles klar der Vorgang wird nun " + Zeit + " Sekunden gehen");
      return Zeit;
    }

    /// <summary>
    /// Funktion um eine gewollte Anzahl an Toasts in den Toaster zutun. Sollte die Anzahl der Toasts jedoch die Anzahl an
    /// Schächten überschreiten funktioniert dies nicht und eine entsprechende Meldung wird ausgegeben.
    /// </summary>
    /// <param name="toastanzahl"></param>
    /// <returns></returns>
    public new Boolean ToastReintun(Int32 toastanzahl)
    {
      if (toastanzahl > Schaechte)
      {
        Console.WriteLine("Sorry so viele Toasts passen leider nicht in den Toaster");
        return false;
      }

      Toastanzahl = toastanzahl;
      Console.WriteLine("Du hast nun " + Toastanzahl + "Toast im Toaster.");
      return true;
    }

    #endregion
  }
}