using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Firebase;
using Firebase.Auth;
using TMPro;
public class AuthControlAddpromotion : MonoBehaviour
{
    public InputField ShopNameInput, ShopRoomNumberInput, AddPosterInput, PromoDescriptionInput, PromotionCodeInput;
    public GameObject AddPromotionPanel, WarningPanel;
    public Text warning_Title_Text, warning_Message_Text;



    public void AddPromotion()
    {
        if (string.IsNullOrEmpty(ShopNameInput.text) && string.IsNullOrEmpty(ShopRoomNumberInput.text) && string.IsNullOrEmpty(AddPosterInput.text) && string.IsNullOrEmpty(PromoDescriptionInput.text) && string.IsNullOrEmpty(PromotionCodeInput.text))
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
