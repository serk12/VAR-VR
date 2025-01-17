using UnityEditor;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static proto.PhoneEvent.Types;

public class SelectAndTransform : MonoBehaviour
{

	public GameObject axis;
	void Update()
	{
		if (VRLogic.mode == VRLogic.SCALATION || VRLogic.mode == VRLogic.ROTATION  || VRLogic.mode == VRLogic.MOVEMENT ||
			VRLogic.mode == VRLogic.SCALATION_NEG || VRLogic.mode == VRLogic.ROTATION_NEG  || VRLogic.mode == VRLogic.MOVEMENT_NEG) {
			RaycastHit hitInfo = new RaycastHit();
	        bool hit = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitInfo);
			if (hit) {
				GameObject selected = GameObject.Find(hitInfo.transform.gameObject.name);
				if(selected.transform.Find("axis(Clone)") == null && selected.tag != "noMove") {
					GameObject axis_go = Instantiate(axis, selected.transform.position, Quaternion.identity) as GameObject;
					axis_go.transform.parent = selected.transform;
					axis_go.transform.LookAt(gameObject.transform);
					float scale = 0.3f;
					axis_go.transform.localScale = new Vector3(scale,scale, scale);
				}
			}
		}
		else {
			GameObject[] allAxis = GameObject.FindGameObjectsWithTag("axis");
			foreach(GameObject ax in allAxis) {
				Destroy(ax);
			}
		}
	}

}
