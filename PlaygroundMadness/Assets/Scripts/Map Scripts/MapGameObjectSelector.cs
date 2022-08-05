using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGameObjectSelector : MonoBehaviour
{

	public GameObject spU,
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
	public int type; // 0: normal, 1: enter
	public Color normalColor, enterColor;

	void Start()
	{
		PickGameObject();
		Clear();
	}

	void PickGameObject()
	{
		//picks correct sprite based on the four door bools
		if (up)
		{
			if (down)
			{
				if (right)
				{
					if (left)
					{
						//Instantiate(spUDRL, transform.position, Quaternion.identity);
						spUDRL.SetActive(true);
					}
					else
					{
						//Instantiate(spDRU, transform.position, Quaternion.identity);
						spDRU.SetActive(true);
					}
				}
				else if (left)
				{
					//Instantiate(spULD, transform.position, Quaternion.identity);
					spULD.SetActive(true);
				}
				else
				{
					//Instantiate(spUD, transform.position, Quaternion.identity);
					spUD.SetActive(true);
				}
			}
			else
			{
				if (right)
				{
					//Instantiate(left ? spRUL : spUR, transform.position, Quaternion.identity);
					var room = left ? spRUL : spUR;
					room.SetActive(true);
				}
				else if (left)
				{
					//Instantiate(spUL, transform.position, Quaternion.identity);
					spUL.SetActive(true);
				}
				else
				{
					//Instantiate(spU, transform.position, Quaternion.identity);
					spU.SetActive(true);
				}
			}

			return;
		}

		if (down)
		{
			if (right)
			{
				//Instantiate(left ? spLDR : spDR, transform.position, Quaternion.identity);
				var room = left ? spLDR : spDR;
				room.SetActive(true);
			}
			else if (left)
			{
				//Instantiate(spDL, transform.position, Quaternion.identity);
				spDL.SetActive(true);
			}
			else
			{
				//Instantiate(spD, transform.position, Quaternion.identity);
				spD.SetActive(true);
			}

			return;
		}

		if (right)
		{
			//Instantiate(left ? spRL : spR, transform.position, Quaternion.identity);
			var room = left ? spRL : spR;
			room.SetActive(true);
		}
		else
		{
			//Instantiate(spL, transform.position, Quaternion.identity);
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

	