using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class payer_controller : MonoBehaviour {
    private bool canJump;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-10f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(10f * Time.deltaTime, 0, 0);
        }

        ManageJump();
    }

    void ManageJump()
    {
        if(gameObject.transform.position.y <= 0)
        {
            canJump = true;
        }

        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 10)
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
        }
        else
        {
            canJump = false;

            if (gameObject.transform.position.y > 0)
            {
                gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
            }
         }
    }
}