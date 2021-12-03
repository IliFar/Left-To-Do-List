**FUNKTIONER OCH STRUKTUR**
Min kods funktioner och struktur baseras på vad beställaren vill ha som krav på programmet. Med det sagt så innehåller programmet Tasks med olika typer som går att lägga till till en Task lista [Method:addTask()], och sen ska dem kunna visas [Method:showTask()], och kan markeras som klar **Jag har skapat en method för det men pga brist i tid och kunskaper så valde jag att skriva kod i Program klassen för att markera uppgiften**. Sen kan man archivera dem markerade uppgifter coh det har jag också fixat i Program klassen.

**ANVÄNDA PRINCIPER**
När det kommer till OOP principer så har använt [Objekt] [Klasser] [Abstraction] [Inheritance] och [Polymorfism].
[Klasser] => Jag skapade en superclass som heter Task och 3 klasser, en klass för varje typ av uppgift.
[Objekt] => i Program klassen så kallar jag på respektive klass objekt baserat på vilken typ av uppgift användaren vill lägga till.
[Abstraction] => Superklassen Task har jag valt att göra den till abstract för att dem andra sub klasser skulle kunna arva från den, samt skapade jag abstract metoder för att hantera vad varje typ av uppgift ska kunna göra.
[Inheritance] => I superklassen skapade jag fields och abstracta methoder som tillhör sub klasser, och sen kallar jag på dem metoder och fields i varje sub klass.
[Polymorfism] => Varje klass kan använda olika metoder som arvas från superklassen.
[Encapsulation] => När det kommer till encapsulation så har jag gjort allt public pga brist i tid.

**Tester För Klasser**
Jag har gjort 2 tester, en för att testa att en tidlös uppgift går att lägga till i listan, och den andra testet är för att testa att en deadline uppgift går att lägga till i listan.
(1)[Lägga-till-Tidlös-Uppgift-Test] => i testet skapade jag en tidlös uppgift, gav den en test sträng, sen lägga jag till uppgiften till listan och asserta om listan är NotEmpty.
(2)[Lägga-till-Tidlös-Uppgift-Test] => i testet skapade jag en deadline uppgift, gav den en test sträng, idags datum och en test datum, sen lägga jag till uppgiften till listan och asserta att listan contains uppgiften och subtraktionen av idags datum och test datumet.
Jag fattade inte riktigt hur man gör avancerade tester, men jag antar att jag behöver fler övningar för att vänja mig vid det.

**ANALYS**
Mitt program har många buggar, som att jag inte har några undantagshantering, ett annat exempel är när uppgiften är markerad, gränssnittet uppdateras inte direkt, jag har också några menybuggar, men om jag ska vara ärlig är det första gången jag känner fastnat i en uppgift och det får mig att ifrågasätta mina kunskaper, men jag tror att den här typen av uppdrag är som en självutvärdering av mina kunskaper och min level.
[Till-Slut] så mitt program kan [lägga-till] en uppgift, [markera], [visa], [archivera] och [visa-dem-archiverad] uppgifter.
