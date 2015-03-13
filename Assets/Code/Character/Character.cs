using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	private float maxSpeed = 20f;

	private bool facingLeft = true;

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		
		float moveX = Input.GetAxis ("Horizontal");
//		changes from unity4 to unity5
//		rigidbody2D.velocity= new Vector2 (moveX * maxSpeed, rigidbody2D.velocity.y);
		GetComponent<Rigidbody2D>().velocity= new Vector2 (moveX * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		anim.SetFloat ("Speed", Mathf.Abs (moveX));

		if(moveX < 0 && !facingLeft) {
			Flip();
		}
		else {
			if(moveX  > 0 && facingLeft) {
				Flip();
			}
		}

	}

	void Flip() {
		facingLeft = !facingLeft;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
