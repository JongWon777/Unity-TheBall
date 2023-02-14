using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Jump
        if (Input.GetButtonDown("Jump"))
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        // Move
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    }
}
