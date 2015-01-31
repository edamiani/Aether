using UnityEngine;
using System.Collections;

public class InputManagerSplashScreen : MonoBehaviour 
{
	// Use this for initialization
	void Awake()
	{
	}
	
	// Update is called once per frame
	void Update() 
	{
		if(Input.GetKeyUp(KeyCode.Return))
		{
			Application.LoadLevel(1);
		}
	}
}
