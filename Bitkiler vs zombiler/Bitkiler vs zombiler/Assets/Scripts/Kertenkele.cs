using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Saldiranlar))]
public class Kertenkele : MonoBehaviour
{

    private Animator kertenkeleAnimator;
    private Saldiranlar saldiranObje;
    // Use this for initialization
    void Start()
    {
        /*
        kertenkeleAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<Saldiranlar>();
        */    
    }

    private void OnTriggerEnter2D(Collider2D colider2D)
    {
        GameObject kertenkeleninEtkilesimeGirdigiObje = colider2D.gameObject;

        if (!(colider2D.gameObject.tag == "Savunanlar"))
        {
            return;
        }
        else
        {
            kertenkeleAnimator.SetBool("SaldiriVarMi", true);
            saldiranObje.HedefiBelirle(kertenkeleninEtkilesimeGirdigiObje);
        }
        /*if (!kertenkeleninEtkilesimeGirdigiObje.GetComponent<Savunanlar>())
        {
            return;
        }
        else
        {
            kertenkeleAnimator.SetBool("SaldiriVarMi", true);
            saldiranObje.HedefiBelirle(kertenkeleninEtkilesimeGirdigiObje);
        }
        */
    }
}
