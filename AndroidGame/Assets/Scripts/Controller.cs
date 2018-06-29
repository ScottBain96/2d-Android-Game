using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour {

	public Rigidbody2D rb;

	//speedX can be edited easily outside of the editor in the Players Controller script.
	public float speedX = 5;
	bool facingRight = true;
	Animator m_animator;


	// Use this for initialization
	void Start () {

		//Setting up Rigidbody and Animator

		rb = GetComponent<Rigidbody2D> ();
		m_animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame

	void FixedUpdate () {


		if (CrossPlatformInputManager.GetButtonDown("Jump") == true) {
			m_animator.SetBool ("isJump", true);
			rb.velocity = new Vector2 (rb.velocity.x, 5);
		}
		else {

			m_animator.SetBool ("isJump", false);
			//m_animator.SetBool ("isAttack1", false);
		}



		//Movement with left/Right Buttons

		if (CrossPlatformInputManager.GetButton ("Left") == true) {
			if (transform.rotation != Quaternion.Euler (0, 180, 0))
				transform.rotation = Quaternion.Euler (0, 180, 0);

			rb.velocity = new Vector2 (-speedX, rb.velocity.y);
		
			m_animator.SetBool ("isWalking", true);
		} else
			m_animator.SetBool ("isWalking", false);

		if (CrossPlatformInputManager.GetButton ("Right") == true) {
			if (transform.rotation != Quaternion.Euler (0, 0, 0))
				transform.rotation = Quaternion.Euler (0, 0, 0);

			rb.velocity = new Vector2 (speedX, rb.velocity.y);
	
			m_animator.SetBool ("isWalking", true);
		} else {

			m_animator.SetBool ("isWalking", false);
		}

		//Attacking with Attack Button and setting animator boolean

		if (CrossPlatformInputManager.GetButtonDown("Attack") == true) {
			m_animator.SetBool ("isAttack1", true);

		}
		else {
			m_animator.SetBool ("isAttack1", false);
		}

	}





}


