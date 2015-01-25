using System;
using System.Collections.Generic;
using UnityEngine;

class SceneManagerLeapOfFaith : SceneManager
{
	void Awake()
	{
		GameManager.Instance.currentElement = GameManager.Instance.initialElement;

		Debug.Log("Current element was set to " + GameManager.Instance.currentElement);
	}

	public override void LoadScene(int sceneId)
	{
		if(sceneId == 4)
		{
			switch(GameManager.Instance.currentElement)
			{
				case GameManager.ElementalType.Air:
				case GameManager.ElementalType.Earth:
					GameManager.Instance.leftElement = GameManager.ElementalType.Fire;
					GameManager.Instance.rightElement = GameManager.ElementalType.Water;
					break;

				case GameManager.ElementalType.Fire:
				case GameManager.ElementalType.Water:
					GameManager.Instance.leftElement = GameManager.ElementalType.Air;
					GameManager.Instance.rightElement = GameManager.ElementalType.Earth;
					break;

				default:
					break;
			}

			Debug.Log("Left element was set to " + GameManager.Instance.leftElement);
			Debug.Log("Right element was set to " + GameManager.Instance.rightElement);
		}

		Debug.Log("Loading level " + sceneId);

		Application.LoadLevel(sceneId);
	}

	void Update()
	{
		GameManager gameManager = GameManager.Instance;
		MiniGameManager miniGameManager = MiniGameManager.Instance;

		if(miniGameManager.isRunning && miniGameManager.hasFinished)
		{
			if(miniGameManager.hasSucceeded)
			{
				gameManager.currentStage++;
				Debug.Log("Current stage was set to " + gameManager.currentStage);

				miniGameManager.Reset();

				LoadScene(4); // ChoiceScreen
			}
			else 
			{
				miniGameManager.Reset();

				LoadScene(2); // LeapOfFaith
			}
		}
	}
}
