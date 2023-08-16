using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPedalController : MonoBehaviour
{
    
    [SerializeReference] Rigidbody pedal;
    [SerializeReference] float torque;

 
    // Start is called before the first frame update
    void Start()
    {

        pedal = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            pedal.AddRelativeTorque(transform.right * torque);
        }
    

    }
}
