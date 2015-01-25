using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EarthMiniGameTimeManager : MonoBehaviour {

	private Time 				mTime;

	public Text 				textSeconds;
	public Text					textMiliseconds;

	public float time;
	
	
	void Update () {
		
		time -= Time.deltaTime;
		
		int minutes = (int) time / 60;
		int seconds = (int) time % 60;
		int fraction = (int) (time * 100) % 100;
		
//		if (time>0)

			//displaying in the 3Dtext
			textSeconds.text = string.Format ("{0:00}:{1:00}", (60 + seconds), (100 + fraction - 1)); 



		
	}


	// Use this for initialization
	void Start () {
		mTime = new Time ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

//		float timeSecondsValue = 30 - Time.;
//		textSeconds.text = timeSecondsValue.ToString();
//
//		float textMilisecondsValue = Time.fixedTime;
//		textMiliseconds.text = textMilisecondsValue.ToString();

	}
}
