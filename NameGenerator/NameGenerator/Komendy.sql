-- Kopiowanie zawartosci kolumny z tab2 do tab1 gdzie id się zgadzaja
/*
UPDATE tab1
SET col_new_name = tab2.copied_col
FROM tab2
WHERE tab1.ID = tab2.ID;
*/

-- Usuwanie tablicy tab1
-- DROP TABLE tab1;

-- Usuwanie duplikatow
/*
WITH CTE AS(
SELECT [col1], [col2], [col3],
       RN = ROW_NUMBER()OVER(PARTITION BY col1 ORDER BY col1)
   FROM tab1
)
DELETE FROM CTE WHERE RN > 1
*/

-- Losowy wiersz w tab1, col1, MSSQL
--SELECT TOP 1 col1 FROM tab1 ORDER BY NEWID()
-- Wersja MySQL:
-- SELECT column FROM table ORDER BY RAND() LIMIT 1

--Zmiana nazwy tablicy MSSQL
--SP_RENAME old_tab1_name, new_tab1_name

--Dodawanie kolumny ID do tab1
--ALTER TABLE tab1 ADD ID INT IDENTITY(1,1)

-- Wyswietlanie zawartosci
--SELECT * FROM tab1 ORDER BY col1 ASC --DESC
--SELECT col1, col2 FROM tab1 WHERE col1 = 'wartosc'