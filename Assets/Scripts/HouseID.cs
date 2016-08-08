using UnityEngine;
using System.Collections;

public class HouseID : MonoBehaviour {

    public int id;
    public bool isActive = false;
    public bool isLast = false;

    void Awake()
    {
        isActive = gameObject.activeInHierarchy;
    }
}
