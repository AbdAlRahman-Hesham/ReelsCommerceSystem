using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedBrandRegistrationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_RejectionReasons_RejectionReasonId",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "VerificationStatus",
                table: "Brands",
                newName: "Governorate");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfEmployees",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Fashion", "Egypt", 4, "Maadi", "Cairo", 50, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Tech", "Egypt", 4, "6th of October", "Giza", 30, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Beauty", "Egypt", 4, "Smouha", "Alexandria", 20, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Fashion", "Egypt", 4, "Nasr City", "Cairo", 40, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Lifestyle", "Egypt", 4, "Dokki", "Giza", 25, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Sports", "Egypt", 4, "Sidi Gaber", "Alexandria", 35, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Home", "Egypt", 4, "New Cairo", "Cairo", 60, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Tech", "Egypt", 4, "6th of October", "Giza", 45, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Beauty", "Egypt", 4, "Miami", "Alexandria", 20, "policy", 2 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Country", "CurrentStep", "District", "Governorate", "NumberOfEmployees", "ReturnPolicyAsHtml", "Status" },
                values: new object[] { "Fashion", "Egypt", 4, "Maadi", "Cairo", 70, "policy", 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_RejectionReasons_RejectionReasonId",
                table: "Brands",
                column: "RejectionReasonId",
                principalTable: "RejectionReasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Users_UserId",
                table: "Brands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_RejectionReasons_RejectionReasonId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Users_UserId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "NumberOfEmployees",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "Governorate",
                table: "Brands",
                newName: "VerificationStatus");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Verified" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Verified" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Pending" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Verified" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Verified" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Pending" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Verified" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Verified" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Pending" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentStep", "ReturnPolicyAsHtml", "Status", "VerificationStatus" },
                values: new object[] { 0, "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", 0, "Verified" });

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_RejectionReasons_RejectionReasonId",
                table: "Brands",
                column: "RejectionReasonId",
                principalTable: "RejectionReasons",
                principalColumn: "Id");
        }
    }
}
