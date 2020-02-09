using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderReceiver : MonoBehaviour {
    [SerializeField] public Collider _collider;
    public Material Default;
    public Material ColliderEnter;
    public Material ColliderStay;
    void OnTriggerEnter(Collider collision)
    {
        GetComponent<MeshRenderer>().material = ColliderEnter;
    }
    void OnTriggerExit(Collider collision)
    {
        GetComponent<MeshRenderer>().material = Default;
    }
    void OnTriggerStay(Collider collision)
    {
        GetComponent<MeshRenderer>().material = ColliderStay;
    }
}
