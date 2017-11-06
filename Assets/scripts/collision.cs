using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
	public int _shtuki = 0;
	public int _score = 0;
	public TextMesh scoreLabel;
	[SerializeField] private TextMesh shtuki;



	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Item") 
		{
			Podschet ();
		}
	}
	void Podschet()
	{
		_shtuki += 1;
		shtuki.text = _shtuki.ToString ();
	}

}
