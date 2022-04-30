﻿using System.Windows;
using System.Windows.Media;

namespace MyCustomControl.Attache
{
    public class BackgroundSwitchElement
    {
        #region MouseHoverBackground
        public static readonly DependencyProperty MouseHoverBackgroundProperty = DependencyProperty.RegisterAttached(
            "MouseHoverBackground", typeof(Brush), typeof(BackgroundSwitchElement),
            new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetMouseHoverBackground(DependencyObject element, Brush value) 
            => element.SetValue(MouseHoverBackgroundProperty, value);
        public static Brush GetMouseHoverBackground(DependencyObject element) 
            => (Brush)element.GetValue(MouseHoverBackgroundProperty);
        #endregion

        #region MouseDownBackground
        public static readonly DependencyProperty MouseDownBackgroundProperty = DependencyProperty.RegisterAttached(
            "MouseDownBackground", typeof(Brush), typeof(BackgroundSwitchElement),
            new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetMouseDownBackground(DependencyObject element, Brush value) 
            => element.SetValue(MouseDownBackgroundProperty, value);
        public static Brush GetMouseDownBackground(DependencyObject element) 
            => (Brush)element.GetValue(MouseDownBackgroundProperty);
        #endregion
    }
}
