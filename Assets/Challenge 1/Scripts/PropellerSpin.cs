using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    private float propellerSpeed=1200f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,propellerSpeed*Time.deltaTime,Space.Self);
    }
}
