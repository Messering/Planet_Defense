using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public GameObject planet;

	void Update (){

		if (Input.anyKey) {
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
