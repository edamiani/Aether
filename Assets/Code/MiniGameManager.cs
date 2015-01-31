using UnityEngine;
using System.Collections;

public class MiniGameManager : MonoBehaviour 
{
	public static MiniGameManager Instance;

	public bool isRunning { get { return mIsRunning; } }
	public bool hasFinished { get { return mHasFinished; } }
	public bool hasSucceeded { get { return mHasSucceeded; } }

	private bool mIsRunning;
	private bool mHasFinished;
	private bool mHasSucceeded;

	/******************** Public methods *********************/
	public void LoadMiniGames(GameManager.ElementalType miniGame1, GameManager.ElementalType miniGame2 = GameManager.ElementalType.None)
	{
		mIsRunning = true;

		// Stub code
		mHasSucceeded = true;
		Debug.Log("Player won all minigames!");

		GameManager.Score score = GameManager.Instance.score;

		switch(miniGame1)
		{
			case GameManager.ElementalType.Air:
				Debug.Log("Adding air score...");
				score.air++;
				break;

			case GameManager.ElementalType.Earth:
				Debug.Log("Adding earth score...");
				score.earth++;
				break;

			case GameManager.ElementalType.Fire:
				Debug.Log("Adding fire score...");
				score.fire++;
				break;

			case GameManager.ElementalType.Water:
				Debug.Log("Adding water score...");
				score.water++;
				break;

			default:
				break;
		}

		if(miniGame2 != GameManager.ElementalType.None)
		{
			switch(miniGame2)
			{
				case GameManager.ElementalType.Air:
					Debug.Log("Adding air score...");
					score.air++;
					break;

				case GameManager.ElementalType.Earth:
					Debug.Log("Adding earth score...");
					score.earth++;
					break;

				case GameManager.ElementalType.Fire:
					Debug.Log("Adding fire score...");
					score.fire++;
					break;

				case GameManager.ElementalType.Water:
					Debug.Log("Adding water score...");
					score.water++;
					break;

				default:
					break;
			}
		}

		mHasFinished = true;

		Debug.Log("Current score:  Air - " + score.air + "; Earth - " + score.earth + "; Fire - " + score.fire + ", Water - " + score.water);
	}

	public void Reset()
	{
		mIsRunning = false;
		mHasFinished = false;
		mHasSucceeded = false;
	}

	/******************** Private methods *********************/
	void Awake()
	{
		if(Instance == null)
		{
			//If I am the first instance, make me the Singleton
			Instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			//If a Singleton already exists and you find
			//another reference in scene, destroy it!
			if(this != Instance)
			{
				Destroy(this.gameObject);
			}
		}
	}

	void Update()
	{
	}
}
