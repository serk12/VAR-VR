using UnityEditor;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlacentaTeleport : MonoBehaviour
{
    public GameObject player;


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
            player.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + 0.15f, transform.position.z);
            Camera cam = Camera.main;
            cam.nearClipPlane = 0.01f;
            GameObject tpgrid = GameObject.Find("tp_grid");
            Transform[] children = tpgrid.GetComponentsInChildren<Transform>();
            float offsetx = 0.1f;
            float offsety = 0.1f;
            float offsetz = 0.1f;
            foreach (Transform child in children)
            {
                if (child.name == "tp_sphere_X") child.position = new Vector3(transform.position.x + offsetx, player.transform.position.y - offsety, transform.position.z + offsetz);
                if (child.name == "tp_sphere_-X") child.position = new Vector3(transform.position.x - offsetx, player.transform.position.y - offsety, transform.position.z + offsetz);
                if (child.name == "tp_sphere_Z") child.position = new Vector3(transform.position.x + offsetx, player.transform.position.y - offsety, transform.position.z - offsetz);
                if (child.name == "tp_sphere_-Z") child.position = new Vector3(transform.position.x - offsetx, player.transform.position.y - offsety, transform.position.z - offsetz);

                child.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            }
        }
        else if (VRLogic.mode == VRLogic.NAVIGATION_IN)
        {
            Debug.Log("NAVIGATION_IN");

            Object POISelectionButton = AssetDatabase.LoadAssetAtPath("Assets/models/prefabs/POISelectionModeButton.prefab", typeof(GameObject));
            //GameObject POISelectionButton = (Transform)Resources.Load("Assets/models/prefabs/POISelectionModeButton.prefab", typeof(Transform));
            Instantiate(POISelectionButton, transform.position, Quaternion.identity);

        }
        else if (VRLogic.mode == VRLogic.POI_LOCATION)
        {
            Debug.Log("POI_LOCATION");

        }
    }
   
}

