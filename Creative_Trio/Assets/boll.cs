using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        this.rigidbody.velocity = new Vector3(0, 0, 1f);
    }
}