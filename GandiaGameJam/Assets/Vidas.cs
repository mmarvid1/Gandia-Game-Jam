using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Vidas : MonoBehaviour
{
    public TextMeshProUGUI textoVida;
    public int Vidas_numero=3;
    public string nombre_escena;
    void Update()
    {
        textoVida.text =Vidas_numero.ToString();
        if(Vidas_numero<=0)
        {SceneManager.LoadScene(nombre_escena);}
    }
    void OnTriggerEnter(Collider other) 
    {
        
        if(other.CompareTag("Enemigo") )
            {
            Vidas_numero--; 
            textoVida.text =Vidas_numero.ToString(); 
            }
        
    }
}


