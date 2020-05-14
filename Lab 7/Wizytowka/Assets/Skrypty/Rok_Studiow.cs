using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rok_Studiow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Mathf.Sin(Time.timeSinceLevelLoad * 3f) * 100f;
        Quaternion target = Quaternion.Euler(-translation, 0, translation);
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime);
  
    }
}
