using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FluffyUnderware.Curvy.Controllers;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public class SpeedController : MonoBehaviour
{
    private SplineController splineCtroller;
    public float speed;
    // Use this for initialization
    void Start()
    {
        splineCtroller = FindObjectOfType<SplineController>();
        if (splineCtroller == null)
        {
            Debug.Log("SplineController is Null!");
            return;
        }
        GetComponent<BoxCollider>().isTrigger = true;
        GetComponent<Rigidbody>().isKinematic = true;

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (splineCtroller == null)
        {
            // Debug.Log("SplineController is Null!");
            return;
        }
        if (other.tag == "Player")
        {
            splineCtroller.Speed = speed;
        }
    }
}
