﻿using System;
using System.Collections.Generic;
using UnityEngine;

class SceneManagerAether : SceneManager
{
	public FadeScreen fade;

	void Awake()
	{
		Debug.Log("Game Over!!!");
		//Invoke ("FadeOutNow", 25f);
	}

	public void FadeOutNow ()
	{
		//fade.FadeOut(1, 1, 1, 0);
	}

	public override void LoadScene(int sceneId)
	{

	}

	void Update()
	{

	}
}
