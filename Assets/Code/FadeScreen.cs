using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class FadeScreen : MonoBehaviour 
{
	Image img;
	private float duration = .5f;

	void Awake() 
	{
		img = GetComponent<Image>();
		FadeIn(1, 1, 1, 1);
	}
	
	public void FadeOut(int red, int green, int blue, int alpha)
	{
		img.color = new Color(red, green, blue, alpha);
		img.DOFade(1, duration);
	}

	public void FadeIn(int red, int green, int blue, int alpha)
	{
		img.color = new Color(red, green, blue, alpha);
		img.DOFade(0, duration);
	}
}

