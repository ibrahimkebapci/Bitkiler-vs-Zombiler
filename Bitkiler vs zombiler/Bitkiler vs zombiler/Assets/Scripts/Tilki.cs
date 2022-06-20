using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilki : MonoBehaviour
{
    private Animator tilkiAnimator;
    private Saldiranlar saldiranObje;
    void Start()
    {      
        tilkiAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<Saldiranlar>(); 
    }
    private void OnTriggerEnter2D(Collider2D colider2D)
    {
        GameObject tilkininEtkilesimeGirdigiObje = colider2D.gameObject;

        if (!(colider2D.gameObject.tag == "Savunanlar"))
        {
            return;
        }
        else if (colider2D.gameObject.tag == "Tas")
        {
            tilkiAnimator.SetTrigger("ZiplamaTilki");
        }
        else
        {
            tilkiAnimator.SetBool("Saldirivarmi", true);
            saldiranObje.HedefiBelirle(tilkininEtkilesimeGirdigiObje);
        }
    }
}
