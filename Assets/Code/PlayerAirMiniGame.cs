using UnityEngine;
using System.Collections;

public class PlayerAirMiniGame : MonoBehaviour {

	public Transform playerGoal;
	private NavMeshAgent navComponent;

	// Use this for initialization
	void Start () 
	{
		navComponent = this.transform.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (playerGoal)
		{
			navComponent.SetDestination(playerGoal.position);
		}
	}
}

