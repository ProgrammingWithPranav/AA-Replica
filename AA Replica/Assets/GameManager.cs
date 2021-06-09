using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private bool gameHasEnded = false;

	public Rotator rotator;
	public Spawner spawner;

	public Animator animator;

    public void EndGame()
	{
		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger("EndGame");

		gameHasEnded = true;
		Debug.Log("End Game");  
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
