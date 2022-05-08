using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavunanObjeleriOlustur : MonoBehaviour
{

    public Camera bizimKameramiz;

    private ParayiTopla toplamPara;
    private GameObject savunanObjeParent;

    private void Start()
    {
        toplamPara = GameObject.FindObjectOfType<ParayiTopla>();
        savunanObjeParent = GameObject.Find("Savunanlar");

        if (!savunanObjeParent)
        {
            savunanObjeParent = new GameObject("Savunanlar");
        }
    }

    private void OnMouseDown()
    {
        Vector2 gercekDunyaPozisyonu = farePozisyonunuGercekDunyayaAktar();
        Vector2 gercekDunyaPozisyonunuYukariYuvarlama = pozisyonuYuvarla(gercekDunyaPozisyonu);
        GameObject olusacakSavunanObje = PanelElemanKontrol.seciliEleman;

        int savunanObjeninMaliyeti = olusacakSavunanObje.GetComponent<Savunanlar>().maliyet;

        if (toplamPara.ParayiKullan(savunanObjeninMaliyeti) == ParayiTopla.ObjeOlusturmaDurumu.BASARILI)
        {
            ObjeyiOlustur(olusacakSavunanObje, gercekDunyaPozisyonunuYukariYuvarlama);
        }
        else
        {
            Debug.Log("Bakiyeniz yetersiz.");
        }
    }

    private void ObjeyiOlustur(GameObject olusacakSavunanObjemiz, Vector2 gercekDunyaPozisyonunuYukariYuvarlamamiz)
    {
        GameObject yeniSavunanObje = Instantiate(PanelElemanKontrol.seciliEleman, gercekDunyaPozisyonunuYukariYuvarlamamiz, Quaternion.identity) as GameObject;
        yeniSavunanObje.transform.parent = savunanObjeParent.transform;
    }

    Vector2 pozisyonuYuvarla(Vector2 yuvarlanacakPozisyon)
    {
        float yuvarlaX = Mathf.CeilToInt(yuvarlanacakPozisyon.x);
        float yuvarlaY = Mathf.CeilToInt(yuvarlanacakPozisyon.y);
        return new Vector2(yuvarlaX, yuvarlaY);
    }
    Vector2 farePozisyonunuGercekDunyayaAktar()
    {
        float fareX = Input.mousePosition.x;
        float fareY = Input.mousePosition.y;
        float kameraUzakligi = 15f;

        Vector3 mousePozisyonu = new Vector3(fareX, fareY, kameraUzakligi);
        Vector2 gercekDunyadakiPozisyonu = bizimKameramiz.ScreenToWorldPoint(mousePozisyonu);

        return gercekDunyadakiPozisyonu;
    }
}
