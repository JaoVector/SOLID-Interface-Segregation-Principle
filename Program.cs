using ISP.Classes;

var faca = new Faca();
faca.Cortar();

var abridor = new Abridor();
abridor.Abrir();

var canivete = new Canivete(faca, abridor);

canivete.Abrir();
canivete.Cortar();
canivete.ChaveFenda();