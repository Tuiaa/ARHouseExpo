using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


/*
 *  All scripts that buttons use
 */
public class ButtonScript : MonoBehaviour {

    public List<GameObject> buildings = new List<GameObject>();
    public int lengthOfList;

    // Check how many building there are on the scene
    void Start()
    {
        lengthOfList = buildings.Count;
        Debug.Log("lengthoflist: " + lengthOfList);
    }

    // Finds the previous house on the list
    public void PreviousHouse()
    {
        Debug.Log("Button pressed");
        // Go through all buildings on the list
        foreach (GameObject building in buildings)
        {
            Debug.Log("in foreach");
            // Find the building that's active in hierarchy
            if (building.activeInHierarchy == true)
            {
                int houseID = building.GetComponent<HouseID>().id;
                Debug.Log("houseid: " + houseID);
                // If the active building is not the first on in list, find previous
                if (houseID != 0)
                    houseID--;
                // If active house is the first, find the last one on list
                else
                    houseID = lengthOfList - 1;
                Debug.Log("houseid: " + houseID);

                // Set the previous active building not active
                building.SetActive(false);
                Debug.Log("building setactive false");
                // Find the new building and set it to active
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

    // Finds the next house on the list
    public void NextHouse()
    {
        foreach (GameObject building in buildings)
        {
            if (building.activeInHierarchy == true)
            {
                int houseID = building.GetComponent<HouseID>().id;
                // Same idea but checks if the active house is not last on the list
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

    // Change scene in main menu
    public void ChangeScene()
    {
        SceneManager.LoadScene("ARCamera");
    }

    // Back to manu button
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
