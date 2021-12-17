using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balada : MonoBehaviour
{
    [SerializeField] AudioSource audioInterno;
    [SerializeField] AudioSource audioExterno;

    public bool balada;

    // Start is called before the first frame update
    void Start()
    {
        audioInterno.volume = 0;
        audioExterno.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarVolumeInterno()
    {
        audioInterno.volume = 1;
        audioExterno.volume = 0;

    }

    public void AumentarVolumeExterno()
    {
        audioInterno.volume = 0;
        audioExterno.volume = 1;
    }


}
