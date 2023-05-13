using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIChangePassword : MonoBehaviour
{
    [SerializeField] Button changePasswordPage;
    void Start()
    {
        changePasswordPage.onClick.AddListener(ChangePasswordPage);
    }

    private void ChangePasswordPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.ChnagePasswordAccountScene);
    }
}
