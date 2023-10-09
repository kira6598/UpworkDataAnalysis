using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpworkDataAnalysis
{
    public class NavigationButton
    {
        List<Button> buttons = new List<Button>();
        Color defaultColor;
        Color SelectColor;

        public NavigationButton(List<Button> buttons, Color defaultColor,Color selectColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.SelectColor = selectColor;

        }

        private void SetButtonColor()
        {
            foreach (Button button in buttons)
            {
                button.BackColor = defaultColor;
            }
        }
        public void HighLight(Button selectButton)
        {
            foreach(Button button in buttons)
            {
                if (button == selectButton)
                {
                    selectButton.BackColor = SelectColor;
                }
                else
                {
                    button.BackColor = defaultColor;    
                }
            }
        }
    }
}
