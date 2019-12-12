using UnityEditor;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlacentaTeleport : MonoBehaviour
{
    public GameObject player;
    public GameObject poi;

        public void Start()
        {
            VRLogic.mode = VRLogic.NAVIGATION_OUT;
        }

        public void clickOnPlacenta()
        {
            if (VRLogic.mode == VRLogic.NAVIGATION_OUT) {
                VRLogic.mode = VRLogic.NAVIGATION_IN;
                player.GetComponent<Transform>().position = new Vector3(transform.position.x, 1.85f, transform.position.z+0.125f);
                GameObject tp_point = player.GetComponent<Transform>().Find("TeleportPointer").gameObject;
                tp_point.SetActive(false);
                GameObject tp_grid = player.GetComponent<Transform>().Find("tp_grid").gameObject;
                tp_grid.SetActive(true);

                tp_grid.GetComponent<Transform>().localScale = new Vector3(0.1f,0.1f,0.1f);
                tp_grid.GetComponent<Transform>().localPosition = new Vector3(0.0f,0.1f,0.0f);

            }
            else if (VRLogic.mode == VRLogic.POI_LOCATION) {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitInfo);
            GameObject teleportPointer = GameObject.Find("TeleportPointer");
            if (hit)
            {
                GameObject x = Instantiate(poi);
                x.transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y+0.0005f, hitInfo.point.z);
            }

        }
    }

    public void tpNavigationOut(Vector3 pos)
    {
        VRLogic.mode = VRLogic.NAVIGATION_OUT;
        player.GetComponent<Transform>().position = pos;

        GameObject tp_point = player.GetComponent<Transform>().Find("TeleportPointer").gameObject;
        tp_point.SetActive(true);
        GameObject tp_grid = player.GetComponent<Transform>().Find("tp_grid").gameObject;
        tp_grid.SetActive(false);

        tp_grid.GetComponent<Transform>().localScale = new Vector3(1.0f,1.0f,1.0f);
        tp_grid.GetComponent<Transform>().localPosition = new Vector3(0.0f,-1f,0.0f);


    }

    public void clickOnPartner()
    {
            Vector3 pos = new Vector3(gameObject.transform.position.x - 3, 2.2f, gameObject.transform.position.z);
            tpNavigationOut(pos);
    }

}
