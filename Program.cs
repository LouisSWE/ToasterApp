// See https://aka.ms/new-console-template for more information

using Toaster = Toaster.Toaster;

String? farbe = String.Empty;
Int32 schaechte = 0;
Console.WriteLine("Bitte gib deine Toasterfarbe an: ");
farbe = Console.ReadLine();
Console.WriteLine("Bitte gib deine Anzahl an gewollten Schächten an: ");
schaechte = Convert.ToInt32(Console.ReadLine());
var meinToaster = new global::Toaster.Toaster(farbe, schaechte);
Console.WriteLine("Alles klar, dein Toaster sieht nun wie folgt aus: " + "Farbe:" + meinToaster.Farbe + " Schächte:" + meinToaster.Schaechte);
Console.WriteLine("Möchstest du mit deinem Toaster toasten?");
var antwort = Console.ReadLine();

if (antwort.Contains("yes", StringComparison.InvariantCultureIgnoreCase) || antwort.Contains("ja", StringComparison.InvariantCultureIgnoreCase))
{
  Console.WriteLine("Ok, wie viel Toast möchtest du denn Toasten?");
  var toastAnzahl = Convert.ToInt32(Console.ReadLine());
  if (meinToaster.ToastReintun(toastAnzahl) == false)
  {
    Console.WriteLine("Fataler Fehler mehr Toasts reinzupressen als möglich, also tschau!!!!");
    return;
  }
}

Console.WriteLine("Nun gehen wir zum Toastvorgang über, gib jedoch bitte noch an wie lange der Prozess gehen soll (in Sekunden).");
var zeit = Convert.ToInt32(Console.ReadLine());
meinToaster.ToasterZeitEinstellen(zeit);

meinToaster.Toasten();

Console.WriteLine("Das Toast wird nun automatisch ausgeworfen!");
meinToaster.Toastauswerfen();
Console.WriteLine("Danke das du diesen Toaster benutzt hast, bis zum nächsten mal!");

