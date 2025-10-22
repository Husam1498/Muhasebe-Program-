using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.DomainKatmani.Roles
{
    public sealed class RolesList
    {

        public static List<AppRole> GetStaticRoles()
        {
            #region UCAF

            List<AppRole> appRoles = new List<AppRole>();

            appRoles.Add(new AppRole(
                title: UcafTitle,
                code: UCAFCreateCode,
                name: UCAFCreateName
                ));

            appRoles.Add(new AppRole(
                title:UcafTitle,
                code: UCAFUpdateCode,
                name: UCAFUpdateName
                ));

            appRoles.Add(new AppRole(
                title:UcafTitle,
                code: UCAFRemoveCode,
                name: UCAFRemoveName
                ));

            appRoles.Add(new AppRole(
                title:UcafTitle,
                code: UCAFReadCode,
                name: UCAFReadName
                ));

            #endregion

            return appRoles;
        }

        #region UcafTitleNames

        private static string UcafTitle = "Hesap Planı";
     
        #endregion

        #region UcafCodeAndName
        private static string UCAFCreateCode = "UCAF.Create";
        private static string UCAFCreateName = "Hesap Planı Kayıt";

        private static string UCAFUpdateCode = "UCAF.Update";
        private static string UCAFUpdateName = "Hesap Planı Günceleme";

        private static string UCAFRemoveCode = "UCAF.Remove";
        private static string UCAFRemoveName = "Hesap Planı Silme";

        private static string UCAFReadCode = "UCAF.Read";
        private static string UCAFReadName = "Hesap Planı Okuma";

        #endregion
   
    }
}
