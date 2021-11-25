using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int meatCount;

    public TextMeshProUGUI guiCount;
    

   


    // Start is called before the first frame update
    void Start()
    {
        meatCount = 0;
        
        guiCount = GameObject.Find("HUD").transform.GetChild(1).GetComponent<TextMeshProUGUI>();      

    }

    // Update is called once per frame
    void Update()
    {
        guiCount.text = "" + meatCount;
       
    }  
    

}
