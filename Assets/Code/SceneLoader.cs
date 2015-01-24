using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void LoadScene(int elementalType)
	{
		GameManager.Instance.initialElement = (GameManager.ElementalType) elementalType;

		GameManager.Instance.test = elementalType;

		Application.LoadLevel(2);
	}
}
