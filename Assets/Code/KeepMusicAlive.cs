using UnityEngine;
using System.Collections;

public class KeepMusicAlive : MonoBehaviour 
{
	public static KeepMusicAlive Instance;

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
}
