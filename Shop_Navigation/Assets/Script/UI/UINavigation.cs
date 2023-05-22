using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class UINavigation : MonoBehaviour
{
    [SerializeField] Button searchingbutton;
    void Start()
    {
        searchingbutton.onClick.AddListener(NavigationPage);
    }

    private void NavigationPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.NavigationScene);
    }
}
