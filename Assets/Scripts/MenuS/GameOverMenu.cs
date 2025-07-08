using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour
{
    public GameObject gamerOvermenu;
    public string Game;
  public void Restart()
    {
        gamerOvermenu.SetActive(false);
        SceneManager.LoadScene(Game);
    }

  public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
