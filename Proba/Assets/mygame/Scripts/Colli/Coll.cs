using UnityEngine; 
using System.Collections; 
public class Coll : MonoBehaviour { 

	public Rigidbody2D b;
	public Rigidbody2D d;
	public Rigidbody2D c;
	public GameObject planet;
	private float a = 1;
	void OnTriggerEnter2D(Collider2D other)
	{
	
		Destroy (other.gameObject);

		if (other.name == "Bird(Clone)") {
			a += b.mass / 5;
		}

		if( other.name =="Bird1(Clone)"){
				a += d.mass/5;
			}
		if( other.name =="Bird2(Clone)"){
				a += c.mass/5;
			}

		planet.transform.localScale = new Vector2 (a,a);
	}
}