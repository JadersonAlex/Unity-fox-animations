using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void Pausado()
    {
        Time.timeScale = 0; // Pausado
    }

    public void SairDoPause()
    {
        Time.timeScale = 1; // sair do pause
    }
}
