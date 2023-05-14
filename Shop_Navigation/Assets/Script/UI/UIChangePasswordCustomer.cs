using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIChangePasswordCustomer : MonoBehaviour
{
    [SerializeField] Button changePasswordCustomerPage;
    void Start()
    {
        changePasswordCustomerPage.onClick.AddListener(ChangePasswordCustomerPage);
    }

    private void ChangePasswordCustomerPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Change_PasswordCustomerScene);
    }
}
