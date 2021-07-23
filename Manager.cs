using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{

    //reverse text
    public TMP_Text ResultOne;
    public TMP_InputField Input1;

    //prime number
    public TMP_Text ResultTwo;
    public TMP_InputField Input2;

    public TMP_Text ResultThree;
    public TMP_InputField Input3;

    public TMP_Text textArray;
    public void Test1() 
    {
        ReverseString(Input1.text);
    }
    public void Test2() 
    {
        GeneratePrimeNumber(int.Parse(Input2.text));
    }
    int[] FillArray = new int[10];
    public void Test3()
    {
        GetIndexOfNumber(FillArray, int.Parse(Input3.text));
    }
    private void ReverseString(string txt)
    {
        string Rev = "";
        int length;
        length = txt.Length - 1;
        while(length >= 0)
        {
            Rev = Rev + txt[length];
            length--;
        }
        ResultOne.text = Rev;
    }
    int length;
    public void GeneratePrimeNumber(int num)
    {
        ResultTwo.text = "";
        int baseNum = 0;

        if(num <= 15)
        {
            length = num - 1;
        }
        else if(num > 15) {
            length = 14;
            Input2.text = "15";
        }
        while(length >= 0)
        {
            baseNum++;
            if(baseNum % 2 != 0 && baseNum >= 2 || baseNum == 2) 
            {
                if(length == 0) {
                    ResultTwo.text += baseNum;
                }
                else {
                    ResultTwo.text += baseNum + ", ";
                }
                length--;
            }
        }
    }
    public void setArray() {
        textArray.text = "";
        for(int i = 0;i < 10;i++)
        {
            FillArray[i] = Random.Range(0,9);
            textArray.text += FillArray[i] + " ";
        }
    } 
    int a;
    private void GetIndexOfNumber(int[] arr, int targetNumber)
    {
        int baseNum = 0;
        int baseNum2 = baseNum;
        int[] BaseArray = FillArray;
        ResultThree.text = "";
        for(int i = 0;i < BaseArray.Length;i++)
        {
            if(BaseArray[i] == targetNumber) 
            {
                Debug.Log(i + 1);
                baseNum += 1;
                if(baseNum == 2) 
                {
                    ResultThree.text += "Second sighting: index " + (i + 1);
                }
            }
        }
        if(baseNum < 2) {
            ResultThree.text += "Second sighting: index -1";
        }
    }
}
