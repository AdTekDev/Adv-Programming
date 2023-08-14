
public class SimpleFacade {
    SimpleSubSystemA subA;
    SimpleSubSystemB subB;
    public SimpleFacade() {
        subA = new SimpleSubSystemA();
        subB = new SimpleSubSystemB();
    }
    public void donHangCuaShopTTTT(string donhang){
        subA.kiemTraDonHang(donhang, 1);
        subB.hoanTatDonHang(donhang, 2);
    }

    public void donHangTrucTiepTTTT(string donhang){
        subA.kiemTraDonHang(donhang, 1); 
        subA.dongGoiDonHang(donhang, 2);
        subB.giaoDonHang(donhang, 3);
        subB.hoanTatDonHang(donhang, 4);
    }

    public void donHangTrucTiepCOD(string donhang){
        
    }
}