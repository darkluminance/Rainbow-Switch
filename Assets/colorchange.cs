using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class colorchange : MonoBehaviour {

	public int score = 0, highscore;

	public Rigidbody2D rbd;

	public Text scoreText, highscoretext;

	public SpriteRenderer SR ;

	public GameObject gameover;

	public AudioSource hit, ded;
	// Use this for initialization
	void Start () {
		int i = Random.Range(0,6);
			if( i == 0){
				gameObject.tag = "Red";
				SR.color = Color.red;
			}else if( i == 1){
				gameObject.tag = "Blue";
				SR.color = Color.cyan;
			}else if( i == 2){
				gameObject.tag = "Green";
				SR.color = new Color(0,0.5725490196078431f,0.27f);
			}else if( i == 3){
				gameObject.tag = "Yellow";
				SR.color = Color.yellow;
			}else if( i == 4){
				gameObject.tag = "Orange";
				SR.color = new Color(1,.5f,0);
			}else if( i == 5){
				gameObject.tag = "Violet";
				SR.color = new Color(1,0,1);
			}else if( i == 6){
				gameObject.tag = "Indigo";
				SR.color = new Color(0.1f,0.0784313725490196f,0.4f);
			}

		highscore = PlayerPrefs.GetInt("highscore", highscore);

		scoreText.text = "Score: " + score;
		highscoretext.text = "Highscore: " + highscore;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (score > highscore)
		{
			highscore = score;
			PlayerPrefs.SetInt("highscore", highscore);
		}
		scoreText.text = "Score: " + score;
		highscoretext.text = "Highscore: " + highscore;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == gameObject.tag){
			int i = Random.Range(0,6);
			score++;
			hit.Play();
			if( i == 6){
				gameObject.tag = "Red";
				SR.color = Color.red;
			}else if( i == 2){
				gameObject.tag = "Blue";
				SR.color = Color.cyan;
			}else if( i == 3){
				gameObject.tag = "Green";
				SR.color = new Color(0,0.5725490196078431f,0.27f);
			}else if( i == 4){
				gameObject.tag = "Yellow";
				SR.color = Color.yellow;
			}else if( i == 5){
				gameObject.tag = "Orange";
				SR.color = new Color(1,.5f,0);
			}else if( i == 0){
				gameObject.tag = "Violet";
				SR.color = new Color(1,0,1);
			}else if( i == 1){
				gameObject.tag = "Indigo";
				SR.color = new Color(0.1f,0.0784313725490196f,0.4f);
			}
		}else {			
			gameover.SetActive(true);
			ded.Play();
		}
	}

	
}
