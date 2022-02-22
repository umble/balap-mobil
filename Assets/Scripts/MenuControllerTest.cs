using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControllerTest : MonoBehaviour
{
    public CarListScript carListScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ChangeCar(int carIdx)
    {
        carListScript.ChangeCar(carIdx);
    }

    public void Respawn(int waypointIdx)
    {
        carListScript.ChangePosition(waypointIdx);
    }
}
