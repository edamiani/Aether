using UnityEngine;
using System.Collections;

public class AudioSingleton : MonoBehaviour 
{
	public static AudioSingleton Instance;

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
	void Update () {
	
	}
}
