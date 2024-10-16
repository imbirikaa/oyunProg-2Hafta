using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_sc : MonoBehaviour
{
    private float _speed = 10f;
    private float _nextFire = 0.2f;
    private float _fireRate = 1f;

    public GameObject laser;




    void Update()
    {
        method();

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
        {
            Instantiate(laser, transform.position + new Vector3(0,1f,0) , Quaternion.identity);
            _nextFire = Time.time + _fireRate;
        }

    }




    void method()

    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float VerInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, VerInput, 0);
        transform.Translate(direction * Time.deltaTime * _speed);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -8.3f, 0), 0);
        if (transform.position.x > 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }
    }
}
