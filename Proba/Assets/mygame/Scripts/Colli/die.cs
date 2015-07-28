using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {
	public GameObject ui;
	public GameObject Game_over;
	public GameObject bird;
	public GameObject planet;
	public GameObject birds;
	public GameObject birds1;
	public GameObject birds2;



	void Start(){
		birds.GetComponent<SpriteRenderer>().enabled=true;
		birds1.GetComponent<SpriteRenderer>().enabled=true;
		birds2.GetComponent<SpriteRenderer> ().enabled = true;

	}
	// Use this for initialization
	void Update () {


		if (this.gameObject.transform.lossyScale.x>=6.5) {
		
			bird.SetActive(false);

			planet.SetActive(false);
			ui.SetActive(true);
			Game_over.SetActive(true);

		}
	}
}


		
		
		

