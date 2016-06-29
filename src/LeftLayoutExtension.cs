using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    public static class LeftLayoutExtension
    {
        //[Extension()]

        public static void upleftLayoutbtncolorExt<T>(T form) where T : Smobiler.Core.MobileForm
        {

            form.LeftLayoutData.Items["imguser"].DefaultValue = "Demo";
            form.LeftLayoutData.Items["labUserIDData"].Text = "Demo";
            form.LeftLayoutData.Items["labUserNameData"].Text = "皮卡丘";

            dynamic setbackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(97)), Convert.ToInt32(Convert.ToByte(128)), Convert.ToInt32(Convert.ToByte(172)));
            dynamic backColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(43)), Convert.ToInt32(Convert.ToByte(52)), Convert.ToInt32(Convert.ToByte(69)));
            dynamic setColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(43)), Convert.ToInt32(Convert.ToByte(52)), Convert.ToInt32(Convert.ToByte(69)));
            dynamic Color = System.Drawing.Color.White;
            switch (form.ToString())
            {
                case "COMSSmobilerDemo.frmMenu":
                    form.LeftLayoutData.Items["imgindex"].BackColor = setbackColor;
                    form.LeftLayoutData.Items["btnindex"].BackColor = setbackColor;
                    form.LeftLayoutData.Items["imginfo"].BackColor = backColor;
                    form.LeftLayoutData.Items["btninfo"].BackColor = backColor;
                    form.LeftLayoutData.Items["imgtz"].BackColor = backColor;
                    form.LeftLayoutData.Items["btntz"].BackColor = backColor;
                    form.LeftLayoutData.Items["imgbz"].BackColor = backColor;
                    form.LeftLayoutData.Items["btnbz"].BackColor = backColor;

                    form.LeftLayoutData.Items["imgindex"].ForeColor = setColor;
                    form.LeftLayoutData.Items["btnindex"].ForeColor = setColor;
                    form.LeftLayoutData.Items["imginfo"].ForeColor = Color;
                    form.LeftLayoutData.Items["btninfo"].ForeColor = Color;
                    form.LeftLayoutData.Items["imgtz"].ForeColor = Color;
                    form.LeftLayoutData.Items["btntz"].ForeColor = Color;
                    form.LeftLayoutData.Items["imgbz"].ForeColor = Color;
                    form.LeftLayoutData.Items["btnbz"].ForeColor = Color;

                    form.LeftLayoutData.Items["imgindex"].DefaultValue = "!\\ue88a042052069";
                    form.LeftLayoutData.Items["imginfo"].DefaultValue = "!\\ue001255255255";
                    form.LeftLayoutData.Items["imgtz"].DefaultValue = "!\\ue0e1255255255";
                    form.LeftLayoutData.Items["imgbz"].DefaultValue = "!\\ue8fd255255255";

                    break;
                case "COMSSmobilerDemo.frmInfo":
                    form.LeftLayoutData.Items["imgindex"].BackColor = backColor;
                    form.LeftLayoutData.Items["btnindex"].BackColor = backColor;
                    form.LeftLayoutData.Items["imginfo"].BackColor = setbackColor;
                    form.LeftLayoutData.Items["btninfo"].BackColor = setbackColor;
                    form.LeftLayoutData.Items["imgtz"].BackColor = backColor;
                    form.LeftLayoutData.Items["btntz"].BackColor = backColor;
                    form.LeftLayoutData.Items["imgbz"].BackColor = backColor;
                    form.LeftLayoutData.Items["btnbz"].BackColor = backColor;

                    form.LeftLayoutData.Items["imgindex"].ForeColor = Color;
                    form.LeftLayoutData.Items["btnindex"].ForeColor = Color;
                    form.LeftLayoutData.Items["imginfo"].ForeColor = setColor;
                    form.LeftLayoutData.Items["btninfo"].ForeColor = setColor;
                    form.LeftLayoutData.Items["imgtz"].ForeColor = Color;
                    form.LeftLayoutData.Items["btntz"].ForeColor = Color;
                    form.LeftLayoutData.Items["imgbz"].ForeColor = Color;
                    form.LeftLayoutData.Items["btnbz"].ForeColor = Color;

                    form.LeftLayoutData.Items["imgindex"].DefaultValue = "!\\ue88a255255255";
                    form.LeftLayoutData.Items["imginfo"].DefaultValue = "!\\ue001042052069";
                    form.LeftLayoutData.Items["imgtz"].DefaultValue = "!\\ue0e1255255255";
                    form.LeftLayoutData.Items["imgbz"].DefaultValue = "!\\ue8fd255255255";
                    break;
                case "COMSSmobilerDemo.frmMessage":
                    form.LeftLayoutData.Items["imgindex"].BackColor = backColor;
                    form.LeftLayoutData.Items["btnindex"].BackColor = backColor;
                    form.LeftLayoutData.Items["imginfo"].BackColor = backColor;
                    form.LeftLayoutData.Items["btninfo"].BackColor = backColor;
                    form.LeftLayoutData.Items["imgtz"].BackColor = setbackColor;
                    form.LeftLayoutData.Items["btntz"].BackColor = setbackColor;
                    form.LeftLayoutData.Items["imgbz"].BackColor = backColor;
                    form.LeftLayoutData.Items["btnbz"].BackColor = backColor;

                    form.LeftLayoutData.Items["imgindex"].ForeColor = Color;
                    form.LeftLayoutData.Items["btnindex"].ForeColor = Color;
                    form.LeftLayoutData.Items["imginfo"].ForeColor = Color;
                    form.LeftLayoutData.Items["btninfo"].ForeColor = Color;
                    form.LeftLayoutData.Items["imgtz"].ForeColor = setColor;
                    form.LeftLayoutData.Items["btntz"].ForeColor = setColor;
                    form.LeftLayoutData.Items["imgbz"].ForeColor = Color;
                    form.LeftLayoutData.Items["btnbz"].ForeColor = Color;

                    form.LeftLayoutData.Items["imgindex"].DefaultValue = "!\\ue88a255255255";
                    form.LeftLayoutData.Items["imginfo"].DefaultValue = "!\\ue001255255255";
                    form.LeftLayoutData.Items["imgtz"].DefaultValue = "!\\ue0e1042052069";
                    form.LeftLayoutData.Items["imgbz"].DefaultValue = "!\\ue8fd255255255";
                    break;
                case "COMSSmobilerDemo.frmHelp":
                    form.LeftLayoutData.Items["imgindex"].BackColor = backColor;
                    form.LeftLayoutData.Items["btnindex"].BackColor = backColor;
                    form.LeftLayoutData.Items["imginfo"].BackColor = backColor;
                    form.LeftLayoutData.Items["btninfo"].BackColor = backColor;
                    form.LeftLayoutData.Items["imgtz"].BackColor = backColor;
                    form.LeftLayoutData.Items["btntz"].BackColor = backColor;
                    form.LeftLayoutData.Items["imgbz"].BackColor = setbackColor;
                    form.LeftLayoutData.Items["btnbz"].BackColor = setbackColor;

                    form.LeftLayoutData.Items["imgindex"].ForeColor = Color;
                    form.LeftLayoutData.Items["btnindex"].ForeColor = Color;
                    form.LeftLayoutData.Items["imginfo"].ForeColor = Color;
                    form.LeftLayoutData.Items["btninfo"].ForeColor = Color;
                    form.LeftLayoutData.Items["imgtz"].ForeColor = Color;
                    form.LeftLayoutData.Items["btntz"].ForeColor = Color;
                    form.LeftLayoutData.Items["imgbz"].ForeColor = setColor;
                    form.LeftLayoutData.Items["btnbz"].ForeColor = setColor;

                    form.LeftLayoutData.Items["imgindex"].DefaultValue = "!\\ue88a255255255";
                    form.LeftLayoutData.Items["imginfo"].DefaultValue = "!\\ue001255255255";
                    form.LeftLayoutData.Items["imgtz"].DefaultValue = "!\\ue0e1255255255";
                    form.LeftLayoutData.Items["imgbz"].DefaultValue = "!\\ue8fd042052069";
                    break;
            }
        }
    }
}

