using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public int test;

	public static GameManager	Instance;

	public struct Score
	{
		int air;
		int earth;
		int fire;
		int water;
	}

	public enum ElementalType : int
	{
		Air = 0,
		Earth = 1,
		Fire = 2,
		Water = 3,
		Aether = 4,
		
		None
	}

	public ElementalType		initialElement { get { return mInitialElement; } set { mInitialElement = value; } }
	public Score				score { get { return mScore; } }

	private ElementalType		mInitialElement;
	private Score				mScore;

	// Use this for initialization
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
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void LoadMiniGame(ElementalType game1, ElementalType game2 = ElementalType.None)
	{
		
	}
}
