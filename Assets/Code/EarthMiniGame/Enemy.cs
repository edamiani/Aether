using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private float 					timeToHide = 0;
	private float					waitingTimeToHide;

	private bool					mRespawned = false;
	public bool						respawned { get { return mRespawned; } }

	private EarthMiniGameManager		earthMiniGameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CanHide ();
	}

	private void CanHide() {

		if (this.mRespawned) {
			timeToHide += Time.deltaTime;
			if(this.timeToHide > this.waitingTimeToHide){
				this.Hide();
				timeToHide = 0;
			}
		}
	}

	public void Hide() {
		this.renderer.enabled = false;
		this.mRespawned = false;
	}

	public void Respawn(float waitingTimeToHide) {
		this.renderer.enabled = true;
		this.waitingTimeToHide = waitingTimeToHide;
		this.mRespawned = true;
	}

	void OnMouseDown() {
		CheckClick ();
	}

	private void CheckClick() {
		if (mRespawned) {
			EarthMiniGameManager.Instance.EnemyCliked();
		}
	}
}


