using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerBoardManager : MonoBehaviour {
    public GameObject obj;
    // Start is called before the first frame update
    void Start() {
        Vector3 position =  GetPosition();
        Debug.Log(position);
    }
    public Vector3 GetPosition() {
        Transform objTransform = obj.transform;
        Vector3 objScale = objTransform.lossyScale;
        float width = objScale.y;
        float half_width = width / 2;
        Vector3 objPosition = objTransform.position;
        float y = objPosition.y;
        float x = objPosition.x;
        float z = objPosition.z;
        Vector3 edge_position;
        edge_position.x = x;
        edge_position.y = y - half_width;
        edge_position.z = z;
        return edge_position;
    }

    public void SetDebug() {
        Debug.Log(GetPosition().ToString());
    }
}
