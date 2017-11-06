using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNDestroy : MonoBehaviour {
	translate trSqr;
	int _speed = 15;
//	int speedBor;
//	public int SpeedBorovs = 15;
	// Use this for initialization
	void Start () {
	//	speedBor = trSqr.SpeedBorovs;
	}
	
	// Update is called once per frame
	void Update () 
	{

		_speed = Random.Range (5, _speed);
		Vector2 position = transform.position;
		position = new Vector2 (position.x + _speed * Time.deltaTime, position.y);
		transform.position = position;
		Destroy (gameObject, 3f);
	}
}
