class Program
{
    public static void Main(string[] args)
    {
        //1 -  10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] numbers = new int[10];


        //2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
            
        }
        Console.WriteLine("Dizi elamanları Gösterildi");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        //3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
        //Goto için Tekrar diye etiket Tanımı
        Tekrar:
        int newNumber;
        Console.WriteLine("Bir Değer Giriniz");
        bool okey = int.TryParse(Console.ReadLine(), out newNumber);
        Console.WriteLine("*****************************************");
        if (okey)
        {
            // Diziyi yeniden boyutlandırma ve yeni elemanı ekleme
            Array.Resize(ref numbers, numbers.Length + 1); // Diziyi 1 eleman büyütüyoruz
            numbers[numbers.Length - 1] = newNumber; // Yeni değeri son eleman olarak ekliyoruz
        }
        else
        {
            Console.WriteLine("Hatalı İşlem Yaptınız Lütfen Tekrar Sayıyı Giriniz");
            //goto ile Tekra etiketine aktarım
            goto Tekrar;
        }

        //4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine("Dizi büyükten küçüğe sıralandı:");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}