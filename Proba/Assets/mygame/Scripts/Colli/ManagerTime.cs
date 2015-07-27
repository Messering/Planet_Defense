using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManagerTime : MonoBehaviour
{
	public static float time_sec;       // The player's time.
	public static float time_min;
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		time_sec = 0;
		time_min = 0;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Time" followed by the score value.
		if (time_sec < 10&&time_min < 10) {
			text.text = "0"+time_min + ":0" + (int)time_sec;
		}
		if (time_sec > 10&&time_min < 10) {
			text.text = "0"+time_min + ":" + (int)time_sec;
		}
	
		if (time_sec > 10&&time_sec < 10) {
			text.text = time_min + ":0" + (int)time_sec;
		}
		if (time_sec > 10&&time_sec > 10) {
			text.text = time_min + ":" + (int)time_sec;
		}
	}
}