using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPedalController : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            pedal.AddRelativeTorque(transform.right * -torque);
        }

    }
}
