using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIeditShopPage : MonoBehaviour
{
    [SerializeField] Button editShopPage;
    void Start()
    {
        editShopPage.onClick.AddListener(EditShopPage);
    }

    private void EditShopPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.EditPageShopScene);
    }
}
