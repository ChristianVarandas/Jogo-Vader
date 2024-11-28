using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void IniciarJogo()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void SairJogo()
    {
        Application.Quit();
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }
}
