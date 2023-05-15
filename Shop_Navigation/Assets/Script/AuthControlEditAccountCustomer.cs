using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Firebase;
using Firebase.Auth;
using TMPro;
public class AuthControlEditAccountCustomer : MonoBehaviour
{
    public InputField nameInput, emailInput, idInput;
    public GameObject EditAccountCustomerPanel, WarningPanel;
    public Text warning_Title_Text, warning_Message_Text;


    public void EditAccountCustomer()
    {
        if (string.IsNullOrEmpty(nameInput.text) && string.IsNullOrEmpty(emailInput.text) && string.IsNullOrEmpty(idInput.text))
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
