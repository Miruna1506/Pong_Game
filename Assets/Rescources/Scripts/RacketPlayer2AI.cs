using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2AI : MonoBehaviour {

    public float movementSpeed;
    public GameObject ball; //o atribui din inspector
    private void FixedUpdate()
    {
        if(Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50) //calculez distanta verticala dintre paleta si minge, si o fac pozitiva cu .Abs
        {
            if(transform.position.y < ball.transform.position.y)//daca poz. y a paletei este mai mica decat poz. y a mingii => paleta urca pt. a o urmari
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed;//deplasare in sus
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movementSpeed;//deplasare in jos
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
