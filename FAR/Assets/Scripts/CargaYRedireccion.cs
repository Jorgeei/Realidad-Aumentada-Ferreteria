using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargaYRedireccion : MonoBehaviour
{
    // Nombre de la siguiente escena a cargar
    public string siguienteEscena = "Inicio";

    // Duración de la pantalla de carga en segundos
    public float tiempoDeEspera = 3.0f;

    void Start()
    {
        // Iniciar la rutina para cargar la siguiente escena después de un tiempo de espera
        StartCoroutine(CargarSiguienteEscena());
    }

    IEnumerator CargarSiguienteEscena()
    {
        // Esperar durante el tiempo especificado
        yield return new WaitForSeconds(tiempoDeEspera);

        // Cargar la siguiente escena
        SceneManager.LoadScene(1);
    }
}

