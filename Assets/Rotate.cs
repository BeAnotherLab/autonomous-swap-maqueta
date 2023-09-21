using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rate;
    private float _rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotation += rate;
        transform.localRotation = Quaternion.Euler(new Vector3(0, _rotation, 0)); ;
    }
}
