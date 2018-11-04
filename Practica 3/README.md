# Practica 3: Delegados y Eventos

### Francisco Javier Mendoza Álvarez

## Requisitos:

* Crear un escenario básico para la escena del proyecto para la evaluación final.
* Agregar dos tipos de GameObject de los que haya varias instancias en la escena.
* Implementar un controlador de escena usando el patrón delegado que gestione las siguientes acciones:
  * Si el jugador choca con un objeto de tipo A se incrementa su poder.
  * Si el jugador choca con objetos de tipo B, todos los de ese tipo sufrirán alguna transformación o algún cambio en su apariencia y decrementarán el poder del jugador.
* Incorporar un elemento que sirva para encender o apagar un foco utilizando el teclado.

## Implementación:


### Linterna

Se ha añadido un foco que representa una linterna que posee el jugador, es posible encenderla y apagarla pulsando la **tecla "L"**

![Demostración de uso de la linterna](https://github.com/PanchoMen/Interfaces-Inteligentes/blob/master/Recursos/Practica%203/Linterna.gif "Uso de la Linterna")

---

### Totems

Se han añadido 2 tipos de totems:
* Totem de color blanco:

  Cuando el jugador colisiona con un totem de este tipo, su poder **incrementa en 10 puntos**;
* Totem de color rosado:

  Cuando el jugador colisiona con este tipo de totem, su poder **decrementa en 10 puntos**, los totems cambian de color durante 10 segundos y reducen el doble de puntos en cada colisión durante este tiempo.
 
![Demostración de las coliciones](https://github.com/PanchoMen/Interfaces-Inteligentes/blob/master/Recursos/Practica%203/Colisiones.gif "Colisiones")
