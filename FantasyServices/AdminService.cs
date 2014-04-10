using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Web.Security;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Data.Entity.Validation;

namespace FantasyServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdminService" in both code and config file together.
    public class AdminService : IAdminService
    {
        


        public bool IsValid(string user, string password)
        {
            fantasyEntities db = new fantasyEntities();

            using (db)
            {
                if (db.admin.Where(a => a.email.Equals(user) && a.password.Equals(password)).FirstOrDefault() != null)
                {
                    return true;
                }
                else return false;
            }



        }


        public bool CreateAdmin(string obj)
        {
            string provjera="";
            
            try
            {
                fantasyEntities db = new fantasyEntities();

                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(admin));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(obj));
                admin a = db.admin.Add((admin)ser.ReadObject(ms));
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    provjera = eve.Entry.Entity.GetType().Name + " " + eve.Entry.State;
                    foreach (var ve in eve.ValidationErrors)
                    {
                        provjera= ve.PropertyName+" "+ve.ErrorMessage;
                    }
                }
               
            }

            if(provjera.Equals("")) return true;
            else return false;

          
        }
    }
}
    

