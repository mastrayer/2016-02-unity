using UnityEngine;
using System.Collections;

public class Debris : MonoBehaviour {
    bool isConnected = false;

    // TODO: 어떻게 데브리와 플레이어를 결합시킬 것인가? (fixed joint는 연산도 많고 버그도 많음..)
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
