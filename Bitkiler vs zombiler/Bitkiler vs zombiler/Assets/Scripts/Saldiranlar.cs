using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saldiranlar : MonoBehaviour
{
    public float SuAnkiHiz;
    private GameObject mevcutHedef;
    private Animator objeninAnimatoru;

    [Tooltip("Kaç saniyede bir doğacağını buraya giriniz.")]
    public float kacSaniyedeBirDogacak;
    void Start()
    {
        objeninAnimatoru = GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(Vector3.left * SuAnkiHiz * Time.deltaTime);
    }
    public void SuAnkiHiziAyarla(float hiz)
    {
        SuAnkiHiz = hiz;
    }
    public void ZararVer(float zararMiktari)
    {
        if (mevcutHedef)
        {
            Saglik saglik = mevcutHedef.GetComponent<Saglik>();
            if (saglik)
            {
                saglik.ZararAl(zararMiktari);
            }
        }
    }
    public void HedefiBelirle(GameObject hedefimiz)
    {
        mevcutHedef = hedefimiz;
    }

}
