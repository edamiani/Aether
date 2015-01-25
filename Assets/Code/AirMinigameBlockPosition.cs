using UnityEngine;
using System.Collections;

public class AirMinigameBlockPosition : MonoBehaviour {

	public Transform blockPoint;
	//public GameObject goal;

	bool isAdded = false;
	
	void OnMouseUp()
	{
		// call method that creates a 'path blocker'
		AddPathBlocker ();
	}

	void OnMouseOver()
	{
		//Debug.Log ("OnMouseOver");
	}

	// Add a 'pathblocker' to the navmesh
	void AddPathBlocker()
	{
		if (!isAdded)
		{
			Vector3 v3 = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
			Transform block = Instantiate(blockPoint, v3, Quaternion.identity) as Transform;
			//Debug.Log(this.blockPoint.gameObject.GetComponent<NavMeshObstacle>());
			//NavMeshAgent block = this.gameObject.AddComponent("NavMeshAgent") as NavMeshAgent;  // .gameObject.AddComponent("NavMeshAgent") as NavMeshAgent;

			Debug.Log("ok");
			isAdded = true;
		}
		else
		{
//			Destroy(blockPoint.gameObject);
//			Destroy(this.blockPoint.gameObject.GetComponent<NavMeshObstacle>());
			blockPoint.position = new Vector3(0, 0, 0);
			Debug.Log(transform.position.x);
			Debug.Log(blockPoint.position);
            

			Debug.Log("NOTTTTT ooook") ;
			isAdded = false;
		}

	}
}

