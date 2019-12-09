using UnityEditor;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SelectAndTransform : MonoBehaviour
{

	public GameObject axis;

	void Update()
	{
		//if (Input.GetMouseButtonDown(0))
		//{
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit){
				GameObject selected = GameObject.Find(hitInfo.transform.gameObject.name);
				if(selected.transform.Find("axis(Clone)") == null) {
					GameObject axis_go = Instantiate(axis, selected.transform.position, Quaternion.identity) as GameObject;
					axis_go.transform.parent = selected.transform;
					axis_go.transform.LookAt(gameObject.transform);
					float scale = 0.3f;
					axis_go.transform.localScale = new Vector3(scale,scale, scale);
				}
			}
		//}
	}

}
