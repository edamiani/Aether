using System;
using System.Collections.Generic;
using UnityEngine;

class SceneManagerAether : SceneManager
{
	public FadeScreen fade;

	void Awake()
	{
		Debug.Log("Game Over!!!");
		Invoke ("FadeOutNow", 5f);
	}

	public void FadeOutNow ()
	{
		fade.FadeOut ();
	}

	public override void LoadScene(int sceneId)
	{

	}

	void Update()
	{

	}
}
