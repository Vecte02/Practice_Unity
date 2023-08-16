using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    GameObject obj;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Ruby");
        offset = new Vector3(0, 0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = obj.transform.position - offset;
    }
}
