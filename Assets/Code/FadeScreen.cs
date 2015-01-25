using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class FadeScreen : MonoBehaviour 
{
	
	Image img;
	public float duration = 2f;

	void Awake () 
	{
		img = GetComponent<Image>();
		img.color = new Color(0, 0, 0, 1);
		FadeIn ();
	}
	
	public void FadeOut()
	{
		img.color = new Color(1, 1, 1, 0);
		img.DOFade(1, duration);
	}
	
	public void FadeIn()
	{
		img.DOFade(0, duration);
	}
}

