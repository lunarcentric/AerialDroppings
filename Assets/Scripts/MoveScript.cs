using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class MoveScript : MonoBehaviour
{
	// 1 - Designer variables
	
	/// <summary>
	/// Object speed
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);
	
	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);

	private Vector2 movement;

	/// <summary>
	/// Will this randomly move?
	/// </summary>
	public bool RandomMove;
	
	void Update()
	{
		/// RandomMove function emulates food movement and increases difficulty.

		if (RandomMove == true) 
		{
			direction.x = Random.Range(-1f,1f);
			direction.y = Random.Range(-1f,1f);
		
		}
		// 2 - Movement
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
			}
	
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}