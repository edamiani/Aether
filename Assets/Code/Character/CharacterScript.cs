using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

	private Animator anim;

	private bool facingLeft = true;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveX = Input.GetAxis ("Horizontal");  

	
		if(moveX < 0) {
			anim.SetTrigger("JumpLeft");
		}
		else {
			if(moveX  > 0) {
				anim.SetTrigger("JumpRight");
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
