using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SymphonyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyProject.DB
{
    public class AccountDBContext : DbContext
    {

        #region [Constructor]
        private AccountDBContext() { }

        public AccountDBContext(DbContextOptions<AccountDBContext> options) : base(options)
        {
        }
        #endregion

        #region [Init]
        public DbSet<Enquiry> EnquiryCollection { get; set; }
        public DbSet<User> UserCollection { get; set; }

        public DbSet<DealerRegistration> DealerCollection { get; set; }

        #endregion

        #region [Db Confguration]	
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* base.OnConfiguring(optionsBuilder);*/
            if (!optionsBuilder.IsConfigured)
            {
                DbUtil.ConfigureDBConnection(optionsBuilder);

            }
        }

        private static void LogMessage(string msg)
        {
            // Log with Debug for now. Will write to real log later
            DbUtil.LogMessage(msg);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("tbl_Enquiry");
                //entity.Property(e => e.RowID).HasColumnName("ID").HasDefaultValueSql("(newid())");
                entity.Property(e => e.CustomerName).HasColumnName("CustomerName").HasMaxLength(50);
                entity.Property(e => e.Email).HasColumnName("Email").HasMaxLength(50);
                entity.Property(e => e.Mobile).HasColumnName("Mobile").HasMaxLength(10);
                entity.Property(e => e.Product).HasColumnName("Product").HasMaxLength(50);
                entity.Property(e => e.Address).HasColumnName("Address").HasMaxLength(50);
                entity.Property(e => e.State).HasColumnName("State").HasMaxLength(50);
                entity.Property(e => e.City).HasColumnName("City").HasMaxLength(50);
                entity.Property(e => e.Pincode).HasColumnName("Pincode").HasMaxLength(6);
                entity.Property(e => e.Remarks).HasColumnName("Remarks").HasMaxLength(100);
            });

            modelBuilder.Entity<DealerRegistration>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("tbl_dealerRegistration");
                //entity.Property(e => e.RowID).HasColumnName("ID").HasDefaultValueSql("(newid())");
                entity.Property(e => e.DealerName).HasColumnName("DealerName").HasMaxLength(50);
                entity.Property(e => e.Name1).HasColumnName("Name1").HasMaxLength(50);
                entity.Property(e => e.GSTNo).HasColumnName("GSTNo").HasMaxLength(50);
                entity.Property(e => e.PANNO).HasColumnName("PANNO").HasMaxLength(50);
                entity.Property(e => e.Email).HasColumnName("Email").HasMaxLength(50);
                entity.Property(e => e.Mobile).HasColumnName("Mobile").HasMaxLength(50);
                entity.Property(e => e.Address).HasColumnName("Address").HasMaxLength(50);
                entity.Property(e => e.State).HasColumnName("State").HasMaxLength(50);
                entity.Property(e => e.City).HasColumnName("City").HasMaxLength(50);
                entity.Property(e => e.Pin).HasColumnName("Pin").HasMaxLength(50);
                entity.Property(e => e.Remarks).HasColumnName("Remarks").HasMaxLength(50);
               
            });
        }

        #endregion

        #region [Supplyer Enquiry]
        public async Task<int> AddEnquiry(Enquiry obj)
        {
            int count = 0;
            if (obj != null)
            {
                try
                {
                    using (var transaction = Database.BeginTransaction())
                    {
                        try
                        {
                            EnquiryCollection.Add(obj);
                            count = await SaveChangesAsync();
                            transaction.Commit();
                        }

                        #region [catch me]
                        catch (DbUpdateConcurrencyException ex) { LogMessage(ex.Message); }
                        catch (DbUpdateException ex) { LogMessage(ex.Message); }
                        catch (Exception ex) { LogMessage(ex.Message); }

                        finally { Database.CloseConnection(); }
                        #endregion
                    }
                }

                #region [catch me]
                catch (DbUpdateConcurrencyException ex) { LogMessage(ex.Message); }
                catch (DbUpdateException ex) { LogMessage(ex.Message); }
                catch (Exception ex) { LogMessage(ex.Message); }

                finally { Database.CloseConnection(); }
                #endregion
            }

            return count;
        }
        #endregion

        #region [Dealer Registration]
        public async Task<int> AddDealer(DealerRegistration obj)
        {
            int count = 0;
            if (obj != null)
            {
                try
                {
                    using (var transaction = Database.BeginTransaction())
                    {
                        try
                        {
                            DealerCollection.Add(obj);
                            count = await SaveChangesAsync();
                            transaction.Commit();
                        }

                        #region [catch me]
                        catch (DbUpdateConcurrencyException ex) { LogMessage(ex.Message); }
                        catch (DbUpdateException ex) { LogMessage(ex.Message); }
                        catch (Exception ex) { LogMessage(ex.Message); }

                        finally { Database.CloseConnection(); }
                        #endregion
                    }
                }

                #region [catch me]
                catch (DbUpdateConcurrencyException ex) { LogMessage(ex.Message); }
                catch (DbUpdateException ex) { LogMessage(ex.Message); }
                catch (Exception ex) { LogMessage(ex.Message); }

                finally { Database.CloseConnection(); }
                #endregion
            }

            return count;
        }
        #endregion

        #region [Login Methods]
        public async Task<User> GetLoginDetails(User obj)
        {
            User user = null;
            if (obj != null)
            {
                try
                {
                    user = await Task.Run(() => DoQueryAllLoginDetails(obj));
                }
                catch (ArgumentNullException ex) { LogMessage(ex.Message); }
                catch (Exception ex) { LogMessage(ex.Message); }
            }
            return user;
        }
        private string BuildMySelectQuery()
        {
            return _selectFields;
        }
        private const string _selectFields = "SELECT Id, Username, Password, RoleId FROM tbl_User";
        private User DoQueryAllLoginDetails(User objnew)
        {
            bool ok = false;
            User theList = null;

            try
            {
                string query = BuildMySelectQuery() + " WHERE UserName COLLATE FINNISH_SWEDISH_CS_AI=" + DbUtil.QuoteMe(objnew.UserName) + "and Password =" + DbUtil.QuoteMe(objnew.Password);

                List<User> aiList = UserCollection.FromSqlRaw(query).ToList();
                if (aiList != null && aiList.Count > 0)
                {
                    theList = aiList[0];
                }
                ok = true;
            }

            catch (InvalidOperationException ex) { LogMessage(ex.Message); }
            catch (ArgumentNullException ex) { LogMessage(ex.Message); }
            catch (Exception ex) { LogMessage(ex.Message); }

            finally { if (!ok) Database.CloseConnection(); }

            return theList;
        }
        #endregion


        #region [Count Total User]
        //public async Task<User> getTotalUser()
        //{

            //User user = null;

            //if (user == null)
            //{
            //    try
            //    {
            //        user = await Task.Run(() => getTotalQuery(user));
            //    }
            //    catch (ArgumentNullException ex) { LogMessage(ex.Message); }
            //    catch (Exception ex) { LogMessage(ex.Message); }
            //}
        //    return user;
        //}

    //private User getTotalQuery(User objnew)
    //{
    //    bool ok = false;
    //    User theList = null;

    //    try
    //    {
    //        string query = getTotalqueryforAll();

    //        List<User> aiList = UserCollection.FromSqlRaw(query).ToList();
    //        if (aiList != null && aiList.Count > 0)
    //        {
    //            theList = aiList[0];
    //        }
    //        ok = true;
    //    }

    //    catch (InvalidOperationException ex) { LogMessage(ex.Message); }
    //    catch (ArgumentNullException ex) { LogMessage(ex.Message); }
    //    catch (Exception ex) { LogMessage(ex.Message); }

    //    finally { if (!ok) Database.CloseConnection(); }

    //    return theList;
    //}

    //private string getTotalqueryforAll()
    //{
    //    return _showAllCountUser;
    //}
    //private const string _showAllCountUser = "SELECT count(Id) from tbl_User";
    #endregion






}
}
