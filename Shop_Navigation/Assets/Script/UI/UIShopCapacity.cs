using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIShopCapacity : MonoBehaviour
{
    [SerializeField] Button shopCapacityPage;
    void Start()
    {
        shopCapacityPage.onClick.AddListener(ShopCapacityPage);
    }
        
    private void ShopCapacityPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.ShopCapacityScene);
    }
}
