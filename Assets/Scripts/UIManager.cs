﻿using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject mainPanel, matchScoutPanel, pitScoutPanel, analyticsPanel, openPanel;
    public string sUserName;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    public void ChangePanel(string panel)
    {
        GameObject tempPanel = null;
        RectTransform rectTransform = null;
        switch (panel)
        {
            case "matchScoutPanel":
                tempPanel = Instantiate(matchScoutPanel);
                rectTransform = tempPanel.GetComponent<RectTransform>();
                Destroy(openPanel);
                openPanel = tempPanel;
                openPanel.transform.parent = gameObject.transform;
                rectTransform.offsetMin = new Vector2(0, 0);
                rectTransform.offsetMax = new Vector2(0, 0);
                openPanel.GetComponentsInChildren<Button>()[0].onClick.AddListener( () => { this.ChangePanel("mainPanel"); } );
                break;
            case "pitScoutPanel":
                tempPanel = Instantiate(pitScoutPanel);
                rectTransform = tempPanel.GetComponent<RectTransform>();
                Destroy(openPanel);
                openPanel = tempPanel;
                openPanel.transform.parent = gameObject.transform;
                rectTransform.offsetMin = new Vector2(0, 0);
                rectTransform.offsetMax = new Vector2(0, 0);
                openPanel.GetComponentsInChildren<Button>()[0].onClick.AddListener(() => { this.ChangePanel("mainPanel"); });
                break;
            case "analyticsPanel":
                tempPanel = Instantiate(analyticsPanel);
                rectTransform = tempPanel.GetComponent<RectTransform>();
                Destroy(openPanel);
                openPanel = tempPanel;
                openPanel.transform.parent = gameObject.transform;
                rectTransform.offsetMin = new Vector2(0, 0);
                rectTransform.offsetMax = new Vector2(0, 0);
                openPanel.GetComponentsInChildren<Button>()[0].onClick.AddListener(() => { this.ChangePanel("mainPanel"); });
                break;
            case "mainPanel":
                tempPanel = Instantiate(mainPanel);
                rectTransform = tempPanel.GetComponent<RectTransform>();
                Destroy(openPanel);
                openPanel = tempPanel;
                openPanel.transform.parent = gameObject.transform;
                rectTransform.offsetMin = new Vector2(0, 0);
                rectTransform.offsetMax = new Vector2(0, 0);
                openPanel.GetComponentsInChildren<Button>()[0].onClick.AddListener(() => { this.ChangePanel("pitScoutPanel"); });
                openPanel.GetComponentsInChildren<Button>()[1].onClick.AddListener(() => { this.ChangePanel("matchScoutPanel"); });
                openPanel.GetComponentsInChildren<Button>()[2].onClick.AddListener(() => { this.ChangePanel("analyticsPanel"); });
                break;
        }
    }
}