using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using WebProgrammingMovie.Models;

namespace WebProgrammingMovie.Seeds
{
    public static class DataSeed
    {
        public static void ActorSeed(ModelBuilder builder)
        {
            builder.Entity<Actor>().HasData(
                new Actor { 
                    Id = 1,
                    ActorName = "Johnny Depp",
                    MovieId=1,
                    PhotoURL= "https://tr.web.img4.acsta.net/pictures/22/04/18/16/11/4406324.jpg",
                    Age=45
                },
                new Actor
                {
                    Id = 2,
                    ActorName = "Geoffrey Rush",
                    MovieId = 1,
                    PhotoURL = "https://tr.web.img3.acsta.net/c_310_420/pictures/15/11/18/10/19/300806.jpg",
                    Age = 70
                },
                new Actor
                {
                    Id = 3,
                    ActorName = "Ashley Greene",
                    MovieId = 2,
                    PhotoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Ashley_Greene_2012.jpg/800px-Ashley_Greene_2012.jpg",
                    Age = 35
                },
                new Actor
                {
                    Id = 4,
                    ActorName = "Emmanuel Imani",
                    MovieId = 2,
                    PhotoURL = "https://www.themoviedb.org/t/p/w500/gTYTHVIfv1HMr6h1gtLoACH7l17.jpg",
                    Age = 30
                },
                new Actor
                {
                    Id = 5,
                    ActorName = "Corey Hawkins",
                    MovieId = 3,
                    PhotoURL = "https://images.mubicdn.net/images/cast_member/473019/cache-239998-1599533284/image-w856.jpg?size=800x",
                    Age = 32
                },
                new Actor
                {
                    Id = 6,
                    ActorName = "Sophie Turner",
                    MovieId = 3,
                    PhotoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Sophie_Turner_%2840553145603%29_%28cropped%29.jpg/800px-Sophie_Turner_%2840553145603%29_%28cropped%29.jpg",
                    Age = 26
                },
                new Actor
                {
                    Id = 7,
                    ActorName = "Dominic Andersen",
                    MovieId = 4,
                    PhotoURL = "https://m.media-amazon.com/images/M/MV5BMDgyM2M4OTMtY2Y5Ni00NjZiLWJlNmQtNmJhNmJmZGNlNjRjXkEyXkFqcGdeQXVyNjYzNzE0Mzk@._V1_UY1200_CR585,0,630,1200_AL_.jpg",
                    Age = 26
                },
                new Actor
                {
                    Id = 8,
                    ActorName = "Jennifer Matter",
                    MovieId = 4,
                    PhotoURL = "https://www.themoviedb.org/t/p/original/e7LqKoP0B02v8VL0t7DBcrxn0Mm.jpg",
                    Age = 42
                }

                );
        }
        public static void CategorySeed(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Aksiyon" },
                new Category { Id = 2, Name = "Macera" }
                );
        }
        public static void DirectorSeed(ModelBuilder builder)
        {
            builder.Entity<Director>().HasData(
                new Director { Id = 1, DirectorName = "Gore Verbinski" },
                new Director { Id = 2, DirectorName = "James Nunn" },
                new Director { Id = 3, DirectorName = "Mark Pellington" },
                new Director { Id = 4, DirectorName = "Bill Thomas" }
                );
        }
        public static void MovieSeed(ModelBuilder builder)
        {
            builder.Entity<Movie>().HasData(
                 new Movie {
                     Id=1,
                     Name= "Karayip Korsanları 1",
                     Review= "Valinin kızı Elizabeth Swann, bir korsan olan Kaptan Barbossa tarafından kaçırılır. Başka bir korsan Jack Sparrow, Elizabethin çocukluk arkadaşı Will Turner ile işbirliği yaparak, kızı kurtarmaya çalışır. Peşine düştükleri korsanların ise gücünü ayışığından alan bir lanetleri vardır. Yaşam ile ölüm arasındaki sınırı aşmak ve güçlerine kavuşmak için kaçırdıkları genç kadını kullanmak istemektedirler.",
                     CategoryId= 1,
                     DirectorId=1,
                     SliderPhotoURL= "https://i.pinimg.com/originals/87/a0/92/87a092260dd800b76f1ac6343f8d7fae.jpg",
                     DetailPhotoURL= "https://upload.wikimedia.org/wikipedia/tr/thumb/e/ea/Karayip_Korsanlar%C4%B1_Salazar%E2%80%99%C4%B1n_%C4%B0ntikam%C4%B1_T%C3%BCrk%C3%A7e_Afi%C5%9F.jpg/800px-Karayip_Korsanlar%C4%B1_Salazar%E2%80%99%C4%B1n_%C4%B0ntikam%C4%B1_T%C3%BCrk%C3%A7e_Afi%C5%9F.jpg",
                     ReleaseDate=System.DateTime.Now,
                     Duration=2.4,
                     IMDB=8.6,
                     Country=Enum.CountryEnum.UnitedStates,
                 },
                 new Movie
                 {
                     Id = 2,
                     Name = "Tek Atış",
                     Review = "The Wheel of Time dizisinde ve Hold the Dark filminde oynayan Emmanuel Imani, Norveç yapımı Exit dizisinde oynayan Dino Kelly, Limehouse'un Gizemli Cinayetleri filminde oynayan Jack Parr gibi isimleri izliyoruz.Filmin yönetmeni Yeşil Sokak Holiganları 3: Asla Pes Etme filminin yönetmeni olan James Nunn’dır.James Nunn aynı zamandaki One Shot filminin iki senaristinden de birisidir.Senaryodaki diğer isim ise kısa metrajlı Bricks filminin senaristi olan Jamie Russell’dir.Aksiyon ve gerilim türlerine giren film şu anda 5.5 gibi bir IMDB puanına sahiptir.Film 5 Kasım 2021 tarihinde vizyona girmiştir.",
                     CategoryId = 1,
                     DirectorId = 2,
                     SliderPhotoURL = "https://metadata-static.plex.tv/5/gracenote/5ae29da9ddfaa3545a845cebd3658cb8.jpg",
                     DetailPhotoURL = "https://img.fullhdfilmizlesene.pw/poster/izle/one-shot-67638.jpg",
                     ReleaseDate = System.DateTime.Now,
                     Duration = 2,
                     IMDB = 7.8,
                     Country = Enum.CountryEnum.UnitedStates,
                 },
                 new Movie
                 {
                     Id = 3,
                     Name = "Survive",
                     Review = "Jane ve Paul henüz birbirlerini tanımasalar da yok yakın bir zamanda birlikte oldukça zorlu bir zaman geçirecek olan kişilerdir. Survive isimli 4k film formatlı film ise Jane ve Paul isimli bu iki yabancının birlikte atlatmaya çalıştıkları korkunç bir durumu anlatmaktadır. Jane kendini psikiyatri kliniğine bir hasta olarak bulduğu zaman kimseyle henüz konuşmaya başlamamıştır.Terapisti ise başından her ne geçtiyse anlatması ve bu hislerini hafifletmesi için sürekli olarak Jane’e cesaret vermektedir.Bir gün ise Jane artık dayanamaz ve neden bu klinikte olduğunu tüm terapi grubuna anlatmaya başlar.Jane kendi hayatına bakarken günlerden bir gün uçakla uzak bir bölgeye gitmesi gerektiğinde herkes gibi uçağa binmiş ve rahatlamıştır.Dolu olan yolcu uçağı bir süre sorunsuz uçtuktan sonra ani bir şekilde denesini kaybetmeye başlar ve hızlı bir şekilde de tam olarak neresi olduğu bilinmeyen bir bölgeye çakılır.İşin tuhaf tarafı ise uçak çakıldıktan sonra Jane dışında sadece Paul adındaki bir adam hayatta kalmıştır.Jane ve Paul başta olayın şoku yüzünden anlaşamasalar da sonrasında eğer bu korkunç bölgeden kurtulmak istiyorlarsa birlikte hareket etmeleri gerektiğini anlarlar.Çünkü bulundukları bölge korkunç bir şekilde soğuk olan ve dağların arasında kalmış kar ve tipinin bir an bile kesilmediği bir bölgedir.Türkçe dublajıyla da hazırlanan bu muhteşem macera filminde Mark Pellington yapımın yönetmen koltuğundaki isimdir.Gerilimi dram ile muhteşem bir şekilde sunan filmin senaryosu ise Alex Morel’in kitabından Richard Abate ile Jeremy Ungar tarafından hazırlanmıştır.Soluk soluğa izleyeceğiniz filmin başrol oyuncu kadrosunu ise Sophie Turner ile Corey Hawkins isimleri oluşturmaktadır.Acaba nedene tüm uçaktan Jane ve Paul hayatta kalan iki kişidir ? Jane ve Paul nerede olduklarını bile henüz bulamazken nasıl hayatta kalmayı başaracaklardır ? Jane eğer olay sonrası psikiyatri kliniğinde ise Paul nerededir ? Yoksa Paul bu korkunç olaydan sağ çıkamamış mıdır ? ",
                     CategoryId = 2,
                     DirectorId = 3,
                     SliderPhotoURL = "https://flxt.tmsimg.com/assets/p18077051_b_h10_ad.jpg",
                     DetailPhotoURL = "https://m.media-amazon.com/images/M/MV5BYjFhZGRiZWUtMmFlYi00MDkwLWFjYTMtYzVhZmQ3ZmUwN2I3XkEyXkFqcGdeQXVyMDA4NzMyOA@@._V1_.jpg",
                     ReleaseDate = System.DateTime.Now,
                     Duration = 1.2,
                     IMDB = 6.8,
                     Country = Enum.CountryEnum.Canada,
                 },
                 new Movie
                 {
                     Id = 4,
                     Name = "The Adventures of Maid Marian",
                     Review= "Sadece 4k film formatıyla değil aynı zamanda Türkçe dublajıyla da siz değerli takipçilerimiz için hazırladığımız The Adventures of Maid Marian isimi macera dolu filmin hem yönetmen hem de senarist koltuğundaki isim Bill Thomas’dır. Marian ismindeki zorlu bir kadının başından geçen tehlike dolu maceralara odaklanan filmde Sophie Craig ile Lainy Boyle ve de Jennifer Matter isimleri de yapımın başrol oyuncu kadrosundaki simalardır.Marian başını beladan kurtarmak ve dikkat çekmemek için her ne kadar tam üç yıl boyunca bir manastırda saklanmış olsa da Marian için tehlikelerle dolu zaman henüz gelmemiştir.Her şeyin durulduğunu zanneden Marian bir anda Aslan Yürekli Richard’ın öldüğünü öğrenir ve bu haber de Marian için sevgilisi olan Robin’in yakında döneceği anlamına gelmektedir.Bu haber üzerine Marian artık saklanmanın bir anlamı kalmadığını düşünür ve hemen üç yıllık manastırından ayrılır.Fakat Marian her şeyi yerli yerinde bulacağını düşünürken bir zamanlar toplumda bir saygınlığı olan ancak artık hiçbir değeri olmayan şerif William De Wendenal’ın da sürgünden döndüğünü anlar.William De Wendenal’ın aklında ise sadece intikam dolu yer almaktadır.Bunu az çok bilen Marian ise her şeye hazırlıklı olması gerektiğini anlar.Fakat Marian sonunda sevgilisi Robin ile buluşur ve birlikte kaçmaya başlarlar.Bu sırada pusuya düşen Marian ile sevgilisi Robin hayatları adına bir savaşa girişirler ancak bu savaşın sonunda yaralanan taraf Robin olur.Ancak Marian buna rağmen sevgilisini ölüme terk etmez ve onu da yanına alarak ormanın derin noktalarına doğru sevgilisi ile birlikte kaçmaya başlar.Ama Marian için bu hiç de kolay olmayacaktır.Çünkü yardım alacak hiçbir yer yokken ve peşlerinde de zalim paralı askerler onları takip ederken Marian bir yandan da ağır bir şekilde yaralanmış olan sevgilisi Robin’i hayatta tutmalıdır.Bakalım Marian bunca zorluğa rağmen sevgilisi ile mutlu bir hayata kavuşabilecek midir ? ",
                     CategoryId = 2,
                     DirectorId = 4,
                     SliderPhotoURL = "https://i.ytimg.com/vi/cuET_yYoFk0/maxresdefault.jpg",
                     DetailPhotoURL = "https://img.yts.mx/assets/images/movies/the_adventures_of_maid_marian_2022/large-cover.jpg",
                     ReleaseDate = System.DateTime.Now,
                     Duration = 1.8,
                     IMDB = 7.5,
                     Country = Enum.CountryEnum.Germany,
                 }
                );
        }
    }
}
