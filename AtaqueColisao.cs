using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueColisao : MonoBehaviour
{
    public AtaqueVisual AtaqueVisual;
    public Fase fase;

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Inimigo" && AtaqueVisual.atacando)
        {
            Debug.Log(other.name);
            Destroy(other.gameObject);
            Fase.inimigosDerrotados += 1;
        }
    }
}
