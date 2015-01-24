using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour 
{
	private static InputManager Instance;

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
		if(Input.GetKeyUp(KeyCode.Return))
		{
			if(Application.loadedLevel == 0)
			{
				Application.LoadLevel(1);
			}
			else
			{
				Application.LoadLevel(0);
			}
		}
	}
}
