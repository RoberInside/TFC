using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public PlayerController _player;
    public Transform _spawnZone;
   
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
        _spawnZone = GameObject.Find("SpawnZone").transform;
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Tocado");            
            _player.transform.position = _spawnZone.position;
            
        }
    }
}
