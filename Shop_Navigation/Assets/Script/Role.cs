using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour
{
    public GameObject CustomerRegisterPanel, RolePanel, ShopOwnerRegisterPanel;

    public void rolePanel()
    {
        RolePanel.SetActive(true);
        CustomerRegisterPanel.SetActive(false);
        ShopOwnerRegisterPanel.SetActive(false);
    }
    public void customerRegisterPanel()
    {
        RolePanel.SetActive(false);
        CustomerRegisterPanel.SetActive(true);
        ShopOwnerRegisterPanel.SetActive(false);
    }
    public void shopownerRegisterPanel()
    {
        RolePanel.SetActive(false);
        CustomerRegisterPanel.SetActive(false);
        ShopOwnerRegisterPanel.SetActive(true);
    }
}
