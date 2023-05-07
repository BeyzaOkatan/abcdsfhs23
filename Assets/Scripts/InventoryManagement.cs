using UnityEngine;

public class InventoryManagement : MonoBehaviour
{
    public static InventoryManagement instance;

    public int alevSayisi = 0;
    public int yerdekiAlevSayisi = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
