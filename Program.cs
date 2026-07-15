using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

Console.OutputEncoding = System.Text.Encoding.UTF8;
int points = 1000;
int totalwin = 0;
int Wins = 0;
int Losses = 0;
int tienthanglonnhat = 0;
Menu:
Console.WriteLine("1. Số dư 2. Chơi 3. thống kê 4. thoát");
string choice  = Console.ReadLine();
switch (choice)
{
    case "1" : Console.WriteLine("Điểm hiện tại của bạn là {0}",points); goto Menu; break;
    case "2" : goto Game; break;
    case "3" : goto Thongke; break;
    case "4" : goto Thoat; break;
    default: Console.WriteLine("Vui lòng chọn lại"); goto Menu; break;
}

Game:
string chosenanimal = null;
Console.WriteLine("Vui lòng chọn linh vật của ban");
Console.WriteLine("1. Bầu  2. Cua  3. Tôm  4. Cá  5. Gà  6.Nai");
string linhvat = Console.ReadLine();
switch (linhvat)
{
case "1" : Console.WriteLine("Bạn đã chọn Bầu làm linh vật");chosenanimal = "Bầu"; break;
case "2" : Console.WriteLine("Bạn đã chọn Cua làm linh vật");chosenanimal = "Cua";break;
case "3" : Console.WriteLine("Bạn đã chọn Tôm làm linh vật");chosenanimal = "Tôm";break;
case "4" : Console.WriteLine("Bạn đã chọn Cá làm linh vật");chosenanimal = "Cá";break;
case "5" : Console.WriteLine("Bạn đã chọn Gà làm linh vật");chosenanimal = "Gà";break;
case "6" : Console.WriteLine("Bạn đã chọn Nai làm linh vật");chosenanimal = "Nai";break;
default: Console.WriteLine("Vui lòng chọn lại");goto Menu; break;
}
int starting = int.Parse(linhvat);
Console.WriteLine("Bạn muốn cược bao nhiêu");
int tiencuoc = int.Parse(Console.ReadLine());
if (tiencuoc > points)
{
    Console.WriteLine("Tiền cược không thể lớn hơn số dư");
}
else
{
    points -= tiencuoc;
}
Random dice = new Random();
Console.WriteLine("--- Đang tung xúc xắc ---");

for (int i = 1; i <= 3; i++)
{
    int roll = dice.Next(1, 7);

    Console.WriteLine($"Xúc xắc {i}: [ {roll} ]");
    if  (roll == starting)
    {
        Console.WriteLine($"Xúc xắc số {i} thắng");
        points += tiencuoc;
        totalwin++;
        Wins++;
    }
    else
    {
        Console.WriteLine($"xúc xắc số {i} thua");
        Losses++;
    }

    int tienthang = totalwin * tiencuoc;
    if (tienthang > tienthanglonnhat)
    {
        tienthanglonnhat = tienthang;
    }
}
Console.WriteLine("----------------------");
goto Menu;
if (points < 0)
{
    Console.WriteLine("Hết tiền! Bạn đã thua!");
    goto Thoat;
}
Thongke:
Console.WriteLine("số trận thắng của bạn là {0}", Wins);
Console.WriteLine("số trận thua của bạn là {0}", Losses);
Console.WriteLine("số tiền thắng lớn nhất của bạn là {0}", tienthanglonnhat);
goto  Menu;

Thoat:
Console.WriteLine("Hẹn gặp lại lần sau");


