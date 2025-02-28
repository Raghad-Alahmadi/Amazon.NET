# Amazon.NET

## AmazonSa - E-Commerce Web App

### Overview
AmazonSa is a simple e-commerce web application built using **ASP.NET Core MVC**. It allows users to browse products, place orders, and view order history.

---

### Features
- **Product Listing**: Display available products with images, descriptions, and prices.
- **Order Placement**: Users can order products and update stock quantities.
- **Order History**: Users can view their past orders.
- **Error Handling**: Proper error messages and pop-ups for stock shortages and invalid inputs.
- **Real-Time Feedback**: Uses AJAX for better user experience with dynamic updates.

---

### Technologies Used
- **ASP.NET Core MVC** - Web framework
- **C#** - Backend programming
- **Razor Views** - Frontend templating
- **Bootstrap** - UI styling
- **Entity Framework Core (Optional)** - For database management
- **JavaScript & AJAX** - Enhancing real-time interactions

---

### Project Structure

AmazonSa/
│-- Controllers/
│   ├── HomeController.cs
│   ├── OrderController.cs
│   ├── ProductController.cs
│-- Models/
│   ├── Order.cs
│   ├── Product.cs
│-- Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   ├── Order/
│   │   ├── PlaceOrder.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│-- wwwroot/
│   ├── images/
│   ├── css/
│   ├── js/
│-- appsettings.json
│-- Program.cs
│-- Startup.cs
How to Run the Project
Clone the Repository
```bash

git clone https://github.com/Raghad-Alahmadi/AmazonSa.git
cd AmazonSa
Run the Application
Using Visual Studio:
Open the project in Visual Studio.

Press Ctrl + F5 to run.

Using .NET CLI:
```bash
dotnet run
Open in Browser
Navigate to:

http://localhost:5000/
Fixes and Enhancements
Fixed Product Fetching in Index.cshtml

Now, products are passed from HomeController instead of using @inject.

Uses Model in the Razor view.

Improved Error Handling in OrderController

Added proper validation for stock availability.

Returns meaningful error messages.

Implemented popup alerts for errors.

Uses AJAX-based form submission for a smoother experience.

Future Improvements
Implement authentication for users.

Integrate a database using Entity Framework Core.

Add an admin panel for managing products and orders.

Improve UI with better styling and animations.

Add real-time notifications for stock updates.

Contributing
Fork the repository.

Create a new branch (feature-new).

Commit your changes:

```bash
git commit -m 'Add new feature'
Push to the branch:

```bash
git push origin feature-new
Open a Pull Request.
