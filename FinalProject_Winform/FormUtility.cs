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
                case "LOT":
                    targetForm = Application.OpenForms["LOTForm"] as LOTForm;
                    if (targetForm == null)
                    {
                        targetForm = new LOTForm();
                        targetForm.Show();
                    }
                    break;
                case "check":
                    targetForm = Application.OpenForms["TestForm"] as TestForm;
                    if (targetForm == null)
                    {
                        targetForm = new TestForm();
                        targetForm.Show();
                    }
                    break;
                case "process":
                    targetForm = Application.OpenForms["ProcessForm"] as ProcessForm;
                    if (targetForm == null)
                    {
                        targetForm = new ProcessForm();
                        targetForm.Show();
                    }
                    break;
                case "stock":
                    targetForm = Application.OpenForms["StockForm"] as StockForm;
                    if (targetForm == null)
                    {
                        targetForm = new StockForm();
                        targetForm.Show();
                    }
                    break;
                case "order":
                    targetForm = Application.OpenForms["OrderForm"] as OrderForm;
                    if (targetForm == null)
                    {
                        targetForm = new OrderForm();
                        targetForm.Show();
                    }
                    break;
                case "chart":
                    targetForm = Application.OpenForms["ChartForm"] as ChartForm;
                    if (targetForm == null)
                    {
                        targetForm = new ChartForm();
                        targetForm.Show();
                    }
                    break;
                default:
                    break;
            }

            if (targetForm != null && targetForm.Name != formName)
            {
                currentForm.Hide();
            }


        }
    }

}
