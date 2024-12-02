using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AtaqueJogador : MonoBehaviour
{
    public Jogador scriptJogador;
    public GameObject sabre;
    public bool ataquePronto = true;
    public float velocidadeAtaque = 3f;
    public AudioClip somSabreAtaque;
    public bool atacando = false;
    public Fase fase;
    BoxCollider colisor;

    private void Start()
    {
        colisor = GetComponent<BoxCollider>();
        colisor.enabled = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ataquePronto)
        {
                ataque();
        }
    }
    public void ataque()
    {
        atacando = true;
        colisor.enabled = true;
        ataquePronto = false;
        Animator animacao = sabre.GetComponent<Animator>();
        animacao.SetTrigger("Ataque");

        AudioSource somSabre = GetComponent<AudioSource>();
        somSabre.PlayOneShot(somSabreAtaque);

        StartCoroutine(tempoAtaque());
    }

    IEnumerator tempoAtaque()
    {
        StartCoroutine(colisaoAtaque());
        yield return new WaitForSeconds(velocidadeAtaque);
        ataquePronto = true;
    }

  IEnumerator colisaoAtaque()
    {
        yield return new WaitForSeconds(1f);
        atacando = false;
        colisor.enabled = false;
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Inimigo" && atacando)
        {
            Destroy(other.gameObject);
            Fase.inimigosDerrotados += 1;
        }
        
    }
}

