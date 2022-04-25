using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecenekKontrolu : MonoBehaviour
{
    public Slider SesAyari;
    public Slider ZorlukAyari;
    public SahneKontrolu sahneYoneticisi;
    private MuzikKontrolu MuzikYoneticisi;

    void Start()
    {
        SesAyari.value = OyuncuAyarlar.AnaSesiAl();
        ZorlukAyari.value = OyuncuAyarlar.zorluguAl();
        MuzikYoneticisi = GameObject.FindObjectOfType<MuzikKontrolu>(); //// m�zikKontrol� tipinde olan nesneyi bulmak i�in kullan�l�r
    }

    void Update()
    {
        MuzikYoneticisi.SesiAyarla(SesAyari.value);
        //ses de�erinde de�i�iklik yapmak istedi�imizde 
    }

    public void SesiKaydetVeCik()
    {
        OyuncuAyarlar.AnaSesiAyarla(SesAyari.value);
        OyuncuAyarlar.ZorluguAyarla(ZorlukAyari.value);
        sahneYoneticisi.IsimleSahneCagirma("1.Menu");
    }
  
    public void BaslangicAyarlariniUygula()
    {
        SesAyari.value = 0.5f;
        ZorlukAyari.value = 2f;
    }
}
