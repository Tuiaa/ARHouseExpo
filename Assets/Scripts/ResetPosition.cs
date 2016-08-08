using UnityEngine;
using System.Collections;

public class ResetPosition : MonoBehaviour {

	void Update () {
        transform.rotation = new Quaternion(0,0,0,0);
        transform.position = new Vector3(0,0,0);
	}
}
