using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;


    private float waitTime = 0.5f;
    private float timer = 0.0f;

    private int counter = 0;
    private bool focus = false;

    void Start() {}

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
          if (focus){
              ++counter;
              if (counter > 5){
                  player.GetComponent<Transform>().position = new Vector3(transform.position.x,1.0f, transform.position.z);
                  counter = 0;
                  focus = false;
              }
          }
          // Remove the recorded 2 seconds.
          timer = timer - waitTime;
        }
    }

    public void enter()
    {
        focus = true;
        counter = 0;
        Debug.Log(transform.position.z);
        Debug.Log(transform.position.x);
    }

    public void exit()
    {
        focus = false;
        counter = 0;
    }
}
