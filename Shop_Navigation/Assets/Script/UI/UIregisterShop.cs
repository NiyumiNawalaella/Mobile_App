using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIregisterShop : MonoBehaviour
{
    [SerializeField] Button registerShopPage;

    void Start()
    {
        registerShopPage.onClick.AddListener(RegisterShopPage);
    }

    private void RegisterShopPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.RegisterShopScene);
    }
}
