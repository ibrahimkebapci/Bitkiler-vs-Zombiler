using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saglik : MonoBehaviour
{

    public float Can;
    public void ZararAl(float zararMiktari)
    {
        Can -= zararMiktari;   
        if (Can <= 0)
        {
            ObjeyiYokEt();
        }
    }
    public void ObjeyiYokEt()
    {
        Destroy(gameObject);
    }
}
