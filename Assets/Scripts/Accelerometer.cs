using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public float speed = 20.0f;
    public bool isFlat = true;
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 acc = Input.acceleration;
         rigid.AddForce(acc.x * speed, 0, acc.y * speed);
    }
}
