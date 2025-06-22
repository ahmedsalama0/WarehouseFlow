# WarehouseFlow

## 📦 Warehouse Management System

A desktop application built with **Windows Forms (.NET 8)** and **Entity Framework Core 8** using the **Code First** approach. It manages inventory operations for warehouses, suppliers, clients, and item movements.

---

## 🧰 Technologies Used

- 💻 Windows Forms (.NET 8)
- 🛠️ Entity Framework Core 8 (Code First)
- 🗄️ SQL Server (via EF migrations)
- 🧮 LINQ for data querying
- 📦 Visual Studio 2022

---

## 📁 Features

- 🔧 **CRUD operations** for:
  - Warehouses
  - Items (+ multiple units per item)
  - Suppliers & Clients
  - Supply Permits & Disbursement Orders
- 🔁 **Item movement tracking**:
  - Supplied items (supplier → warehouse)
  - Disbursed items (warehouse → client)
  - Transferred items (warehouse → warehouse)
- 📊 **Live data display** using `DataGridView`

---
