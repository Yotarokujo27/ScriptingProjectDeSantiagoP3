using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryComponent : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
