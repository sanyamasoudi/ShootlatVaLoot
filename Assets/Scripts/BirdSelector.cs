using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSelector : MonoBehaviour
{
    public static BirdSelector instance;
    public GameObject Bird;
    [SerializeField] GameObject SucessfullMenu;
    [SerializeField] private GameObject BirdItem;
    [SerializeField] private GameObject BirdItem1;
    [SerializeField] private GameObject BirdItem2;
    [SerializeField] private GameObject BirdItem3;
    [SerializeField] private GameObject BirdItem4;
    [SerializeField] private GameObject BirdItem5;
    [SerializeField] private GameObject BirdItem6;
    [SerializeField] private GameObject BirdItem7;
    [SerializeField] private GameObject BirdItem8;
    [SerializeField] private GameObject BirdItem9;
    [SerializeField] private GameObject BirdItem10;
    [SerializeField] private GameObject BirdItem11;

    public AudioClip Audio;
    [SerializeField] private AudioClip AudioItem;
    [SerializeField] private AudioClip AudioItem1;
    [SerializeField] private AudioClip AudioItem2;
    [SerializeField] private AudioClip AudioItem3;
    [SerializeField] private AudioClip AudioItem4;
    [SerializeField] private AudioClip AudioItem5;
    [SerializeField] private AudioClip AudioItem6;
    [SerializeField] private AudioClip AudioItem7;
    [SerializeField] private AudioClip AudioItem8;
    [SerializeField] private AudioClip AudioItem9;
    [SerializeField] private AudioClip AudioItem10;
    [SerializeField] private AudioClip AudioItem11;

    void Awake()
    {
        instance = this;
        Audio = AudioItem;
        Bird = BirdItem;
    }
    public void SelectItem()
    {
        Audio = AudioItem;
        Bird = BirdItem;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem1()
    {
        Audio = AudioItem1;
        Bird = BirdItem1;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem2()
    {
        Audio = AudioItem2;
        Bird = BirdItem2;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem3()
    {
        Audio = AudioItem3;
        Bird = BirdItem3;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem4()
    {
        Audio = AudioItem4;
        Bird = BirdItem4;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem5()
    {
        Audio = AudioItem5;
        Bird = BirdItem5;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem6()
    {
        Audio = AudioItem6;
        Bird = BirdItem6;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem7()
    {
        Audio = AudioItem7;
        Bird = BirdItem7;
        SucessfullMenu.SetActive(true);

    }
    public void SelectItem8()
    {
        Audio = AudioItem8;
        Bird = BirdItem8;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem9()
    {
        Audio = AudioItem9;
        Bird = BirdItem9;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem10()
    {
        Audio = AudioItem10;
        Bird = BirdItem10;
        SucessfullMenu.SetActive(true);
    }
    public void SelectItem11()
    {
        Audio = AudioItem11;
        Bird = BirdItem11;
        SucessfullMenu.SetActive(true);
    }
    public void CloseSucessfullMenu()
    {
        SucessfullMenu.SetActive(false);
    }

}
