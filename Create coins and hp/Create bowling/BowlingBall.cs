using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    public float force;
    private List<Vector3> pinPositions;
    private List<Quaternion> pinRotations;
    private Vector3 ballPosition;
    void Start()
    {
        var pins = GameObject.FindGameObjectsWithTag("Pin");
        pinPositions = new List<Vector3>();
        pinRotations = new List<Quaternion>();
        foreach (var pin in pins)
        {
            pinPositions.Add(pin.transform.position);
            pinRotations.Add(pin.transform.rotation);
        }
        ballPosition = GameObject.FindGameObjectWithTag("Ball").transform.position;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force));
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
        if (Input.GetKeyUp(KeyCode.RightArrow))
            GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0), ForceMode.Impulse);
       
    }
}