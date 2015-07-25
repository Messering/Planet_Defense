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
			a += b.mass / 2;
			print (a);
		}

		if( other.name =="Bird1(Clone)"){
				a += d.mass/2;
				print (a);
			}
		if( other.name =="Bird2(Clone)"){
				a += c.mass/2;
				print (a);
			}


		planet.transform.localScale = new Vector2 (a,a);

	}
}