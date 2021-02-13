using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    GameObject MainCamera;
    float PosZ = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        PosZ = this.gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        MainCamera = GameObject.Find("Main Camera");
        if (MainCamera.transform.position.z >= PosZ)
        {
            Destroy(this.gameObject);
        }
    }
}
