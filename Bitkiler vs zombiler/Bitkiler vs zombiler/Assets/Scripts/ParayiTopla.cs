using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ParayiTopla : MonoBehaviour
{
  private int toplamPara = 0;
  private Text paraMiktarininGosterimi;
  private void Start()
    {
        paraMiktarininGosterimi = GetComponent<Text>();
    }
  public void ParayiEkle(int paraMiktari)
    {
        toplamPara += paraMiktari;
        parayiEkrandaGoster();
    }

    public void ParayiSil(int paraMiktari)
    {
        toplamPara -= paraMiktari;
        parayiEkrandaGoster();
    }

    public void parayiEkrandaGoster()
    {
        paraMiktarininGosterimi.text = toplamPara.ToString();
    }
}
