using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductSizeMappingSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductSizeMapping",
                columns: new[] { "Id", "ProductColorMappingId", "ProductSizeId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 3 },
                    { 2, 1, 2, 4 },
                    { 3, 2, 1, 4 },
                    { 4, 2, 2, 5 },
                    { 5, 2, 3, 6 },
                    { 6, 3, 1, 5 },
                    { 7, 3, 2, 6 },
                    { 8, 3, 3, 7 },
                    { 9, 3, 4, 8 },
                    { 10, 4, 1, 6 },
                    { 11, 4, 2, 7 },
                    { 12, 4, 3, 8 },
                    { 13, 4, 4, 9 },
                    { 14, 4, 5, 10 },
                    { 15, 5, 1, 7 },
                    { 16, 5, 2, 8 },
                    { 17, 5, 3, 9 },
                    { 18, 5, 4, 10 },
                    { 19, 5, 5, 11 },
                    { 20, 5, 6, 12 },
                    { 21, 6, 1, 8 },
                    { 22, 7, 1, 9 },
                    { 23, 7, 2, 10 },
                    { 24, 8, 1, 10 },
                    { 25, 8, 2, 11 },
                    { 26, 8, 3, 12 },
                    { 27, 9, 1, 11 },
                    { 28, 9, 2, 12 },
                    { 29, 9, 3, 13 },
                    { 30, 9, 4, 14 },
                    { 31, 10, 1, 12 },
                    { 32, 10, 2, 13 },
                    { 33, 10, 3, 14 },
                    { 34, 10, 4, 15 },
                    { 35, 10, 5, 16 },
                    { 36, 11, 1, 13 },
                    { 37, 11, 2, 14 },
                    { 38, 11, 3, 15 },
                    { 39, 11, 4, 16 },
                    { 40, 11, 5, 17 },
                    { 41, 11, 6, 18 },
                    { 42, 12, 1, 14 },
                    { 43, 13, 1, 15 },
                    { 44, 13, 2, 16 },
                    { 45, 14, 1, 16 },
                    { 46, 14, 2, 17 },
                    { 47, 14, 3, 18 },
                    { 48, 15, 1, 17 },
                    { 49, 15, 2, 18 },
                    { 50, 15, 3, 19 },
                    { 51, 15, 4, 20 },
                    { 52, 16, 1, 18 },
                    { 53, 16, 2, 19 },
                    { 54, 16, 3, 20 },
                    { 55, 16, 4, 21 },
                    { 56, 16, 5, 22 },
                    { 57, 17, 1, 19 },
                    { 58, 17, 2, 20 },
                    { 59, 17, 3, 21 },
                    { 60, 17, 4, 22 },
                    { 61, 17, 5, 23 },
                    { 62, 17, 6, 24 },
                    { 63, 18, 1, 20 },
                    { 64, 19, 1, 21 },
                    { 65, 19, 2, 22 },
                    { 66, 20, 1, 22 },
                    { 67, 20, 2, 23 },
                    { 68, 20, 3, 24 },
                    { 69, 21, 1, 23 },
                    { 70, 21, 2, 24 },
                    { 71, 21, 3, 25 },
                    { 72, 21, 4, 26 },
                    { 73, 22, 1, 24 },
                    { 74, 22, 2, 25 },
                    { 75, 22, 3, 26 },
                    { 76, 22, 4, 27 },
                    { 77, 22, 5, 28 },
                    { 78, 23, 1, 25 },
                    { 79, 23, 2, 26 },
                    { 80, 23, 3, 27 },
                    { 81, 23, 4, 28 },
                    { 82, 23, 5, 29 },
                    { 83, 23, 6, 30 },
                    { 84, 24, 1, 26 },
                    { 85, 25, 1, 27 },
                    { 86, 25, 2, 28 },
                    { 87, 26, 1, 28 },
                    { 88, 26, 2, 29 },
                    { 89, 26, 3, 30 },
                    { 90, 27, 1, 29 },
                    { 91, 27, 2, 30 },
                    { 92, 27, 3, 31 },
                    { 93, 27, 4, 32 },
                    { 94, 28, 1, 30 },
                    { 95, 28, 2, 31 },
                    { 96, 28, 3, 32 },
                    { 97, 28, 4, 33 },
                    { 98, 28, 5, 34 },
                    { 99, 29, 1, 31 },
                    { 100, 29, 2, 32 },
                    { 101, 29, 3, 33 },
                    { 102, 29, 4, 34 },
                    { 103, 29, 5, 35 },
                    { 104, 29, 6, 36 },
                    { 105, 30, 1, 32 },
                    { 106, 31, 1, 33 },
                    { 107, 31, 2, 34 },
                    { 108, 32, 1, 34 },
                    { 109, 32, 2, 35 },
                    { 110, 32, 3, 36 },
                    { 111, 33, 1, 35 },
                    { 112, 33, 2, 36 },
                    { 113, 33, 3, 37 },
                    { 114, 33, 4, 38 },
                    { 115, 34, 1, 36 },
                    { 116, 34, 2, 37 },
                    { 117, 34, 3, 38 },
                    { 118, 34, 4, 39 },
                    { 119, 34, 5, 40 },
                    { 120, 35, 1, 37 },
                    { 121, 35, 2, 38 },
                    { 122, 35, 3, 39 },
                    { 123, 35, 4, 40 },
                    { 124, 35, 5, 41 },
                    { 125, 35, 6, 42 },
                    { 126, 36, 1, 38 },
                    { 127, 37, 1, 39 },
                    { 128, 37, 2, 40 },
                    { 129, 38, 1, 40 },
                    { 130, 38, 2, 41 },
                    { 131, 38, 3, 42 },
                    { 132, 39, 1, 41 },
                    { 133, 39, 2, 42 },
                    { 134, 39, 3, 43 },
                    { 135, 39, 4, 44 },
                    { 136, 40, 1, 42 },
                    { 137, 40, 2, 43 },
                    { 138, 40, 3, 44 },
                    { 139, 40, 4, 45 },
                    { 140, 40, 5, 46 },
                    { 141, 41, 1, 43 },
                    { 142, 41, 2, 44 },
                    { 143, 41, 3, 45 },
                    { 144, 41, 4, 46 },
                    { 145, 41, 5, 47 },
                    { 146, 41, 6, 48 },
                    { 147, 42, 1, 44 },
                    { 148, 43, 1, 45 },
                    { 149, 43, 2, 46 },
                    { 150, 44, 1, 46 },
                    { 151, 44, 2, 47 },
                    { 152, 44, 3, 48 },
                    { 153, 45, 1, 47 },
                    { 154, 45, 2, 48 },
                    { 155, 45, 3, 49 },
                    { 156, 45, 4, 50 },
                    { 157, 46, 1, 48 },
                    { 158, 46, 2, 49 },
                    { 159, 46, 3, 50 },
                    { 160, 46, 4, 1 },
                    { 161, 46, 5, 2 },
                    { 162, 47, 1, 49 },
                    { 163, 47, 2, 50 },
                    { 164, 47, 3, 1 },
                    { 165, 47, 4, 2 },
                    { 166, 47, 5, 3 },
                    { 167, 47, 6, 4 },
                    { 168, 48, 1, 50 },
                    { 169, 49, 1, 1 },
                    { 170, 49, 2, 2 },
                    { 171, 50, 1, 2 },
                    { 172, 50, 2, 3 },
                    { 173, 50, 3, 4 },
                    { 174, 51, 1, 3 },
                    { 175, 51, 2, 4 },
                    { 176, 51, 3, 5 },
                    { 177, 51, 4, 6 },
                    { 178, 52, 1, 4 },
                    { 179, 52, 2, 5 },
                    { 180, 52, 3, 6 },
                    { 181, 52, 4, 7 },
                    { 182, 52, 5, 8 },
                    { 183, 53, 1, 5 },
                    { 184, 53, 2, 6 },
                    { 185, 53, 3, 7 },
                    { 186, 53, 4, 8 },
                    { 187, 53, 5, 9 },
                    { 188, 53, 6, 10 },
                    { 189, 54, 1, 6 },
                    { 190, 55, 1, 7 },
                    { 191, 55, 2, 8 },
                    { 192, 56, 1, 8 },
                    { 193, 56, 2, 9 },
                    { 194, 56, 3, 10 },
                    { 195, 57, 1, 9 },
                    { 196, 57, 2, 10 },
                    { 197, 57, 3, 11 },
                    { 198, 57, 4, 12 },
                    { 199, 58, 1, 10 },
                    { 200, 58, 2, 11 },
                    { 201, 58, 3, 12 },
                    { 202, 58, 4, 13 },
                    { 203, 58, 5, 14 },
                    { 204, 59, 1, 11 },
                    { 205, 59, 2, 12 },
                    { 206, 59, 3, 13 },
                    { 207, 59, 4, 14 },
                    { 208, 59, 5, 15 },
                    { 209, 59, 6, 16 },
                    { 210, 60, 1, 12 },
                    { 211, 61, 1, 13 },
                    { 212, 61, 2, 14 },
                    { 213, 62, 1, 14 },
                    { 214, 62, 2, 15 },
                    { 215, 62, 3, 16 },
                    { 216, 63, 1, 15 },
                    { 217, 63, 2, 16 },
                    { 218, 63, 3, 17 },
                    { 219, 63, 4, 18 },
                    { 220, 64, 1, 16 },
                    { 221, 64, 2, 17 },
                    { 222, 64, 3, 18 },
                    { 223, 64, 4, 19 },
                    { 224, 64, 5, 20 },
                    { 225, 65, 1, 17 },
                    { 226, 65, 2, 18 },
                    { 227, 65, 3, 19 },
                    { 228, 65, 4, 20 },
                    { 229, 65, 5, 21 },
                    { 230, 65, 6, 22 },
                    { 231, 66, 1, 18 },
                    { 232, 67, 1, 19 },
                    { 233, 67, 2, 20 },
                    { 234, 68, 1, 20 },
                    { 235, 68, 2, 21 },
                    { 236, 68, 3, 22 },
                    { 237, 69, 1, 21 },
                    { 238, 69, 2, 22 },
                    { 239, 69, 3, 23 },
                    { 240, 69, 4, 24 },
                    { 241, 70, 1, 22 },
                    { 242, 70, 2, 23 },
                    { 243, 70, 3, 24 },
                    { 244, 70, 4, 25 },
                    { 245, 70, 5, 26 },
                    { 246, 71, 1, 23 },
                    { 247, 71, 2, 24 },
                    { 248, 71, 3, 25 },
                    { 249, 71, 4, 26 },
                    { 250, 71, 5, 27 },
                    { 251, 71, 6, 28 },
                    { 252, 72, 1, 24 },
                    { 253, 73, 1, 25 },
                    { 254, 73, 2, 26 },
                    { 255, 74, 1, 26 },
                    { 256, 74, 2, 27 },
                    { 257, 74, 3, 28 },
                    { 258, 75, 1, 27 },
                    { 259, 75, 2, 28 },
                    { 260, 75, 3, 29 },
                    { 261, 75, 4, 30 },
                    { 262, 76, 1, 28 },
                    { 263, 76, 2, 29 },
                    { 264, 76, 3, 30 },
                    { 265, 76, 4, 31 },
                    { 266, 76, 5, 32 },
                    { 267, 77, 1, 29 },
                    { 268, 77, 2, 30 },
                    { 269, 77, 3, 31 },
                    { 270, 77, 4, 32 },
                    { 271, 77, 5, 33 },
                    { 272, 77, 6, 34 },
                    { 273, 78, 1, 30 },
                    { 274, 79, 1, 31 },
                    { 275, 79, 2, 32 },
                    { 276, 80, 1, 32 },
                    { 277, 80, 2, 33 },
                    { 278, 80, 3, 34 },
                    { 279, 81, 1, 33 },
                    { 280, 81, 2, 34 },
                    { 281, 81, 3, 35 },
                    { 282, 81, 4, 36 },
                    { 283, 82, 1, 34 },
                    { 284, 82, 2, 35 },
                    { 285, 82, 3, 36 },
                    { 286, 82, 4, 37 },
                    { 287, 82, 5, 38 },
                    { 288, 83, 1, 35 },
                    { 289, 83, 2, 36 },
                    { 290, 83, 3, 37 },
                    { 291, 83, 4, 38 },
                    { 292, 83, 5, 39 },
                    { 293, 83, 6, 40 },
                    { 294, 84, 1, 36 },
                    { 295, 85, 1, 37 },
                    { 296, 85, 2, 38 },
                    { 297, 86, 1, 38 },
                    { 298, 86, 2, 39 },
                    { 299, 86, 3, 40 },
                    { 300, 87, 1, 39 },
                    { 301, 87, 2, 40 },
                    { 302, 87, 3, 41 },
                    { 303, 87, 4, 42 },
                    { 304, 88, 1, 40 },
                    { 305, 88, 2, 41 },
                    { 306, 88, 3, 42 },
                    { 307, 88, 4, 43 },
                    { 308, 88, 5, 44 },
                    { 309, 89, 1, 41 },
                    { 310, 89, 2, 42 },
                    { 311, 89, 3, 43 },
                    { 312, 89, 4, 44 },
                    { 313, 89, 5, 45 },
                    { 314, 89, 6, 46 },
                    { 315, 90, 1, 42 },
                    { 316, 91, 1, 43 },
                    { 317, 91, 2, 44 },
                    { 318, 92, 1, 44 },
                    { 319, 92, 2, 45 },
                    { 320, 92, 3, 46 },
                    { 321, 93, 1, 45 },
                    { 322, 93, 2, 46 },
                    { 323, 93, 3, 47 },
                    { 324, 93, 4, 48 },
                    { 325, 94, 1, 46 },
                    { 326, 94, 2, 47 },
                    { 327, 94, 3, 48 },
                    { 328, 94, 4, 49 },
                    { 329, 94, 5, 50 },
                    { 330, 95, 1, 47 },
                    { 331, 95, 2, 48 },
                    { 332, 95, 3, 49 },
                    { 333, 95, 4, 50 },
                    { 334, 95, 5, 1 },
                    { 335, 95, 6, 2 },
                    { 336, 96, 1, 48 },
                    { 337, 97, 1, 49 },
                    { 338, 97, 2, 50 },
                    { 339, 98, 1, 50 },
                    { 340, 98, 2, 1 },
                    { 341, 98, 3, 2 },
                    { 342, 99, 1, 1 },
                    { 343, 99, 2, 2 },
                    { 344, 99, 3, 3 },
                    { 345, 99, 4, 4 },
                    { 346, 100, 1, 2 },
                    { 347, 100, 2, 3 },
                    { 348, 100, 3, 4 },
                    { 349, 100, 4, 5 },
                    { 350, 100, 5, 6 },
                    { 351, 101, 1, 3 },
                    { 352, 101, 2, 4 },
                    { 353, 101, 3, 5 },
                    { 354, 101, 4, 6 },
                    { 355, 101, 5, 7 },
                    { 356, 101, 6, 8 },
                    { 357, 102, 1, 4 },
                    { 358, 103, 1, 5 },
                    { 359, 103, 2, 6 },
                    { 360, 104, 1, 6 },
                    { 361, 104, 2, 7 },
                    { 362, 104, 3, 8 },
                    { 363, 105, 1, 7 },
                    { 364, 105, 2, 8 },
                    { 365, 105, 3, 9 },
                    { 366, 105, 4, 10 },
                    { 367, 106, 1, 8 },
                    { 368, 106, 2, 9 },
                    { 369, 106, 3, 10 },
                    { 370, 106, 4, 11 },
                    { 371, 106, 5, 12 },
                    { 372, 107, 1, 9 },
                    { 373, 107, 2, 10 },
                    { 374, 107, 3, 11 },
                    { 375, 107, 4, 12 },
                    { 376, 107, 5, 13 },
                    { 377, 107, 6, 14 },
                    { 378, 108, 1, 10 },
                    { 379, 109, 1, 11 },
                    { 380, 109, 2, 12 },
                    { 381, 110, 1, 12 },
                    { 382, 110, 2, 13 },
                    { 383, 110, 3, 14 },
                    { 384, 111, 1, 13 },
                    { 385, 111, 2, 14 },
                    { 386, 111, 3, 15 },
                    { 387, 111, 4, 16 },
                    { 388, 112, 1, 14 },
                    { 389, 112, 2, 15 },
                    { 390, 112, 3, 16 },
                    { 391, 112, 4, 17 },
                    { 392, 112, 5, 18 },
                    { 393, 113, 1, 15 },
                    { 394, 113, 2, 16 },
                    { 395, 113, 3, 17 },
                    { 396, 113, 4, 18 },
                    { 397, 113, 5, 19 },
                    { 398, 113, 6, 20 },
                    { 399, 114, 1, 16 },
                    { 400, 115, 1, 17 },
                    { 401, 115, 2, 18 },
                    { 402, 116, 1, 18 },
                    { 403, 116, 2, 19 },
                    { 404, 116, 3, 20 },
                    { 405, 117, 1, 19 },
                    { 406, 117, 2, 20 },
                    { 407, 117, 3, 21 },
                    { 408, 117, 4, 22 },
                    { 409, 118, 1, 20 },
                    { 410, 118, 2, 21 },
                    { 411, 118, 3, 22 },
                    { 412, 118, 4, 23 },
                    { 413, 118, 5, 24 },
                    { 414, 119, 1, 21 },
                    { 415, 119, 2, 22 },
                    { 416, 119, 3, 23 },
                    { 417, 119, 4, 24 },
                    { 418, 119, 5, 25 },
                    { 419, 119, 6, 26 },
                    { 420, 120, 1, 22 },
                    { 421, 121, 1, 23 },
                    { 422, 121, 2, 24 },
                    { 423, 122, 1, 24 },
                    { 424, 122, 2, 25 },
                    { 425, 122, 3, 26 },
                    { 426, 123, 1, 25 },
                    { 427, 123, 2, 26 },
                    { 428, 123, 3, 27 },
                    { 429, 123, 4, 28 },
                    { 430, 124, 1, 26 },
                    { 431, 124, 2, 27 },
                    { 432, 124, 3, 28 },
                    { 433, 124, 4, 29 },
                    { 434, 124, 5, 30 },
                    { 435, 125, 1, 27 },
                    { 436, 125, 2, 28 },
                    { 437, 125, 3, 29 },
                    { 438, 125, 4, 30 },
                    { 439, 125, 5, 31 },
                    { 440, 125, 6, 32 },
                    { 441, 126, 1, 28 },
                    { 442, 127, 1, 29 },
                    { 443, 127, 2, 30 },
                    { 444, 128, 1, 30 },
                    { 445, 128, 2, 31 },
                    { 446, 128, 3, 32 },
                    { 447, 129, 1, 31 },
                    { 448, 129, 2, 32 },
                    { 449, 129, 3, 33 },
                    { 450, 129, 4, 34 },
                    { 451, 130, 1, 32 },
                    { 452, 130, 2, 33 },
                    { 453, 130, 3, 34 },
                    { 454, 130, 4, 35 },
                    { 455, 130, 5, 36 },
                    { 456, 131, 1, 33 },
                    { 457, 131, 2, 34 },
                    { 458, 131, 3, 35 },
                    { 459, 131, 4, 36 },
                    { 460, 131, 5, 37 },
                    { 461, 131, 6, 38 },
                    { 462, 132, 1, 34 },
                    { 463, 133, 1, 35 },
                    { 464, 133, 2, 36 },
                    { 465, 134, 1, 36 },
                    { 466, 134, 2, 37 },
                    { 467, 134, 3, 38 },
                    { 468, 135, 1, 37 },
                    { 469, 135, 2, 38 },
                    { 470, 135, 3, 39 },
                    { 471, 135, 4, 40 },
                    { 472, 136, 1, 38 },
                    { 473, 136, 2, 39 },
                    { 474, 136, 3, 40 },
                    { 475, 136, 4, 41 },
                    { 476, 136, 5, 42 },
                    { 477, 137, 1, 39 },
                    { 478, 137, 2, 40 },
                    { 479, 137, 3, 41 },
                    { 480, 137, 4, 42 },
                    { 481, 137, 5, 43 },
                    { 482, 137, 6, 44 },
                    { 483, 138, 1, 40 },
                    { 484, 139, 1, 41 },
                    { 485, 139, 2, 42 },
                    { 486, 140, 1, 42 },
                    { 487, 140, 2, 43 },
                    { 488, 140, 3, 44 },
                    { 489, 141, 1, 43 },
                    { 490, 141, 2, 44 },
                    { 491, 141, 3, 45 },
                    { 492, 141, 4, 46 },
                    { 493, 142, 1, 44 },
                    { 494, 142, 2, 45 },
                    { 495, 142, 3, 46 },
                    { 496, 142, 4, 47 },
                    { 497, 142, 5, 48 },
                    { 498, 143, 1, 45 },
                    { 499, 143, 2, 46 },
                    { 500, 143, 3, 47 },
                    { 501, 143, 4, 48 },
                    { 502, 143, 5, 49 },
                    { 503, 143, 6, 50 },
                    { 504, 144, 1, 46 },
                    { 505, 145, 1, 47 },
                    { 506, 145, 2, 48 },
                    { 507, 146, 1, 48 },
                    { 508, 146, 2, 49 },
                    { 509, 146, 3, 50 },
                    { 510, 147, 1, 49 },
                    { 511, 147, 2, 50 },
                    { 512, 147, 3, 1 },
                    { 513, 147, 4, 2 },
                    { 514, 148, 1, 50 },
                    { 515, 148, 2, 1 },
                    { 516, 148, 3, 2 },
                    { 517, 148, 4, 3 },
                    { 518, 148, 5, 4 },
                    { 519, 149, 1, 1 },
                    { 520, 149, 2, 2 },
                    { 521, 149, 3, 3 },
                    { 522, 149, 4, 4 },
                    { 523, 149, 5, 5 },
                    { 524, 149, 6, 6 },
                    { 525, 150, 1, 2 },
                    { 526, 151, 1, 3 },
                    { 527, 151, 2, 4 },
                    { 528, 152, 1, 4 },
                    { 529, 152, 2, 5 },
                    { 530, 152, 3, 6 },
                    { 531, 153, 1, 5 },
                    { 532, 153, 2, 6 },
                    { 533, 153, 3, 7 },
                    { 534, 153, 4, 8 },
                    { 535, 154, 1, 6 },
                    { 536, 154, 2, 7 },
                    { 537, 154, 3, 8 },
                    { 538, 154, 4, 9 },
                    { 539, 154, 5, 10 },
                    { 540, 155, 1, 7 },
                    { 541, 155, 2, 8 },
                    { 542, 155, 3, 9 },
                    { 543, 155, 4, 10 },
                    { 544, 155, 5, 11 },
                    { 545, 155, 6, 12 },
                    { 546, 156, 1, 8 },
                    { 547, 157, 1, 9 },
                    { 548, 157, 2, 10 },
                    { 549, 158, 1, 10 },
                    { 550, 158, 2, 11 },
                    { 551, 158, 3, 12 },
                    { 552, 159, 1, 11 },
                    { 553, 159, 2, 12 },
                    { 554, 159, 3, 13 },
                    { 555, 159, 4, 14 },
                    { 556, 160, 1, 12 },
                    { 557, 160, 2, 13 },
                    { 558, 160, 3, 14 },
                    { 559, 160, 4, 15 },
                    { 560, 160, 5, 16 },
                    { 561, 161, 1, 13 },
                    { 562, 161, 2, 14 },
                    { 563, 161, 3, 15 },
                    { 564, 161, 4, 16 },
                    { 565, 161, 5, 17 },
                    { 566, 161, 6, 18 },
                    { 567, 162, 1, 14 },
                    { 568, 163, 1, 15 },
                    { 569, 163, 2, 16 },
                    { 570, 164, 1, 16 },
                    { 571, 164, 2, 17 },
                    { 572, 164, 3, 18 },
                    { 573, 165, 1, 17 },
                    { 574, 165, 2, 18 },
                    { 575, 165, 3, 19 },
                    { 576, 165, 4, 20 },
                    { 577, 166, 1, 18 },
                    { 578, 166, 2, 19 },
                    { 579, 166, 3, 20 },
                    { 580, 166, 4, 21 },
                    { 581, 166, 5, 22 },
                    { 582, 167, 1, 19 },
                    { 583, 167, 2, 20 },
                    { 584, 167, 3, 21 },
                    { 585, 167, 4, 22 },
                    { 586, 167, 5, 23 },
                    { 587, 167, 6, 24 },
                    { 588, 168, 1, 20 },
                    { 589, 169, 1, 21 },
                    { 590, 169, 2, 22 },
                    { 591, 170, 1, 22 },
                    { 592, 170, 2, 23 },
                    { 593, 170, 3, 24 },
                    { 594, 171, 1, 23 },
                    { 595, 171, 2, 24 },
                    { 596, 171, 3, 25 },
                    { 597, 171, 4, 26 },
                    { 598, 172, 1, 24 },
                    { 599, 172, 2, 25 },
                    { 600, 172, 3, 26 },
                    { 601, 172, 4, 27 },
                    { 602, 172, 5, 28 },
                    { 603, 173, 1, 25 },
                    { 604, 173, 2, 26 },
                    { 605, 173, 3, 27 },
                    { 606, 173, 4, 28 },
                    { 607, 173, 5, 29 },
                    { 608, 173, 6, 30 },
                    { 609, 174, 1, 26 },
                    { 610, 175, 1, 27 },
                    { 611, 175, 2, 28 },
                    { 612, 176, 1, 28 },
                    { 613, 176, 2, 29 },
                    { 614, 176, 3, 30 },
                    { 615, 177, 1, 29 },
                    { 616, 177, 2, 30 },
                    { 617, 177, 3, 31 },
                    { 618, 177, 4, 32 },
                    { 619, 178, 1, 30 },
                    { 620, 178, 2, 31 },
                    { 621, 178, 3, 32 },
                    { 622, 178, 4, 33 },
                    { 623, 178, 5, 34 },
                    { 624, 179, 1, 31 },
                    { 625, 179, 2, 32 },
                    { 626, 179, 3, 33 },
                    { 627, 179, 4, 34 },
                    { 628, 179, 5, 35 },
                    { 629, 179, 6, 36 },
                    { 630, 180, 1, 32 },
                    { 631, 181, 1, 33 },
                    { 632, 181, 2, 34 },
                    { 633, 182, 1, 34 },
                    { 634, 182, 2, 35 },
                    { 635, 182, 3, 36 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 635);
        }
    }
}
