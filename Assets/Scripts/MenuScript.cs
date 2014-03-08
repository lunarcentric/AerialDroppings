using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	private GUISkin skin;
	
	void Start()
	{
		// Load a skin for the buttons
		skin = Resources.Load("GUISkin") as GUISkin;
	}
	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;
		
		// Draw a button to start the game
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Play Game"
			)
			)
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("maingame");
		}
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(6 * Screen.height / 7) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Exit Game"
			)
		    )
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.Quit();
	}
}

	void Update(){
		if (Input.GetKey ("escape")){
			Application.Quit ();
		}
			}
}

