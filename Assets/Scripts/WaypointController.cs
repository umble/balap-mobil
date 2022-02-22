using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour
{
    [SerializeField] Waypoint[] waypoints;
    private VehiclePhysics.VPVehicleController car;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Waypoint SelectWaypoint(int index)
    {
        return waypoints[index];
    }
}
