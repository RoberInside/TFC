using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI winText;
    // Start is called before the first frame update
    void Start()
    {
        winText = GameObject.Find("YouDidIt").GetComponent<TextMeshProUGUI>();
        winText.CrossFadeAlpha(0,0.01f,false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine(winAppears());
        }
    }
    IEnumerator winAppears()
    {
        Completed();
        yield return new WaitForSeconds(3.0f);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene(0);
    }
    public void Completed()
    {
        winText.CrossFadeAlpha(1,0.1f,false);
    }
}
