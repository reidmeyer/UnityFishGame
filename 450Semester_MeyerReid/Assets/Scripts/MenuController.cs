using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

	public static MenuController instance;

	public GameObject mainMenu;
    public GameObject deathMenu;


	void Awake()
	{
		instance = this;
		Hide();
	}

	public void Show()
	{
		gameObject.SetActive(true);
		ShowMainMenu();
        Time.timeScale=0;
        Character.instance.isPaused=true;
	}

    public void Death()
    {
        gameObject.SetActive(true);
        ShowDeathMenu();
        Time.timeScale=0;
        Character.instance.isPaused=true;
        Character.instance.isDead=1f;

    }

	public void Hide()
	{
		gameObject.SetActive(false);
        Time.timeScale=1;
        if(Character.instance!=null)
        {
            Character.instance.isPaused=false;
        }
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

   /* public void ResetScore()
    {
        PlayerPrefs.DeleteKey("Score");
        PlayerController.instance.score=0;
    }*/

    void SwitchMenu(GameObject someMenu)
    {
    	mainMenu.SetActive(false);
    	//optionsMenu.SetActive(false);
    	deathMenu.SetActive(false);

    	someMenu.SetActive(true);
    }


    public void ShowMainMenu()
    {
    	SwitchMenu(mainMenu);
    }

    public void ShowDeathMenu()
    {
        SwitchMenu(deathMenu);
    }
    /*
    public void ShowOptionsMenu()
    {
    	SwitchMenu(optionsMenu);
    }
    public void ShowLevelMenu()
    {
    	SwitchMenu(levelMenu);
    }*/


    // Update is called once per frame
    void Update()
    {
        
    }
}
