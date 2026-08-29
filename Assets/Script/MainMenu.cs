using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartNewGame()
    {
        Settings.fromSave = false;
        SceneManager.LoadScene("Loading");
    }
    public void LoadSavedGame()
    {
        Settings.fromSave = true;
        SceneManager.LoadScene("Loading");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
