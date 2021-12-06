using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadingMenu : MonoBehaviour
{
    public TextMeshProUGUI fadeTextRadar;
    public TextMeshProUGUI fadeTextObjective;
   
   

    // Start is called before the first frame update
    void Start()
    {
        fadeTextRadar = GameObject.Find("MeatsNerby").GetComponent<TextMeshProUGUI>();
        fadeTextObjective = GameObject.Find("Objetivo").GetComponent<TextMeshProUGUI>();       
        fadeTextRadar.CrossFadeAlpha(0, 0.01f, false);

        StartCoroutine(fadingWaitObjective(5.5f));
        
    }
    private void Update()
    {
        
        
    }
    // Update is called once per frame    
    public IEnumerator fadingWaitRadar(float secondsToWait)
    {
        //fadeTextRadar.gameObject.SetActive(true);
        fadeTextRadar.CrossFadeAlpha(1, 0.2f, false);        
        yield return new WaitForSeconds(secondsToWait);
        Fade(fadeTextRadar);
    }
    public IEnumerator fadingWaitObjective(float secondsToWait)
    {
        fadeTextObjective.gameObject.SetActive(true);
        fadeTextObjective.alpha = 1;
        yield return new WaitForSeconds(secondsToWait);
        fadeTextObjective.text = "Find all the meat pieces so you can jump enough and cross the river!";
        yield return new WaitForSeconds(secondsToWait);
        fadeTextObjective.text = "Press 'F' to smell the meat around you.";
        yield return new WaitForSeconds(secondsToWait);
        Fade(fadeTextObjective);
        //fadeTextObjective.gameObject.SetActive(false);
    }
    
    public void Fade(TextMeshProUGUI text)
    {
        text.CrossFadeAlpha(0, 1.0f, false);        
    }

}
