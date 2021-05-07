using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private string email, password, userID, userName;

    public GameObject loginPanel, registerPanel, userInfoPanel, userAddressPanel, userAboutPanel, errorPanel;

    public InputField loginNameField, loginPassField;

    public InputField userNameField, passField, emailField, userIDField;

    public Button loginButton, goToRegister, registerButton;

    Dictionary<string, LogController> users = new Dictionary<string, LogController>()
    {
        {"default", new LogController ("default", "default", "default", "default") }
    };


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RegisterLoginButton()
    {
        loginPanel.SetActive(false);
        registerPanel.SetActive(true);
    }

    public void LoginSuccess()
    {
        if (string.IsNullOrWhiteSpace(emailField.text) || string.IsNullOrWhiteSpace(passField.text))
        {
            emailField.gameObject.SetActive(false);
            passField.gameObject.SetActive(false);
        }
    }
}
