﻿using System;
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




        public bool UpdateAdmin(string obj, string user)
        {
            string provjera = "";

            try
            {
                fantasyEntities db = new fantasyEntities();

                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(admin));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(obj));
                admin a = db.admin.Where(k => k.email == user).FirstOrDefault();
                if (a == null) provjera = "nema";
                a = (admin)ser.ReadObject(ms);
                
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    provjera = eve.Entry.Entity.GetType().Name + " " + eve.Entry.State;
                    foreach (var ve in eve.ValidationErrors)
                    {
                        provjera = ve.PropertyName + " " + ve.ErrorMessage;
                    }
                }

            }
            
            if (provjera.Equals("")) return true;
            else return false;
        }

        public bool DeleteAdmin(string user)
        {
            string provjera = "";
            try
            {
                fantasyEntities db = new fantasyEntities();

               
                
                admin a = db.admin.Where(k => k.email == user).FirstOrDefault();
                if (a == null) provjera = "nema";
                else
                {
                    db.admin.Attach(a);
                    db.admin.Remove(a);

                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    provjera = eve.Entry.Entity.GetType().Name + " " + eve.Entry.State;
                    foreach (var ve in eve.ValidationErrors)
                    {
                        provjera = ve.PropertyName + " " + ve.ErrorMessage;
                    }
                }

            }

            if (provjera.Equals("")) return true;
            else return false;

        }

        public string ReadAdmin(string email)
        {
            string provjera = "";
            string jsonString="";
            try
            {
            
                fantasyEntities db = new fantasyEntities();
                var context = db.admin.Where(a => a.email == email).FirstOrDefault();
                if (context == null) provjera = "nema";
                else
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(admin));
                    MemoryStream ms = new MemoryStream();
                    ser.WriteObject(ms, context);
                    jsonString = Encoding.UTF8.GetString(ms.ToArray());
                    ms.Close();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    provjera = eve.Entry.Entity.GetType().Name + " " + eve.Entry.State;
                    foreach (var ve in eve.ValidationErrors)
                    {
                        provjera = ve.PropertyName + " " + ve.ErrorMessage;
                    }
                }

            }

            return jsonString;
        }

        public List<string> ReadAllAdmins()
        {
            string provjera = "";
            List<string> jsonString = new List<string>();
            try
            {

                fantasyEntities db = new fantasyEntities();
                var context = db.admin.ToList();
                if (context == null) provjera = "nema";
                else
                {
                    foreach (admin a in context)
                    {
                        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(admin));
                        MemoryStream ms = new MemoryStream();
                        ser.WriteObject(ms, a);
                        jsonString.Add(Encoding.UTF8.GetString(ms.ToArray()));
                        ms.Close();
                    }
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    provjera = eve.Entry.Entity.GetType().Name + " " + eve.Entry.State;
                    foreach (var ve in eve.ValidationErrors)
                    {
                        provjera = ve.PropertyName + " " + ve.ErrorMessage;
                    }
                }

            }

          

            return jsonString;
        }
    }
}
    

