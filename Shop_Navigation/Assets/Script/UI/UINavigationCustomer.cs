using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UINavigationCustomer : MonoBehaviour
{
    [SerializeField] Button searchingbutton;
    void Start()
    {
        searchingbutton.onClick.AddListener(NavigationCustomerPage);
    }

    private void NavigationCustomerPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.NavigationCustomer);
    }
}
