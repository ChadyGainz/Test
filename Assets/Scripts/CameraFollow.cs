using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour {
	// The thing which this camera follows.
	public GameObject Target;

	// How far the camera is above the target
	public float Distance = 5;

	private void Update() {
		this.transform.position = Target.transform.position;
		this.transform.position = this.transform.position + new Vector3(0, Distance, 0);
	}
}
