using UnityEngine;
using System.Collections;

public class InputManagerLeapOfFaith : MonoBehaviour
{
	// Use this for initialization
	void Awake()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
		{
			GameManager.Instance.LoadMiniGames(GameManager.Instance.initialElement, GameManager.ElementalType.None);
		}
	}
}