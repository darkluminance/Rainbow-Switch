using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour {

	public Text gameovertext;

	public GameObject playerexplode, player, superHeptagon, restbut;
	private bool rest = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(gameOver());
	}

	private void Update()
	{
		if (rest)
		{
			if(Input.GetKeyDown(KeyCode.Space)) restartgame();
		}
	}

	IEnumerator gameOver(){
			Instantiate(playerexplode, player.transform.position, Quaternion.identity);
			player.gameObject.SetActive(false);
			yield return new WaitForSeconds(2);
			superHeptagon.SetActive(false);
			gameovertext.text = "GameOver. Press <this> to restart";
			restbut.SetActive(true);
			rest = true;

	}

	public void restartgame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
