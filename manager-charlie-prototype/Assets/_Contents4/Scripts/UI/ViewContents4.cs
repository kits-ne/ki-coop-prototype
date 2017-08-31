﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Contents4
{

    public class ViewContents4 : MonoBehaviour
    {


        public SwipeManager InstSelectPage = null;
        public UIAlarmSelectPage InstAlarmSelectPage = null;


        public void HideSelectPage()
        {
            InstSelectPage.gameObject.SetActive(false);
        }
        public void ShowSelectPage()
        {
            InstSelectPage.gameObject.SetActive(true);
        }
        public void HideAlarmSelectPage()
        {
            InstAlarmSelectPage.gameObject.SetActive(false);
        }
        public void ShowAlarmSelectPage()
        {
            InstAlarmSelectPage.gameObject.SetActive(true);
        }


        public void OnClickSleep()
        {
            HideSelectPage();

        }

        public void OnClickWakeUp()
        {
            HideSelectPage();

        }

        public void OnClickEat()
        {
            HideSelectPage();

        }

        public void OnClickRead()
        {
            HideSelectPage();

        }


        public void OnClickWash()
        {
            HideSelectPage();

        }

        public void OnClickBrush()
        {
            HideSelectPage();

        }

    }

}
