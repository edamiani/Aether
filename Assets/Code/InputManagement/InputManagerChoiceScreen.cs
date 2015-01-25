using UnityEngine;
using System.Collections;

public class InputManagerChoiceScreen : MonoBehaviour
{
	// Use this for initialization
	void Awake()
	{
		Debug.Log("Current element is " + GameManager.Instance.currentElement);
	}

	// Update is called once per frame
	void Update()
	{
		GameManager gameManager = GameManager.Instance;

		if(Input.GetKeyUp(KeyCode.LeftArrow))
		{
			gameManager.pathChosen = gameManager.leftElement;
			gameManager.LoadMiniGames(gameManager.currentElement, gameManager.leftElement);
		}
		else if(Input.GetKeyUp(KeyCode.RightArrow))
		{
			gameManager.pathChosen = gameManager.rightElement;
			gameManager.LoadMiniGames(gameManager.currentElement, gameManager.rightElement);
		}
	}
}