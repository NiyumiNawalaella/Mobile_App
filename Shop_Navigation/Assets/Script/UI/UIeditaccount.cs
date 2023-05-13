using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIeditaccount : MonoBehaviour
{
    [SerializeField] Button editAccountpage;
 
    void Start()
    {
        editAccountpage.onClick.AddListener(EditAccountPage);
    }

    private void EditAccountPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.EditPageAccountScene);
    }
}
