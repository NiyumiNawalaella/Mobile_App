using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Firebase;
using Firebase.Auth;

public class AuthController : MonoBehaviour
{
    public InputField emailInput, passwordInput, forgetPassEmail;
    public GameObject Login_Panel, ForgetPassordPanel, WarningPanel;
    public Text warning_Title_Text, warning_Message_Text, Login_Text;

    [Header("Firebase")]
    public DependencyStatus dependencyStatus;
    public FirebaseUser User;
    public FirebaseAuth Auth;
    //private FirebaseApp app;

    public void OpenLoginPanel()
    {
        Login_Panel.SetActive(true);
        ForgetPassordPanel.SetActive(false);
    }
    public void OpenForgetPasswordPanel()
    {
        Login_Panel.SetActive(false);
        ForgetPassordPanel.SetActive(true);
    }
    public void LoginUser()
    {
        if (string.IsNullOrEmpty(emailInput.text) && string.IsNullOrEmpty(passwordInput.text))
        {
            showWarningMessage("Error", "Fields are Empty, Please fill all the Input Fields");
            return;
        }
        //Do Login
    }

    public void forgetPass()
    {
        if (string.IsNullOrEmpty(forgetPassEmail.text))
        {
            showWarningMessage("Error", "Fields are Empty, Please fill all the Input Fields");
            return;
        }
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
    private void Awake()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                //If they are avaliable Initialize Firebase
                //app = Firebase.FirebaseApp.DefaultInstance;
               Debug.Log("Setting up Firebase Auth");
               //Set the authentication instance object
               Auth = FirebaseAuth.DefaultInstance;
            }
            else
            {
                showWarningMessage("Could not resolve all Firebase dependencies: ", " " + dependencyStatus);
            }
        });
    }
    public void LoginButton()
    {
        //Call the login coroutine passing the email and password
        StartCoroutine(Login(emailInput.text, passwordInput.text));
    }

    private IEnumerator Login(string _email, string _password)
    {
        //Call the function auth signin function passing the email and password
        var LoginTask = FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(_email, _password);
        yield return new WaitUntil(predicate: () => LoginTask.IsCompleted);

        if(LoginTask.Exception != null)
        {
            //If there are errors handle them
            Debug.LogWarning(message:$"Failed to register task with {LoginTask.Exception}");
            FirebaseException firebaseEx = LoginTask.Exception.GetBaseException() as FirebaseException;
            AuthError errorCode = (AuthError)firebaseEx.ErrorCode;

            showWarningMessage("","Login Failed!");
            switch(errorCode)
            {
                case AuthError.MissingEmail:
                    showWarningMessage("", "Missing Email");
                    break;
                case AuthError.MissingPassword:
                    showWarningMessage("", "Missing Password");
                    break;
                case AuthError.WrongPassword:
                    showWarningMessage("", "Wrong Password");
                    break;
                case AuthError.InvalidEmail:
                    showWarningMessage("", "Invalid Email");
                    break;
                case AuthError.UserNotFound:
                    showWarningMessage("", "Account does not exist");
                    break;
            }
        }
        else
        {
            //User is now logged in
            //Now get the result
            User = LoginTask.Result.User;
            Debug.LogFormat("User signed in successfully: {0} ({1})", User.UserId, User.Email);
            Login_Text.text = "Logged In";
        }
    }
}
   /* public void SignInUser(string email, string password)
    {
        FirebaseAuth.SignInWithEmailAndPasswordAsync(emailInput, passwordInput).ContinueWith(task =>
        {
        if (task.IsCanceled)
        {
            Debug.LogError("SignInWithEmailAndPasswordAsync was Canceled.");
        }
        if (task.IsFaulted)
        {
            Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
            return;
        }

        Firebase.Auth.FirebaseUser newUser = task.Result;
        Debug.LogFormat("User Signed in sucessfully: {0} ({1})",
        newUser.DisplayName, newUser.UserId);
        });
    }
}*/

/*{
    public Text emailInput, passwordInput;
    //[SerializeField] Button registershop, registerCustomer;

    public void Login()
    {
        if (emailInput.text.Equals("") && passwordInput.text.Equals(""))
        {
            print("Please enter an email and password to login");
            return;
        }
        FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(emailInput.text, passwordInput.text).ContinueWith((task => { 
        
            if(task.IsCanceled)
            {
                return;
            }
            if(task.IsFaulted)
            {
                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetErrorMessage((AuthError)e.ErrorCode);

                return;
            }
            if(task.IsCompleted)
            {
                print("User Logged In");
                return;
            }
        }));
    }
    //void Start()
    //{
        //registershop.onClick.AddListener(RegisterShopPage);
       // registerCustomer.onClick.AddListener(RegisterCustomer);
    //}
    public void Login_Anonymous() { }

    /*public void RegisterUser()
    {
        if (emailInput.text.Equals("") && passwordInput.text.Equals("") && roleInput.text.Equals(""))
        {
            print("Please enter an email, password and select the role to register");
            return;
        }
       
            FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(emailInput.text, passwordInput.text).ContinueWith((task =>
            {
                if (task.IsCanceled)
                {
                    Firebase.FirebaseException e = task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                    GetErrorMessage((AuthError)e.ErrorCode);
                    return;
                }
                if (task.IsFaulted)
                {
                    Firebase.FirebaseException e =
                    task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                    GetErrorMessage((AuthError)e.ErrorCode);

                    return;
                }
                if (task.IsCompleted)
                {
                    print("Registracion COMPLETE");
                    //ScenesManager.Instance.LoadScene(ScenesManager.Scene.WelcomeScene);
                    //registerCustomer.GetComponentRegister
                }
            }));
        
    }
     
   
public void Logout() { }

    public void GetErrorMessage(AuthError errorCode)
    {
        string msg = "";

        msg = errorCode.ToString();

        print(msg);
    }
}*/
