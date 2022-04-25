/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaldiranObjeyiYerineKoy : MonoBehaviour
{
    public GameObject[] saldiranObjelerinPrefabi;
    
    void Update()
    {
        foreach (GameObject saldiranOnjeninPrefabiItem  in  saldiranObjelerinPrefabi)
        {
            if(SaldiriVaktiMi(saldiranOnjeninPrefabiItem))
            {
                SaldiranObjeyiYolaYerlestir(saldiranOnjeninPrefabiItem);
            }
        }
    }
    void SaldiranObjeyiYolaYerlestir(GameObject saldiranObje)
    {
        GameObject saldiranObjeniz = Instantiate(saldiranObje) as GameObject;
        saldiranObjeniz.transform.parent = transform;
        saldiranObjeniz.transform.position = transform.position;
    }
    bool SaldiriVaktiMi(GameObject saldiranObje)
    {
        Saldiranlar saldiriYapanObje = saldiranObje.GetComponent<Saldiranlar>();
        
        float dogmaBeklemeSuresi = saldiriYapanObje.kacSaniyedeBirDogacak;
        float dogmaBeklemeOrani = 1 / dogmaBeklemeSuresi;

        float sonOran = dogmaBeklemeOrani * Time.deltaTime;

        if(Random.value < sonOran)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
*/