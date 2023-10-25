//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class RueditaAnimada : MonoBehaviour
//{
//    public float velocidadRotacion = 100.0f;
//    private RectTransform imagenRuedita;

//    // Start is called before the first frame update
//    void Start()
//    {
//        imagenRuedita = GetComponentInChildren<Image>().rectTransform;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Vector3 rotation = imagenRuedita.eulerAngles;
//        rotation.z -= velocidadRotacion * Time.deltaTime;
//        imagenRuedita.eulerAngles = rotation;
//    }
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RueditaAnimada : MonoBehaviour
{
    public Texture2D[] animacionRuedita;
    public float velocidadRotacion = 05.0f; // Cambia este valor para ajustar la velocidad de rotación
    private Image imagenRuedita;
    private int indiceTexturaActual = 0;
    private int cantidadTexturas;
    private float tiempoPorTextura = 0.1f;
    private float tiempoUltimaActualizacion = 0f;

    void Start()
    {
        imagenRuedita = GetComponent<Image>();
        cantidadTexturas = animacionRuedita.Length;
    }

    void Update()
    {
        float tiempoActual = Time.time;
        if (tiempoActual - tiempoUltimaActualizacion > tiempoPorTextura)
        {
            tiempoUltimaActualizacion = tiempoActual;
            ActualizarTextura();
        }

        RotarRuedita();
    }

    void ActualizarTextura()
    {
        indiceTexturaActual = (indiceTexturaActual + 1) % cantidadTexturas;
        imagenRuedita.sprite = Sprite.Create(animacionRuedita[indiceTexturaActual], new Rect(0, 0, animacionRuedita[indiceTexturaActual].width, animacionRuedita[indiceTexturaActual].height), new Vector2(0.5f, 0.5f));
    }

    void RotarRuedita()
    {
        // Girar hacia la derecha multiplicando por -1 la velocidad de rotación
        imagenRuedita.rectTransform.Rotate(0f, 0f, -velocidadRotacion * Time.deltaTime);
    }
}
