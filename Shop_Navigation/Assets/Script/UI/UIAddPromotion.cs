using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAddPromotion : MonoBehaviour
{
    [SerializeField] Button addPromotionPage;

    void Start()
    {
        addPromotionPage.onClick.AddListener(AddPromotionPage);
    }

    private void AddPromotionPage()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.AddPromotionScene);
    }
}
