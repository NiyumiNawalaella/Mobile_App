using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIhome_customer : MonoBehaviour
{

    [SerializeField] Button customer_home;


    void Start()
    {
        customer_home.onClick.AddListener(Customer_homePage);
    }

    private void Customer_homePage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Home_CustomerScene);
    }
    // {

    //     Home_Panel.SetActive(true);
    //     Promotion_Panel.SetActive(false);
    //     Search_Panel.SetActive(false);
    //     Account_Panel.SetActive(false);
    // }

}

