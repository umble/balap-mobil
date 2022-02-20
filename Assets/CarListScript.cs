using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarListScript : MonoBehaviour
{
    public int selectedCarIndex;
    public GameObject[] CarList;
    public VehiclePhysics.VPCameraController cameraControllerObj;
    GameObject SelectedCar;
    // Start is called before the first frame update
    void Start()
    {
        selectedCarIndex = PlayerPrefs.GetInt("SelectedCar");
        SelectedCar = CarList[selectedCarIndex];
        var carObject = Instantiate(SelectedCar);
        cameraControllerObj.target = carObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
