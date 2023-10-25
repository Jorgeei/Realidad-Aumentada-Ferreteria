using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomableImage : MonoBehaviour
{
    public Vector3 desiredScale = new Vector3(1.5f, 1.5f, 1.5f); // Escala deseada para la imagen

    void Start()
    {
        transform.localScale = desiredScale; // Establecer la escala deseada al inicio
    }
}


