using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzikKontrolu : MonoBehaviour
{
    static MuzikKontrolu muzikOynaticisi;
    //müzik oynatıcısı tekrar tekrar oluşmasın diye static olarak tanımlıyoruz
    public void Awake()
    {
        Debug.Log("Awake Çalıştı");
        if (muzikOynaticisi != null)
        {
            Destroy(gameObject);
        }
        else
        {
            muzikOynaticisi = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    public void SesiAyarla(float SesDegeri)
    {
        GetComponent<AudioSource>().volume = SesDegeri;
        //yeni ses değerini atayabilmek için kullanılan kod satırı
    }
    private void Start()
    {

    }
}
