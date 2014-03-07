using UnityEngine;
using System.Collections;

public class PixelCarScript : MonoBehaviour {

	void Update()
	{
		// 2 - Limited time to live to avoid any leak
		if (transform.position.x <= -22){
		Destroy(gameObject); // 20sec
		}
		}
}
