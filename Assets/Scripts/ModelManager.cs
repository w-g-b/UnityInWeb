using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    public GameObject model1;
    public GameObject model2;
    public GameObject model3;
    public GameObject model4;
    public GameObject model5;

    public void ShowModel(int i)
    {
        switch (i)
        {
            case 1:
                model1.SetActive(true);
                model2.SetActive(false);
                model3.SetActive(false);
                model4.SetActive(false);
                model5.SetActive(false);
                break;
            case 2:
                model1.SetActive(false);
                model2.SetActive(true);
                model3.SetActive(false);
                model4.SetActive(false);
                model5.SetActive(false);
                break;
            case 3:
                model1.SetActive(false);
                model2.SetActive(false);
                model3.SetActive(true);
                model4.SetActive(false);
                model5.SetActive(false);
                break;
            case 4:
                model1.SetActive(false);
                model2.SetActive(false);
                model3.SetActive(false);
                model4.SetActive(true);
                model5.SetActive(false);
                break;
            case 5:
                model1.SetActive(false);
                model2.SetActive(false);
                model3.SetActive(false);
                model4.SetActive(false);
                model5.SetActive(true);
                break;
            default:
                model1.SetActive(true);
                model2.SetActive(false);
                model3.SetActive(false);
                model4.SetActive(false);
                model5.SetActive(false);
                break;
        }
    }
}