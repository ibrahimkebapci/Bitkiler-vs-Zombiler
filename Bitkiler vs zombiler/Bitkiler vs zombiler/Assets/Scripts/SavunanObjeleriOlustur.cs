using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavunanObjeleriOlustur : MonoBehaviour
{
    public Camera bizimKameramiz;
    private GameObject savunanObjeParent;
    // Start is called before the first frame update
    private void Start()
    {
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

        GameObject yeniSavunanObje = Instantiate(PanelElemanKontrol.seciliEleman, gercekDunyaPozisyonunuYukariYuvarlama, Quaternion.identity);
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
        float kameraUzakligi = 10f;

        Vector3 mousePozisyonu = new Vector3(fareX,fareY, kameraUzakligi);
        Vector2 gercekDunyadakiPozisyonu = bizimKameramiz.ScreenToWorldPoint(mousePozisyonu);
       
        return gercekDunyadakiPozisyonu;
    }
}
