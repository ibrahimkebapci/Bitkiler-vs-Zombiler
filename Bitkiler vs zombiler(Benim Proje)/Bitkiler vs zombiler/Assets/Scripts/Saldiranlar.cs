using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saldiranlar : MonoBehaviour
{
    //[Range(0f,1000f)]
    private float SuAnkiHiz;
    private GameObject mevcutHedef;
    private Animator objeninAnimatoru;

    [Tooltip("Kac Saniyede Bir Dogacagini Buraya Giriniz.")]
    public float kacSaniyedeBirDogacak;

    void Start()
    {
        objeninAnimatoru = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * SuAnkiHiz * Time.deltaTime);
        if (mevcutHedef)
        {
            objeninAnimatoru.SetBool("Saldirivarmi", true);
        }
        else if (!mevcutHedef)
        {
            objeninAnimatoru.SetBool("Saldirivarmi", false);
        }
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
