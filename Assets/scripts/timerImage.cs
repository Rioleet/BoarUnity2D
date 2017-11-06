using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerImage : MonoBehaviour {
	public float MaxTime;
	public float CurrentTime;
	public float IncreaseT = 1f;

	[SerializeField] GameObject gameOver;
	[SerializeField] GameObject gameWin;
	[SerializeField] GameObject winScore;
	[SerializeField] translate trsrpt;
	[SerializeField] translate trscrpt;
	public collision colRef;
	public Tap tapRef;
	public GameObject triggerRef;

	// Use this for initialization
	void Start () {
		CurrentTime = MaxTime;
//		trsrpt.GetComponent<translate> ();
	}

	void Update () {
		CurrentTime -= IncreaseT * Time.deltaTime;	
		transform.localScale = new Vector3 ((CurrentTime / MaxTime), 1, 1);
		if (CurrentTime <= 0) {
//			trsrpt.GameOver ();
			trscrpt.GameOver ();
			winScore.SetActive (true);
			Destroy (tapRef);
			Destroy (triggerRef);
			if (colRef._score == colRef._shtuki) {
				ConditionToWin ();
			} else {
				gameOver.SetActive (true);
			}
		}

	}
	void ConditionToWin()
		{
			gameWin.SetActive (true);
		}
}
