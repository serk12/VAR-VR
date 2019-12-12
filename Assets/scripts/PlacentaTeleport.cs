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
            if (VRLogic.mode == VRLogic.NAVIGATION_OUT)
            {
                Debug.Log("NAVIGATION_OUT to NAVIGATION_IN");

                GameObject.Find("ModeText").GetComponent<Text>().text = "NAVIGATION THROUGH PLACENTA";
                VRLogic.mode = VRLogic.NAVIGATION_IN;
                player.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + 0.175f, transform.position.z);
                Camera cam = Camera.main;
                cam.nearClipPlane = 0.01f;
                GameObject tpgrid = GameObject.Find("tp_grid");
                tpgrid.GetComponent<Transform>().localScale = new Vector3(0.1f,0.1f,0.1f);
                tpgrid.GetComponent<Transform>().localPosition = new Vector3(0.0f,-0.105f,0.0f);
            }
            else if (VRLogic.mode == VRLogic.NAVIGATION_IN)
            {
                Debug.Log("NAVIGATION_IN");

                //Object POISelectionButton = AssetDatabase.LoadAssetAtPath("Assets/models/prefabs/POISelectionModeButton.prefab", typeof(GameObject));
                //GameObject POISelectionButton = (Transform)Resources.Load("Assets/models/prefabs/POISelectionModeButton.prefab", typeof(Transform));
                //Instantiate(POISelectionButton, transform.position, Quaternion.identity);

            }
            else if (VRLogic.mode == VRLogic.POI_LOCATION)
            {
                Debug.Log("POI_LOCATION");
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0)), out hitInfo);
            GameObject teleportPointer = GameObject.Find("TeleportPointer");
            if (hit)
            {
                GameObject x = Instantiate(poi);
                x.transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y+0.0005f, hitInfo.point.z);
            }

        }
    }

        public void clickOnPartner()
        {
            if (VRLogic.mode == VRLogic.NAVIGATION_IN)
            {
                Debug.Log("NAVIGATION_IN to NAVIGATION_OUT");

                GameObject.Find("ModeText").GetComponent<Text>().text = "NAVIGATION THROUGH ROOM";
                VRLogic.mode = VRLogic.NAVIGATION_IN;
                player.GetComponent<Transform>().position = new Vector3(transform.position.x - 3, 2.2f, transform.position.z);
                Camera cam = Camera.main;
                cam.nearClipPlane = 0.01f;
                GameObject tpgrid = GameObject.Find("tp_grid");
                tpgrid.GetComponent<Transform>().localScale = new Vector3(1.0f,1.0f,1.0f);
                tpgrid.GetComponent<Transform>().localPosition = new Vector3(0.0f,-1f,0.0f);
            }
            else if (VRLogic.mode == VRLogic.NAVIGATION_OUT)
            {
                Debug.Log("NAVIGATION_OUT");

            }
        }

}
