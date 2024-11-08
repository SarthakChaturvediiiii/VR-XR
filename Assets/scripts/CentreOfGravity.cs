using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreOfGravity : MonoBehaviour
{
    
    
  public Vector3 centerOfMass; 
  private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.centerOfMass = centerOfMass;
    }


    void Update()
    {
#if UNITY_EDITOR
        _rb.centerOfMass -= centerOfMass;
        _rb.WakeUp();
#endif

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position + transform.rotation * centerOfMass, 0.2f);
    }


}
