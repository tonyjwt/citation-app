using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemScript : MonoBehaviour {

    public Text lastName;
    public Text middleName;
    public Text firstname;
    public Text articleTitle;
    public Text websiteTitle;
    public Text publisher;
    public Text day;
    public Text month;
    public Text year;
    public Text url;

    public Text citationText;
    //Text citationText;

	//void Start ()
	//{
        //citationText = citationInputField.GetComponent<Text>();
	//}

	public void GenerateCitation ()
    {
        //websiteTitle.fontStyle = FontStyle.Italic;
        //Text citationText = citationInputField.GetComponent<InputField>().textComponent;
        citationText.text = lastName.text + ", " + firstname.text + " " + middleName.text + ". " + "'" + articleTitle.text + ".' " + "<i>" + websiteTitle.text + "</i>" + ", " + publisher.text + ", " + day.text + " " + month.text + ". " + year.text + ", " + url.text;
    }

    public void Copy ()
    {
        //string toCopy = citationText.ToString();
        TextEditor textEditor = new TextEditor();
        textEditor.text = citationText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }

    public void QuitApp ()
    {
        Application.Quit();
    }
}
