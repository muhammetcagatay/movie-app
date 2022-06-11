using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgrammingMovie.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Country = table.Column<int>(type: "int", nullable: true),
                    PhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    View = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DirectorId = table.Column<int>(type: "int", nullable: true),
                    SliderPhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailPhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    IMDB = table.Column<double>(type: "float", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movie_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    PhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actor_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Score = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rating_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Aksiyon" },
                    { 2, "Macera" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "DirectorName" },
                values: new object[,]
                {
                    { 1, "Gore Verbinski" },
                    { 2, "James Nunn" },
                    { 3, "Mark Pellington" },
                    { 4, "Bill Thomas" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "CategoryId", "Country", "DetailPhotoURL", "DirectorId", "Duration", "IMDB", "Name", "ReleaseDate", "Review", "SliderPhotoURL", "View" },
                values: new object[,]
                {
                    { 1, 1, 2, "https://upload.wikimedia.org/wikipedia/tr/thumb/e/ea/Karayip_Korsanlar%C4%B1_Salazar%E2%80%99%C4%B1n_%C4%B0ntikam%C4%B1_T%C3%BCrk%C3%A7e_Afi%C5%9F.jpg/800px-Karayip_Korsanlar%C4%B1_Salazar%E2%80%99%C4%B1n_%C4%B0ntikam%C4%B1_T%C3%BCrk%C3%A7e_Afi%C5%9F.jpg", 1, 2.3999999999999999, 8.5999999999999996, "Karayip Korsanları 1", new DateTime(2022, 6, 11, 13, 52, 33, 747, DateTimeKind.Local).AddTicks(3801), "Valinin kızı Elizabeth Swann, bir korsan olan Kaptan Barbossa tarafından kaçırılır. Başka bir korsan Jack Sparrow, Elizabethin çocukluk arkadaşı Will Turner ile işbirliği yaparak, kızı kurtarmaya çalışır. Peşine düştükleri korsanların ise gücünü ayışığından alan bir lanetleri vardır. Yaşam ile ölüm arasındaki sınırı aşmak ve güçlerine kavuşmak için kaçırdıkları genç kadını kullanmak istemektedirler.", "https://i.pinimg.com/originals/87/a0/92/87a092260dd800b76f1ac6343f8d7fae.jpg", 0 },
                    { 2, 1, 2, "https://img.fullhdfilmizlesene.pw/poster/izle/one-shot-67638.jpg", 2, 2.0, 7.7999999999999998, "Tek Atış", new DateTime(2022, 6, 11, 13, 52, 33, 748, DateTimeKind.Local).AddTicks(8065), "The Wheel of Time dizisinde ve Hold the Dark filminde oynayan Emmanuel Imani, Norveç yapımı Exit dizisinde oynayan Dino Kelly, Limehouse'un Gizemli Cinayetleri filminde oynayan Jack Parr gibi isimleri izliyoruz.Filmin yönetmeni Yeşil Sokak Holiganları 3: Asla Pes Etme filminin yönetmeni olan James Nunn’dır.James Nunn aynı zamandaki One Shot filminin iki senaristinden de birisidir.Senaryodaki diğer isim ise kısa metrajlı Bricks filminin senaristi olan Jamie Russell’dir.Aksiyon ve gerilim türlerine giren film şu anda 5.5 gibi bir IMDB puanına sahiptir.Film 5 Kasım 2021 tarihinde vizyona girmiştir.", "https://metadata-static.plex.tv/5/gracenote/5ae29da9ddfaa3545a845cebd3658cb8.jpg", 0 },
                    { 3, 2, 3, "https://m.media-amazon.com/images/M/MV5BYjFhZGRiZWUtMmFlYi00MDkwLWFjYTMtYzVhZmQ3ZmUwN2I3XkEyXkFqcGdeQXVyMDA4NzMyOA@@._V1_.jpg", 3, 1.2, 6.7999999999999998, "Survive", new DateTime(2022, 6, 11, 13, 52, 33, 748, DateTimeKind.Local).AddTicks(8081), "Jane ve Paul henüz birbirlerini tanımasalar da yok yakın bir zamanda birlikte oldukça zorlu bir zaman geçirecek olan kişilerdir. Survive isimli 4k film formatlı film ise Jane ve Paul isimli bu iki yabancının birlikte atlatmaya çalıştıkları korkunç bir durumu anlatmaktadır. Jane kendini psikiyatri kliniğine bir hasta olarak bulduğu zaman kimseyle henüz konuşmaya başlamamıştır.Terapisti ise başından her ne geçtiyse anlatması ve bu hislerini hafifletmesi için sürekli olarak Jane’e cesaret vermektedir.Bir gün ise Jane artık dayanamaz ve neden bu klinikte olduğunu tüm terapi grubuna anlatmaya başlar.Jane kendi hayatına bakarken günlerden bir gün uçakla uzak bir bölgeye gitmesi gerektiğinde herkes gibi uçağa binmiş ve rahatlamıştır.Dolu olan yolcu uçağı bir süre sorunsuz uçtuktan sonra ani bir şekilde denesini kaybetmeye başlar ve hızlı bir şekilde de tam olarak neresi olduğu bilinmeyen bir bölgeye çakılır.İşin tuhaf tarafı ise uçak çakıldıktan sonra Jane dışında sadece Paul adındaki bir adam hayatta kalmıştır.Jane ve Paul başta olayın şoku yüzünden anlaşamasalar da sonrasında eğer bu korkunç bölgeden kurtulmak istiyorlarsa birlikte hareket etmeleri gerektiğini anlarlar.Çünkü bulundukları bölge korkunç bir şekilde soğuk olan ve dağların arasında kalmış kar ve tipinin bir an bile kesilmediği bir bölgedir.Türkçe dublajıyla da hazırlanan bu muhteşem macera filminde Mark Pellington yapımın yönetmen koltuğundaki isimdir.Gerilimi dram ile muhteşem bir şekilde sunan filmin senaryosu ise Alex Morel’in kitabından Richard Abate ile Jeremy Ungar tarafından hazırlanmıştır.Soluk soluğa izleyeceğiniz filmin başrol oyuncu kadrosunu ise Sophie Turner ile Corey Hawkins isimleri oluşturmaktadır.Acaba nedene tüm uçaktan Jane ve Paul hayatta kalan iki kişidir ? Jane ve Paul nerede olduklarını bile henüz bulamazken nasıl hayatta kalmayı başaracaklardır ? Jane eğer olay sonrası psikiyatri kliniğinde ise Paul nerededir ? Yoksa Paul bu korkunç olaydan sağ çıkamamış mıdır ? ", "https://flxt.tmsimg.com/assets/p18077051_b_h10_ad.jpg", 0 },
                    { 4, 2, 1, "https://img.yts.mx/assets/images/movies/the_adventures_of_maid_marian_2022/large-cover.jpg", 4, 1.8, 7.5, "The Adventures of Maid Marian", new DateTime(2022, 6, 11, 13, 52, 33, 748, DateTimeKind.Local).AddTicks(8084), "Sadece 4k film formatıyla değil aynı zamanda Türkçe dublajıyla da siz değerli takipçilerimiz için hazırladığımız The Adventures of Maid Marian isimi macera dolu filmin hem yönetmen hem de senarist koltuğundaki isim Bill Thomas’dır. Marian ismindeki zorlu bir kadının başından geçen tehlike dolu maceralara odaklanan filmde Sophie Craig ile Lainy Boyle ve de Jennifer Matter isimleri de yapımın başrol oyuncu kadrosundaki simalardır.Marian başını beladan kurtarmak ve dikkat çekmemek için her ne kadar tam üç yıl boyunca bir manastırda saklanmış olsa da Marian için tehlikelerle dolu zaman henüz gelmemiştir.Her şeyin durulduğunu zanneden Marian bir anda Aslan Yürekli Richard’ın öldüğünü öğrenir ve bu haber de Marian için sevgilisi olan Robin’in yakında döneceği anlamına gelmektedir.Bu haber üzerine Marian artık saklanmanın bir anlamı kalmadığını düşünür ve hemen üç yıllık manastırından ayrılır.Fakat Marian her şeyi yerli yerinde bulacağını düşünürken bir zamanlar toplumda bir saygınlığı olan ancak artık hiçbir değeri olmayan şerif William De Wendenal’ın da sürgünden döndüğünü anlar.William De Wendenal’ın aklında ise sadece intikam dolu yer almaktadır.Bunu az çok bilen Marian ise her şeye hazırlıklı olması gerektiğini anlar.Fakat Marian sonunda sevgilisi Robin ile buluşur ve birlikte kaçmaya başlarlar.Bu sırada pusuya düşen Marian ile sevgilisi Robin hayatları adına bir savaşa girişirler ancak bu savaşın sonunda yaralanan taraf Robin olur.Ancak Marian buna rağmen sevgilisini ölüme terk etmez ve onu da yanına alarak ormanın derin noktalarına doğru sevgilisi ile birlikte kaçmaya başlar.Ama Marian için bu hiç de kolay olmayacaktır.Çünkü yardım alacak hiçbir yer yokken ve peşlerinde de zalim paralı askerler onları takip ederken Marian bir yandan da ağır bir şekilde yaralanmış olan sevgilisi Robin’i hayatta tutmalıdır.Bakalım Marian bunca zorluğa rağmen sevgilisi ile mutlu bir hayata kavuşabilecek midir ? ", "https://i.ytimg.com/vi/cuET_yYoFk0/maxresdefault.jpg", 0 }
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName", "Age", "MovieId", "PhotoURL" },
                values: new object[,]
                {
                    { 1, "Johnny Depp", 45, 1, "https://tr.web.img4.acsta.net/pictures/22/04/18/16/11/4406324.jpg" },
                    { 2, "Geoffrey Rush", 70, 1, "https://tr.web.img3.acsta.net/c_310_420/pictures/15/11/18/10/19/300806.jpg" },
                    { 3, "Ashley Greene", 35, 2, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Ashley_Greene_2012.jpg/800px-Ashley_Greene_2012.jpg" },
                    { 4, "Emmanuel Imani", 30, 2, "https://www.themoviedb.org/t/p/w500/gTYTHVIfv1HMr6h1gtLoACH7l17.jpg" },
                    { 5, "Corey Hawkins", 32, 3, "https://images.mubicdn.net/images/cast_member/473019/cache-239998-1599533284/image-w856.jpg?size=800x" },
                    { 6, "Sophie Turner", 26, 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Sophie_Turner_%2840553145603%29_%28cropped%29.jpg/800px-Sophie_Turner_%2840553145603%29_%28cropped%29.jpg" },
                    { 7, "Dominic Andersen", 26, 4, "https://m.media-amazon.com/images/M/MV5BMDgyM2M4OTMtY2Y5Ni00NjZiLWJlNmQtNmJhNmJmZGNlNjRjXkEyXkFqcGdeQXVyNjYzNzE0Mzk@._V1_UY1200_CR585,0,630,1200_AL_.jpg" },
                    { 8, "Jennifer Matter", 42, 4, "https://www.themoviedb.org/t/p/original/e7LqKoP0B02v8VL0t7DBcrxn0Mm.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_MovieId",
                table: "Actor",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CategoryId",
                table: "Movie",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DirectorId",
                table: "Movie",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_MovieId",
                table: "Rating",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_UserId",
                table: "Rating",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Director");
        }
    }
}
