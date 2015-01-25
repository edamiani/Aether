using UnityEngine;
using System.Collections;

public class AirMinigameBlockPosition : MonoBehaviour {

	public Transform blockPoint;
	public GameObject goal;

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
			Debug.Log("ooook") ;
			isAdded = true;
		}
		else
		{
//			DestroyImmediate(blockPoint, true);
			Debug.Log("NOTTTTT ooook") ;
			isAdded = false;
		}

	}
}

