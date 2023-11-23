using BUS.Service;
using DAL.Context;
using DAL.Models;
using DAL.Repository;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TableSVC tableSVC = new TableSVC(new TableRepos(new QRDbContext()));
            // ProductSVC productSVC = new ProductSVC(new ProductRepos(new QRDbContext()));
            // đã test product

            // RoleSVC roleSVC = new RoleSVC(new RoleRepos(new QRDbContext()));
            // 2 thằng dưới đi chung với nhau sau khi khởi tạo bảng role
            // AccountSVC accountSVC = new AccountSVC(new AccountRepos(new QRDbContext()));
            // ProfileSVC profileSVC = new ProfileSVC(new ProfileRepos(new QRDbContext()));

            // VoucherTypeSVC voucherTypeSVC = new VoucherTypeSVC(new VoucherTypeRepos(new QRDbContext()));
            // OrderHeaderSVC orderHeaderSVC = new OrderHeaderSVC(new OrderHeaderRepos(new QRDbContext()));

            // VoucherSVC voucherSVC = new VoucherSVC(new VoucherRepos(new QRDbContext()));


            // OrderDetailsSVC orderDetailsSVC = new OrderDetailsSVC(new OrderDetailsRepos(new QRDbContext()));

            try
            {
                // tableSVC.Add(new Table() { TableID = "A001",TableName = "Bàn số 1"});
               //  productSVC.Add(new Products() { ProductID = "P001", ProductName = "Bánh Trung Thu", Price = 50.0, Category = "Bánh Ngọt", Image = " ", IsInStock = true });

                // roleSVC.Add(new Role() { RoleID = "001", RoleName = "Nhân viên" });
                // accountSVC.Add(new Account() { Id = "NV002", RoleID = "001", ProfileID = "NV003", UserName = "nguyenvanb", Password = "123", Email = "nguyenvanb@gmail.com" });
                // profileSVC.Add(new Profile() { ProfileID = "NV003", FullName = "Nguyễn Văn B", Address = "004 Nguyễn Trãi, p7,q5 TPHCM", Phone = "0903999455", IdentifyCard = "1123456789", StaffShifts = "Ca Chiều", Position = "Nhân viên", Salary = 3500000 });

                //  voucherTypeSVC.Add(new VoucherType() { VoucherTypeID = "VT001", VoucherName = "Discount 10%", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(30), Description = "10% off on all orders" });
                // orderHeaderSVC.Add(new OrderHeader() { OrderHeaderID = "OH001", TableID = "A001", OrderTotal = 100.0, Discount = 10.0, OrderDate = DateTime.Now, OrderStatus = "Pending", VAT = 10.0, Note = "Sample Order" });


                //  voucherSVC.Add(new Voucher() { VoucherID = "V001", VoucherTypeID = "VT001", OrderHeaderID = "OH001", IsValid = true });


               // orderDetailsSVC.Add(new OrderDetails() { OrderDetailsID = "OD001", ProductID = "P001", OrderHeaderID = "OH001", Quantity = 2 });

                MessageBox.Show("Add success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
