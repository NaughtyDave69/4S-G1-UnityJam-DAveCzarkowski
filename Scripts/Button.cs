using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public TextMeshProUGUI countertext;
    public Image button2;
    public Image button1;
    private int counter = 0;

    public RawImage glitch1;
    public RawImage glitch2;



    void Start()
    {
        countertext.text = counter.ToString();

        glitch1.enabled = false;
        glitch2.enabled = false;
        button2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 42)
        {
            button1.enabled = false;
            glitch1.enabled = true;
            glitch2.enabled = true;
            button2.enabled = true;
            StartCoroutine(womp());
        }
    }

    public void IncreaseCounter() 
    { 
        counter++;
        countertext.text = counter.ToString();
    
    }

   private IEnumerator womp()
    {


yield return  new WaitForSeconds(3.0f);

        Application.Quit();
    }
}
