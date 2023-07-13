using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform
{
    public static class FormUtility
    {
        //버튼 값에 따라 Form 여는 함수
        public static void OpenForm(string formName, Form currentForm)
        {
            Form targetForm = null;

            switch (formName)
            {
                case "LOTForm":
                    targetForm = Application.OpenForms["LOTForm"] as LOTForm;
                    if (targetForm == null)
                    {
                        targetForm = new LOTForm(currentForm as MainForm);
                    }
                    break;
                case "TestForm":
                    targetForm = Application.OpenForms["TestForm"] as TestForm;
                    if (targetForm == null)
                    {
                        targetForm = new TestForm(currentForm as MainForm);
                    }
                    break;
                case "ProcessForm":
                    targetForm = Application.OpenForms["ProcessForm"] as ProcessForm;
                    if (targetForm == null)
                    {
                        targetForm = new ProcessForm(currentForm as MainForm); // MainForm의 인스턴스 전달
                    }
                    break;
                case "StockForm":
                    targetForm = Application.OpenForms["StockForm"] as StockForm;
                    if (targetForm == null)
                    {
                        targetForm = new StockForm(currentForm as MainForm);
                    }
                    break;
                case "OrderForm":
                    targetForm = Application.OpenForms["OrderForm"] as OrderForm;
                    if (targetForm == null)
                    {
                        targetForm = new OrderForm(currentForm as MainForm);
                    }
                    break;
                case "ChartForm":
                    targetForm = Application.OpenForms["ChartForm"] as ChartForm;
                    if (targetForm == null)
                    {
                        targetForm = new ChartForm(currentForm as MainForm);
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid formName"); // 유효하지 않은 formName 예외 처리
            }

            if (targetForm != null)
            {
                //currentForm.Hide(); // 현재 폼 숨기기
                targetForm.Show(); // 타겟 폼 보여주기
            }
            else
            {
                throw new Exception("Failed to open form"); // 폼을 열 수 없는 경우 예외 처리
            }
        }

    }

}
