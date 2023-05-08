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
        Envanter.yerdekisusayisi = needsu;
        print(Envanter.acilankutu);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            print("a " + Envanter.acilankutu + " "+ needalev + " "  + needsu);
            
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
                Envanter.yerdekisusayisi = needsu;
            }
            if(needalev == 0 && needhava == 0 && needsu == 0 && needtoprak == 0)
            {
                if (Envanter.acilankutu == 3)
                {
                    Envanter.acilankutu++;
                    print("abc");
                    needalev = 5;
                    needsu = 5;

                }
                if(Envanter.acilankutu == 4)
                {
                    if (needalev == 0 && needsu == 0)
                    {
                        kutu[7].SetActive(true);
                    }
                }
                else
                {
                    print("b" + Envanter.acilankutu);
                    acilankutu = Envanter.acilankutu;
                    Envanter.isTrue[acilankutu] = true;
                    kutu[acilankutu].SetActive(true);
                    kutu[acilankutu + 3].SetActive(false);
                    kutu[acilankutu + 4].SetActive(true);
                    if (Envanter.acilankutu >= 1)
                    {
                        kutu[3].SetActive(false);
                    }

                    Envanter.acilankutu++;

                    needalev = 2;
                    needsu = 2;
                    Envanter.yerdekisusayisi = needsu;
                    Envanter.yerdekialevsayisi = needalev;
                    print(Envanter.yerdekialevsayisi);
                    print("needalev" + needalev);
                    print("needsu" + needsu);
                }

            }
        }
    }
    private void Fýrlat()
    {
        ThrowBall throwBall = GameObject.FindGameObjectWithTag("Player").GetComponent<ThrowBall>();
        throwBall.ThroWball();
    }
}
