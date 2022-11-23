using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControls : MonoBehaviour
{
    public float rotationSpeed = 50;
    public float movementSpeed = 25f;
    float accelaration = 0;
    public float accelarationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        accelaration = Mathf.Clamp(accelaration, 0, 80);
        if (Input.GetKey(KeyCode.S))
        {
            if (accelaration == 0)
            {
                accelaration = -5;
            }
            else
            {
                accelaration -= accelarationSpeed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {

            accelaration += accelarationSpeed * Time.deltaTime;
            
        }
        else
        {
            accelaration -= accelarationSpeed * Time.deltaTime;
        }
        transform.position += transform.forward * Time.deltaTime * accelaration;
        if (accelaration != 0)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {

                transform.Rotate(new Vector3(0, 1, 0), -rotationSpeed * Time.deltaTime);
            }

        }

    }
}
