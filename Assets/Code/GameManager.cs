using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public int test;

	public static GameManager	Instance; 

	public class Score
	{
		public int air;
		public int earth;
		public int fire;
		public int water;
	}

	public enum ElementalType : int
	{
		Air		= 0,
		Earth	= 1,
		Fire	= 2,
		Water	= 3,
		Aether	= 4,
		
		None
	}

	public ElementalType		currentElement { get { return mCurrentElement; } set { mCurrentElement = value; } }
	public ElementalType[]		currentMiniGames { get { return mCurrentMiniGames; } }
	public int					currentStage { get { return mCurrentStage; } set { mCurrentStage = value; } }
	public ElementalType		initialElement { get { return mInitialElement; } set { mInitialElement = value; } }
	public ElementalType		leftElement { get { return mLeftElement; } set { mLeftElement = value; } }
	public ElementalType		pathChosen { get { return mPathChosen; } set { mPathChosen = value; } }
	public ElementalType		previousElement { get { return mPathChosen; } set { mPreviousElement = value; } }
	public ElementalType		rightElement { get { return mRightElement; } set { mRightElement = value; } }
	public Score				score { get { return mScore; } }

	private ElementalType		mCurrentElement;
	private ElementalType[]		mCurrentMiniGames = new ElementalType[2];
	private int					mCurrentStage = 1;
	private ElementalType		mInitialElement;
	private ElementalType		mLeftElement;
	private ElementalType		mPathChosen;
	private ElementalType		mPreviousElement;
	private ElementalType		mRightElement;
	private Score				mScore = new Score();

	public void StartScene(int sceneId, ElementalType elementalType)
	{
		if(sceneId == 2)
		{
			mInitialElement = elementalType;
		}

		Application.LoadLevel(sceneId);
	}

	void Awake () 
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

	public void LoadMiniGames(ElementalType miniGame1, ElementalType miniGame2 = ElementalType.None)
	{
		MiniGameManager.Instance.LoadMiniGames(miniGame1, miniGame2);
	}
}
