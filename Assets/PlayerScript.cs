using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class PlayerScript : MonoBehaviour {
    Rigidbody rigid;
    public Vector3 forward;
    float rotationSensitivity = 0.1f;
    float speedFactor = 10.0f;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
        forward = transform.forward;
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 right = Vector3.Cross(Vector3.up, forward);

        forward += right * Input.GetAxis("Horizontal") * rotationSensitivity;
        forward.Normalize();

        float direction = Input.GetAxis("Vertical");

        rigid.AddForce(forward * direction * speedFactor);


        //Debug.Log(rigid.velocity);
        //Debug.LogWarning(rigid.velocity.magnitude);
    }
}
