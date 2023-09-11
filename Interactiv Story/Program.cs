using System;

 
string choice = "";

Console.WriteLine("du vaknar upp i ett mörkt rum du inte känner igen.");
Console.WriteLine("ser dig omkring i rummet, för att först få mer information om vart du är, till du ser en lapp där det står: \"De kom tidigare än vi förväntade\"");
Console.WriteLine("du förstår inte vad lappen menade, men bestämde dig för att lägga den i fickan.");
Console.WriteLine("när du väll har lämnat rummet så är du i en korridor. sedan hör de en röst som ropar på dig, den säger: \"snälla, hjälp mig\". du kollar åt höger dör vid slutet av korridoren så ser du ett fönster med ett huvud som tittar igenom. händerna höll mot kanten och ansiktet döljdes av svart hår");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "gå höger till fönstret med den ropande rösten")
{
  Console.WriteLine("du långsamt närmar dig fönsteret");

}
else if (choice == "du går vänster, ignorerar rösten")
{
  Console.WriteLine("Du kommer in i reaktorrummet.");
  Console.WriteLine("Röda larmlampor blinkar, och du ser att reaktorn snart kommer att explodera.");
  Console.WriteLine("På en skärm blinkar frågan \"RESET REACTOR SYSTEMS?\"");
  Console.WriteLine("Under skärmen finns två knappar. En röd, en grön. Det står inget på dem som antyder vilken som är \"ja\" och vilken som är \"nej\".");
  Console.WriteLine("Trycker du på röd eller grön knapp?");

  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "röd")
  {
    Console.WriteLine("Bra jobbat! Du mindes precis i tid att någon på marknadsföringsavdelningen tyckt att rött var en mycket snällare färg och att man därmed bytt färg på alla ja/nej-knappar.");
    Console.WriteLine("Rymdskeppet är räddat och kan åka vidare med sin last av illegala vapen.");
  }
  else if (choice == "grön")
  {
    Console.WriteLine("BOOM! Tyvärr hade du glömt att någon på marknadsföringsavdelningen tyckt att rött var en mycket snällare färg och att man därmed bytt färg på alla ja/nej-knappar.");
    Console.WriteLine("Du är död och rymdskeppet förintat.");
  }
  else
  {
    Console.WriteLine("Din klant! Du skrev inget jag kunde förstå, så nu dör du när reaktorn exploderar.");
  }
}
else
{
  Console.WriteLine("Din klant! Du skrev inget jag kunde förstå, så nu dör du när reaktorn exploderar.");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();