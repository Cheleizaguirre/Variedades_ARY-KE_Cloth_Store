# Variedades Ary-Ke Cloth Store

An online clothing store application built with .NET (Framework 4.7.2).
The system allows users to browse products, manage inventory, and generate reports. It leverages multiple NuGet packages for UI components, database access, PDF generation, compression, and image processing.

---

## 🎯 Purpose

1. **Build** a functional desktop application for managing an online clothing store.
2. **Practice** full-stack development with .NET technologies and package integration.
3. **Enable** inventory management, product listing, and report generation in PDF/Excel.
4. **Provide** a modern, responsive, and user-friendly interface using MetroFramework and MetroModernUI.

---

## ✨ Key Features

- Product Management: Add, edit, and delete clothing items with images.
- Inventory Control: Track stock levels and product categories.
- PDF/Report Generation: Export invoices, stock reports, or summaries using PDFsharp and EPPlus.
- Database Integration: MySQL database access via MySql.Data and express-myconnection equivalents.
- Modern UI: Metro-style interface with MetroFramework and MetroModernUI.
- Data Compression & Performance: LZ4 compression and recyclable memory streams for efficient memory handling.
- Utility Packages: Includes Google.Protobuf, System.Buffers, System.IO.Pipelines, and other supporting libraries for advanced processing.

---

## 🛠️ Stack

| Layer                      |	Technology / Package                                                      |
|----------------------------|----------------------------------------------------------------------------|
| Framework                  |	.NET Framework 4.7.2                                                      |
| UI                         |	MetroFramework, MetroModernUI                                             |
| Database                   |	MySQL via MySql.Data                                                      |
| PDF/Excel                  |	PDFsharp, EPPlus                                                          |
| Compression                |	K4os.Compression.LZ4, ZstdSharp.Port                                      |
| Logging & Utils            |	Microsoft.Extensions.Logging, Microsoft.IO.RecyclableMemoryStream         |
| Image Processing           |	EPPlus.System.Drawing, System.Numerics.Vectors                            |
| Networking / Serialization |	Google.Protobuf                                                           |
| Async & Performance        |	System.Threading.Tasks.Extensions, System.Runtime.CompilerServices.Unsafe |

---

## ⚙️ Local Installation (Developers)

1. Clone repository

```bash
git clone https://github.com/Cheleizaguirre/Variedades_ARY-KE_Cloth_Store.git
```

2. Open solution in Visual Studio (version supporting .NET Framework 4.7.2).
3.Restore NuGet packages via Visual Studio or CLI:

```bash
nuget restore Variedades_ARY-KE_Cloth_Store.sln
```

4. Configure database connection in the app config to your local MySQL server.
5. Build and run the application in Visual Studio.

---

## 🧠 How It Works

1. The app connects to a MySQL database to fetch and update product information.
2. Users can interact with a modern Metro-style UI to manage clothing inventory.
3. Reports can be generated in PDF or Excel for sales, stock levels, or summaries.
4. Compression and optimized memory streams are used to enhance performance.
5. Additional libraries like Google.Protobuf and System.Buffers ensure smooth serialization and processing.

---

## 🚀 Future Improvements

- Add authentication and role-based access for admins and staff.
- Include online synchronization for e-commerce integration.
- Implement product filtering, search, and dynamic sorting.
- Improve reporting dashboards with charts and analytics.
- Upgrade to .NET 6/7 for modern features and better performance.

---

## 🤝 Contributing

1. Fork the repository and create a new branch (git checkout -b feature/YourFeature).
2. Make clear commits describing your changes.
3. Open a Pull Request detailing the improvements or fixes.

---
