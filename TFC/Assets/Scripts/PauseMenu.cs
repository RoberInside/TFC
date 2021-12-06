using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menuPausa;
    public Button resumeBttn;   
    public Button mMenuBttn;
    public Button quitBttn;

    public bool pauseActive;

    // Start is called before the first frame update
    void Start()
    {
        pauseActive = false;
        menuPausa = GameObject.Find("MenuPausa");
        resumeBttn = GameObject.Find("MenuPausa").transform.GetChild(1).GetComponent<Button>();
        mMenuBttn = GameObject.Find("MenuPausa").transform.GetChild(2).GetComponent<Button>();
        quitBttn = GameObject.Find("MenuPausa").transform.GetChild(3).GetComponent<Button>();
        //Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = pauseActive;
    }
    public void Resume()
    {
        if (menuPausa.activeSelf) pauseActive = false;
    }    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(1);

    }
    public void Quit()
    {
        Application.Quit();
    }
}
