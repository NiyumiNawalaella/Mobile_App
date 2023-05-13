using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIregister : MonoBehaviour
{
    [SerializeField] Button registerrole;

    void Start()
    {
        registerrole.onClick.AddListener(RolePage);
    }

    private void RolePage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.RoleScene);
    }
}
