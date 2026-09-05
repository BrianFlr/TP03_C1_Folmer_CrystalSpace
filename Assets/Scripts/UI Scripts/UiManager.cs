using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    private Scene actualScene;

    private void Awake()
    {
        // Guardo la escena activa
        actualScene = SceneManager.GetActiveScene();
    }

    private void Update()
    {
        if(actualScene.name != "MainMenu") // Si el nombre de la escena actual no es "MainMenu"
        {
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) // Me deja cambiar a la escena para entrar en pausa
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive); // Cargo la escena de "MainMenu", pero colocándola encima de la actual "Gameplay".

                Time.timeScale = 0;
                //isPause = !isPause;

                //if (isPause)
                //{

                //}
                //else
                //{
                //    
                //}
            }
        }
       
        
    }
}
