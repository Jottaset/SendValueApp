﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SendValueApp
{
    public partial class PageCalc : ContentPage
    {
        public PageCalc(string valor01, string valor02)
        {
            int a = Convert.ToInt32(valor01);
            int b = Convert.ToInt32(valor02);

            int c = a + b;


            InitializeComponent();
            label_resultado.Text = c.ToString();

        }

        void Recalcular(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();

        }
    }
}
