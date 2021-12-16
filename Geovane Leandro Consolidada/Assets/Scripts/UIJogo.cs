using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIJogo : MonoBehaviour
{
    [SerializeField] GameObject menuPause;
    [SerializeField] GameObject menuOpcoes;
    [SerializeField] GameObject menuSairParaMenu;
    [SerializeField] GameObject menuSairJogo;


    void Start()
    {
        menuPause.SetActive(false);
        menuOpcoes.SetActive(false);
        menuSairParaMenu.SetActive(false);
        menuSairJogo.SetActive(false);
    }

    // Menu para pausar o jogo
    public void PausarOGame()
    {
        Time.timeScale = 0;
        menuPause.SetActive(true);
    }

    public void FecharMenuPause()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1;
    }

    //Abrir Opções de resolução e volume, o carinha la mano
    public void AbrirMenuOpcoes()
    {
        menuOpcoes.SetActive(true);
    }

    // Menu para voltar ao inicio do jogo

    public void AbrirMenuSairParaMenu()
    {
        menuSairParaMenu.SetActive(true);
    }

    public void SimMenuInicial()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    public void NaoMenuInicial()
    {
        menuSairParaMenu.SetActive(false);
    }

    public void AbrirMenuSairJogo()
    {
        menuSairJogo.SetActive(true);
    }

}
