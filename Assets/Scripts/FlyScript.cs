using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour {
	private int poops;
	public int PoopValue;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
				if (otherCollider.gameObject.name == "Player") {
						Destroy (gameObject);
						PlayerScript Player = otherCollider.gameObject.GetComponent <PlayerScript> ();
						Player.poops.poops = Player.poops.poops + PoopValue;

				}

		}
	
	void Update()
	{
		// 2 - Limited time to live to avoid any leak
		if (transform.position.x <= -22){
			Destroy(gameObject); // 20sec
		}
	}
	
}
