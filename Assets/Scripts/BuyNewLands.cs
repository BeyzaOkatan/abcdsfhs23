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
            if(Envanter.yerdekialevsayisi == 0 && needhava == 0 && needsu == 0 && needtoprak == 0)
            {
                print("b" + Envanter.acilankutu);
                acilankutu = Envanter.acilankutu;
                kutu[acilankutu].SetActive(true);
                Envanter.acilankutu++;
                if(Envanter.acilankutu == 3)
                {
                    gameObject.SetActive(false);
                }
                needalev = 2;
            }
        }
    }
    private void Fýrlat()
    {
        ThrowBall throwBall = GameObject.FindGameObjectWithTag("Player").GetComponent<ThrowBall>();
        throwBall.ThroWball();
    }
}
