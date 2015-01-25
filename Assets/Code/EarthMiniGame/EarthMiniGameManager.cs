using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EarthMiniGameManager : MonoBehaviour {

	public static EarthMiniGameManager Instance;

	private static int 			MAX_ENEMIES = 9;
	private static int			POINT_ON_CLICK_ENEMY = 10;
	private static int			POINT_ON_CLICK_ALLY = 10;

	public Enemy[]				enemies = new Enemy[MAX_ENEMIES];

	private float 				timerToRespawn;
	private float 				waitingTimeToRespawn = 0.5f;

	private float				waitingTimeToHide = 1;

	public int					mPoints = 0;
	private int					points { get { return mPoints; } }

	public EarthMiniGameTimeManager timeManager;

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
			enemyToRespawn.Respawn(this.waitingTimeToHide);
			return true;
		}
		return false;
	}

	public void EnemyCliked() {
		mPoints += POINT_ON_CLICK_ENEMY;
		Debug.Log (points);
	}
}
