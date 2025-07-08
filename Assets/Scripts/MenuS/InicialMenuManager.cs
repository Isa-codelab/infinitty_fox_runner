using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicialMenuManager : MonoBehaviour
{
    [SerializeField] private string NameGame;
    [SerializeField] private GameObject painelInicialMenu;
    [SerializeField] private GameObject painelMenuConfigure;

    public void startGame()
    {   
        SceneManager.LoadScene(NameGame);
    }

    public void OpenConfig() 
    {
        painelInicialMenu.SetActive(false);
        painelMenuConfigure.SetActive(true);
      

    }

    public void CloseConfig()
    {
        painelMenuConfigure.SetActive(false);
        painelInicialMenu.SetActive(true);
       
    }

    public void Quit()
    {
        Debug.Log("Out of the game");
        Application.Quit();
    }
}
