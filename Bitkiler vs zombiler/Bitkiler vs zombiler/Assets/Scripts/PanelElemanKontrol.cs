using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelElemanKontrol : MonoBehaviour
{
    public GameObject elemanPrefab;
    public PanelElemanKontrol[] panelinElemanlari;
    public static GameObject seciliEleman;

    // Start is called before the first frame update
    void Start()
    {
        panelinElemanlari = GameObject.FindObjectsOfType<PanelElemanKontrol>();
        foreach (PanelElemanKontrol eleman in panelinElemanlari)
        {
            eleman.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
    private void OnMouseDown()
    {
        seciliEleman = elemanPrefab;
        foreach(PanelElemanKontrol eleman in panelinElemanlari)
        {
            eleman.GetComponent<SpriteRenderer>().color = Color.black;
        }
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
