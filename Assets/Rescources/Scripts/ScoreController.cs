using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreController : MonoBehaviour {
	private int scorePlayer1 = 0;
	private int scorePlayer2 = 0;

	//legatura cu Ui-ul
	public GameObject scoreTextPlayer1; 
	public GameObject scoreTextPlayer2;

	public int goalToWin;
	
	// Update is called once per frame
	void Update () {
		if (this.scorePlayer1 >= this.goalToWin || this.scorePlayer2 >= this.goalToWin) {
			SceneManager.LoadScene("GameOver");
		}
	}
	private void FixedUpdate()
	{
		Text uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<Text>(); //extragerea componentei Text din UI folosind metoda generica GetComponent
		uiScorePlayer1.text = this.scorePlayer1.ToString(); //pun scorul pe ecran

        Text uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }
	public void GoalPlayer1()
	{
		this.scorePlayer1++;
	}
    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }
}
