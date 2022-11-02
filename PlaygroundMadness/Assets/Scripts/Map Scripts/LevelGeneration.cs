using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour {
	
	//Tamaño del mapa
	Vector2 worldSize = new Vector2(4,4);
	//Un arreglo con los cuartos que querran ser generados
	Room[,] rooms;
	//Lista con las posiciones tomadas, con contains se nos hace mas facil saber si una posicion esta tomada o no
	List<Vector2> takenPositions = new List<Vector2>();
	//Valores que le daran la posicion a la habitacion
	int gridSizeX, gridSizeY;
	//Numero de habitaciones que queremos generar
	public int numberOfRooms = 11;
	//Objeto que se va instanciar
	public GameObject roomWhiteObj;
	
	
	void Start () {
		// Nos aseguramos que el numero de habitaciones sea menor al numero de habitaciones que se pueden generar
		if (numberOfRooms >= (worldSize.x * 2) * (worldSize.y * 2))
		{ 
			numberOfRooms = Mathf.RoundToInt((worldSize.x * 2) * (worldSize.y * 2));
		}
		gridSizeX = Mathf.RoundToInt(worldSize.x); 
		gridSizeY = Mathf.RoundToInt(worldSize.y);
		CreateRooms(); //Llamamos a la funcion que creara las habitaciones
		SetRoomDoors(); //Asignamos las puertas a las habitaciones
		DrawMap(); //Instanciamos los objetos que haran el mapa
	}
	void CreateRooms(){
		//Asignamos el espacio que tomara la habitacion en el grid
		rooms = new Room[gridSizeX * 2,gridSizeY * 2];
		//Asignamos la posicion inicial, al ser tipo 1 se genrara siempre en el 0,0
		rooms[gridSizeX,gridSizeY] = new Room(Vector2.zero, 1);
		//Asignamos la posicion inicial a la lista de posiciones tomadas
		takenPositions.Insert(0,Vector2.zero);
		//Confirmamos que esa posicion 0,0 ha sido tomada
		Vector2 checkPos = Vector2.zero;
		
		float randomCompare = 0.2f, randomCompareStart = 0.2f, randomCompareEnd = 0.01f;
		//añade habitacion
		for (int i =0; i < numberOfRooms -1; i++){
			//Calculamos la probabilidad de que se genere una habitacion en una posicion aleatoria
			float randomPerc = ((float) i) / (((float)numberOfRooms - 1));
			randomCompare = Mathf.Lerp(randomCompareStart, randomCompareEnd, randomPerc);
			//Nos toma una posicion aleatoria que si este disponible
			checkPos = NewPosition();
			
			//Si la posicion no esta disponible prueba con otra
			//Al adentrarnos mas al ciclo es poco probable que se genere una habitacion en una posicion aleatoria, por lo que siempre intenta conectarse con una vecina
			if (NumberOfNeighbors(checkPos, takenPositions) > 1 && Random.value > randomCompare){
				int iterations = 0;
				do{
					checkPos = SelectiveNewPosition();
					iterations++;
				}while(NumberOfNeighbors(checkPos, takenPositions) > 1 && iterations < 100);
				//Intentamos que consiga una posicion 50 veces y si no lo logra arroja error
				if (iterations >= 50)
					print("error:esta habitacion tiene habitaciones adyacentes a ella");
			}
			//Aqui se coloca la habitacion en la lista y en el grid, tambien esta es de tipo 0 ya que no es la inicial
			rooms[(int) checkPos.x + gridSizeX, (int) checkPos.y + gridSizeY] = new Room(checkPos, 0);
			takenPositions.Insert(0,checkPos);
			
		}	
	}
	
	//Aqui es como tomamos nuevas posiciones validas y conectamos la habitacion con todas las puertas posibles
	//Para este script una habitacion es vailda si es vecina de otra (adyacente)
	Vector2 NewPosition(){
		int x = 0, y = 0;
		Vector2 checkingPos = Vector2.zero;
		do{
			
			//Tomamos una posicion aleatoria de nuestra lista de posiciones tomadas
			int index = Mathf.RoundToInt(Random.value * (takenPositions.Count - 1)); //Toma una habitacion
			x = (int) takenPositions[index].x;//Toma la posicion X y Y de la habitacion
			y = (int) takenPositions[index].y;
			
			bool UpDown = (Random.value < 0.5f);//Aleatoriamente seleccionamos si queremos ir arriba o abajo
			bool positive = (Random.value < 0.5f);//Aleatoriamente seleccionamos si queremos ir a la derecha o izquierda
			
			//Encontramos una posicion adecuada segun los boleanos de arriba
			if (UpDown)
			{ 
				if (positive)
				{
					y += 1;
				}
				else
				{
					y -= 1;
				}
			}
			else
			{
				if (positive)
				{
					x += 1;
				}
				else
				{
					x -= 1;
				}
			}
			checkingPos = new Vector2(x,y);
		}
		while (takenPositions.Contains(checkingPos) || x >= gridSizeX || x < -gridSizeX || y >= gridSizeY || y < -gridSizeY); //Aqui asegruamos que la posicion sea valida
		return checkingPos; //Colocamos la habitacion en esa posicion
	}
	
	//Este metodo es muy parecido al de arriba pero aqui se asegura que la habitacion sea vecina de otra y solo de una habitacion
	Vector2 SelectiveNewPosition()
	{ 
		int index = 0, inc = 0;
		int x =0, y =0;
		
		Vector2 checkingPos = Vector2.zero;
		do{
			inc = 0;
			do{
				index = Mathf.RoundToInt(Random.value * (takenPositions.Count - 1));
				inc ++;
			}
			while (NumberOfNeighbors(takenPositions[index], takenPositions) > 1 && inc < 100);
			
			//Tomamos una posicion aleatoria de nuestra lista de posiciones tomadas
			x = (int) takenPositions[index].x;
			y = (int) takenPositions[index].y;
			
			bool UpDown = (Random.value < 0.5f);
			bool positive = (Random.value < 0.5f);
			
			if (UpDown)
			{
				if (positive)
				{
					y += 1;
				}
				else
				{
					y -= 1;
				}
			}
			else
			{
				if (positive)
				{
					x += 1;
				}
				else
				{
					x -= 1;
				}
			}
			checkingPos = new Vector2(x,y);
		}
		while (takenPositions.Contains(checkingPos) || x >= gridSizeX || x < -gridSizeX || y >= gridSizeY || y < -gridSizeY);
		if (inc >= 100){ // Aca despues de 100 intentos de encontrar una posicion valida arroja error si no logra encontrar una que tenga la posicion deseada
			print("Error:no existe una habitacion vecina con solo una puerta habilitada");
		}
		return checkingPos;
	}
	int NumberOfNeighbors(Vector2 checkingPos, List<Vector2> usedPositions){
		int ret = 0; // start at zero, add 1 for each side there is already a room
		if (usedPositions.Contains(checkingPos + Vector2.right)){ //using Vector.[direction] as short hands, for simplicity
			ret++;
		}
		if (usedPositions.Contains(checkingPos + Vector2.left)){
			ret++;
		}
		if (usedPositions.Contains(checkingPos + Vector2.up)){
			ret++;
		}
		if (usedPositions.Contains(checkingPos + Vector2.down)){
			ret++;
		}
		return ret;
	}
	
	//Aqui se crea la habitacion en el grid y recorre cad apunto de nuestro arreglo de habitaciones para seleccionar las correctas
	void DrawMap(){
		foreach (Room room in rooms){
			if (room == null){
				continue; //Si la habitacion no existe, no la dibuja
			}
			//Tomamos el tamaño de nuestro mapa y lo adaptamos al tamaño de nuestros sprites multimplicandolos por las dimensiones
			Vector2 drawPos = room.gridPos;
			drawPos.x *= 128;//Dimensiones de la habitacion en cuanto a sprites	
			drawPos.y *= 64;
			//Aqui entra nuestro objeto mapa y se pasan todos las habtiaciones para instanciar
			MapGameObjectSelector mapper = Object.Instantiate(roomWhiteObj, drawPos, Quaternion.identity).GetComponent<MapGameObjectSelector>();
			
			
			mapper.type = room.type;
			mapper.up = room.doorTop;
			mapper.down = room.doorBot;
			mapper.right = room.doorRight;
			mapper.left = room.doorLeft;
		}
	}
	void SetRoomDoors(){
		//Aqui se establecen las puertas de las habitaciones, se verifica si tiene una puerta a cada lado y se toma segun la necesidad
		for (int x = 0; x < ((gridSizeX * 2)); x++)
		{
			for (int y = 0; y < ((gridSizeY * 2)); y++)
			{
				if (rooms[x,y] == null)
				{
					continue;
				}
				Vector2 gridPosition = new Vector2(x,y);
				if (y - 1 < 0)
				{ //Chequeamos arriba
					rooms[x,y].doorBot = false;
				}
				else
				{
					rooms[x,y].doorBot = (rooms[x,y-1] != null);
				}
				if (y + 1 >= gridSizeY * 2)
				{ //Chequeamos abajo
					rooms[x,y].doorTop = false;
				}
				else
				{
					rooms[x,y].doorTop = (rooms[x,y+1] != null);
				}
				if (x - 1 < 0)
				{ //Chequeamos a la izquierda
					rooms[x,y].doorLeft = false;
				}
				else
				{
					rooms[x,y].doorLeft = (rooms[x - 1,y] != null);
				}
				if (x + 1 >= gridSizeX * 2)
				{ //Chequeamos a la derecha
					rooms[x,y].doorRight = false;
				}
				else
				{
					rooms[x,y].doorRight = (rooms[x+1,y] != null);
				}
			}
		}
	}
}
