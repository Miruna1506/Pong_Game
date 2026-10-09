using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//detectarea coliziunilor cu paletele si peretii => schimbarea directiei mingii
public class CollisionController : MonoBehaviour {

    public BallMovement ballMovement;
    public ScoreController scoreController;
    void BounceFromRacket(Collision2D c) 
    {
        Vector3 ballPosition = this.transform.position; //this = obiectul pe care este atasat scriptul curent (Ball)
        Vector3 racketPosition = c.gameObject.transform.position; // c-contine info despre coliziune, inclusiv obiectul cu care mingea s-a ciocnit

        float racketHeight = c.collider.bounds.size.y; //inaltimea rachetei

        float x;
        if (c.gameObject.name == "RacketPlayer1")
        {
            x = 1; //mingea va merge spre dreapta
        }
        else
        {
            x = -1; //mingea va merge spre stanga
        }
        float y = (ballPosition.y - racketPosition.y) / racketHeight; //ca sa vedem daca mingea va merge in jos sau in sus (asta in functie de cat de sus sau de jos s-a lovit de paleta)

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }
    
    //metoda speciala care se apeleaza automat cand obiectul pe care se afla scriptul intra intr-o coliziune
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRacket(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            this.scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovement.StartBall(false));
        }
    }
    
}

