using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	Animator anim;
	SpriteRenderer sprite;

	// Start is called before the first frame update
	void Start()
    {
		anim = GetComponent<Animator>();
		sprite = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
    {
		// Input.GetAxis takes input from the keyboard
		// Time.deltaTime gives the time interval in seconds from the last frame to the current one. This makes the player movement device independent.
		float posupdate = Input.GetAxis("Horizontal") * Time.deltaTime * 6f;
		transform.position += new Vector3(posupdate, 0, 0);

		// disable Animator when no key is pressed
		if (posupdate == 0)
		{
			anim.enabled = false;
		}
		// Flip player when moving in the opposite direction
		else if (posupdate < 0)
		{
			anim.enabled = true;
			sprite.flipX = true;
		}
		else
		{
			anim.enabled = true;
			sprite.flipX = false;
		}
	}
}
