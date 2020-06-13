using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2.ViewModels
{
   public class MainViewModel
    {

        #region ViewModels
        public PhotoViewModel Photos { get; set; }
        #endregion
        #region Constructor
        public MainViewModel()
        { this.Photos = new PhotoViewModel(); }
        #endregion 
    }
}
