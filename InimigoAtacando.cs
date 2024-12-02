using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using JetBrains.Annotations;

public class InimigoAtacando : MonoBehaviour
{
    [SerializeField] float alcance = 20f;
    [SerializeField] float velocidadeOlhar = 5f;

    public Jogador JogadorScript;
    public int dano;
    private Transform jogadorTransform;
    private float espera = 0f;
    private float esperaTempo = 3f;

    public AudioClip ataqueTiro;
    public AudioClip carregarAtaque;
    AudioSource tocarSom;

    void Start()
    {
        tocarSom = GetComponent<AudioSource>();
        jogadorTransform = GameObject.Find("Jogador").transform;
    }
    

    void Update()
    {
       
        Vector3 posicaoJogador = new Vector3(jogadorTransform.position.x, transform.position.y, jogadorTransform.position.z); 



        if (Vector3.Distance(transform.position, posicaoJogador) < alcance) // QUando o jogador estiver dentro do alcance
        {
            //tudo isso é pro inimigo se virar pro jogador
            Vector3 direcaoJogador = posicaoJogador - transform.position;
            float virar = velocidadeOlhar * Time.deltaTime;
            Vector3 virarPara = Vector3.RotateTowards(transform.forward, direcaoJogador, virar, 0f);

            transform.rotation = Quaternion.LookRotation(virarPara);

            if (espera <= 0.1)
            {
                tocarSom.PlayOneShot(carregarAtaque);
            }
            espera += Time.deltaTime; //conta o tempo que passou
            Debug.Log(espera);
            if (espera >= esperaTempo) // após X segundos reseta o contador e faz o ataque
            {
                espera = espera - esperaTempo;

                inimigoAtacar();
            }
        }

    }
    public void inimigoAtacar()
    {
        //Cria um raycast mirado no jogador
        RaycastHit ataque;
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), transform.forward, out ataque, alcance))
        {
            Debug.Log(ataque.collider);
            tocarSom.PlayOneShot(ataqueTiro);
            if (ataque.collider.gameObject.tag == "Player")
            {
                JogadorScript.vida -= dano;
            }
        }
    }

}
