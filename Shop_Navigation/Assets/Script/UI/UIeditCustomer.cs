using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIeditCustomer : MonoBehaviour
{
    [SerializeField] Button editCustomerpage;

    void Start()
    {
        editCustomerpage.onClick.AddListener(EditCustomerPage);
    }

    private void EditCustomerPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.EditCustomerScene);
    }
}
