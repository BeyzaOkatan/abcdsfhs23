using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envanter : MonoBehaviour
{
    public static int alevsayisi = 6;

    public static int yerdekialevsayisi;
    public static int susayisi;
    public static int yerdekisusayisi;
    public static int topraksayisi;
    public static int yerdekitopraksayisi;
    public static int havasayisi;
    public static int yerdekihavasayisi;
    public static int acilankutu;
    public static bool[] isTrue = new bool[3];
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public static void AddAlev(int alev)
    {
        alevsayisi += alev;
    }
    public static string ReturnAlev()
    {
        return alevsayisi.ToString();
    }
    public static void AddSu(int su)
    {
        susayisi += su;
    }
    public static string ReturnSu()
    {
        return susayisi.ToString();
    }
    public static void AddToprak(int toprak)
    {
        topraksayisi += toprak;
    }
    public static string ReturnToprak()
    {
        return topraksayisi.ToString();
    }
    public static void AddHava(int hava)
    {
        havasayisi += hava;
    }
    public static string ReturnHava()
    {
        return havasayisi.ToString();
    }

}
