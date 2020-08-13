using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class Login : MonoBehaviour
{
    public InputField LoginidInputidInput;
    public InputField LoginpasswdInput;
    public InputField SigninidInput;
    public InputField SigninpasswdInput;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if (LoginidInputidInput.isFocused == true)
        {
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                LoginpasswdInput.Select();
            }
        }

        if (LoginpasswdInput.isFocused == true)
        {
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                LoginidInputidInput.Select();
            }
            if (Input.GetKeyUp(KeyCode.Return))
            {
                LoginBtn();
            }
        }
        if (SigninidInput.isFocused == true)
        {
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                SigninpasswdInput.Select();
            }
        }

        if (SigninpasswdInput.isFocused == true)
        {
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                SigninidInput.Select();
            }
            if (Input.GetKeyUp(KeyCode.Return))
            {
                CreateAccoutnBtn();
            }
        }
    }
    public void LoginBtn()
    {
        StartCoroutine(LoginCo());
        //Application.ExternalCall("login",idInput.text,passwdInput.text);
    }
    IEnumerator LoginCo()
    {
        Application.ExternalCall("userLogin", LoginidInputidInput.text, LoginpasswdInput.text);
        yield return null;
    }
    public void CreateAccoutnBtn()
    {
        StartCoroutine(CreateAccoutCo());
    }
    IEnumerator CreateAccoutCo()
    {
        Application.ExternalCall("userCreate", SigninidInput.text, SigninpasswdInput.text);
        yield return null;
    }
}
