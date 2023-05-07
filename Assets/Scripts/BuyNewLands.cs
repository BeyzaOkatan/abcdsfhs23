using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyNewLands : MonoBehaviour
{
    [SerializeField] int needalev;
    [SerializeField] int needhava;
    [SerializeField] int needsu;
    [SerializeField] int needtoprak;
    [SerializeField] GameObject[] kutu;
    private int acilankutu;
    private void Start()
    {
        for(int i = 0; i < Envanter.acilankutu; i++)
        {
            kutu[i].SetActive(Envanter.isTrue[i]);
        }
    }
    private void Update()
    {
        Envanter.yerdekialevsayisi = needalev;
        print(Envanter.acilankutu);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            print("a " + Envanter.acilankutu + " "+ needalev);
            
            while(Envanter.alevsayisi > 0 && needalev > 0)
            {
                Fýrlat();
                Envanter.alevsayisi--;
                needalev--;
                Envanter.yerdekialevsayisi = needalev;
            }
            while (Envanter.havasayisi > 0 && needhava > 0)
            {
                Fýrlat();
                Envanter.havasayisi--;
                needhava--;
            }
            while (Envanter.topraksayisi > 0 && needtoprak > 0)
            {
                Fýrlat();
                Envanter.topraksayisi--;
                needtoprak--;
            }
            while (Envanter.susayisi > 0 && needsu > 0)
            {
                Fýrlat();
                Envanter.susayisi--;
                needsu--;
            }
            if(needalev == 0 && needhava == 0 && needsu == 0 && needtoprak == 0)
            {
                print("b" + Envanter.acilankutu);
                acilankutu = Envanter.acilankutu;
                Envanter.isTrue[acilankutu] = true; 
                kutu[acilankutu].SetActive(true);
                kutu[acilankutu + 3].SetActive(false);
                kutu[acilankutu + 4].SetActive(true);
                if(Envanter.acilankutu >= 1)
                {
                    kutu[3].SetActive(false);
                }
                if (Envanter.acilankutu == 3)
                {
                    Destroy(kutu[6]);
                }
                Envanter.acilankutu++;
                needalev = 2;
                print("needalev" + needalev);
            }
        }
    }
    private void Fýrlat()
    {
        ThrowBall throwBall = GameObject.FindGameObjectWithTag("Player").GetComponent<ThrowBall>();
        throwBall.ThroWball();
    }
}
