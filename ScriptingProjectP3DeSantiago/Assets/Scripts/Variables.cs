using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }
        // Update is called once per frame
    void Update()
    {

    }

    int MultiplyByTwo (int num)
  
    {
            int result;
            result = num * 2;
            return result;
     
    }
}