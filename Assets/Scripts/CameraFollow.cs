using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform target;
	public Camera cam;
	public int pixelPerUnit = 32;
	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
	}

	// Update is called once per frame
	void Update () {
		cam.orthographicSize = Screen.height / pixelPerUnit / 4;
		if (target) {
			Vector3 z = new Vector3 (0, 0, -1);
			transform.position = Vector3.Lerp (transform.position, target.position, 0.1f) + z;
		}
	}
}
