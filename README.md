# Simple Text Encryptor/Decryptor - WinForms C#

This is a beginner-friendly Windows Forms application written in C#.  
It allows users to **encrypt** and **decrypt** text using a basic Caesar cipher technique (character shifting based on a numeric key).

> ⚠️ **Note:** This project is intended for learning purposes only.  
> The encryption method used is *not secure* and should **not** be used to protect real data.

---

## ✨ Features

- Encrypt plain text using a numeric key
- Decrypt the encrypted text back to the original
- Input validation with `ErrorProvider`
- simple WinForms UI
- Good use of basic controls: `TextBox`, `NumericUpDown`, `Button`, etc.

---

## 📷 Screenshot

> ![image](https://github.com/user-attachments/assets/8bc027be-9692-492a-a4d6-8a575b5ff9c7)


---

## 🧠 What I Practiced

- Event handling (`Click`, `Validating`)
- Input validation
- Working with `char[]` and simple logic
- Structuring a small WinForms app
- Git and GitHub basics

---

## 🚀 How to Run

1. Clone the repository:

2. Open the solution (`.sln`) file in Visual Studio.

3. Run the project.

4. Type your text, enter a positive key, and click **Encrypt** or **Decrypt**.

---

## 🔐 How the Encryption Works

A simple Caesar cipher:
- Encryption: shifts each character forward by the key
- Decryption: shifts each character backward by the key

```csharp
char[i] = (char)(char[i] + key); // Encrypt
char[i] = (char)(char[i] - key); // Decrypt
```

---

## 📄 License

This project is open source.  
You are free to use, modify, and share it for learning purposes.

---

## 🙋‍♂️ Author

Made with 💻 by [Mayas]  
Feel free to connect or give feedback!
