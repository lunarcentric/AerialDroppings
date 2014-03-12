using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public bool randomizeTime = true;	// Whether the time between spawns should be random or not.
	public GameObject[] enemies;		// Array of enemy prefabs.
	
	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	void Spawn ()
	{
		// Select a random enemy from the array.
		int enemyIndex = Random.Range(0, enemies.Length);
    	// Instantiate a random enemy.
		Instantiate (enemies [enemyIndex], transform.position, enemies [enemyIndex].transform.rotation);
	}
}