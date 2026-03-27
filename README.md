# Event-Driven Programming Assignment (C# .NET WinForms)

## 📌 Overview
This project is developed as part of an assignment focusing on **Event-Driven Programming** using **C#**, **.NET Framework**, and **Windows Forms (WinForms)**.

The application demonstrates how user interactions (events) trigger specific responses in a graphical user interface (GUI).

---

## 🎯 Objectives
- Understand the concept of **event-driven programming**
- Build a functional desktop application using **WinForms**
- Implement event handling in **C#**
- Design a user-friendly graphical interface

---

## 🛠️ Technologies Used
- **C#**
- **.NET Framework**
- **Windows Forms (WinForms)**
- **Visual Studio**

---

## ⚙️ Features
- Interactive GUI with buttons, labels, and input fields
- Event handling (e.g., button clicks, text input, form load)
- Dynamic updates based on user actions
- Basic validation and user feedback

---

## 🧠 Concept: Event-Driven Programming
Event-driven programming is a paradigm where the flow of the program is determined by events such as:
- User actions (clicks, typing)
- System-generated events (load, resize)

In this project:
- Each UI component responds to specific events
- Event handlers are written in C# to define the behavior

Example:
```csharp
private void button1_Click(object sender, EventArgs e)
{
    label1.Text = "Button Clicked!";
}
