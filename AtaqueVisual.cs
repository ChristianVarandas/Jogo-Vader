using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueVisual : MonoBehaviour
{

    public Jogador scriptJogador;
    public GameObject sabre;
    public bool ataquePronto = true;
    public float velocidadeAtaque = 5f;
    public AudioClip somSabreAtaque;
    public bool atacando = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ataquePronto)
            {
                ataque();
            }

        }

    }
    public void ataque()
    {
        atacando = true;
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
    }
}
