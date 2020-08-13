using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.EventSystems;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class showrank : MonoBehaviour
{
    string[] keys;
    string jsonstring;
    bool isKey = false;
    bool isJson = false;
    public string created;
    public int score;
    public Text ScoreTxt;
    public Text DateTxt;
    public GameObject Button;
    public Button tileButton;

    void Start()
    {
    }

    void Update()
    {
        if (isKey && isJson)
            scoreData();
    }

    public void sendBtn()
    {
        ScoreTxt.text = "";
        Application.ExternalCall("loadData", EventSystem.current.currentSelectedGameObject.name);
    }

    public void scoreData()
    {
        JObject json = JObject.Parse(jsonstring);
        foreach (var key in keys)
        {
            created = (string)json[key.ToString()]["createdAt"];
            score = (int)json[key.ToString()]["score"];
            ScoreTxt.text += "     " + created + "                                                                                                                        " + score.ToString()+"\n";
        }
        ScoreTxt.text = ScoreTxt.text.Remove(ScoreTxt.text.Length - 1);
        isKey = false;
        isJson = false;
    }
    public void getKeys(string jskeys)
    {
        keys = jskeys.Split(',');
        isKey = true;
    }
    public void getJson(string jsonstr)
    {
        jsonstring = (string)jsonstr;
        isJson = true;
    }
}
