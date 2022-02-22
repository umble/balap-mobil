using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarListScript : MonoBehaviour
{
    public int selectedCarIndex;
    public int selectedWaypointIndex;
    public GameObject[] CarList;
    public VehiclePhysics.VPCameraController cameraControllerObj;
    public WaypointController waypointController;
    GameObject SelectedCar;
    GameObject SpawnedCar;
    Waypoint SelectedWaypoint;
    // Start is called before the first frame update
    void Start()
    {
        selectedCarIndex = PlayerPrefs.GetInt("SelectedCar");
        selectedWaypointIndex = PlayerPrefs.GetInt("SelectedWaypoint");
        SelectedCar = CarList[selectedCarIndex];
        SelectedWaypoint = waypointController.SelectWaypoint(selectedWaypointIndex);

        Vector3 position = SelectedWaypoint.GetPosition();
        Vector3 rotation = SelectedWaypoint.GetRotation();
        SpawnedCar = Instantiate(SelectedCar, position, new Quaternion(rotation.x, rotation.y, rotation.z, 0));
        cameraControllerObj.target = SpawnedCar.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeCar(int carIndex)
    {
        Vector3 tempPosition;
        Vector3 tempRotation;
        if (SpawnedCar)
        {
            tempPosition = SpawnedCar.transform.position;
            tempRotation = SpawnedCar.transform.eulerAngles;
            Destroy(SpawnedCar);
            SelectedCar = CarList[carIndex];
            SpawnedCar = Instantiate(SelectedCar, new Vector3(tempPosition.x, 2, tempPosition.z), new Quaternion(tempRotation.x, tempRotation.y, tempRotation.z, 0));
            cameraControllerObj.target = SpawnedCar.transform;
        }
    }

    public void ChangePosition(int waypointIndex)
    {
        SelectedWaypoint = waypointController.SelectWaypoint(waypointIndex);
        Vector3 position = SelectedWaypoint.GetPosition();
        Vector3 rotation = SelectedWaypoint.GetRotation();
        SpawnedCar.transform.position = position;
        SpawnedCar.transform.rotation = new Quaternion(rotation.x, rotation.y, rotation.z, 0);
    }


}
