using UnityEngine;
using System.Collections;

public class ObjectScript : MonoBehaviour {

    // Scales the object depending on the number (1f is full size)
    public float scale = 6f;

	void Awake() {
        ChangeScale();
	}

	void ChangeScale()
    {
        float height = Camera.main.orthographicSize * 2;
        float width = height * Screen.width / Screen.height;

        gameObject.transform.localScale = Vector3.one * height / scale;
    }


}
