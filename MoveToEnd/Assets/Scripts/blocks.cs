using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClearBoard(int i)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp (0)) {
            Ray ray=Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast (ray,out hit)){
                // Debug.Log(hit.collider.tag);
                if(hit.collider.tag == "block plane") {
                    Vector3 position = hit.point;
                    position.y += 3;
                    GameObject b = GameObject.Instantiate(block, position, Quaternion.identity)as GameObject;
                    b.transform.parent = gameObject.transform;
                }

                if (hit.collider.tag == "block")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
		} else if (Input.GetMouseButtonUp (1)) {
            Ray ray=Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast (ray,out hit)){
                if(hit.collider.tag == "block") {
                    Destroy(hit.collider.gameObject);
                }
            }
        }

    }
}
