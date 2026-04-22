using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SumaDeNumeros : MonoBehaviour
{
    public TMP_InputField input_Numero1;
    public TMP_InputField input_Numero2;
    public TextMeshProUGUI txt_Resultado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void addNumbers(){
    
int num1 = int.Parse(input_Numero1.text);
int num2 = int.Parse(input_Numero2.text);
string resultado = (num1 + num2).ToString();

txt_Resultado.text = resultado;

    }
}
