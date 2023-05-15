using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Firebase;
using Firebase.Auth;
using TMPro;
public class AuthControlRegisterShopOwner : MonoBehaviour
{
    public InputField EmailInput, PasswordInput, ConfrimPasswordInput;
    public GameObject RegisterPanel, WarningPanel;
    public Text warning_Title_Text, warning_Message_Text;


    public void RegisterShopOwner()
    {
        if (string.IsNullOrEmpty(EmailInput.text) && string.IsNullOrEmpty(PasswordInput.text) && string.IsNullOrEmpty(ConfrimPasswordInput.text))
        {
            showWarningMessage("Error", "Fields are Empty, Please fill all the Input Fields");
            return;
        }
        //validation for similar password between new password and confrim password
    }

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
