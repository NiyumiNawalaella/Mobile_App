using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIbackbuttonCustomer : MonoBehaviour
{
    public string Home_CustomerScene;
    public void GoBack()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Home_CustomerScene);

       
    }
}
