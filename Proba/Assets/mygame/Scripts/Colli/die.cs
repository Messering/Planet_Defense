using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {
	public GameObject ui;
	public GameObject Game_over;
	public GameObject bird;
	public GameObject planet;

	// Use this for initialization
	void Update () {
		if (this.gameObject.transform.lossyScale.x>=6) {
			bird.SetActive(false);

		}
		if (this.gameObject.transform.lossyScale.x>=6.5) {
			Transform[] gos = FindObjectsOfType<Transform>();
			foreach (Transform go in gos)  Destroy(go);
			planet.SetActive(false);
			ui.SetActive(true);
			Game_over.SetActive(true);

			//Application.LoadLevel ("Game over");
		}
	
	}

}
