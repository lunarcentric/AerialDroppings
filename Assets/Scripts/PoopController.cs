using UnityEngine;
using System.Collections;

public class PoopController : MonoBehaviour {
	
	public int poops = 3;					// The player's remaining poops.


	void Awake ()
	{
	}
	
	void Update ()
	{
		// Set the score text.
		guiText.text = "Poops Remaining: " + poops;
	}
}