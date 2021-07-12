using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject ememy;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClearBoard(int i)
    {
        timer = 0;
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2) {
            Vector3 position = transform.position;
            position.y += 2;
            GameObject e = GameObject.Instantiate(ememy, position, Quaternion.identity)as GameObject;
            // Instantiate(ememy, transform);

            e.transform.parent = gameObject.transform;

            timer = 0;
        }
    }
}
