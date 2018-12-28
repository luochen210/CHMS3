using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DAL
{
   public class InputLanguageSet
    {
       /// <summary>
       /// 设置英文输入法
       /// </summary>
       public static void SetEnIME()
       {
           InputLanguage IME = GetEnIME();
           if (IME == null)
           {
               InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
           }
           else
           {
               InputLanguage.CurrentInputLanguage = IME;
           }
       }
       private static InputLanguage GetEnIME()
       {
           foreach (InputLanguage IL in InputLanguage.InstalledInputLanguages)
           {
               if (IL.LayoutName == "简体中文 - 美式键盘")
               {
                   return IL;
               }
           }
           return null;
       }
    }
}
