using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    public void Awake()
    {
        Instance = this;
    }
    public enum Scene
    {
        FirstScene,
        LoginScene,
        RoleScene,
        RegisterCustomerScene,
        RegisterShopOwnerScene,
        RegisterShopScene,
        WelcomeScene,
        HomeScene,
        Home_CustomerScene,
        AddPromotionScene,
        ChangePasswordAccountScene,
        Change_PasswordCustomerScene,
        EditCustomerScene,
        EditPageAccountScene,
        EditPageShopScene,
        PermissionScene,
        SearchingScene,
        ShopCapacityScene
    }
    public void LoadScene(Scene scene )
    {
        SceneManager.LoadScene(scene.ToString());
    }
    
}
