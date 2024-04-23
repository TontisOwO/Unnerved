using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SavedData PlayerData = null;
    public string floor1 = "Totorial";
    string menu = "Settings";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (PlayerData.inMenu == true )
            {
                SceneManager.LoadScene(PlayerData.CurrentFloor);
                PlayerData.inMenu = false;
            }
            if (PlayerData.inMenu == false )
            {
                SceneManager.LoadScene(menu);
                PlayerData.inMenu = true;
            }
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void AltLoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(PlayerData.CurrentFloor);
    }

    public void EraseData()
    {
        PlayerData.AxeItem = false;
        PlayerData.CrubrItem = false;
        PlayerData.MatchItem = false;
        PlayerData.KeyItem = false;
        PlayerData.SampleItem = false;
        PlayerData.CurrentFloor = 1;
        SceneManager.LoadScene(floor1);
    }
}
