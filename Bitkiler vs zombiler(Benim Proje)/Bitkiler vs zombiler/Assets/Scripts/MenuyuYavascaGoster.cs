using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuyuYavascaGoster : MonoBehaviour
{
    public float YavascaGostermeSuresi;
    private Color guncelRenk = Color.black;
    void Start()
    {

    }
    void Update()
    {
        if (Time.timeSinceLevelLoad < YavascaGostermeSuresi)
        {
            float alfaDegisimi = Time.deltaTime / YavascaGostermeSuresi;
            guncelRenk.a -= alfaDegisimi;
            GetComponent<Image>().color=guncelRenk;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
