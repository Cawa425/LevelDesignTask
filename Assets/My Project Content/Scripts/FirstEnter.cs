using System;
using My_Project_Content.Scripts.Interfaces;
using UnityEngine;

namespace My_Project_Content.Scripts
{
    public class FirstEnter : MonoBehaviour, ITrigger
    {
        public void Start()
        {
            MakeAction();
        }

        public void MakeAction()
        {
            MainDemoScript.Instance.mainText.text = "Зайдите в здание";
        }
    }
}