# InputOutput

## Haalbaarheidsanalyse
Voor project Special Input output van deze periode hebben wij als team gekozen om aan de slag te gaan met gesture sensors, deze pakken bewegingen op zoals, links, rechts, omhoog, omlaag, ver en dichtbij.
Gelijk kwam er een idee omhoog en dat was flappy bird namaken, dit was wel haalbaar en realistisch maar het zou niet goed werken met iets wat niet al te snel werkt, dus snel gingen wij verder met het idee om pacman bestuurbaar te maken met een gesture sensor.

We hebben tests gedaan met de desbetreffende sensor (ADP-9660) en bevestigt dat hij het doet, konden wij aan de slag. Het idee was om eerst de basis te maken zoals controls met een gesture sensor en dan konden we vanaf daar nog andere functies of games controlled door de sensor maken. We hebben de game in een kleine omgeving uitgeprobeerd met de werkende gesture sensor en konden verder gaan met het plan. Het idee was niet al te groot of lastig dus het in het klein testen was ook geen probleem.

## Kosten
Wat hebben we nodig voor het project, wat moeten we hebben om het te realiseren? 
Qua programma’s hebben wij nodig; Visual Studio, Unity, Arduino software, kennis van C# en C++, een Arduino en tot slot een gesture sensor.
Het enige waar echt geld voor betaalt is is de Arduino maar die hadden we al, en de gesture sensor.
Er is ook gekeken naar alternatieven input devices, zoals een leap sensor, maar die interesseerde ons niet voor het project en was te duur.
Ook hebben we gekeken naar een joystick maar deze was niet passend.
Wij hebben gekozen om alleen essentieel materiaal te gebruiken en later te baseren op hoe goed het project gaat of wij voor extra’s gaan.

## Tijd
Wij hebben genoeg tijd voor het project en stellen prioriteiten op functionaliteit, met alle overige tijd die we hebben kunnen we de game tweaken en versoepelen of eventueel voor extra functies gaan.
Het meeste prioriteit ligt bij een werkende input krijgen van de gesture sensor, wat gelukt is, nu ligt de prioriteit op het versoepelen van de game en misschien extra functies.
Wij hadden zeker veel geld kunnen betalen voor een plugin en dan makkelijk met de input aan de slag kunnen gaan maar dat was veel geld dus we hebben ervoor gekozen om verder te zoeken en dat is uiteindelijk gelukt.

## User test met Guido van der Kort
User test ging als volgt:
Guido van der Kort werd achter de PC neergezet en heeft de game zelf uitgevogeld en gespeeld.
Tijdens het spelen zijn de volgende vragen gesteld:
Hoe vind je de game aanvoelen?
  -   Sensor werkt over het algemeen wel goed maar dan moet je de beweging goed uitvoeren, voor de rest lagd het wel.
Hoe pakt het of houd het je aandacht?
  -   Game is wel grappig en het is wel soms irritant dat de sensor het niet doet, maar het is wel leuk om te proberen er zo soepel mogelijk door te komen.
Wat vind je lastig aan de game?
  -   De game zijn controls werken niet altijd even goed.
Wat vind je goed aan de game?
  -   Alles werkt best soepel naast de lag, en het ziet goed uit.
Wat vind je niet goed aan de game?
  -   Game is best laggy en het word snel saai.

## Update log
  -   Note: log werd bijgehouden in hetzelfde document als de bronnen en grof uitgewerkte ideëen omdat dat prettiger werkte, wij kwamen er later achter dat dat in de readme moest.

09/03/2022: Technisch onderzoek uitgevoerd en gedocumenteerd.
  -   Jim Koning en Joost Robat


14/03/2022: Onderzoek gedaan en testing naar het gebruiken van arduino in unity.
  -   Jim Koning en Joost Robat


15/03/2022: Vervolg onderzoek en testing van de arduino uitgevoerd met het arduino programma, ook een library gevonden die de sensor output laat geven.\
  -   Jim Koning en Joost Robat


16/03/2022: Vervolg onderzoek, in unity en experimenteren met het aanpassen van de library.
  -   Jim Koning en Joost Robat


21/03/2022: Vervolg onderzoek, heeft geleid in nog meer bronnen en code waarmee we nu de game kunnen maken, hiervoor was er veel nutteloze code en libraries die niet werkte of geld voor moest betalen.
  -   Jim Koning en Joost Robat


22/03/2022: Game idee veranderd naar Pacman besturen met een gesture sensor, meer realistisch en hoeft niet zo responsive te zijn als flappy bird. Begin gemaakt aan de game en meer code uitgeschreven die al in de game gebruikt kan worden.
  -   Joost Robat en Jim Koning


23/03/2022: Presentatie geupdate en even extra bronnen neergezet in document, ook research gedaan naar githubs van mede-studenten. (README.md) Code efficienter gemaakt
  -   Jim Koning en Joost Robat


28/03/2022: Nog meer documentatie voor later opgeslagen en aan de code gewerkt; code weer efficienter gemaakt en overzichtelijker met behulp van Richard.
  -   Joost Robat
  -   Jim Koning : Ziek


30/03/2022: Aan code gewerkt en de game opties aangepast, movement aangepast.
  -   Joost Robat
  -   Jim Koning : Ziek

05/04/2022: Game aangepast, wat code tests gerunt voor efficientere game.
  -   Joost Robat
  -   Jim Koning

06/04/2022: Nog meer rond geklooit met code om het efficienter te maken.
  -   Joost Robat
  -   Jim Koning




## Bronnen
Bronnenlijst 

Onderzoek over sensor:
https://www.silabs.com/documents/public/application-notes/AN580.pdf
https://www.sparkfun.com/products/12787



Sensor werkend maken in Arduino:
https://learn.sparkfun.com/tutorials/apds-9960-rgb-and-gesture-sensor-hookup-guide/all

https://youtu.be/9SYt4MDSAro
https://youtu.be/SD3iUnLNjY0
https://youtu.be/9SYt4MDSAro

Sensor input krijgen in Unity
https://ardity.dwilches.com/ (kost geld)

https://github.com/XR-lab/Eurovisie

https://medium.com/interface-lab/arduino-tutorial-series-connecting-to-unity-eedc48e77087

https://www.erikaagostinelli.com/post/using-arduino-to-control-unity-objects
