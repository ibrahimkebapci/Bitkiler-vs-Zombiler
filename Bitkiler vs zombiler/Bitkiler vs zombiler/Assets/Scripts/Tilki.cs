using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Saldiranlar))]
public class Tilki : MonoBehaviour
{
    private Animator tilkiAnimator;
    private Saldiranlar saldiranObje;
    // Start is called before the first frame update
    void Start()
    {
        tilkiAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<Saldiranlar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject tilkininEtkilesimeGirdigiObje = collision.gameObject;
        if (!tilkininEtkilesimeGirdigiObje.GetComponent<Savunanlar>()) 
        {
            return;
        }
        else if (tilkininEtkilesimeGirdigiObje.GetComponent<Tas>())
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
