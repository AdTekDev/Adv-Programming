using System;
public class SimpleSubSystemA {
    public void kiemTraDonHang(string tendh, int step) {
        Console.WriteLine($" Buoc[{step}] Kiem tra DH {tendh}");
    }

    public void dongGoiDonHang(string tendh, int step) {
        Console.WriteLine($" Buoc[{step}] DONG GOI DH {tendh}");
    }
}