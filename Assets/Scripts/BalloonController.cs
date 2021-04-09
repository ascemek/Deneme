using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This one is yours

public class BalloonController : MonoBehaviour
{
    public GameObject balloonPrefab;
    public float floatStrength = 20f;
    public float growRate = 1.5f;

    private GameObject balloon;


    void Update()
    {
        //if the trigger button pressed it will create a balloon
        if (Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            //Debug.Log("Trigger down");
            CreateBalloon();
        }

        // if the trigger button released it will release a balloon
        else if (Input.GetButtonUp("XRI_Right_TriggerButton"))
        {
            //Debug.Log("Trigger up");
            ReleaseBalloon();
        }
    }


    public void CreateBalloon()
    {
        balloon = Instantiate(balloonPrefab);
        balloon.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void ReleaseBalloon()
    {
        Rigidbody rb = balloon.GetComponent<Rigidbody>();
        Vector3 force = Vector3.up * floatStrength;
        rb.AddForce(force);

        GameObject.Destroy(balloon, 10f);
        balloon = null;
    }

    public void GrowBalloon()
    {
        balloon.transform.localScale += balloon.transform.localScale * growRate * Time.deltaTime;
    }
}
