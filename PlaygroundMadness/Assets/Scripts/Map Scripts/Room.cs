using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room {
	//Clase que no hereda de monobehaviour, es una clase que se encarga de almacenar la informacion de una habitacion
	
	//Posicion en la que se encuentra la habitacion en el grid
	public Vector2 gridPos;
	//Tipo de habitacion
	public int type;
	//Booleanos que nos dicen cuando no hay una puerta en cierta posicion
	public bool doorTop, doorBot, doorLeft, doorRight;

	//Constructor de la clase para poder ser accedida desde el script del generador
	public Room(Vector2 _gridPos, int _type){
		gridPos = _gridPos;
		type = _type;
	}
}
