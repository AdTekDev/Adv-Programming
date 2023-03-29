
Console.WriteLine("\nTro choi doan so (4 chu so abcd): ");

int X, SoMayTinh, solan, sldung;
int nm,tm,cm,dm;
int nn,tn,cn,dn;

string ketqua;

bool chuaketthuc;
Random rnd = new Random();
SoMayTinh = rnd.Next(1000,9999);

nm = (SoMayTinh / 1000) % 10;
tm = (SoMayTinh / 100) % 10;
cm = (SoMayTinh / 10) % 10;
dm = SoMayTinh % 10;

solan = 0;
chuaketthuc = true;

while (solan < 12 && chuaketthuc) {
	solan++;
	ketqua = "";
	sldung = 0;
	Console.WriteLine($"Nhap lan thu[{solan}]: ");
	X = Convert.ToInt32(Console.ReadLine());
	
	nn = (X / 1000) % 10;
	tn = (X / 100) % 10;
	cn = (X / 10) % 10;
	dn = X % 10;
	
	if (nm == nn) {
		sldung++;
		ketqua += "= ";
	} else if (tm == nn || cm == nn || dm == nn) {
		ketqua += "* ";
	} else {
		ketqua += "_ ";
	}
	
	if (tm == tn) {
		sldung++;
		ketqua += "= ";
	} else if (nm == tn || cm == tn || dm == tn) {
		ketqua += "* ";
	} else {
		ketqua += "_ ";
	}
	
	if (cm == cn) {
		sldung++;
		ketqua += "= ";
	} else if (tm == cn || nm == cn || dm == cn) {
		ketqua += "* ";
	} else {
		ketqua += "_ ";
	}
	
	if (dm == dn) {
		sldung++;
		ketqua += "= ";
	} else if (tm == dn || nm == dn || cm == dn) {
		ketqua += "* ";
	} else {
		ketqua += "_ ";
	}
	
	if (sldung == 4) {
		chuaketthuc = false;
		Console.WriteLine("WIN  !!!");
	} else {
		Console.WriteLine($"... Sosanh = [{ketqua}]");
	}

}

if (chuaketthuc) 
	Console.WriteLine($"Ban da het luot choi, So can du doan la {SoMayTinh}");
