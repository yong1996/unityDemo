using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    public Text t;
    public double count = 0;
    private Rigidbody rBody;
    private Vector3 intPos;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        intPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Count: " + count;

        //水平轴
        float horizontal = Input.GetAxis("Horizontal");
        //垂直轴
        float vertical = Input.GetAxis("Vertical");
        // 方向
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if (dir != Vector3.zero)
        {
            rBody.velocity = dir * 10;
        }
    }

    public void clearCount(int i)
    {
        count = 0;
        moveBack(0);
    }

    public void moveBack(int i)
    {
        transform.position = intPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy") {
            Destroy(other.gameObject);
            count++;
        }
    }

    private void OnCollisionEnter(Collision collection)
    {
        if (collection.collider.tag == "enemy")
        {
            Destroy(collection.gameObject);
            count++;
        }
    }
}
