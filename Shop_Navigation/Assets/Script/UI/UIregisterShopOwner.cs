using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIregisterShopOwner : MonoBehaviour
{
    [SerializeField] Button registershopowner;

    void Start()
    {
        registershopowner.onClick.AddListener(RegisterShopOwnerPage);
    }

    private void RegisterShopOwnerPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.RegisterShopOwnerScene);
    }
}
