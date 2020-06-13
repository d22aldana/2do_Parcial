using System;
using System.Collections.Generic;
using System.Text;
using Parcial2.Models;

namespace Parcial2.ViewModels
{
    class PhotoViewModel: BaseViewModel
    {
       #region Services private ApiService apiService #endregion

        #region Attributes  
        private int id;
        private string title;
        private string url;
        private object apiService;
        #endregion

        #region Properties
        private async void LoadPhoto()
        {

            var country = await this.apiService.Get<Photo>(
                "https://jsonplaceholder.typicode.com/",
                "photos/",
                "Id"
                );
            this.title = photo[0].Title;
            this.url = Photo[0].url;
            this.id = photo[0].Alpha2Code;

        }
        #endregion

    }
}
