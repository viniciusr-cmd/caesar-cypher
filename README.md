# **CaesarCypher Project**

## Overview

This project implements a classic Caesar cipher for encrypting and decrypting text. The cipher works by shifting each letter in the plaintext by a certain number of positions (the **key**) down the alphabet. For example, with a key of 3, "hello" becomes "khoor."

## Usage

### **Prerequisites:** Ensure you have the [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.

0.1 **Clone the repository:** Clone the repository to your local machine using the following command.
```bash
git clone
```
0.2 **Navigate to the project directory:** Change the current directory to the location of the CaesarCypher project.
```bash
cd Caesar
```

1. **Run the program:** Execute the CaesarCypher application.
```bash
dotnet run
```
2. **Enter text:** Type the text you want to encrypt or decrypt in the designated prompt.
3. **Enter key:** Specify the key value (the number of positions to shift the letters). Ensure the key is a non-negative integer.
4. **View results:** Observe the encrypted and decrypted text displayed on the console.

## Example

```
Enter the text to be encrypted: hello
Enter the key: 3
Encrypted text: khoor
Decrypted text: hello
```

## Functionality

- **Encryption:** The `Encrypt` method shifts each letter in the input text by the specified key, wrapping around to the beginning of the alphabet if necessary.
- **Decryption:** The `Decrypt` method performs the opposite operation, shifting letters back by the key to recover the original message.

## Technical Details

- The project uses C# and leverages the `Console` class for user interaction.
- Input validation checks ensure valid text and key values are provided.
- The implementation handles both uppercase and lowercase letters correctly.
- Key values exceeding the alphabet size are automatically wrapped around, maintaining the Caesar cipher principle.

## Additional Notes

- This project is intended for educational purposes and demonstrates a basic encryption technique.
- It would benefit from incorporating more robust security measures in real-world scenarios.

## Future Enhancements

- Consider adding an option to specify the alphabet size (for non-standard alphabets).
- Implement encryption/decryption for other character sets, including numbers and symbols.

### This README.MD file was created using generative text based in GEMINI by Google.