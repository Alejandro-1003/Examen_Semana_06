using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int Puntaje = 5;
    private int Vidas = 2;
    private int Zombie= 0;
    private int VidasZombie= 2;
    // Start is called before the first frame update
    
    public void GanarPuntos() {
        if(Puntaje > 0)
            Puntaje -= 1;
            
    }

    public void PerderVidas() {
        if(Vidas > 0)
            Vidas -= 1;
    }
    public void ZombieMuerto(){
        Zombie +=1;
    }
    public void PVidasZombie() {
        if(VidasZombie > 0)
            VidasZombie -= 1;
    }

    public int GetPuntaje() {
        return Puntaje;
    }

    public int GetVidas() {
        return Vidas;
    }
    public int GetZombie(){
        return Zombie;
    }
    public int GetVidasZombie(){
        return VidasZombie;
    }
}
