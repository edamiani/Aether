using UnityEngine;
using System.Collections;

public class EarthMiniGameManager : MonoBehaviour {

	private static int 	MAX_ENEMIES = 9;

	public Enemy[]		enemies = new Enemy[MAX_ENEMIES];

	private float 		timerToRespawn;
	private int 		waitingTimeToRespawn = 2;

	private int			timeToHide = 2;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.CanRespawnEnemy ();
	
	}

	private void CanRespawnEnemy() {
		timerToRespawn += Time.deltaTime;
		if(timerToRespawn > waitingTimeToRespawn){
			bool isEnemyRespawned = this.TryRespawnRandomEnemy();
			if(isEnemyRespawned) {
				timerToRespawn = 0;
			}
		}
	}

	private bool TryRespawnRandomEnemy() {
		int indexRandomEnemy = Random.Range(0, MAX_ENEMIES);
		Enemy enemyToRespawn = enemies [indexRandomEnemy];
		if (!enemyToRespawn.respawned) {
			enemyToRespawn.Respawn(timeToHide);
			return true;
		}
		return false;

	}
}
