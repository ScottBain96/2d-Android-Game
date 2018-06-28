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
		
		bool isAttackPress1 = CrossPlatformInputManager.GetButtonDown ("Jump");
		//if (CrossPlatformInputManager.GetButtonDown ("Jump")) {


			m_animator.SetBool ("isAttack1", isAttackPress1);


		//} else {

		//	m_animator.SetBool ("isAttack1", false);
		//}




		//TO MOVE
		//rb.velocity = new Vector2 (speedX, rb.velocity.y);



		//if (Input.GetMouseButtonDown (0)) {
			//m_animator.SetBool("isWalking", true);
			//rb.velocity = new Vector2 (rb.velocity.x, 6);

		}
	}
//}
