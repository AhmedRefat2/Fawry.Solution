# Fawry.Solution

# 🛒 E-Commerce Checkout System — Fawry Internship Challenge

A console-based e-commerce system implemented in C# that simulates product management, cart operations, shipping logic, and secure checkout. Built to fulfill the requirements of the Fawry Internship technical challenge.

---

## 🚀 Features

✅ Add products to cart with specific quantity  
✅ Handle both shippable and non-shippable items  
✅ Support for expirable and non-expirable products  
✅ Automatic shipping fee calculation based on weight  
✅ Validations for:
- Empty cart
- Insufficient balance
- Expired or out-of-stock products

✅ Console receipt with detailed order summary  
✅ Shipment notice for shippable items

---

## 📦 Product Types

| Product Type         | Expirable | Shippable | Requires Weight |
|----------------------|-----------|-----------|------------------|
| Cheese               | ✅        | ✅        | ✅               |
| Biscuits             | ✅        | ✅        | ✅               |
| TV                   | ❌        | ✅        | ✅               |
| Mobile Scratch Card  | ❌        | ❌        | ❌               |

---

## 🧩 Code Architecture

📁 EcommerceSystem

ProductModule
- Product.cs (abstract)
- ShippableProduct.cs
- ShippableAndExpirableProduct.cs
- ExpirableProduct.cs
- NonExpirableNonShippableProduct  
- Interfaces : IShippable
  
ShippingModule
- ShippingService.cs
- CheckoutService.cs

CartModule
- Cart.cs
- CartItem.cs

CustomerModule
- Customer.cs

Test
- HappyTest()
- BadTest1()
- BadTest2()
  
Program.cs

---

## 📤 Sample Output
** Shipment notice **

2x Cheese 400g

1x Biscuits 700g

Total package weight 1.1kg

** Checkout receipt **

2x Cheese 200

1x Biscuits 150

Subtotal 350

Shipping 30

Amount 380

✅ Thank you for shopping with us!

Remaining balance: 120 EGP

---

## 🛠️ How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/ecommerce-checkout-system.git

Open the solution in Visual Studio or any C# IDE.

Run the Program.cs file.

📌 Technologies Used
  
  - C# (.NET Core)
  
  - Console Application
  
  - OOP (Inheritance, Interfaces)
  
  - LINQ for grouping and filtering
  
  - Exception handling

📈 Possible Extensions

  - GUI or Web API version
  
  - Discount and coupon system
  
  - Unit tests (xUnit or NUnit)
  
  - Product inventory persistence (e.g., database or JSON file)
  
  - Multi-language support


