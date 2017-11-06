using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {
	public collision colReference;
	[SerializeField] private AudioSource tapSound;

	public void OnMouseUp()
		{
			colReference._score++;
			colReference.scoreLabel.text = colReference._score.ToString ();
			tapSound.Play ();
		}
}