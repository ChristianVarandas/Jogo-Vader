using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{

    private CharacterController controleJogador;
    private Transform cam;
    float speed = 10;
    public int vida = 100;
    public Vector3 mover;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        controleJogador = GetComponent<CharacterController>();
        cam = Camera.main.transform;

        transform.position = new Vector3(280f, 0.43f, -253f);

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        mover = new Vector3(horizontal, 0, vertical);

        mover = cam.TransformDirection(mover);
        mover.y = 0;

        controleJogador.Move(mover * Time.deltaTime * speed);

        if(mover != Vector3.zero)
        {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(mover), Time.deltaTime * 10);
        }
       
        if(vida <= 0)
        {
            SceneManager.LoadScene("FimJogo");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }



}