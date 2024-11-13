using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HK1B_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.UTF8;
            //phát sinh một số ngẫu nhiên có 3 chữ số 
            Random rd = new Random();
            int soNgauNhien = rd.Next(100, 1000);

           

            //tối đa nhập 7 lần đoán số
            int soLanDoan = 0;
            string ketQua = "";
            while (soLanDoan < 7 && ketQua != "+++")
            {
                Console.Write("Mời bạn đoán số: ");

                string soDuDoan = Console.ReadLine();

                soLanDoan++;

                //hàm kiểm tra số ngẫu nhiên và số người dùng đoán theo điều kiện của bài toán
                ketQua = LayKetQuaDuDoan(soNgauNhien.ToString(), soDuDoan); //+, ?

                //in kết quả để kiểm tra 

                Console.WriteLine("Kết quả: " + ketQua);
            }

            Console.WriteLine("Số ngẫu nhiên: " + soNgauNhien);


            Console.ReadLine();
        }

        static string LayKetQuaDuDoan(string soNgauNhien, string soDuDoan)
        {
            string ketQua = "";
            //thực hiện logic của bài toán
            for (int i = 0; i < soNgauNhien.Length; i++)
            {
                if (soNgauNhien[i] == soDuDoan[i])
                {
                    ketQua += "+";
                }
                else if (soNgauNhien.Contains(soDuDoan[i].ToString()))
                {
                    ketQua += "?";
                }
            }

            return ketQua;
        }
    }
}
