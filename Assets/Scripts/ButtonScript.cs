using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

    public List<GameObject> buildings = new List<GameObject>();
    public int lengthOfList;

    void Start()
    {
        lengthOfList = buildings.Count;
        Debug.Log("lengthoflist: " + lengthOfList);
    }

    public void PreviousHouse()
    {
        Debug.Log("Button pressed");
        foreach (GameObject building in buildings)
        {
            Debug.Log("in foreach");
            if (building.activeInHierarchy == true)
            {
                int houseID = building.GetComponent<HouseID>().id;
                Debug.Log("houseid: " + houseID);
                if (houseID != 0)
                    houseID--;
                else
                    houseID = lengthOfList - 1;
                Debug.Log("houseid: " + houseID);
                //  else
                //    houseID = lengthOfList;
                //Debug.Log("houseid (length): " +lengthOfList);
                building.SetActive(false);
                Debug.Log("building setactive false");
                foreach (GameObject buildingID in buildings)
                {
                    if (buildingID.GetComponent<HouseID>().id == houseID)
                    {
                        buildings[houseID].SetActive(true);
                        Debug.Log("building set active true");
                        return;
                    }
                        
                }
                return;
            }
        }
    }

    public void NextHouse()
    {
        foreach (GameObject building in buildings)
        {
            if (building.activeInHierarchy == true)
            {
                int houseID = building.GetComponent<HouseID>().id;
                if (building.GetComponent<HouseID>().isLast != true)
                    houseID++;
                else
                    houseID = 0;

                building.SetActive(false);

                foreach (GameObject buildingID in buildings)
                {
                    if (buildingID.GetComponent<HouseID>().id == houseID)
                    {
                        buildingID.SetActive(true);
                        return;
                    }
                }
                return;
            }
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("ARCamera");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
