namespace BernaİremYİGİT.Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ogrenci_Sayi = 0;
            int temp = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("kaç öğrenci :");
                    ogrenci_Sayi = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("lütfen rakam giriniz :");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Anlaşılamayan bir hata yaşandı ...");
                }
            }
            string[,] dizi = new string[ogrenci_Sayi, 7];

            for (int i = 0; i < ogrenci_Sayi; i++)
            {
                int deg_vize = 0;
                int deg_final = 0;

                for (int j = 0; j < 5; j++)
                {
                    string deg = "Öğrenci numarası :";
                    switch (j)
                    {
                        case 1:
                            deg = "Öğrenci adı :";
                            break;
                        case 2:
                            deg = "Öğrenci soyadı :";
                            break;
                        case 3:
                            deg = "Öğrenci vize notu :";
                            break;
                        case 4:
                            deg = "Öğrenci final notu :";
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine(deg);

                    if (j == 0)
                    {
                        while (true)
                        {
                            try
                            {
                                dizi[i, j] = Console.ReadLine();
                                temp = int.Parse(dizi[i, j]);
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Numara sorgusu kısmına harf girmeyiniz : ");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Numara sorgusu kısmında bilinmeyen bir hata yaşandı ... ");
                            }

                        }
                    }
                    else if (j == 1)
                    {
                        while (true)
                        {
                            try
                            {
                                dizi[i, j] = Console.ReadLine();
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ad girme kısmında anlaşılamayan bir hata oluştu ...");
                            }
                        }
                    }
                    else if (j == 2)
                    {
                        while (true)
                        {
                            try
                            {
                                dizi[i, j] = Console.ReadLine();
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ad girme kısmında anlaşılamayan bir hata oluştu ...");
                            }
                        }
                    }
                    else if (j == 3)
                    {
                        while (true)
                        {
                            try
                            {
                                dizi[i, j] = Console.ReadLine();
                                deg_vize = int.Parse(dizi[i, j]);
                                if (deg_vize >= 0 && deg_vize <= 100)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0 ila 100 arasında bir puan giriniz :");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Vize notu kısmına geçerli girdi giriniz :");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Vize notu kısımlarında bilinmeyen bir hata oluştu ...");
                            }
                        }
                    }
                    else if (j == 4)
                    {
                        while (true)
                        {
                            try
                            {
                                dizi[i, j] = Console.ReadLine();
                                deg_final = int.Parse(dizi[i, j]);
                                if (deg_final >= 0 && deg_final <= 100)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0 ila 100 arasında bir puan giriniz :");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Final notu kısmına geçerli girdi giriniz :");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Final notu kısımlarında bilinmeyen bir hata oluştu ...");
                            }

                        }
                    }

                    float deg_ort = deg_vize * 40 / 100 + deg_final * 60 / 100;
                    dizi[i, 5] = Convert.ToString(deg_ort);

                    if (deg_ort > 85 && deg_ort < 100)
                    {
                        dizi[i, 6] = "AA";
                    }
                    else if (deg_ort > 75)
                    {
                        dizi[i, 6] = "BA";
                    }
                    else if (deg_ort > 60)
                    {
                        dizi[i, 6] = "BB";
                    }
                    else if (deg_ort > 50)
                    {
                        dizi[i, 6] = "CB";
                    }
                    else if (deg_ort > 40)
                    {
                        dizi[i, 6] = "CC";
                    }
                    else if (deg_ort > 30)
                    {
                        dizi[i, 6] = "DC";
                    }
                    else if (deg_ort > 20)
                    {
                        dizi[i, 6] = "DD";
                    }
                    else if (deg_ort > 10)
                    {
                        dizi[i, 6] = "FD";
                    }
                    else if (deg_ort >= 0)
                    {
                        dizi[i, 6] = "FF";
                    }


                }
                Console.WriteLine("");
            }

            for (int k = 0; k < ogrenci_Sayi; k++)
            {
                int sayac = k + 1;
                Console.WriteLine($"{sayac}'nci öğrenci : ");

                Console.WriteLine($"öğrenci numarası :      {dizi[k, 0]}");
                Console.WriteLine($"öğrenci adı :           {dizi[k, 1]}");
                Console.WriteLine($"öğrenci soyadı :        {dizi[k, 2]}");
                Console.WriteLine($"öğrenci vize puanı :    {dizi[k, 3]}");
                Console.WriteLine($"öğrenci final puanı :   {dizi[k, 4]}");
                Console.WriteLine($"öğrenci ortalama :      {dizi[k, 5]}");
                Console.WriteLine($"öğrenci 4'lük puanı :   {dizi[k, 6]}");

                Console.WriteLine("");
            }


            int en_kucuk_v = int.MaxValue;
            int en_buyuk_v = int.MinValue;
            int en_kucuk_f = int.MaxValue;
            int en_buyuk_f = int.MinValue;

            for (int t = 0; t < ogrenci_Sayi; t++)
            {

                if (en_kucuk_v > int.Parse(dizi[t, 3]))
                {
                    en_kucuk_v = int.Parse(dizi[t, 3]);
                }
                if (en_kucuk_f > int.Parse(dizi[t, 4]))
                {
                    en_kucuk_f = int.Parse((dizi[t, 4]));
                }
                if (en_buyuk_f < int.Parse(dizi[t, 4]))
                {
                    en_buyuk_f = int.Parse(dizi[t, 4]);
                }
                if (en_buyuk_v < int.Parse(dizi[t, 3]))
                {
                    en_buyuk_v = int.Parse((dizi[t, 3]));
                }
            }

            temp = 0;
            for (int i = 0; i < ogrenci_Sayi; i++)
            {
                temp += int.Parse(dizi[i, 5]);

            }
            temp = temp / ogrenci_Sayi;
            Console.WriteLine($"""
                sınıf mezuniyet ortalaması    : {temp}
                vizelerden alınmış en az puan : {en_kucuk_v}
                vizelerden alınmış en çok puan : {en_buyuk_v}
                finallerden alınmış en az puan : {en_kucuk_f}
                finallerden alınmış en çok puan : {en_buyuk_f}
                """);
            Console.ReadKey();

        }
    }
}
