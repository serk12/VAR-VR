using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeClick : MonoBehaviour
{
    protected float waitTime = 0.5f;
    protected int topCounter = 5;

    private int counter = 0;
    private bool focus = false;
    private float timer = 0.0f;

    public virtual void Start() {}

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
          if (focus){
              ++counter;
              if (counter > topCounter){
                  this.clickEvent();
                  counter = 0;
                  focus = false;
              }
          }
          // Remove the recorded 2 seconds.
          timer = timer - waitTime;
        }
    }

    public virtual void enter()
    {
        focus = true;
        counter = 0;
    }

    public virtual void exit()
    {
        focus = false;
        counter = 0;
    }

    public virtual void clickEvent(){}
}
