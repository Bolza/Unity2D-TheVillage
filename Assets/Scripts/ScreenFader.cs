using UnityEngine;
using System.Collections;

public class ScreenFader : MonoBehaviour {
	Animator anim;
	bool isFading = false;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}

	public IEnumerator FadeIn() {
		isFading = true;
		anim.SetTrigger ("FadeIn");
		while (isFading) {
			yield return null;
		}
	}

	public IEnumerator FadeOut() {
		isFading = true;
		anim.SetTrigger ("FadeOut");
		while (isFading) {
			yield return null;
		}
	}

	// Update is called once per frame
	void AnimationComplete () {
		isFading = false;
	}
}
