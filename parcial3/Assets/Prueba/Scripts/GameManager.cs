using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public float dummys;
    public Text cronometroText; // Referencia al texto en el Canvas
  
    public float contadorTiempo = 0f; // Contador de tiempo
    private bool cronometroActivo = true; // Estado del cron�metro
    void Update()
    {
        // C�digo que se ejecuta en cada frame
        if(dummys > 6)
        {

        }
        if (cronometroActivo)
        {
            // Incrementa el tiempo
            contadorTiempo += Time.deltaTime;

            // Actualiza el texto del cron�metro
            cronometroText.text = "Tiempo: " + contadorTiempo.ToString("F2");

            // Verifica si el tiempo alcanza el l�mite
            if (dummys > 6)
            {
                PausarCronometro();
            }
        }
    }
    public void PausarCronometro()
    {
        cronometroActivo = false;
        Debug.Log("Cron�metro pausado");
    }

    public void ReiniciarCronometro()
    {
        contadorTiempo = 0f;
        cronometroActivo = true;
        Debug.Log("Cron�metro reiniciado");
    }
    public void sumarDummys()
    {
        dummys += 1;
        Debug.Log("entro un dummy" );
    }
    public void RestarDummys()
    {
        dummys -= 1;
        Debug.Log("Salio un dummy");
    }
    
}
