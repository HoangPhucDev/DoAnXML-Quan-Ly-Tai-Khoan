using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DXDoAnXML
{
    public class Accounts
    {
        [Key, Display(AutoGenerateField = true)]
        public int Id { set; get; }
       // [Required]
        [Display(Name = "Nguồn")]
        public string Nguon { set; get; }
        [Display(Name = "Tài Khoảng")]
        public string TaiKhoan { set; get; }
        [Display(Name = "Mật Khẩu")]
        public string MatKhau { set; get; }
         XElement xmlAccount { set; get; }


        public Accounts()
        {
            LoadFile loadfile = new LoadFile();
            xmlAccount = loadfile.xmlLoadFile;
        }

        public Accounts(string path)
        {
            LoadFile loadfile = new LoadFile(path);
            xmlAccount = loadfile.xmlLoadFile;
        }

        public List<Accounts> GetAll()
        {
            List<Accounts> list = new List<Accounts> { };
            try { 
                 list = (from p in xmlAccount.Elements("TAIKHOAN")
                                       select new Accounts
                                       {
                                           Id = int.Parse(p.Attribute("ID").Value),
                                           TaiKhoan = p.Element("TEN").Value,
                                           MatKhau = p.Element("MATKHAU").Value,
                                           Nguon = p.Element("NGUON").Value
                                       }).ToList();
            }
            catch { XtraMessageBox.Show("Lổi Mở File\n" +
                                        "Vui Lòng Kiểm Tra Lại File accounts.xml Trong Thư Mục Cài Đặt",
                                        "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return list;
        }
        public int GetMaxId()
        {
            int Maxid = 0;
            List<Accounts> list = GetAll();
            try
            {
                Maxid = list.Max(p => p.Id);
            }
            catch
            { }
            return Maxid;
        }
        public void Insert(string _Name, string _MatKhau, string _Nguon)
        {
            XElement newAccount = new XElement("TAIKHOAN",

                    new XAttribute("ID", GetMaxId() + 1),

                    new XElement("TEN", _Name),

                    new XElement("MATKHAU", _MatKhau),

                    new XElement("NGUON", _Nguon));

            xmlAccount.Add(newAccount);

            xmlAccount.Save(LoadFile.FILENAME);
        }

        public void Delete(string ID)
        {
            IEnumerable<XElement> list = (from b in xmlAccount.Elements("TAIKHOAN")
                                          where b.Attribute("ID").Value == ID
                                          select b).Take(1);
            foreach (XElement item in list)

            {

                item.Remove();

            }
            xmlAccount.Save(LoadFile.FILENAME);
        }

        public void Update(string ID, string _Nguon, string _TaiKhoang, string _MatKhau)
        {
            IEnumerable<XElement> list = (from b in xmlAccount.Elements("TAIKHOAN")
                                          where b.Attribute("ID").Value == ID
                                          select b).Take(1);
            foreach (XElement xe in list)

            {
                xe.SetElementValue("NGUON", _Nguon);
                xe.SetElementValue("TEN", _TaiKhoang);
                xe.SetElementValue("MATKHAU", _MatKhau);
            }
            xmlAccount.Save(LoadFile.FILENAME);
        }
    }
}
