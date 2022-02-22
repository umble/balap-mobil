using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaypointSelectorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SelectWaypoint(int waypointIdx)
    {
        PlayerPrefs.SetInt("SelectedWaypoint", waypointIdx);
        Debug.Log(waypointIdx);
        SceneManager.LoadScene("Test City-noCar");
    }
}
