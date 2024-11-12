using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueScript : MonoBehaviour
{
    public DialogueAsset dialogueArray;

    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI dialogueTextLast;
    [SerializeField] GameObject dialoguePanel;
    private int index;

    public float timeToWait = 3f;
    float timer;
    public float wordSpeed = 0.06f;
    public bool isDialogueOn;

    void Update()
    {

        if (dialogueText.text == dialogueArray.dialogue[index] && isDialogueOn)
        {
            timer += Time.deltaTime;
            if (timer > timeToWait)
            {
                NextLine();
            }
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        if (isDialogueOn)
        {
            foreach (char letter in dialogueArray.dialogue[index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(wordSpeed);

            }
        }
    }

    public void NextLine()
    {
        if(index < dialogueArray.dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
            timer = 0f;
        }
        else
        {
            DialogueOff();
            zeroText();
        }
    }

    public void DialogueOn()
    {
        isDialogueOn = true;
        dialoguePanel.SetActive(true);
        StartCoroutine(Typing());
    }

    public void DialogueOff()
    {
        isDialogueOn = false;
        zeroText();
    }
    
}
