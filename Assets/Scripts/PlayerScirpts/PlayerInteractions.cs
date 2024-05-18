using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteractions : MonoBehaviour
{
    public static PlayerInteractions Instance;

    public UnityEvent<Interactions> OnEnvInteractionEnter;

    public UnityEvent<Interactions> OnEnvInteractionExit;

    public Interactions _RefInteraction;

    public CoinMaker _CoinMakerRef;

    public string CoinMakerObject,Coin,Monument,GraveYard,OldWell,ClotheShop;


    private void Awake()
    {
        Instance = this;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(CoinMakerObject))
        {
            _RefInteraction = Interactions.CoinMakerBlock;
            _CoinMakerRef = collision.gameObject.GetComponentInParent<CoinMaker>();
            OnEnvInteractionEnter?.Invoke(_RefInteraction);
        }
        if (collision.gameObject.CompareTag(Coin))
        {
            _RefInteraction = Interactions.Coin;
            collision.gameObject.SetActive(false);
            OnEnvInteractionEnter?.Invoke(_RefInteraction);
        }
        if (collision.gameObject.CompareTag(GraveYard))
        {
            _RefInteraction = Interactions.GraveYard;
            OnEnvInteractionEnter?.Invoke(_RefInteraction);
        }
        if (collision.gameObject.CompareTag(Monument))
        {
            _RefInteraction = Interactions.Monument;
            OnEnvInteractionEnter?.Invoke(_RefInteraction);
        }
        if (collision.gameObject.CompareTag(OldWell))
        {
            _RefInteraction = Interactions.OldWell;
            OnEnvInteractionEnter?.Invoke(_RefInteraction);
        }
        if (collision.gameObject.CompareTag(ClotheShop))
        {
            _RefInteraction = Interactions.ClotheShope;
            OnEnvInteractionEnter?.Invoke(_RefInteraction);
        }



    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        OnEnvInteractionExit?.Invoke(_RefInteraction);
        //if (collision.gameObject.CompareTag(CoinMakerObject))
        //{
        //    _RefInteraction = Interactions.CoinMakerBlock;
        //    OnEnvInteractionExit?.Invoke(_RefInteraction);
        //}
        //if (collision.gameObject.CompareTag(GraveYard))
        //{
        //    OnEnvInteractionExit?.Invoke(_RefInteraction);
        //}
        //if (collision.gameObject.CompareTag(Monument))
        //{
        //    OnEnvInteractionExit?.Invoke(_RefInteraction);
        //}
        //if (collision.gameObject.CompareTag(OldWell))
        //{
        //    OnEnvInteractionExit?.Invoke(_RefInteraction);
        //}
        //if (collision.gameObject.CompareTag(ClotheShop))
        //{
        //    OnEnvInteractionExit?.Invoke(_RefInteraction);
        //}
    }


    public void HitCoinMaker()
    {
        _CoinMakerRef.WoodHit();
    }
}
