using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGameObjectSelector : MonoBehaviour {
	
    public GameObject 	spU, spD, spR, spL,
			spUD, spRL, spUR, spUL, spDR, spDL,
			spULD, spRUL, spDRU, spLDR, spUDRL;
	
    public bool up, down, left, right;
	public int type; // 0: normal, 1: enter
	public Color normalColor, enterColor;
	
	void Start () {
		PickGameObject	();
	}
	void PickGameObject(){ //picks correct sprite based on the four door bools
		if (up){
			if (down){
				if (right){
					if (left){
						Instantiate(spUDRL, transform.position, Quaternion.identity);
					}else{
						Instantiate(spDRU, transform.position, Quaternion.identity);
					}
				}else if (left){
					Instantiate(spULD, transform.position, Quaternion.identity);
				}else{
					Instantiate(spUD, transform.position, Quaternion.identity);
				}
			}else{
				if (right)
				{
					Instantiate(left ? spRUL : spUR, transform.position, Quaternion.identity);
				}else if (left){
					Instantiate(spUL, transform.position, Quaternion.identity);
				}else{
					Instantiate(spU, transform.position, Quaternion.identity);
				}
			}
			return;
		}
		if (down){
			if (right)
			{
				Instantiate(left ? spLDR : spDR, transform.position, Quaternion.identity);
			}else if (left){
				Instantiate(spDL, transform.position, Quaternion.identity);
			}else{
				Instantiate(spD, transform.position, Quaternion.identity);
			}
			return;
		}
		if (right)
		{
			Instantiate(left ? spRL : spR, transform.position, Quaternion.identity);
		}else{
				Instantiate(spL, transform.position, Quaternion.identity);
		}
	}
}