using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuOpcoes : MonoBehaviour
{
    
    Resolution[] resolucoes;
    [SerializeField] AudioMixer mixerMenu;
    [SerializeField] GameObject menuOpcoes;
    [SerializeField] Dropdown menuDeResolucoes;

    private void Start()
    {
        resolucoes = Screen.resolutions;
        menuDeResolucoes.ClearOptions();
        
        int indexResolutions = 0;

        List<string> opcoes = new List<string>();

        for (int i = 0; i < resolucoes.Length; i++)
        {
            string opcao = resolucoes[i].width + " x " + resolucoes[i].height;
            opcoes.Add(opcao);

            if (resolucoes[i].width == Screen.currentResolution.width && resolucoes[i].height == Screen.currentResolution.height)
            {
                indexResolutions = i;
            }
        }

        menuDeResolucoes.AddOptions(opcoes);
        menuDeResolucoes.value = indexResolutions;
        menuDeResolucoes.RefreshShownValue();

    }

    //Botão Sair

    public void BotaoYeah()
    {
        menuOpcoes.SetActive(false);
    }

    //Volume

    public void AlterarVolumeMenuInicial(float novoVolume)
    {
        novoVolume = Mathf.Log10(novoVolume) * 20;
        //prof, essa parte e muito chata
        mixerMenu.SetFloat("VolumeGeralDaMusiquinha", novoVolume);
    }

    //Resoluções

    public void MudarResolucao(int novaResolucao)
    {
        Resolution resolucao = resolucoes[novaResolucao];
        Screen.SetResolution(resolucao.width, resolucao.height, Screen.fullScreen);
    }

    public void TelaCheia(bool telaCheia)
    {
        Screen.fullScreen = telaCheia;
    }
}
