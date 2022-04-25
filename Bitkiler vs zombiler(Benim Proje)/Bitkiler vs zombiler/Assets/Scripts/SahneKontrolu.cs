using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKontrolu : MonoBehaviour
{
    public float SonrakiSahneninYuklenmeSuresi;
    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "0.MenudenOncekiSahne")
        {
            //aktif olan sahnemizin ismi 0.MenudenOncekiSahne ise Invoke fonksiyonunu çalıştır
            Invoke("SonrakiSahne", SonrakiSahneninYuklenmeSuresi);
        }
    }
    public void SonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //aktif olan sahnenin indexini 1 arttırıp yani sahneye geç
    }

    public void OyundanCikis()
    {
        Debug.Log("Oyundan çıkış gerçekleşti");
        Application.Quit();
    }
    public void IsimleSahneCagirma(string sahneIsmi)
    {
        SceneManager.LoadScene(sahneIsmi);
    }
    public void IndexleSahneCagirma(int sahneIndexi)
    {
        SceneManager.LoadScene(sahneIndexi);
    }
}
