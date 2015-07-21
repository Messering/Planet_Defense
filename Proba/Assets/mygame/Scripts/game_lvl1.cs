using UnityEngine;
using System.Collections;

public class game_lvl1 : MonoBehaviour {


	void Update (){
		
		if (Input.GetMouseButtonDown (0)) {
			print ("Click");
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit,1000)){
				//DestroyObject(hit.transform.gameObject);

				Destroy(hit.collider.gameObject);
			}
			
			
		}
	}
}
