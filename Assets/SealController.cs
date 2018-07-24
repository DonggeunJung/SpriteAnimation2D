using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealController : MonoBehaviour {
	Rigidbody2D rb2d;
	Animator animator;

	public float maxHeight;
	public float flapVelocity;
	public GameObject sprite;

	void Awake() {
		rb2d = GetComponent<Rigidbody2D>();
		animator = sprite.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		// Get input when unless max height
		if (Input.GetButtonDown ("Fire1") && transform.position.y < maxHeight) {
			Flap ();
		}

		bool bFly = false;
		if (rb2d.velocity.y > 0)
			bFly = true;
		animator.SetBool("flap", bFly);
	}

	void Flap() {
		// Accelerate to up side
		rb2d.velocity = new Vector2(0.0f, flapVelocity);
	}
}
