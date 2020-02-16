using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Perso_Display : MonoBehaviour
{
    public Perso_ onizuka;
    public Perso_ onizuka_vener;
    public Perso_ onizuka_peur;
    public Perso_ dragon;
    public Perso_ yakuza;
    public Perso_ samurai;

    public Dialogue dialogue1;
    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI nom;
    public Image image;

    private bool hasClickedThisFrame;
    private void Awake() {
        hasClickedThisFrame = false;
        StartCoroutine(ReadDialogue());
    }

    private IEnumerator ReadDialogue() {
        foreach(DialogueLine o in dialogue1.liste)
        {
            dialogue.text = o.dialogue;
            nom.text = o.perso.perso_name;
            image.sprite = o.perso.image;
            while (!hasClickedThisFrame) yield return new WaitForEndOfFrame();
            hasClickedThisFrame = false;
        }
    }
    public void OnClick()
    {
        hasClickedThisFrame = true;
    }
}
