using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Camera cam1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
        
            Ray ray1 = cam1.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray1, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<Collider>() != null) 
                { 
                    Vector3 distanceTarget = hitInfo.point - transform.position;
                    Vector3 forceDirection = distanceTarget.normalized;

                }
            }
        
        
        }

    }
    void OnMouseOver()
        {
            //If your mouse hovers over the GameObject with the script attached, output this message

            Debug.Log("Mouse is over GameObject.");
        }

        void OnMouseExit()
        {
            //The mouse is no longer hovering over the GameObject so output this message each frame
            Debug.Log("Mouse is no longer on GameObject.");
        }
}
