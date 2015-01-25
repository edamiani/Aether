using System;
using System.Collections.Generic;
using UnityEngine;

class SceneManagerChoiceScreen : SceneManager
{
	void Awake()
	{
	}

	public override void LoadScene(int sceneId)
	{
		GameManager gameManager = GameManager.Instance;

		if(sceneId == 4)
		{
			gameManager.currentElement = gameManager.pathChosen;

			switch(gameManager.currentElement)
			{
				case GameManager.ElementalType.Air:
				case GameManager.ElementalType.Earth:
					gameManager.leftElement = GameManager.ElementalType.Fire;
					gameManager.rightElement = GameManager.ElementalType.Water;
					break;

				case GameManager.ElementalType.Fire:
				case GameManager.ElementalType.Water:
					gameManager.leftElement = GameManager.ElementalType.Air;
					gameManager.rightElement = GameManager.ElementalType.Earth;
					break;

				default:
					break;
			}

			Debug.Log("Left element was set to " + gameManager.leftElement);
			Debug.Log("Right element was set to " + gameManager.rightElement);
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
			gameManager.currentStage++;
			Debug.Log("Current stage was set to " + gameManager.currentStage);

			miniGameManager.Reset();

			if(gameManager.currentStage <= 5)
			{
				LoadScene(4); // ChoiceScreen
			}
			else
			{
				LoadScene(1); // ElementalChoice
			}
		}
	}
}
