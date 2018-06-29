using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour {

	public Rigidbody2D rb;
	public float speedX;



	Animator m_animator;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		m_animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	
	
		//TO MOVE

		//rb.velocity = new Vector2 (1, rb.velocity.y);


		if (CrossPlatformInputManager.GetButtonDown("Jump") == true) {
			m_animator.SetBool ("isAttack1", true);
		
		}
		 else {
			m_animator.SetBool ("isAttack1", false);
		}
		if (Input.GetMouseButton (0) && CrossPlatformInputManager.GetButtonDown ("Jump") == false) {
			m_animator.SetBool ("isWalking", true);
			rb.velocity = new Vector2 (speedX, rb.velocity.y);

		} else {

			m_animator.SetBool ("isWalking", false);
		}


	}
}


