### GameOfLife

Ein Spielfeld wird in Zeilen und Spalten unterteilt.  
Jedes Gitterquadrat ist eine Zelle, welche einen von zwei Zuständen besitzen kann: tot (weiß) oder lebendig (schwarz).   
Zunächst wird eine Anfangsgenerationvon lebenden Zellen auf dem Spielfeld platziert.   
Jede lebende oder tote Zelle hat auf diesem Spielfeld genau acht Nachbarzellen, die berücksichtigt werden.   

#### Die nächste Generation ergibt sich durch die Befolgung einfacher Regeln:
* Eine tote Zelle mit genau drei lebenden Nachbarn wird in der Folgegeneration neu geboren.
* Lebende Zellen mit weniger als zwei lebenden Nachbarn sterben in der Folgegeneration an Einsamkeit.
* Eine lebende Zelle mit zwei oder drei lebenden Nachbarn bleibt in der Folgegeneration am Leben.
* Lebende Zellen mit mehr als drei lebenden Nachbarn sterben in der Folgegeneration an Überbevölkerung.

#### Dabei soll das Spielfeld...
* eine fixe Größe haben 16 x 9.
* zwischen 2 Größen wählbar sein.
* dynamisch aufgebaut werden (Benutzerabfrage). 

#### Anfangskonstellation auf dem Spielfeld:
* Die lebenden Zellen werden zufällig festgelegt. 
* Die lebenden Zellen können per Mausklick festgelegt werden 

#### Der Rand des Spielfelds:
* besteht aus toten Zellen.
* ist wie ein Torus aufgebaut

Online Simulation: https://playgameoflife.com/
