using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void CargarEscenaTutorial()
    {
        //En los parentesis tienes que poner el nombre de la escena en el build settings
        SceneManager.LoadScene("Tutorial");
        Debug.Log("Cambiando a la escena a prueba");
    }
    public void CargarEscenaPrueba()
    {
        SceneManager.LoadScene("Extintor");
        Debug.Log("Cambiando a la escena a prueba");
    }
}