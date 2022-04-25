using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaldiranObjeyiYolaKoy : MonoBehaviour
{

    public GameObject[] saldiranObjelerinPrefabi;
    // Update is called once per frame
    void Update()
    {
        foreach (GameObject saldiranObjeninPrefabi in saldiranObjelerinPrefabi)
        {
            if (SaldiriVaktiMi(saldiranObjeninPrefabi))
            {
                SaldiranObjeyiYolaYerlestir(saldiranObjeninPrefabi);
            }
        }
    }
    void SaldiranObjeyiYolaYerlestir(GameObject saldiranObje)
    {
        GameObject saldiranObjemiz = Instantiate(saldiranObje) as GameObject;
        saldiranObjemiz.transform.parent = transform;
        saldiranObjemiz.transform.position = transform.position;
    }

    bool SaldiriVaktiMi(GameObject saldiranObje)
    {
        Saldiranlar saldiriYapanObje = saldiranObje.GetComponent<Saldiranlar>();

        float dogmaBeklemeSuresi = saldiriYapanObje.kacSaniyedeBirDogacak;
        float dogmaBeklemeOrani = 1 / dogmaBeklemeSuresi;

        //0.16  //0.025  0.04  4/100
        float sonOran = dogmaBeklemeOrani * Time.deltaTime;

        //0.04
        if (Random.value < sonOran)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



}
