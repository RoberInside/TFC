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
        maxDistance = 10f;
        


    }
    public void FixedUpdate()
    {
        
    }

    private void OnDrawGizmos()
    {

        RaycastHit h;

        

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, transform.lossyScale.x + maxDistance);
        //Debug.Log("hit");
        
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, transform.lossyScale.x);

        if (Physics.SphereCast(transform.position, transform.lossyScale.x, transform.forward, out h, maxDistance, pickUpLayer, QueryTriggerInteraction.UseGlobal))
        {
            Debug.Log("hit");
           
        }

    }
    public void RaycastRadar()
    {
        //RaycastHit hit;
        //Ray hit = _player.transform.position.;
        
    }
}
