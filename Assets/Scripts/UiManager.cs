using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text PuntajeText;
    public Text Vida;
    public Text Zombie;

    public void PrintPuntaje(int puntos) {
        PuntajeText.text = "Bala: " + puntos;
    }

    public void PrintVida(int vida) {
        Vida.text = "Vidas: " + vida;
    }

     public void PrintZombie(int Zombie) {
        PuntajeText.text = "Zombie: " + Zombie;
    }
    

}
