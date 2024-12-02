using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void IniciarJogo()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void SairJogo()
    {
        Application.Quit();
    }

    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }
}
