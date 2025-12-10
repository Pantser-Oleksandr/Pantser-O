using System;

// Базовий клас для роботи зі стрічками
public class StringBase
{
    protected string characters;  // Зберігає символи стрічки
    protected byte lengthInBytes; // Довжина в байтах (UTF-8)

    // Конструктори
    public StringBase()
    {
        characters = "";
        lengthInBytes = 0;
    }

    public StringBase(string str)
    {
        characters = str ?? "";
        lengthInBytes = (byte)System.Text.Encoding.UTF8.GetByteCount(characters);
    }

    public StringBase(char ch)
    {
        characters = ch.ToString();
        lengthInBytes = (byte)System.Text.Encoding.UTF8.GetByteCount(characters);
    }

    // Основні методи
    public byte GetLength() => lengthInBytes;

    public void Clear()
    {
        characters = "";
        lengthInBytes = 0;
    }

    public string GetString() => characters;

    // Додаткові методи
    public bool IsEmpty() => lengthInBytes == 0;

    public void Concatenate(StringBase other)
    {
        if (other != null)
        {
            characters += other.GetString();
            lengthInBytes += other.GetLength();
        }
    }

    public StringBase Substring(int startIndex, int length)
    {
        if (startIndex < 0 || length < 0 || startIndex + length > characters.Length)
            throw new ArgumentOutOfRangeException("Invalid substring parameters");

        return new StringBase(characters.Substring(startIndex, length));
    }

    public override string ToString() => $"String: '{characters}' ({lengthInBytes} bytes)";
}