using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNDestroyback : MonoBehaviour {
	translate trSqr;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		int _speed = trSqr.SpeedBorovs;
		_speed = Random.Range (7, 15);
		Vector2 position = transform.position;
		position = new Vector2 (position.x - _speed * Time.deltaTime, position.y);
		transform.position = position;
		Destroy (gameObject, 3f);
	}
}
