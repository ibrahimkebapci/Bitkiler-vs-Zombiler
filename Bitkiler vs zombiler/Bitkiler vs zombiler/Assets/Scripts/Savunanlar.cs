using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savunanlar : MonoBehaviour
{
   private ParayiTopla paraKazanma;

   private void Start()
   {
        paraKazanma = GameObject.FindObjectOfType<ParayiTopla>();
   }
   public void ParayiArttir(int paraMiktari)
    {
        paraKazanma.ParayiEkle(paraMiktari);
    }

}
