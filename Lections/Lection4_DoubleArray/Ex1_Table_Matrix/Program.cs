﻿string[,] table = new string[2, 3];
// Инициализация строк String.Empty
// table[0,0] table[0,1] table[0,2]
// table[1,0] table[1,1] table[1,2]

table[1, 2] = "Word";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 3; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

