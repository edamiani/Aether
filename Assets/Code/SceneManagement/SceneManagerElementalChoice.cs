using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class SceneManagerElementalChoice : SceneManager
{
	void Awake()
	{
		GameManager gameManager = GameManager.Instance;

		gameManager.currentElement = gameManager.initialElement;

		GameObject aetherButton = GameObject.FindGameObjectWithTag("AetherButton");

		aetherButton.GetComponent<Button>().interactable = false;

		if(gameManager.score.air != 0 ||
		   gameManager.score.earth != 0 ||
		   gameManager.score.fire != 0 ||
		   gameManager.score.water != 0)
		{
			// Calculate statistics
			float total = gameManager.score.air + gameManager.score.earth + gameManager.score.fire + gameManager.score.water;

			float airRatio = gameManager.score.air / total;
			float earthRatio = gameManager.score.earth / total;
			float fireRatio = gameManager.score.fire / total;
			float waterRatio = gameManager.score.water / total;

			Debug.Log(airRatio + "  " + earthRatio + "  " + fireRatio + "  " + waterRatio);

			if(Around(airRatio, 0.245f, 0.255f) && Around(earthRatio, 0.245f, 0.255f) && Around(fireRatio, 0.245f, 0.255f) && Around(waterRatio, 0.245f, 0.255f))
			{
				aetherButton.GetComponent<Button>().interactable = true;
			}
		}
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

	public void LoadSceneAether()
	{
		Debug.Log("Moving to the aether...");

		Application.LoadLevel(5);
	}

	public override void StartMiniGames(GameManager.ElementalType game1, GameManager.ElementalType game2 = GameManager.ElementalType.None)
	{

	}

	private bool Around(float value, float min, float max)
	{
		return (value > min && value < max);
	}
}
