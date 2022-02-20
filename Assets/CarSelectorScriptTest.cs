using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelectorScriptTest : MonoBehaviour
{
    //public Scene sceneGameplay;
    public GameObject SelectedCar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectCar(GameObject CarObject)
    {
        CarObject = SelectedCar;
        Debug.Log(CarObject.name);
        //SceneManager.LoadScene(sceneGameplay.name);
    }
}
