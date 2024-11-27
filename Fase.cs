using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fase : MonoBehaviour
{

    public static int inimigosDerrotados;
    public int totalInimigos;
    public bool portaAberta = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        abrirPorta();
    }

    void abrirPorta()
    {
        if (inimigosDerrotados > totalInimigos)
        {
            Animator animarPorta = GetComponent<Animator>();
            portaAberta = true;
            animarPorta.SetTrigger("PortaAberta");

        }
    }
}
