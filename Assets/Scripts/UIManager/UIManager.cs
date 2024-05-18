using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager Instance;

    public GameObject AttackBttn,DialogBoxPanel,ShopEnterButtn;

    public DialogBox DialogScriptable;

    public Text _CoinText,DialogBoxText;

    public int CoinValue,CurrentValue=0;

    private void Start()
    {
        PlayerInteractions.Instance.OnEnvInteractionEnter.AddListener(OnEnvEnterInteraction);
        PlayerInteractions.Instance.OnEnvInteractionExit.AddListener(OnEnvInteractedExit);
    }


    private void Awake()
    {
        Instance = this;
    }

    public void OnEnvEnterInteraction(Interactions I)
    {
        switch (I)
        {
            case Interactions.CoinMakerBlock:
                AttackBttn.SetActive(true);
                break;
            case Interactions.ClotheShope:
                DialogBoxText.text = DialogScriptable.DialogTypes[1].DialogText;
                DialogBoxPanel.SetActive(true);
                ShopEnterButtn.SetActive(true);
                break;
            case Interactions.GraveYard:
                DialogBoxText.text = DialogScriptable.DialogTypes[2].DialogText;
                DialogBoxPanel.SetActive(true);
                break;
            case Interactions.Monument:
                DialogBoxText.text = DialogScriptable.DialogTypes[0].DialogText;
                DialogBoxPanel.SetActive(true);
                break;
            case Interactions.OldWell:
                DialogBoxText.text = DialogScriptable.DialogTypes[3].DialogText;
                DialogBoxPanel.SetActive(true);
                break;
            case Interactions.Coin:
                CurrentValue = CurrentValue + CoinValue;
                _CoinText.text = CurrentValue.ToString();
                break;
        }
    }
    public void OnEnvInteractedExit(Interactions i)
    {
        ShopEnterButtn.SetActive(false);
        AttackBttn.SetActive(false);
        DialogBoxPanel.SetActive(false);
    }
}
