using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public GameObject target;
    PlayerScript script;

	// Use this for initialization
	void Start () {
        script = target.GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position - (script.forward*3) + new Vector3(0, 1.0f, 0);
        transform.LookAt(target.transform);
	}
}
