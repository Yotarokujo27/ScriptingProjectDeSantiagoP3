using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DualAxisExample : MonoBehaviour
{
    public Text horizontallyValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float vPos= v * vRange;

        Debug.Log(transform.position = new Vector3(xPos, 0, vPos));
        Debug.Log(horizontallyValueDisplayText.text = h.ToString("F2"));
        Debug.Log(verticalValueDisplayText.text = v.ToString("F2"));
    }
}
