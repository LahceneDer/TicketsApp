using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Action = DataAccess.Models.Action;
namespace TicketsApp.Services
{
    public class CheckPermissionService
    {
        private static IHttpContextAccessor _httpContextAccessor = new HttpContextAccessor();
        public static bool CheckAutorisation(Action action, Resource resource)
        {
            return true;
            //return _httpContextAccessor.HttpContext.User.Claims.Any(); ;
            var isSuperUser =
                _httpContextAccessor?.HttpContext?.User?.Claims?.Any(p => p.Type == "SuperUser" && p.Value == "true") ?? false;
            if (isSuperUser)
                return true;
            //var _action = EnumExtension.GetDisplayValue<Action>(action);
            //var _resource = EnumExtension.GetDisplayValue<Resource>(resource);

            bool hasPermission = _httpContextAccessor?.HttpContext?.User?.Claims?.Any(p => p.Type == "P" && p.Value == $"{(int)action}-{(int)resource}") ?? false;
            //hasPermission = _httpContextAccessor?.HttpContext?.User?.Claims?.Any(p => p.Type == "permission" && p.Value == _action + "-" + _resource) ?? false; 
            //if (!hasPermission)
                //CheckModulesActionsConfiguration(action, resource);
            return hasPermission;

            // return _httpContextAccessor?.HttpContext?.User?.Claims?.Any(p => p.Type == "permission" && p.Value == _action + "-" + _resource) ?? false;
        }

        internal static bool CheckAutorisation(object utilisateurs, Resource parametrage)
        {
            throw new System.NotImplementedException();
        }

        //public static void CheckModulesActionsConfiguration(string moduleAction)
        //{
        //    if (Module_Actions.Contains(moduleAction))
        //        return;
        //    var a = moduleAction.Split(new[] { '-' }, 2);
        //    CheckModulesActionsConfiguration(a[0], a[1]);
        //}


        public static void CheckModulesActionsConfiguration(Action action, Resource resource)
        {
            //if (module == "AllResource")
            //    return;
            var db = new ApplicationDbContext();
            //var edited = false;
            //var ml = db.Modules.FirstOrDefault(m => m.ModuleNom == module)
            //?? new Module { ModuleNom = module, ModuleActions = new List<ModuleAction>() };
            //if (ml.ModuleID == 0)
            //{
            //    db.Modules.Add(ml);
            //    db.SaveChanges();
            //    edited = true;
            //}
            var ma = db.ModuleActions.Where(a => a.Resource == resource && a.Action == action).FirstOrDefault();
            if (ma != null)
                return;
            ma = db.ModuleActions.Add(new ModuleAction { Resource = resource, Action = action }).Entity;
            db.SaveChanges();
            var ignoreIf = false;
            /* ma.Module.ModuleNom == Modules.Dashboard
            || ma.Module.ModuleNom == Modules.Demandes_Labo && ma.ModuleActionNom == ModuleActions.DateDemandeUltérieur
            || ma.Module.ModuleNom == Modules.ValidationBio && ma.ModuleActionNom == ModuleActions.EditValidatedResult
            || ma.Module.ModuleNom == Modules.Patient && ma.ModuleActionNom == ModuleActions.EditAfterBioValidation
            || ma.Module.ModuleNom == Modules.Analyse && ma.ModuleActionNom == ModuleActions.changeStateDate
            ;*/
            if (!ignoreIf)
            {
                var moduleActionRoles = db.Roles.ToList()
                .Select(r => new ModuleActionRole { RoleId = r.RoleId, ModuleActionId = ma.ModuleActionID }).ToList();
                db.ModuleActionRoles.AddRange(moduleActionRoles);
                db.SaveChanges();
            }
            // LoadModule_Actions();

        }
    }
}
