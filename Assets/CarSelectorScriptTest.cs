using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelectorScriptTest : MonoBehaviour
{
    //public Scene sceneGameplay;
    //public int SelectedCar;
    //public CarListScript TargetGameplayScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectCar(int CarObject)
    {
        //CarObject = SelectedCar;
        PlayerPrefs.SetInt("SelectedCar", CarObject);
        Debug.Log(CarObject);
        SceneManager.LoadScene("Test City-noCar");
    }
}
