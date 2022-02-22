using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Vector3 position;
    [SerializeField] Vector3 rotation;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = position;
        this.transform.eulerAngles = rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 GetPosition()
    {
        return this.position;
    }

    public Vector3 GetRotation()
    {
        return this.rotation;
    }
}
