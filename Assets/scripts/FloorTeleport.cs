using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class FloorTeleport : MonoBehaviour
{
    public GameObject player;


    public void Start()
    {

    }

    public void teleport()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0)), out hitInfo);
        if (hit) {
            player.GetComponent<Transform>().position = new Vector3(hitInfo.point.x, player.GetComponent<Transform>().position.y, hitInfo.point.z);
        }
    }

    public void Update()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        if (hit)
        {
            if (hitInfo.transform.gameObject.name == "Floor")
            {
                transform.position = new Vector3(hitInfo.point.x, 0.1f, hitInfo.point.z);

            }

        }

    }
}
