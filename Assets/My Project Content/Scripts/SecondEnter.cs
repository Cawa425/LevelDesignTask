using System;
using My_Project_Content.Scripts.Interfaces;
using UnityEngine;

namespace My_Project_Content.Scripts
{
    public class SecondEnter : MonoBehaviour, ITrigger
    {
        private void OnCollisionEnter(Collision collision)
        {
            MakeAction();
        }

        public void MakeAction()
        {
            MainDemoScript.Instance.mainText.text = "Посетите магазин";
        }
    }
}