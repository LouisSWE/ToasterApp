// See https://aka.ms/new-console-template for more information

using Toaster;
using Toaster = Toaster.Toaster;
//Die in der Konsole eingegebne Farbe
String? farbe = String.Empty;

//Die in der Konsole eingegebene Anzahl an Schächten.
Int32 schaechte = 0;

Console.WriteLine("Möchtest du einen Supertoaster oder Toaster erstellen? 1 für den Toaster 2 für den Supertoaster");
var toasterAuswahl = Convert.ToInt32(Console.ReadLine());
if (toasterAuswahl == 1)
{
  //Zuorndung der gewollten Toasterfarbe
  Console.WriteLine("Bitte gib deine Toasterfarbe an: ");
  farbe = Console.ReadLine();

  //Zuordnung der gewollten Anzahl an Schächten
  Console.WriteLine("Bitte gib deine Anzahl an gewollten Schächten an: ");
  schaechte = Convert.ToInt32(Console.ReadLine());

  //Erstellung des eigenen Toaster Objektes
  var meinToaster = new global::Toaster.Toaster(farbe, schaechte);
  Console.WriteLine("Alles klar, dein Toaster sieht nun wie folgt aus: " + "Farbe:" + meinToaster.Farbe + " Schächte:" + meinToaster.Schaechte);

  Console.WriteLine("Möchstest du mit deinem Toaster toasten?");
  var antwort = Console.ReadLine();

  //Sollte ein Toast Vorgang gewollt fortgeführt werden, werden alle weiteren Schritte dieses Prozesses eingeleitet.
  if (antwort.Contains("yes", StringComparison.InvariantCultureIgnoreCase) || antwort.Contains("ja", StringComparison.InvariantCultureIgnoreCase))
  {
    Console.WriteLine("Ok, wie viel Toast möchtest du denn Toasten?");
    var toastAnzahl = Convert.ToInt32(Console.ReadLine());
    //Sollte die Funktion zum Toast reintun zurückgeben das dort etwas falsch ist beendet sich das Programm mit einer entsprechenden Nachricht.
    if (meinToaster.ToastReintun(toastAnzahl) == false)
    {
      Console.WriteLine("Fataler Fehler mehr Toasts reinzupressen als möglich, also tschau!!!!");
      return;
    }

    Console.WriteLine("Nun gehen wir zum Toastvorgang über, gib jedoch bitte noch an wie lange der Prozess gehen soll (in Sekunden).");
    var zeit = Convert.ToInt32(Console.ReadLine());
    meinToaster.ToasterZeitEinstellen(zeit);

    meinToaster.Toasten();

    Console.WriteLine("Das Toast wird nun automatisch ausgeworfen!");
    meinToaster.Toastauswerfen();
    Console.WriteLine("Danke das du diesen Toaster benutzt hast, bis zum nächsten mal!");
  }
}
else
{
  //Zuorndung der gewollten Toasterfarbe
  Console.WriteLine("Bitte gib deine Toasterfarbe an: ");
  farbe = Console.ReadLine();

  //Zuordnung der gewollten Anzahl an Schächten
  Console.WriteLine("Bitte gib deine Anzahl an gewollten Schächten an: ");
  schaechte = Convert.ToInt32(Console.ReadLine());

  //Erstellung des eigenen Toaster Objektes
  var meinSuperToaster = new SuperToaster(farbe, schaechte);
  Console.WriteLine("Alles klar, dein SuperToaster sieht nun wie folgt aus: " + "Farbe:" + meinSuperToaster.Farbe + " Schächte:" + meinSuperToaster.Schaechte);

  Console.WriteLine("Möchstest du mit deinem Toaster toasten?");
  var antwort = Console.ReadLine();

  //Sollte ein Toast Vorgang gewollt fortgeführt werden, werden alle weiteren Schritte dieses Prozesses eingeleitet.
  if (antwort.Contains("yes", StringComparison.InvariantCultureIgnoreCase) || antwort.Contains("ja", StringComparison.InvariantCultureIgnoreCase))
  {
    Console.WriteLine("Ok, wie viel Toast möchtest du denn Toasten?");
    var toastAnzahl = Convert.ToInt32(Console.ReadLine());
    //Sollte die Funktion zum Toast reintun zurückgeben das dort etwas falsch ist beendet sich das Programm mit einer entsprechenden Nachricht.
    if (meinSuperToaster.ToastReintun(toastAnzahl) == false)
    {
      Console.WriteLine("Fataler Fehler mehr Toasts reinzupressen als möglich, also tschau!!!!");
      return;
    }

    Console.WriteLine("Nun gehen wir zum Toastvorgang über, gib jedoch bitte noch an wie lange der Prozess gehen soll (in Sekunden).");
    var zeit = Convert.ToInt32(Console.ReadLine());
    meinSuperToaster.ToasterZeitEinstellen(zeit);

    if (meinSuperToaster.Toasten() == null)
    {
      Console.WriteLine("Bitte benutz den SuperToaster gerne wieder sobald er abgekühlt ist, tschau!!!");
      return;
    }

    //Auswurf des Toast und beendung des gesamten Prozess
    Console.WriteLine("Das Toast wird nun automatisch ausgeworfen!");
    meinSuperToaster.Toastauswerfen();
    Console.WriteLine("Danke das du diesen SuperToaster benutzt hast, bis zum nächsten mal!");
  }
}


