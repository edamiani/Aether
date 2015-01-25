using System;
using System.Collections.Generic;
using UnityEngine;

abstract class SceneManager : MonoBehaviour
{
	public abstract void LoadScene(int sceneId);

	public virtual void StartMiniGames(GameManager.ElementalType game1, GameManager.ElementalType game2 = GameManager.ElementalType.None) { }

	void Update()
	{

	}
}
