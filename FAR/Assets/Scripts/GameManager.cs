using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenu;
    public event Action OnItemsMenu;
    public event Action OnARPosition;


    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main Menu Activated");
    }

    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Items Menu Activated");
    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position Menu Activated");
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void Iniciar()
    {
        SceneManager.LoadScene(2);
    }

    //public class LoadingScreen : MonoBehaviour
    //{
    //    public string sceneToLoad = "SceneWithModels"; // Nombre de la siguiente escena a cargar

    //    void Start()
    //    {
    //        // Iniciar la carga de la siguiente escena en una corrutina para poder mostrar la pantalla de carga
    //        StartCoroutine(LoadNextScene());
    //    }

    //    IEnumerator LoadNextScene()
    //    {
    //        // Mostrar la imagen de carga (puedes activarla si estaba desactivada)
    //        gameObject.SetActive(true);

    //        // Esperar un pequeño tiempo para mostrar la pantalla de carga antes de cargar la siguiente escena
    //        yield return new WaitForSeconds(2f);

    //        // Cargar la siguiente escena
    //        SceneManager.LoadScene(1);
    //    }
    //}
}
