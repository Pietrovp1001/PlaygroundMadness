using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGameObjectSelector : MonoBehaviour
{
	//Aqui asignamos en el inspector cada tipo de habitacion que hay en el juego 15 en total
	public GameObject 
		spU,
		spD,
		spR,
		spL,
		spUD,
		spRL,
		spUR,
		spUL,
		spDR,
		spDL,
		spULD,
		spRUL,
		spDRU,
		spLDR,
		spUDRL;

	public bool up, down, left, right;
	public int type; //Tipo de habitacion 0 normal y 1 entrad

	void Start()
	{
		PickGameObject();
		Clear();
	}
	void PickGameObject()
	{
		//Tomamos el tipo de habitacion y la direccion de las puertas para elegir el prefab que corresponde por los booleanos anteriores
		if (up)
		{
			if (down)
			{
				if (right)
				{
					if (left)
					{
						spUDRL.SetActive(true);
					}
					else
					{
						spDRU.SetActive(true);
					}
				}
				else if (left)
				{
					spULD.SetActive(true);
				}
				else
				{
					spUD.SetActive(true);
				}
			}
			else
			{
				if (right)
				{
					var room = left ? spRUL : spUR;
					room.SetActive(true);
				}
				else if (left)
				{
					spUL.SetActive(true);
				}
				else
				{
					spU.SetActive(true);
				}
			}

			return;
		}

		if (down)
		{
			if (right)
			{
				var room = left ? spLDR : spDR;
				room.SetActive(true);
			}
			else if (left)
			{
				spDL.SetActive(true);
			}
			else
			{
				spD.SetActive(true);
			}

			return;
		}
		if (right)
		{
			var room = left ? spRL : spR;
			room.SetActive(true);
		}
		else
		{
			spL.SetActive(true);
		}
	}
	void Clear()
	{
		List<Transform>children = new List<Transform>();
		for (int i = 0; i < transform.childCount; i++)
		{
				children.Add(transform.GetChild(i));
		}
		foreach (Transform child in children)
		{
			if (!child.gameObject.activeSelf)
			{
				Destroy(child.gameObject);
			}
		}
	}
}

	