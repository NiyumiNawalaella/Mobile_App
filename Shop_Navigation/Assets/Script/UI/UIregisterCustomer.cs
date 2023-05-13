using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIregisterCustomer : MonoBehaviour
{
    [SerializeField] Button registercustomer;

    void Start()
    {
        registercustomer.onClick.AddListener(RegisterCustomerPage);
    }

    private void RegisterCustomerPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.RegisterCustomerScene);
    }
}
