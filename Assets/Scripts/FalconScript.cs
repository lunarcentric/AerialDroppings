using UnityEngine;
using System.Collections;

public class FalconScript : MonoBehaviour {

	void Update()
	{
		// 2 - Limited time to live to avoid any leak
		if (transform.position.x <= -22){
			Destroy(gameObject); // 20sec
		}
	}
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.name == "Player") {
			Destroy (gameObject);
			Destroy (otherCollider.gameObject);			
		}
		}

}
