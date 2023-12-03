using BUS.IService;
using BUS.Shared;
using DAL.Context;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class DbInitializer : IDbInitializer
    {
        private readonly QRDbContext _db;
        public DbInitializer(QRDbContext qRDbContext)
        {
            _db = qRDbContext;
        }
        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Any()) // kiểm tra migration, nếu không có sẽ thực hiện migration (.count hoặc any cũng đc)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {

            }


            if (!_db.role.Any(p => p.RoleName == SD.Admin))
            {
                _db.role.Add(new() { RoleName = SD.Admin });
                _db.role.Add(new() { RoleName = SD.Staff });
                _db.SaveChanges();

                var profiles = new List<Profile>()
                {
                    new()
                    {
                        FullName = "Nguyen Van A",
                        Address = "0123 ABZX ",
                        Phone = "0903999854",
                        IdentifyCard = "0123456789",
                        StaffShifts = "ca chiều",
                        Position = "nhân viên",
                        Salary = 90000
                    }
                };
                _db.profiles.AddRange(profiles); // add list, thêm nhiều đối tượng
                _db.SaveChanges();
                var accounts = new List<Account>()
                {
                    new()
                    {
                       ProfileID = _db.profiles.FirstOrDefault(p => p.FullName == "Nguyen Van A").ProfileID,
                       RoleID = _db.role.FirstOrDefault(p => p.RoleName == SD.Staff).RoleID,
                       Email = "avcxx@gmail.com",
                       UserName = "nv001",
                       Password = "NV001"
                    },
                };
                _db.Accounts.AddRange(accounts); // add list, thêm nhiều đối tượng
                _db.SaveChanges();

                //... tiếp tục những thằng còn lại

                };
            }
        }
    }
