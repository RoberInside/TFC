using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    PlayerController _player;
    PickUp _meat;
    public float maxDistance;
    private float radius;
    private Vector3 origin;
    private Vector3 direction;

    public LayerMask pickUpLayer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
        _meat = FindObjectOfType<PickUp>();

    }


    //private void OnDrawGizmos() // pruebas raycast
    //{
    //    RaycastRadar();
       

    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawWireSphere(origin, radius);
        
    //    Gizmos.color = Color.white;
    //    Gizmos.DrawLine(origin, transform.position);

    //}//
    public void RaycastRadar()
    {
        RaycastHit hit;

        radius = transform.lossyScale.x + (maxDistance - transform.lossyScale.x);
        origin = transform.position + new Vector3(0, maxDistance, 0);
        direction = new Vector3(0, -1, 0);

        if (Physics.SphereCast(origin, radius, direction, out hit, maxDistance, pickUpLayer, QueryTriggerInteraction.UseGlobal))
        {            
            Debug.Log("hit");            
        }
        else
            Debug.Log("not hit");        
    }
}
