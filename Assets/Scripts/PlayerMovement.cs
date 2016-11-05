using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 2f;
	Rigidbody2D rb2d;
	Animator anim;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 movement = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		if (movement != Vector2.zero) {
			anim.SetBool ("isWalking", true);
			anim.SetFloat ("inputX", movement.x);
			anim.SetFloat ("inputY", movement.y);
		} else {
			anim.SetBool ("isWalking", false);
		}

		rb2d.MovePosition (rb2d.position + movement * Time.deltaTime * speed);
	}
}
