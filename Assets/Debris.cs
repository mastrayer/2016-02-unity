using UnityEngine;
using System.Collections;

public class Debris : MonoBehaviour {
    bool isConnected = false;

    void OnCollisionEnter(Collision collision)
    {
        if (!isConnected && collision.gameObject.CompareTag("Player"))
        {
            isConnected = true;
            gameObject.tag = "Player";

            //transform.SetParent(collision.gameObject.transform);
            //GetComponent<FixedJoint>().connectedBody = collision.gameObject.GetComponent<Rigidbody>();
            transform.SetParent(GameObject.Find("Player").transform);
            GetComponent<FixedJoint>().connectedBody = GameObject.Find("Player").GetComponent<Rigidbody>();
        }
    }
}
