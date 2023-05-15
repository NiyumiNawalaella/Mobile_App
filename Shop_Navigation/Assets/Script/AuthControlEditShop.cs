using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Firebase;
using Firebase.Auth;
using TMPro;
public class AuthControlEditShop : MonoBehaviour
{
    public InputField ShopNameInput, TelePhoneNumberInput, ShopDescriptionInput, ShopRoomNumberInput, ShopLocatedFloorNumberInput;
    public Dropdown ShopTypeInput;
    public GameObject EditShopPanel, WarningPanel;
    public Text warning_Title_Text, warning_Message_Text;



    public void EditShop()
    {
        if (string.IsNullOrEmpty(ShopNameInput.text) && string.IsNullOrEmpty(TelePhoneNumberInput.text) && string.IsNullOrEmpty(ShopDescriptionInput.text) && string.IsNullOrEmpty(ShopRoomNumberInput.text) && string.IsNullOrEmpty(ShopLocatedFloorNumberInput.text))
        {
            showWarningMessage("Error", "Fields are Empty, Please fill all the Input Fields");
            return;
        }
    }
    private void Start()
    {
        ShopTypeInput.onValueChanged.AddListener(OnDropdownValueChanged);
    }
    private void OnDropdownValueChanged(int value)
    {
        if (value == 0)
        {
            showWarningMessage("Error", "Fields are Empty, Please Select Shop Type");
        }

    }
    //validation for similar password between new password and confrim password


    private void showWarningMessage(string title, string message)
    {
        warning_Title_Text.text = "" + title;
        warning_Message_Text.text = "" + message;

        WarningPanel.SetActive(true);
    }

    public void CloseWarningMessage_Panel()
    {
        WarningPanel.SetActive(false);
    }
}
