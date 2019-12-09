using UnityEditor;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Menu : MonoBehaviour
{

    public void Start()
    {
        VRLogic.mode = VRLogic.NAVIGATION_OUT;
    }

    public void clickOnPOISelectionModeButton()
    {
        /*if (VRLogic.mode == VRLogic.NAVIGATION_OUT)
        {
            Debug.Log("NAVIGATION_OUT to NAVIGATION_IN");

            GameObject.Find("ModeText").GetComponent<Text>().text = "NAVIGATION INSIDE "
            VRLogic.mode = VRLogic.NAVIGATION_IN;
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

        }*/
    }

    public void Update()
    {
        Camera cam = Camera.main;
        float distanceFromCamera = 2.0f;
        //Vector3 direction = Quaternion.AngleAxis(-45, Vector3.up) * cam.transform.forward;
        Vector3 direction = cam.transform.forward;
        Vector3 resultingPosition = cam.transform.position + direction * distanceFromCamera;
        transform.position = resultingPosition;
        //transform.LookAt(cam.transform);
        // transform.Rotate(0, 0, 40);

    }

}
