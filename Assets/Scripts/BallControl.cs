using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

	private Rigidbody2D rigidbody2d;
	private AudioSource audioSource;


	// Use this for initialization
	void Start()
	{
		rigidbody2d = GetComponent<Rigidbody2D>();
		audioSource = GetComponent<AudioSource>();
		Invoke("AddStartingForce", 1.5f);
	}

	public void ResetPosition()
	{
		rigidbody2d.velocity = Vector2.zero;
		rigidbody2d.position = Vector2.zero;
	}

	public void AddStartingForce()
	{
		// Flip a coin to determine if the ball starts left or right
		float x = Random.value < 0.5f ? -1f : 1f;

		// Flip a coin to determine if the ball goes up or down. Set the range
		// between 0.5 -> 1.0 to ensure it does not move completely horizontal.
		float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
									  : Random.Range(0.5f, 1f);

		Vector2 direction = new Vector2(x, y);
		rigidbody2d.AddForce(direction * 10);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.CompareTag("Player"))
		{
			Vector2 vel;
			vel.x = rigidbody2d.velocity.x;
			vel.y = (rigidbody2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
			rigidbody2d.velocity = vel;
			audioSource.Play();
		}
	}

}