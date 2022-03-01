using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StechSquash : MonoBehaviour
{
    public Vector3 speed;//speed by frame
    public float softness;
    public Vector3 posPreced;
    // Start is called before the first frame update
    void Start()
    {
        
        posPreced = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        speed = transform.position - posPreced;
        
        if(speed!=Vector3.zero)
        {
            transform.up = -speed.normalized;
        }

        Debug.Log(speed.magnitude*10);
        transform.localScale = new Vector3(softness, (2 - softness), softness) * speed.magnitude * 100;
        transform.localScale = new Vector3(Mathf.Clamp(transform.localScale.x,softness,1),
            Mathf.Clamp(transform.localScale.y, 1, 2-softness),
           Mathf.Clamp(transform.localScale.x, softness, 1));

        posPreced = transform.position;
    }
}
