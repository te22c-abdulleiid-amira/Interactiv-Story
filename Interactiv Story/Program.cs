using System;

 
string choice = "";

Console.WriteLine("du vaknar upp i ett mörkt rum du inte känner igen.");
Console.WriteLine("ser dig omkring i rummet, för att först få mer information om vart du är");
Console.WriteLine("du ser en lapp där det står: \"De kom tidigare än vi förväntade\"");
Console.WriteLine("du förstår inte vad lappen menade, men bestämde dig för att lägga den i fickan.");
Console.WriteLine("när du väll har lämnat rummet så är du i en korridor.");
Console.WriteLine("sedan hör de en röst som ropar på dig, den säger: \"snälla, hjälp mig\".");
Console.WriteLine("du kollar åt höger där vid slutet av korridoren så ser du ett fönster med ett huvud som tittar igenom.");
Console.WriteLine("händerna höll mot kanten och ansiktet döljdes av svart hår");
Console.WriteLine("vad gör du? går du vänster till och ignorerar rösten eller höger mot rösten");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "vänster")
{
  Console.WriteLine("du bestämmer dig för att ignorera rösten som ber om din hjälp.");
  Console.WriteLine("för varje steg du tar ifrån rösten, desto högre blir den");
  Console.WriteLine("men nu så roppar den inte efter hjälp mer. nu så skriver den ord du aldrig hört talas om.");
  Console.WriteLine("precis innan du bestämmer dig för att vända dig om så känner du en hand på ditt huvud.");
  Console.WriteLine("handen vrider ditt huvud ett perfect 360 innan allt blir svart.");
  Console.WriteLine("du dog");
}
else if (choice == "höger")
{
  Console.WriteLine("du närmar dig rösten, rösten som blir svagare för varje steg du tar.");
  Console.WriteLine("när du väll står framför personen som hänger vid förnstret så tar du tag i hennes hand.");
  Console.WriteLine("\"snälla, hjälp mig upp\" ber hon");
  
  Console.WriteLine("hjälper du henne?");

  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "ja")
  {
    Console.WriteLine("du tar tag i hennes hand och drar upp henne med allt du har. du lykas att dra upp henne in till byggnaden");
    Console.WriteLine("där du kan få en bätte sun av henne.");
    Console.WriteLine("när hon väll står framför dig så börjar hon viska.\"...monster...monster\"");
    Console.WriteLine("du förmedlar henne att du inte riktigt förstodd vad hon sa, tills hon höjer rösten");
    Console.WriteLine("\"DU FÖRSTÖRDE ALLT\" vrålar hon medans hon kastar sin kropp på dig.");
    Console.WriteLine("från ryggen drar hon fram en kniv och hugar dig om och om igen.");
    Console.WriteLine("du dog");
  }
  else if (choice == "nej")
  {
    Console.WriteLine("en efter en puttar du av hennes fingrar från fönsteret, tills hon hänger kvar på sitt lilfinger.");
    Console.WriteLine("när du väll puttat av alla hennes fingrar så hör du hennes röst försvinna ner mot marken tills du hör ett plask");
    Console.WriteLine("nu när hon var borta så kan du see utsikten som gömde sig bakom henne.");
    Console.WriteLine("allt du såg var något som såg ut som en stad, men nu var den förstörd.");
    Console.WriteLine("det du nu tittar på är din förstörda stad.");
    Console.WriteLine("din värld");
    Console.WriteLine("ditt hem");
    Console.WriteLine("ditt mästerverk");
  }
  else
  {
    Console.WriteLine("skriv tydligt idiot");
  }
}
else
{
  Console.WriteLine("du dog för att du inte kunde stava");
}

Console.WriteLine("tryck ENTER för att avsluta");
Console.ReadLine();