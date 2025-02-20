﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public static class Utils 
{
    /// <summary>
    /// Extension-method to show an UI Element (set it to visible)
    /// </summary>
    /// <param name="element"></param>
    public static void Show(this VisualElement element)
    {
        if (element == null)
            return;

        element.style.visibility = Visibility.Visible;
        element.style.display = DisplayStyle.Flex;
    }

    /// <summary>
    /// Extension-method to hide an UI Element (set it to visible)
    /// </summary>
    /// <param name="element"></param>
    public static void Hide(this VisualElement element)
    {
        if (element == null)
            return;

        element.style.visibility = Visibility.Hidden;
        element.style.display = DisplayStyle.None;
    }
}
