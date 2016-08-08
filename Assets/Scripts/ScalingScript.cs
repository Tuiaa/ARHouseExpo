using UnityEngine;
using System.Collections;

public class ScalingScript : MonoBehaviour {

    void Awake()
    {
        float height = 1.724f * Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad);
        float width = height * Screen.width / Screen.height;

        gameObject.transform.localScale = new Vector3(width, height, 1f);
    }
}
