using UnityEngine;

/// <summary>
/// Handle hitpoints and damages
/// </summary>
public class HealthScript : MonoBehaviour
{
	/// <summary>
	/// Total hitpoints
	/// </summary>
	public int hp = 1;
	
	/// <summary>
	/// Enemy or player?
	/// </summary>
	public bool isEnemy = true;

	//Initialize Score and Poop variables
	private ScoreController score;
	private PoopController poops;


	//Initialize score prefab
	void Start () { 
		score = GameObject.Find ("Score"). GetComponent<ScoreController>();
		poops = GameObject.Find ("Poops").GetComponent <PoopController>();
	}

	/// <summary>
	/// Inflicts damage and check if the object should be destroyed
	/// </summary>
	/// <param name="damageCount"></param>
	public void Damage(int damageCount)
	{
		hp -= damageCount;
		
		if (hp <= 0)
		{
//			// 'Splosion!
//			SpecialEffectsHelper.Instance.Explosion(transform.position);
//			SoundEffectsHelper.Instance.MakeExplosionSound();
//			// Dead!
			Destroy(gameObject);
			score.score += 100;
		}
	}
	
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		// Is this a shot?
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		FlyScript fly = otherCollider.gameObject.GetComponent<FlyScript> ();

		if (shot != null)
		{
			// Avoid friendly fire
			if (shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage); 
				// Destroy the shot
				Destroy(shot.gameObject); // Remember to always target the game object, otherwise you will just remove the script
			}
		}
		if (fly != null)
		{

			Destroy(fly.gameObject);
			poops.poops++;
		}
}
}