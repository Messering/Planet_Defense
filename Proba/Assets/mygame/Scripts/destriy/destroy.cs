using UnityEngine;
using System.Collections;

public class game_lvl1 : MonoBehaviour {
	public GameObject planet;
	
	void Update (){
		
		if (Input.anyKey) {
				//DestroyObject(hit.transform.gameObject);
				Destroy(this.gameObject);

		}
	}
}
