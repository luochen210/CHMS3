using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DAL
{
   public class InputLanguageSet
    {
       /// <summary>
       /// ����Ӣ�����뷨
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
               if (IL.LayoutName == "�������� - ��ʽ����")
               {
                   return IL;
               }
           }
           return null;
       }
    }
}
