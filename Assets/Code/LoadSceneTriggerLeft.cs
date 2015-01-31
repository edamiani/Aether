using UnityEngine;
using System.Collections;

public class LoadSceneTriggerLeft : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Hit 1!!!");

		GameManager gameManager = GameManager.Instance;

		gameManager.pathChosen = gameManager.leftElement;
		gameManager.LoadMiniGames(gameManager.currentElement, gameManager.leftElement);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("Hit 2!!!");
	}

}
