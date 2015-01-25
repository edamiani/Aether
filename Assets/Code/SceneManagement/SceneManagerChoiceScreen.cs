using System;
using System.Collections.Generic;
using UnityEngine;

class SceneManagerChoiceScreen : SceneManager
{
	public FadeScreen fade;

	private SpriteRenderer mSprBgLeftFire;
	private SpriteRenderer mSprBgLeftAir;
	private SpriteRenderer mSprBgRightWater;
	private SpriteRenderer mSprBgRightEarth;

	private SpriteRenderer mSprGateLeftFireAir;
	private SpriteRenderer mSprGateLeftFireEarth;
	private SpriteRenderer mSprGateLeftWaterAir;
	private SpriteRenderer mSprGateLeftWaterEarth;
	private SpriteRenderer mSprGateRightFireAir;
	private SpriteRenderer mSprGateRightFireEarth;
	private SpriteRenderer mSprGateRightWaterAir;
	private SpriteRenderer mSprGateRightWaterEarth;

	private int mTempSceneId;

	void Awake()
	{
		fade.FadeIn(0, 0, 0, 1);

		mSprBgLeftAir = GameObject.Find("spr_bg_left_air").GetComponent<SpriteRenderer>();
		mSprBgLeftFire = GameObject.Find("spr_bg_left_fire").GetComponent<SpriteRenderer>();
		mSprBgRightEarth = GameObject.Find("spr_bg_right_earth").GetComponent<SpriteRenderer>();
		mSprBgRightWater = GameObject.Find("spr_bg_right_water").GetComponent<SpriteRenderer>();

		mSprGateLeftFireAir = GameObject.Find("spr_gate_left_fire_air").GetComponent<SpriteRenderer>();
		mSprGateLeftFireEarth = GameObject.Find("spr_gate_left_fire_earth").GetComponent<SpriteRenderer>();
		mSprGateLeftWaterAir = GameObject.Find("spr_gate_left_water_air").GetComponent<SpriteRenderer>();
		mSprGateLeftWaterEarth = GameObject.Find("spr_gate_left_water_earth").GetComponent<SpriteRenderer>();
		mSprGateRightFireAir = GameObject.Find("spr_gate_right_fire_air").GetComponent<SpriteRenderer>();
		mSprGateRightFireEarth = GameObject.Find("spr_gate_right_fire_earth").GetComponent<SpriteRenderer>();
		mSprGateRightWaterAir = GameObject.Find("spr_gate_right_water_air").GetComponent<SpriteRenderer>();
		mSprGateRightWaterEarth = GameObject.Find("spr_gate_right_water_earth").GetComponent<SpriteRenderer>();

		// Disable everything by default
		mSprBgLeftFire.enabled = false;
		mSprBgLeftAir.enabled = false;
		mSprBgRightWater.enabled = false;
		mSprBgRightEarth.enabled = false;

		mSprGateLeftFireAir.enabled = false;
		mSprGateLeftFireEarth.enabled = false;
		mSprGateLeftWaterAir.enabled = false;
		mSprGateLeftWaterEarth.enabled = false;
		mSprGateRightFireAir.enabled = false;
		mSprGateRightFireEarth.enabled = false;
		mSprGateRightWaterAir.enabled = false;
		mSprGateRightWaterEarth.enabled = false;

		GameManager gameManager = GameManager.Instance;

		switch(gameManager.currentElement)
		{
			case GameManager.ElementalType.Air:
				mSprBgLeftFire.enabled = true;
				mSprBgRightWater.enabled = true;

				mSprGateLeftFireAir.enabled = true;
				mSprGateRightWaterAir.enabled = true;

				break;

			case GameManager.ElementalType.Earth:
				mSprBgLeftFire.enabled = true;
				mSprBgRightWater.enabled = true;

				mSprGateLeftFireEarth.enabled = true;
				mSprGateRightWaterEarth.enabled = true;

				break;

			case GameManager.ElementalType.Fire:
				mSprBgLeftAir.enabled = true;
				mSprBgRightEarth.enabled = true;

				mSprGateLeftFireAir.enabled = true;
				mSprGateRightFireEarth.enabled = true;

				break;

			case GameManager.ElementalType.Water:
				mSprBgLeftAir.enabled = true;
				mSprBgRightEarth.enabled = true;

				mSprGateLeftWaterAir.enabled = true;
				mSprGateRightWaterEarth.enabled = true;

				break;

			default:
				break;
		}
	}

	public override void LoadScene(int sceneId)
	{
		fade.FadeOut(0, 0, 0, 0);

		mTempSceneId = sceneId;

		Invoke("DeferredLoading", .5f);
		//DeferredLoading();
	}

	public void DeferredLoading()
	{
		GameManager gameManager = GameManager.Instance;

		if(mTempSceneId == 4)
		{
			gameManager.currentElement = gameManager.pathChosen;

			switch(gameManager.currentElement)
			{
				case GameManager.ElementalType.Air:
				case GameManager.ElementalType.Earth:
					gameManager.leftElement = GameManager.ElementalType.Fire;
					gameManager.rightElement = GameManager.ElementalType.Water;
					break;

				case GameManager.ElementalType.Fire:
				case GameManager.ElementalType.Water:
					gameManager.leftElement = GameManager.ElementalType.Air;
					gameManager.rightElement = GameManager.ElementalType.Earth;
					break;

				default:
					break;
			}

			Debug.Log("Left element was set to " + gameManager.leftElement);
			Debug.Log("Right element was set to " + gameManager.rightElement);
		}

		Debug.Log("Loading level " + mTempSceneId);

		Application.LoadLevel(mTempSceneId);
	}

	void Update()
	{
		GameManager gameManager = GameManager.Instance;
		MiniGameManager miniGameManager = MiniGameManager.Instance;

		if(miniGameManager.isRunning && miniGameManager.hasFinished)
		{
			gameManager.currentStage++;
			Debug.Log("Current stage was set to " + gameManager.currentStage);

			miniGameManager.Reset();

			if(gameManager.currentStage <= 5)
			{
				LoadScene(4); // ChoiceScreen
			}
			else
			{
				LoadScene(1); // ElementalChoice
			}
		}
	}
}
