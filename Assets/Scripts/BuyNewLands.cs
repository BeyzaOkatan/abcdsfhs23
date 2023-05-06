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
            print("a"); 
            while(Envanter.alevsayisi > 0 && needalev > 0)
            {
                Fırlat();
                Envanter.alevsayisi--;
                needalev--;
            }
            while (Envanter.havasayisi > 0 && needhava > 0)
            {
                Fırlat();
                Envanter.havasayisi--;
                needhava--;
            }
            while (Envanter.topraksayisi > 0 && needtoprak > 0)
            {
                Fırlat();
                Envanter.topraksayisi--;
                needtoprak--;
            }
            while (Envanter.susayisi > 0 && needsu > 0)
            {
                Fırlat();
                Envanter.susayisi--;
                needsu--;
            }
            if(needalev == 0 && needhava == 0 && needsu == 0 && needtoprak == 0)
            {
                print("b");
                acilankutu = Envanter.acilankutu;
                kutu[acilankutu].SetActive(true);
                Envanter.acilankutu++;
                if(Envanter.acilankutu == 3)
                {
                    gameObject.SetActive(false);
                }
            }
        }
    }
    private void Fırlat()
    {

    }
}
