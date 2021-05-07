using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject loginPanel, registerPanel;

    public InputField passField, emailField;

    public InputField registerPassField, registerEmailField, registerUserId, registerUsername;

    public Text messageText, loginSuccessText, registerLoginSuccessText;

    public void RegisterLoginButton()
    {
        loginPanel.SetActive(false);
        registerPanel.SetActive(true);
    }

    public void LoginSuccess()
    {
        if (!string.IsNullOrWhiteSpace(emailField.text) && !string.IsNullOrWhiteSpace(passField.text) && emailField.text.IndexOf('@') > 0)
        {
            emailField.gameObject.SetActive(false);
            passField.gameObject.SetActive(false);
            loginSuccessText.gameObject.SetActive(true);
        }
        else
        {
            messageText.text = "Data is incorrect! Try Again!";
        }
    }

    public void RegisterLoginSuccess()
    {
        if (!string.IsNullOrWhiteSpace(registerUsername.text) && !string.IsNullOrWhiteSpace(registerUserId.text)
            && !string.IsNullOrWhiteSpace(registerPassField.text) && !string.IsNullOrWhiteSpace(registerEmailField.text)
            && registerEmailField.text.IndexOf('@') > 0)
        {
            registerEmailField.gameObject.SetActive(false);
            registerPassField.gameObject.SetActive(false);
            registerUserId.gameObject.SetActive(false);
            registerUsername.gameObject.SetActive(false);
            registerLoginSuccessText.gameObject.SetActive(true);
        }
        else
        {
            messageText.text = "Data is incorrect! Try Again!";
        }
    }
}
