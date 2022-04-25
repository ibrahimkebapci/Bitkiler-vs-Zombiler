using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kertenkele : MonoBehaviour
{
    private Animator KertenkeleAnimator;
    private Saldiranlar saldiranObje;
    // Start is called before the first frame update
    void Start()
    {
        KertenkeleAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<Saldiranlar>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject KertenkeleninEtkilesimeGirdigiObje = collision.gameObject;
        if (!KertenkeleninEtkilesimeGirdigiObje.GetComponent<Savunanlar>())
        {
            return;
        }

        else
        {
            KertenkeleAnimator.SetBool("Saldirivarmi", true);
            saldiranObje.HedefiBelirle(KertenkeleninEtkilesimeGirdigiObje);
        }
    }
}
