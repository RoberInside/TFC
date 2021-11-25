using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUp : MonoBehaviour
{
    public PlayerController _player;
    public float jumpIncrease;
    
    private GameManager _gM;
   

    // Start is called before the first frame update
    void Start()
    {
        _gM = FindObjectOfType<GameManager>();
        _player = FindObjectOfType<PlayerController>();        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gameObject.SetActive(false);
            _player._jumpForce += jumpIncrease;
            _gM.meatCount++;
        }
    }
   
}
