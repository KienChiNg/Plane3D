using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float tiltInput;
    private float HoritaltInput;
    [SerializeField] private float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiltInput =  Input.GetAxis("Vertical");
        HoritaltInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.back * Time.deltaTime * HoritaltInput * turnSpeed);
        transform.Rotate(Vector3.left * Time.deltaTime * tiltInput * turnSpeed);
        
    }
}
