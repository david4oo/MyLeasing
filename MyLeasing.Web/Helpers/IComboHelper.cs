using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyLeasing.Web.Helpers
{
    public interface IComboHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();
    }
}