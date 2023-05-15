using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Firebase;
using Firebase.Auth;
using TMPro;
public class AuthControlChangePasswordShopOwner : MonoBehaviour
{
    public InputField currentPasswordInput, PasswordInput, ConfirmPasswordInput;
    public GameObject ChangePasswordPanel, WarningPanel;
    public Text warning_Title_Text, warning_Message_Text;



    public void ChangePasswordShopOwner()
    {
        if (string.IsNullOrEmpty(currentPasswordInput.text) && string.IsNullOrEmpty(PasswordInput.text) && string.IsNullOrEmpty(ConfirmPasswordInput.text))
        {
            showWarningMessage("Error", "Fields are Empty, Please fill all the Input Fields");
            return;
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
