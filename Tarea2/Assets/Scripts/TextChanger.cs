using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChanger : MonoBehaviour
{
    //para modificar los valores de los labels de texto
    //Desarrollado por Camilo Andr�s Barrag�n G�mez 3/02/2022

    public TMP_InputField TextoEntry;
    public Text TxtLabel;
    public TextMeshProUGUI TMPLabel;


    public void Changer()
    { 
        var texto = TextoEntry.text;
        TxtLabel.text = texto;
        TMPLabel.SetText(texto);
    }

    //Para mostrar la posici�n del slider

    public Slider SliderEjemplo;
    public TextMeshProUGUI SliderTxt;

    public void SliderTextShow()
    {
        string[] values = new string[4]{ "Miguel", "Camilo", "Jeison", "David"};

        SliderTxt.SetText(values[(int)SliderEjemplo.value]);

        //SliderTxt.SetText(SliderEjemplo.value.ToString());
    }

    //Para deshabilitar el canvas

    public Canvas menuInicio;

    public void canvasHide()
    {
        menuInicio.enabled = false;
    }
}
