using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saglik : MonoBehaviour
{
    public float Can;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ZararAl(float zararMiktari)
    {
        Can -= zararMiktari;
        if(Can <= 0 )
        {
            ObjeyiYokEt();
        }
    }
    public void ObjeyiYokEt()
    {
        Destroy(gameObject);
    }
}
