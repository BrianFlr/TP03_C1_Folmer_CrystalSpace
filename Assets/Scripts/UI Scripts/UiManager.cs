using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public bool isPause = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) // Me deja cambiar a la escena para entrar en pausa
        {
            isPause = !isPause;

            if (isPause)
            {
                // Seteo el tiempo en 0
                Time.timeScale = 0;

                // Cargo la escena de "MainMenu", pero colocándola encima de la actual. En este caso "Gameplay"
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
            }
            else
            {
                // Seteo el tiempo en 1 para reanudar el juego
                Time.timeScale = 1;

                // Apago la escena de "MainMenu" para volver a la del juego
                SceneManager.UnloadSceneAsync("MainMenu");
            }
        }
    }
}
