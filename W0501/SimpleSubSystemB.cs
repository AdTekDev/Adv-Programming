using System;
public class SimpleSubSystemB {
    public void giaoDonHang(string tendh, int step) {
        Console.WriteLine($" Buoc[{step}] Giao Hang {tendh}");
    }

    public void thuTienHang(string tendh, int step) {
        Console.WriteLine($" Buoc[{step}] THU TIEN DH {tendh}");
    }

    public void hoanTatDonHang(string tendh, int step) {
        Console.WriteLine($" Buoc[{step}] Hoan Tat DH {tendh}");
    }
}