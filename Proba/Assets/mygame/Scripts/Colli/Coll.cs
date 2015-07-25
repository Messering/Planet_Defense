using UnityEngine; 
using System.Collections; 
public class Coll : MonoBehaviour { 

	public Rigidbody2D b;
	public GameObject planet;
	private float a = 1;
	void OnTriggerEnter2D(Collider2D other)
	{
	
		Destroy (other.gameObject);
		a += b.mass / 2;
		planet.transform.localScale = new Vector2 (a,a);

	}
}