# KAYIT
Veri tabanı kullanarak bir kimlik kartı oluşturdum. Her değer girildiğinde veriler gösterilip kayıt edilecektir.
İlk önce SQL Server'da kayıtlar adı altında bir veritabanı oluşturdum. Bunları görüntüleyebilmek için Visual Studio'da ListView'yi kullandım.
Visual Studio'da bir SQL kütüphanesi ekledim.
Bağlantıyı oluşturdum.
Daha sonra verileri çağırmak için Global adında bir yordam oluşturdum.
Yapmış olduğum bağlantıyı açtım (bağlan.open();)
Bir komut oluşturdum. Bu yüzden new dizisini kullandım. Veri komutunu vermem gerekiyor bu yüzden select yapıp tablodan bağlantıyı seçtim.
Okutma komutu gerekiyordu sqlDataReader'yi kullanarak sql de veriyi okuttum.
Bir döngü lazımdı. C# da bu döngüler while , do-while, for döngüleridir. Kesme döngüsü olan "while" döngüsünü kullandım. While(oku.Read(1) okuduğu müddetçe veri tabanındaki verileri alsın.ListView'e yadırsın.
Elemanları ise ListView'de oluşturdum. ve ListView1.Items.Add(ekle); yazıp elemanları çağırdım.
Son olarak ise kaydetme butonu; kaydetme butonunu çalıştırmak için bağlantıyı açtım. İnsert İnto yani içine ekle (tablodaki) values yazıp textlerdeki değerleri alıp ekledim.
En son olarakta ToString olarak kaydedip bağlanla ilişkilendirdim.
