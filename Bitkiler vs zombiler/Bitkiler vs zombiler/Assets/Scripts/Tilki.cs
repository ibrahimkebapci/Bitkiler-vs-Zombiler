using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilki : MonoBehaviour
{
    private Animator tilkiAnimator;
    private Saldiranlar saldiranObje;
    // Use this for initialization
    void Start()
    {
        /*
        tilkiAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<Saldiranlar>();
        */
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
            tilkiAnimator.SetTrigger("ziplamaIslemi");
        }
        else
        {
            tilkiAnimator.SetBool("SaldiriVarMi", true);
            saldiranObje.HedefiBelirle(tilkininEtkilesimeGirdigiObje);
        }
        /*
        if (!tilkininEtkilesimeGirdigiObje.GetComponent<Savunanlar>())
        {
            return;
        }
        else if (tilkininEtkilesimeGirdigiObje.GetComponent<Tas>())
        {
            tilkiAnimator.SetTrigger("ziplamaIslemi");
        }
        else
        {
            tilkiAnimator.SetBool("SaldiriVarMi", true);
            saldiranObje.HedefiBelirle(tilkininEtkilesimeGirdigiObje);
        }
        */
    }
}
