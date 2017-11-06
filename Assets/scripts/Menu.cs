using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
//	public Animator anim;
	[SerializeField] private GameObject levels;
	void Start()
	{
//		anim.GetComponent<Animator> ();
	}

	public void LaunchGame()
	{
		levels.SetActive (false);
		SceneManager.LoadScene (1);
		Time.timeScale = 1f;

	}
	public void OnMenu()
	{
		SceneManager.LoadScene (0);
	}
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
	public void QuitApp()
	{
		Application.Quit ();
	}
	public void Pause()
	{
		Time.timeScale = 0f;
	}
	public void Resume()
	{
		Time.timeScale = 1f;
	}
	public void OnClickButton()
	{
		
	//if (levels.activeInHierarchy)
			return;
	//	DontDestroyOnLoad (gameObject);
	//	anim.SetTrigger ("click");

	}
	public void Level2()
	{
		levels.SetActive (false);
		SceneManager.LoadScene (2);
		Time.timeScale = 1f;
	}
}
