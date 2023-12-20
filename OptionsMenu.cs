using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matopeli
{
    internal class OptionsMenu
    {
        public event EventHandler OptionsBackToPauseMenuEvent;
        public event EventHandler OptionsBackToMainMenuEvent;

        /// <summary>
        /// Piirtää Options Menuun BackToPauseMenu ja BackToMainMenu napit ja yhdistää ne yllä oleviin EventHandlereihin
        /// </summary>
        public void Show()
        {
            
        }
    }
}
