public class IniFile
{
    private readonly string _filePath;

    public IniFile()
    {
        _filePath = Environment.CurrentDirectory + "\\Config.ini";
    }

    public string Read(string section, string key)
    {
        var lines = File.ReadAllLines(_filePath);
        bool inSection = false;
        foreach (var line in lines)
        {
            if (line.StartsWith($"[{section}]"))
            {
                inSection = true;
                continue;
            }
            if (inSection)
            {
                if (line.StartsWith("["))
                {
                    break; // Другая секция
                }
                var keyValue = line.Split('=');
                if (keyValue.Length == 2 && keyValue[0].Trim() == key)
                {
                    return keyValue[1].Trim();
                }
            }
        }
        return null; // Если не найдено
    }

    public void Write(string section, string key, string value)
    {
        var lines = new List<string>();
        bool inSection = false;
        bool keyFound = false;

        // Чтение существующего INI файла
        if (File.Exists(_filePath))
        {
            lines.AddRange(File.ReadAllLines(_filePath));
        }

        for (int i = 0; i < lines.Count; i++)
        {
            var line = lines[i];
            if (line.StartsWith($"[{section}]"))
            {
                inSection = true;
                continue;
            }
            if (inSection)
            {
                if (line.StartsWith("["))
                {
                    // Мы достигли другой секции
                    break;
                }
                var keyValue = line.Split('=');
                if (keyValue.Length == 2 && keyValue[0].Trim() == key)
                {
                    keyValue[1] = value; // Изменяем значение
                    lines[i] = $"{keyValue[0]}={keyValue[1]}";
                    keyFound = true;
                    break;
                }
            }
        }

        // Если ключ не найден, добавляем его
        if (!keyFound)
        {
            if (!inSection)
            {
                lines.Add($"[{section}]");
            }
            lines.Add($"{key}={value}");
        }

        // Запись обратно в файл
        File.WriteAllLines(_filePath, lines);
    }
}