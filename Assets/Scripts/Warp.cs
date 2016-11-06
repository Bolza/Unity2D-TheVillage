using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	public bool inTransition = false;

	void Awake() {
		
	}
	IEnumerator OnTriggerEnter2D (Collider2D other) {
		if (inTransition == false) {
			other.GetComponent<PlayerMovement>().freeze = true;
			ScreenFader af = GameObject.FindWithTag ("Fader").GetComponent<ScreenFader> ();
			yield return StartCoroutine (af.FadeOut ());
			

			target.GetComponent<Warp>().inTransition = true;
			other.gameObject.transform.position = target.position;
			Camera.main.transform.position = target.position;

			yield return StartCoroutine (af.FadeIn ());
		}
			
	}
	void OnTriggerExit2D(Collider2D other) {
		inTransition = false;
		other.GetComponent<PlayerMovement>().freeze = false;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
