using UnityEngine;
using System.Collections;

public class DestroyByClick : MonoBehaviour {
	
	private int valuescore;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) 
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			if(hit.collider != null)
			{
				if(hit.collider.gameObject==gameObject){ Destroy(gameObject);
					//ManagerScore.score+=10;
					if(hit.collider.gameObject.name=="Bird(Clone)"){valuescore=1; ManagerScore.score+=valuescore;}
					if(hit.collider.gameObject.name=="Bird1(Clone)"){valuescore=2; ManagerScore.score+=valuescore;}
					if(hit.collider.gameObject.name=="Bird2(Clone)"){valuescore=3; ManagerScore.score+=valuescore;}
				}
			}
		}
	}
}