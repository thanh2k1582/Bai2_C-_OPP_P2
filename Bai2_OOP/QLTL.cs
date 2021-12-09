using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2_OOP
{
    class QLTL
    {
        private List<Sach> ListSach = null;
        private List<TapChi> ListTapChi = null;
        private List<Bao> ListBao = null;
        private List<TaiLieu> ListTaiLieu = null;
        public QLTL()
        {
            ListSach = new List<Sach>();
            ListTapChi = new List<TapChi>();
            ListBao = new List<Bao>();
            ListTaiLieu = new List<TaiLieu>();
        }

        public void NhapSach()
        {
            Sach sach = new Sach();
            Console.Write("Nhap ma: ");
            sach.MaTl = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ten nha xuat ban: ");
            sach.TenNXB = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap so ban phat hanh: ");
            sach.SoBPH = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap ten tac gia: ");
            sach.TenTG = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap so trang: ");
            sach.SoTrang = Convert.ToInt32(Console.ReadLine());

            ListSach.Add(sach);
        }
        public void NhapTapChi()
        {
            TapChi tapchi = new TapChi();
            Console.Write("Nhap ma: ");
            tapchi.MaTl = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ten nha xuat ban: ");
            tapchi.TenNXB = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap so ban phat hanh: ");
            tapchi.SoBPH = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so phat hanh: ");
            tapchi.SoPH = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap thang phat hanh: ");
            tapchi.ThangPH = Convert.ToInt32(Console.ReadLine());

            ListTapChi.Add(tapchi);
        }
        public void NhapBao()
        {
            Bao bao = new Bao();
            Console.Write("Nhap ma: ");
            bao.MaTl = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ten nha xuat ban: ");
            bao.TenNXB = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap so ban phat hanh: ");
            bao.SoBPH = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap ngay phat hanh: ");
            bao.NgayPH = Convert.ToInt32(Console.ReadLine());

            ListBao.Add(bao);
        }


        public void XuatSach(List<Sach> listSach)
        {
            foreach (Sach sach in listSach)
            {
                Console.WriteLine("Ma tai lieu: {0}", sach.MaTl);
                Console.WriteLine("Ten nha xuat ban: {0}", sach.TenNXB);
                Console.WriteLine("So ban phat hanh: {0}", sach.SoBPH);
                Console.WriteLine("Ten tac gia: {0}", sach.TenTG);
                Console.WriteLine("So trang: {0}", sach.SoTrang);
            }
            Console.WriteLine();
        }
        public void XuatTapChi(List<TapChi> listTapChi)
        {
            foreach (TapChi tapchi in listTapChi)
            {
                Console.WriteLine("Ma tai lieu: {0}", tapchi.MaTl);
                Console.WriteLine("Ten nha xuat ban: {0}", tapchi.TenNXB);
                Console.WriteLine("So ban phat hanh: {0}", tapchi.SoBPH);
                Console.WriteLine("So phat hanh: {0}", tapchi.SoPH);
                Console.WriteLine("Thang phat hanh: {0}", tapchi.ThangPH);
            }
            Console.WriteLine();
        }
        public void XuatBao(List<Bao> listBao)
        {
            foreach (Bao bao in listBao)
            {
                Console.WriteLine("Ma tai lieu: {0}", bao.MaTl);
                Console.WriteLine("Ten nha xuat ban: {0}", bao.TenNXB);
                Console.WriteLine("So ban phat hanh: {0}", bao.SoBPH);
                Console.WriteLine("Ngay phat hanh: {0}", bao.NgayPH);
            }
            Console.WriteLine();
        }

        //Tìm kiếm theo mã tài liệu
        public List<Sach> timSachTheoMaTaiLieu(String keyword)
        {
            List<Sach> searchResult = new List<Sach>();
            foreach (Sach sach in ListSach)
            {
                if (sach.MaTl.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(sach);
                }
            }
            return searchResult;
        }
        public List<TapChi> timTapChiTheoMaTaiLieu(String keyword)
        {
            List<TapChi> searchResult = new List<TapChi>();
            foreach (TapChi tapChi in ListTapChi)
            {
                if (tapChi.MaTl.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(tapChi);
                }
            }
            return searchResult;
        }
        public List<Bao> timBaoTheoMaTaiLieu(String keyword)
        {
            List<Bao> searchResult = new List<Bao>();
            foreach (Bao bao in ListBao)
            {
                if (bao.MaTl.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(bao);
                }
            }
            return searchResult;
        }


        //find ma tai lieu
        public Sach FindByIDSach(string ID)
        {
            Sach searchResult = null;
            foreach (Sach Sach in ListSach)
            {
                if (Sach.MaTl == ID)
                {
                    searchResult = Sach;
                }
            }
            return searchResult;
        }
        public TapChi FindByIDTapChi(string ID)
        {
            TapChi searchResult = null;
            foreach (TapChi TapChi in ListTapChi)
            {
                if (TapChi.MaTl == ID)
                {
                    searchResult = TapChi;
                }
            }
            return searchResult;
        }
        public Bao FindByIDBao(string ID)
        {
            Bao searchResult = null;
            foreach (Bao Bao in ListBao)
            {
                if (Bao.MaTl == ID)
                {
                    searchResult = Bao;
                }
            }
            return searchResult;
        }


        //delete
        public bool DeleteByIdSach(string ID)
        {
            bool IsDeleted = false;
            Sach sach = FindByIDSach(ID);
            if (sach != null)
            {
                IsDeleted = ListSach.Remove(sach);
            }
            return IsDeleted;
        }
        public bool DeleteByIdTapChi(string ID)
        {
            bool IsDeleted = false;
            TapChi tapchi = FindByIDTapChi(ID);
            if (tapchi != null)
            {
                IsDeleted = ListTapChi.Remove(tapchi);
            }
            return IsDeleted;
        }
        public bool DeleteByIdBao(string ID)
        {
            bool IsDeleted = false;
            Bao bao = FindByIDBao(ID);
            if (bao != null)
            {
                IsDeleted = ListBao.Remove(bao);
            }
            return IsDeleted;
        }



        public List<Sach> getListSach()
        {
            return ListSach;
        }
        public List<TapChi> getListTapChi()
        {
            return ListTapChi;
        }
        public List<Bao> getListBao()
        {
            return ListBao;
        }
    }
}
