using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSair : MonoBehaviour
{
    [SerializeField] GameObject menuSair;

    public void BotaoVazar()
    {
        Application.Quit();
    }

    public void FicarNoJogo()
    {
        menuSair.SetActive(false);
    }
}
