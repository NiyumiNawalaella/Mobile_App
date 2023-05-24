using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIwelcomeCustomer : MonoBehaviour
{
    [SerializeField] Button welcomeCustomerPage;

    void Start()
    {
        welcomeCustomerPage.onClick.AddListener(WelcomeCustomerPage);
    }

    private void WelcomeCustomerPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.WelcomeCustomer);
    }
}
