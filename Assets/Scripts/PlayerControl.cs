using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerControl : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed;
    public float boundY;
    private Rigidbody2D rb2D;
  

	private void Awake()
	{
        rb2D = GetComponent<Rigidbody2D>();
    }

	void Update()
    {
        Vector2 velocity = rb2D.velocity;
        if(Input.GetKey(moveUp))
        {
            velocity.y = speed;
		}
        else if(Input.GetKey(moveDown))
		{
            velocity.y = -speed;
		}
        else
		{
            velocity.y = 0;
		}
        rb2D.velocity = velocity;

        Vector2 pos = transform.position;
		if(pos.y > boundY)
		{
            pos.y = boundY;
		}
        if(pos.y < -boundY)
		{
            pos.y = -boundY;
		}
        transform.position = pos;

    }
}
