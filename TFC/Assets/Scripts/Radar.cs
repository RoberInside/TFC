using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    PlayerController _player;
    PickUp _meat;
    public float maxDistance = 10f;

    public LayerMask pickUpLayer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
        _meat = FindObjectOfType<PickUp>();

    }
    

    //private void OnDrawGizmos() // pruebas raycast
    //{        

    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(transform.position, transform.lossyScale.x + maxDistance);
    //    //Debug.Log("hit");
        
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawWireSphere(transform.position, transform.lossyScale.x);

    //}//
    public void RaycastRadar()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position, transform.lossyScale.x, transform.forward, out hit, maxDistance, pickUpLayer, QueryTriggerInteraction.UseGlobal))
        {
            Debug.Log("hit");
        }
        else
            Debug.Log("not hit");
        
    }
}
