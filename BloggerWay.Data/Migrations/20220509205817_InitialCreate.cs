using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggerWay.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "1573209b-aa09-410d-83c9-f7ebfc9da84f", "Admin", "ADMIN" },
                    { 2, "d50b9161-aa46-46c6-9fbe-65d5a64bf75f", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "f0c94756-aa8f-48b3-85a7-bdf031875450", "adminuser@gmail.com", true, false, null, "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEKOsW5RnJ3kvsHRm5AT1N7f9++EkERWCqwBLolduz1rmSX4/K4YNp8vBKGaEq2aLig==", "+905555555555", true, "defaultUser.png", "7054c54d-fdb7-4aca-83b4-c2ccc04c7473", false, "adminuser" },
                    { 2, 0, "eb6287c3-52c6-49f2-9c7c-a3a5855742c0", "editoruser@gmail.com", true, false, null, "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAEAACcQAAAAEBLl653Ro6qrZZAq0tCAWKKyV3T+IVOk4GWh0+qawxoqPGeYxwkqtiJ4ayqqMEfFaA==", "+905555555555", true, "defaultUser.png", "9f904d2c-2cc9-4282-bcdd-14232d28114e", false, "editoruser" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 23, 58, 17, 353, DateTimeKind.Local).AddTicks(3450), new DateTime(2022, 5, 9, 23, 58, 17, 353, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 23, 58, 17, 353, DateTimeKind.Local).AddTicks(3471), new DateTime(2022, 5, 9, 23, 58, 17, 353, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 23, 58, 17, 353, DateTimeKind.Local).AddTicks(3476), new DateTime(2022, 5, 9, 23, 58, 17, 353, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, 1, " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 350, DateTimeKind.Local).AddTicks(8408), new DateTime(2022, 5, 9, 23, 58, 17, 350, DateTimeKind.Local).AddTicks(7518), true, false, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 350, DateTimeKind.Local).AddTicks(8977), "C# .Net5 özellikleri", "Ali Veli", "C#, C#9 ,.NET5 Yenilikleri", "C#, C#9 .NET5 , .NET Framework, .NET Core", "Default.jpg", "C# .Net5 özellikleri ", 1, 12 },
                    { 2, 2, 1, " Bir okuyucunun, sayfa düzenine bakarken sayfanın okunabilir içeriği tarafından dikkatinin dağılacağı uzun süredir bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, 'İçerik burada, içerik burada' kullanılmasının aksine, harflerin az çok normal dağılımına sahip olması ve okunabilir İngilizce gibi görünmesini sağlamasıdır. Birçok masaüstü yayıncılık paketi ve web sayfası düzenleyicisi artık varsayılan model metni olarak Lorem Ipsum'u kullanıyor ve 'lorem ipsum' araması, henüz emekleme aşamasında olan birçok web sitesini ortaya çıkaracaktır. Yıllar içinde, bazen tesadüfen, bazen de bilerek (enjekte edilmiş mizah ve benzeri) çeşitli versiyonlar gelişti.", "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 351, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 5, 9, 23, 58, 17, 351, DateTimeKind.Local).AddTicks(18), true, false, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 351, DateTimeKind.Local).AddTicks(20), "C++ 11 ve 19 özellikleri", "Ali Veli", "C++ 11 ve 19 özellikleri", "C++ 11 ve 19 özellikleri", "Default.jpg", "C++ 11 ve 19 özellikleri ", 1, 295 },
                    { 3, 3, 1, " Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham..", "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 351, DateTimeKind.Local).AddTicks(26), new DateTime(2022, 5, 9, 23, 58, 17, 351, DateTimeKind.Local).AddTicks(25), true, false, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 351, DateTimeKind.Local).AddTicks(27), "JavaScript ES2019 ES2020 özellikleri ", "Ali Veli", "JavaScript ES2019 ES2020 özellikleri ", "JavaScript ES2019 ES2020 özellikleri ", "Default.jpg", "JavaScript ES2019 ES2020 özellikleri ", 1, 100 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 355, DateTimeKind.Local).AddTicks(2421), true, false, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 355, DateTimeKind.Local).AddTicks(2430), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 355, DateTimeKind.Local).AddTicks(2443), true, false, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 355, DateTimeKind.Local).AddTicks(2444), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 355, DateTimeKind.Local).AddTicks(2448), true, false, "InitialCreate", new DateTime(2022, 5, 9, 23, 58, 17, 355, DateTimeKind.Local).AddTicks(2449), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 25, 56, 889, DateTimeKind.Local).AddTicks(748), new DateTime(2022, 4, 11, 21, 25, 56, 889, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 25, 56, 889, DateTimeKind.Local).AddTicks(1744), new DateTime(2022, 4, 11, 21, 25, 56, 889, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 25, 56, 889, DateTimeKind.Local).AddTicks(1748), new DateTime(2022, 4, 11, 21, 25, 56, 889, DateTimeKind.Local).AddTicks(1750) });
        }
    }
}
