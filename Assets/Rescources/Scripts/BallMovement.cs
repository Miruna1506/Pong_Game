using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	public float movementSpeed;
	public float extraSpeedPerHit;
	public float maxExtraSpeed;
	int hitCounter = 0;
	// Use this for initialization
	void Start () {
		StartCoroutine(this.StartBall());
	}
	//pozitionarea mingii cand unul dintre jucatori marcheaza
	void PositionBall(bool isStartingPlayer1)
	{
		this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		if (isStartingPlayer1)
		{
			this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);//pun mingea in stanga
		}
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);//pun mingea in dreapta
        }
    }
	//corutina care pozitioneaza mingea, asteapta si apoi o lanseaza
	public IEnumerator StartBall(bool isStartingPlayer1 = true)
	{
		this.PositionBall(isStartingPlayer1);

		this.hitCounter = 0;
		yield return new WaitForSeconds(2);

		//in functie de care jucator incepe lansez mingea in directia sa
		if (isStartingPlayer1)
		{
			this.MoveBall(new Vector2(-1, 0));//mingea se va misca la stanga
		}
		else
		{
			this.MoveBall(new Vector2(1,0));
		}
	}
	public void MoveBall(Vector2 dir)
	{
		dir = dir.normalized;//normalizez directia

		float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

		Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();// Obtin componenta Rigidbody2D a obiectului pentru a-i putea modifica viteza

        rigidbody2D.velocity = dir * speed;//inmultim componentele vectorului cu viteza pt. a obtine viteza pe fiecare axa
    }
	public void IncreaseHitCounter()
	{
		if(this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed)
		{
			this.hitCounter++;
		}
	}
}
