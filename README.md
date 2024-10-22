# Bulky App 📚💼

This is a comprehensive **Book Management and Purchasing Application** built using **ASP.NET Core MVC**. The application supports multiple user roles—**Admin**, **Company**, **Customer**, and **Employee**—each with distinct access levels and functionalities. The app facilitates secure payments with the integration of the **Stripe** payment gateway, providing flexibility for both immediate and deferred transactions.

## Features ✨

- **User Roles**: Multiple user roles with role-specific access and functionalities.
    - **Admin**: Manage books, users, and overall system configuration.
    - **Company**: Purchase books on behalf of the company with deferred payment options.
    - **Customer**: Browse and purchase books, with secure online payments.
    - **Employee**: Assist in book management and transactions.
  
- **Stripe Payment Gateway**: Integration with **Stripe** to handle secure payments and refunds.
    - **Immediate Payments** for customer purchases.
    - **Deferred Payments** for company orders to provide financial flexibility.
  
- **Book Management**: Easy management of books, with features to add, update, and delete book records.
  
- **Responsive UI**: Built with **Bootstrap CSS**, the UI is mobile-friendly and visually appealing.

## Technologies Used 🛠️

- **Backend**: ASP.NET Core MVC, C#, Entity Framework
- **Database**: SQL Server
- **Frontend**: CSHTML, Bootstrap CSS
- **Payment Gateway**: Stripe

## Live Demo 🌐

Check out the live application here: [Bulky App Live](https://jatin-bulkyapp.runasp.net/)

## Installation & Setup 🚀

1. Clone the repository:

   `git clone https://github.com/your-repo/BulkyApp.git`

2. Navigate to the project directory and install the necessary dependencies.

3. Update the database connection string in the `appsettings.json` file.

4. Obtain a **Stripe API key** and replace `YOUR_STRIPE_API_KEY` in the configuration file with your actual API key.

5. Run the application:

   `dotnet run`

6. Open your browser and navigate to:

   `https://localhost:7254/`

## Usage 🛒

1. **Admin**: Log in with admin credentials to manage the entire system, including book records and users.
2. **Company/Customer**: Browse the available books and make purchases using **Stripe** for secure transactions.
3. **Employee**: Assist in managing book inventory and handle customer inquiries.

## Contributing 🤝

We welcome contributions! If you find any issues or have suggestions, please open an issue or submit a pull request.

## License 📄

This project is licensed under the [MIT License](LICENSE).
