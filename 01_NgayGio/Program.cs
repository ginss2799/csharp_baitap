using System;

class Program{
    static void Main(string [] args){
        // De chay code, go lenh 
        //dotnet run 
        //Giai bai tap: hien thi ngay gio he thong
        DateTime dt = DateTime.Now; //khai bao bien kieu ngay gio, dat ten bien dt va gan gia tri la gio hien tai bang lenh DateTime.Now
        Console.WriteLine(dt.ToString());
        //Nang cao: Ban hãy định dạng chuỗi xuất theo kiểu ngày--tháng-năm  giờ:phút:giây
    }

}
