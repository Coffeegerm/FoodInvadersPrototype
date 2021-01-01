using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
	public float xRange = 10;

	public float hInput;
	public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (transform.position.x < -xRange)
		{
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}
		// get left right arrow feedback, -1 - 1
		hInput = Input.GetAxis("Horizontal");
		// translate model right by hInput with time and speed
		transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);
    }
}
