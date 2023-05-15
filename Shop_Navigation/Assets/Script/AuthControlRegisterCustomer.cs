using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading.Tasks;
using Firebase;
using Firebase.Auth;
using TMPro;
using Firebase.Extensions;

public class AuthControlRegisterCustomer : MonoBehaviour
{ ///
    /*
    Firebase.Auth.FirebaseAuth auth;
    Firebase.Auth.FirebaseUser user;

    void Start()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                InitializeFirebase();

                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
    }

    private void InitializeFirebase()
    {
        throw new NotImplementedException();
    }

    private void Awake()
    {
        auth = FirebaseAuth.DefaultInstance;
    }
    public InputField emailInput, passwordInput, confrimpassowrdInput, usernameInput;
    public GameObject RegisterCustomer_Panel, WarningPanel;
    public Text warning_Title_Text, warning_Message_Text;

   
    public void RegisterUser()
    {
        if (string.IsNullOrEmpty(emailInput.text) && string.IsNullOrEmpty(passwordInput.text) && string.IsNullOrEmpty(confrimpassowrdInput.text))
        {
            showWarningMessage("Error", "Fields are Empty, Please fill all the Input Fields");
            return;
        }
        //validation for similar password between entered password and confrim password

        //Do SignUp
        CreateUser(emailInput.text, passwordInput.text, usernameInput.text);
    }

    private void showWarningMessage(string title, string message)
    {
        warning_Title_Text.text = "" + title;
        warning_Message_Text.text = "" + message;

        WarningPanel.SetActive(true);
    }

    public void CloseWarningMessage_Panel()
    {
        //warning_Title_Text.text = "";
        //warning_Message_Text.text = ""; 

        WarningPanel.SetActive(false);
    }
    void CreateUser(string email, string password, string username)
    {
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWithOnMainThread(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            // Firebase user has been created.
            Firebase.Auth.AuthResult result = task.Result;
            Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                result.User.DisplayName, result.User.UserId);

            UpdateUserProfile(username);
        });
    }*/
    ////
   /* public void SignInUser(string email, string password)
    {
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            Firebase.Auth.AuthResult result = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                result.User.DisplayName, result.User.UserId);
        });
    }
    void InitializeFirebase()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
        AuthStateChanged(this, null);
    }

    void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {
        if (auth.CurrentUser != user)
        {
            bool signedIn = user != auth.CurrentUser && auth.CurrentUser != null
                && auth.CurrentUser.IsValid();
            if (!signedIn && user != null)
            {
                Debug.LogError("Signed out " + user.UserId);
            }
            if (signedIn)
            {
                Debug.LogError("Signed in " + user.UserId);
                
            }
        }
    }*/

    /*void OnDestroy()
    {
        auth.StateChanged -= AuthStateChanged;
        auth = null;
    }
    */
    
    ///
    /*void UpdateUserProfile(string UserName)
    {
        Firebase.Auth.FirebaseUser user = auth.CurrentUser;
        if (user != null)
        {
            Firebase.Auth.UserProfile profile = new Firebase.Auth.UserProfile
            {
                DisplayName = UserName,
               // PhotoUrl = new System.Uri("https://example.com/jane-q-user/profile.jpg"),
            };
            user.UpdateUserProfileAsync(profile).ContinueWith(task => {
                if (task.IsCanceled)
                {
                    Debug.LogError("UpdateUserProfileAsync was canceled.");
                    return;
                }
                if (task.IsFaulted)
                {
                    Debug.LogError("UpdateUserProfileAsync encountered an error: " + task.Exception);
                    return;
                }

                Debug.Log("User profile updated successfully.");

                showWarningMessage("Alert", "Account Successfully Created");
            });
        }
    }*/
}
