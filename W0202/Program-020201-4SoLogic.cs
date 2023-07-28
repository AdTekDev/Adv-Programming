int x, nhapvao;
int xA, xB, xC, xD;
int nA, nB, nC, nD;
int solan = 0;
int soDung, soSaiVT;

Random rand = new Random();
x = rand.Next(1000,9999);
// Tach a,b,c,d
xA = (x/1000) % 10;
xB = (x/100) % 10;
xC = (x/10) % 10;
xD = x% 10;

while (solan < 12) {
    Console.WriteLine("Tro choi doan so, nhap 1 so co 4 chu so:");
    nhapvao = int.Parse(Console.ReadLine());    

    nA = (nhapvao/1000) % 10;
    nB = (nhapvao/100) % 10;
    nC = (nhapvao/10) % 10;
    nD = nhapvao% 10;

    soDung = 0;
    soSaiVT = 0;
    if (xA == nA)  soDung++;
    else if (xA == nC || xA == nB || xA == nD) soSaiVT++;
    if (xB == nB)  soDung++;
    else if (xB == nC || xB == nA || xB == nD) soSaiVT++;
    if (xC == nC)  soDung++;
    else if (xC == nA || xC == nB || xC == nD) soSaiVT++;
    if (xD == nD)  soDung++;
    else if (xD == nC || xD == nB || xD == nA) soSaiVT++;
    //..
    Console.WriteLine($"{soDung} dung vtri, {soSaiVT} sai vt");
    solan++;
}

