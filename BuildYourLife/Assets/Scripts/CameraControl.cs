using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
	
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            OnClick();
        }
	}

    void OnClick()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            //Debug.Log(hit.collider.name);

            if (hit.collider.CompareTag("Clickable"))
            {
                ClickableObject co = hit.collider.GetComponent<ClickableObject>();

                if (co)
                {
                    co.OnClick();
                }
            }
        }
    }

}
