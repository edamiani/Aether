using System;
using System.Collections.Generic;
using UnityEngine;

class SceneManagerElementalChoice : SceneManager
{
	void Awake()
	{
		GameManager.Instance.currentElement = GameManager.Instance.initialElement;
	}

	public override void LoadScene(int sceneId)
	{
		Debug.Log("Loading level " + sceneId);

		Application.LoadLevel(sceneId);
	}

	public void LoadSceneAir()
	{
		Debug.Log("Setting initial elemental type to air.");

		GameManager.Instance.initialElement = GameManager.ElementalType.Air;

		GameManager.Instance.currentStage = 1;

		Application.LoadLevel(2);
	}

	public void LoadSceneEarth()
	{
		Debug.Log("Setting initial elemental type to earth.");

		GameManager.Instance.initialElement = GameManager.ElementalType.Earth;

		GameManager.Instance.currentStage = 1;

		Application.LoadLevel(2);
	}

	public void LoadSceneFire()
	{
		Debug.Log("Setting initial elemental type to fire.");

		GameManager.Instance.initialElement = GameManager.ElementalType.Fire;

		GameManager.Instance.currentStage = 1;

		Application.LoadLevel(2);
	}

	public void LoadSceneWater()
	{
		Debug.Log("Setting initial elemental type to water.");

		GameManager.Instance.initialElement = GameManager.ElementalType.Water;

		GameManager.Instance.currentStage = 1;

		Application.LoadLevel(2);
	}

	public override void StartMiniGames(GameManager.ElementalType game1, GameManager.ElementalType game2 = GameManager.ElementalType.None)
	{

	}
}
