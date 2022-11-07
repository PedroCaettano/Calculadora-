using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;


public class calculadoracontroler : MonoBehaviour
{
    [SerializeField] private Text TextDisplay1; 
    [SerializeField] private Text TextDisplay2;

    private string _expression;


    // Start is called before the first frame update
    void Start()
    {
        TextDisplay1.text = "";
        TextDisplay2.text = "";
    }
public void Limpar()
      {
        TextDisplay1.text = "";
      }


    public void HandleInsertValue(string value)
    {
        TextDisplay2.text = value;
        TextDisplay1.text += TextDisplay2.text;
    }

    public void HandleSum(int num1, int num2)
    {
        int sum = num1 + num2;
        TextDisplay1.text = sum.ToString();
    }
    public void ExpressionCalculator()
    {
        _expression = TextDisplay1.text;
        DataTable table = new DataTable("tabela");
        string _result = table.Compute(_expression, string.Empty).ToString();
        TextDisplay2.text = _result;
         Debug.Log(_result);
    }
}