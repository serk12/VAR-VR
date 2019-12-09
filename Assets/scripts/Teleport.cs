using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : TimeClick
{
    public GameObject player;

    public override void Start()
    {
        waitTime = 0.1f;
        topCounter = 8;
    }

    public override void clickEvent()
    {
        player.GetComponent<Transform>().position = new Vector3(transform.position.x, player.GetComponent<Transform>().position.y, transform.position.z);
    }


}
