using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTrigo01 : MonoBehaviour
{
    public enum _monChoix { a, b, c}

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3( 0, Mathf.Abs(Mathf.Sin(Time.time)), 0);
        transform.position = new Vector3(0, Mathf.Abs( Mathf.Tan(Time.time)), 0);
    
    }
}
