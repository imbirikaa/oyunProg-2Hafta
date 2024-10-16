using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_sc : MonoBehaviour
{
    private float _speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed);
        if (transform.position.y > 7.22f)
        {
            Destroy(gameObject);
        }
    }
}
