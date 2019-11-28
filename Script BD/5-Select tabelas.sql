USE DB_GER_VEICULO

SELECT * FROM TBL_LOGINS
SELECT * FROM TBL_FUNCIONARIO
SELECT * FROM TBL_TELEFONE
SELECT * FROM TBL_ENDERECO
SELECT * FROM TBL_FOTO
SELECT * FROM TBL_ENDERECO_FUNCIONARIO

SELECT * FROM TBL_EMPRESA

SELECT * FROM TBL_CNH 
SELECT * FROM TBL_SEGURO_VEICULO
SELECT * FROM TBL_SEGURO
SELECT * FROM TBL_VEICULO
SELECT * FROM TBL_SAIDA
SELECT * FROM TBL_MOTORISTA
SELECT * FROM TBL_ENTRADA


SELECT S.SAI_INT_ID AS ID, V.VEI_STR_PLACA AS Placa, V.VEI_STR_MODELO AS Modelo, M.MOT_STR_NOME AS Motorista,E.EMP_STR_NOME AS Empresa, CONVERT(VARCHAR(10), S.SAI_DATE_DATA, 103) AS DATA FROM TBL_SAIDA AS S
                INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID
               INNER JOIN TBL_MOTORISTA AS M ON M.MOT_INT_ID = S.MOT_INT_ID
                INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID   ORDER BY S.SAI_DATE_DATA DESC 



INSERT INTO TBL_ENTRADA (SAI_INT_ID,ENT_DATE_DATA) VALUES (?,?)

UPDATE TBL_SAIDA SET SAI_STR_SITUACAO = 'Finalizada'

UPDATE TBL_MOTORISTA SET MOT_STR_SITUACAO = 'Disponivel' WHERE MOT_INT_ID = @idMot

update TBL_VEICULO SET VEI_STR_SITUACAO = 'Disponivel', VEI_DOUBLE_KM += '1500'  where VEI_INT_ID = 1

SELECT SAI_INT_ID, FUN_INT_ID, MOT_INT_ID, VEI_INT_ID FROM TBL_SAIDA WHERE SAI_INT_ID = 1






SELECT M.MOT_INT_ID, M.MOT_STR_NOME, M.EMP_INT_ID FROM TBL_MOTORISTA AS M
INNER JOIN TBL_SAIDA AS S ON S.MOT_INT_ID = M.MOT_INT_ID
WHERE EMP_INT_ID = 1 AND S.SAI_INT_ID = 2 OR (M.MOT_STR_SITUACAO = 'Disponivel' AND EMP_INT_ID = 1)


update TBL_VEICULO set VEI_STR_SITUACAO = 'Disponivel' where VEI_INT_ID = 1



SELECT  V.VEI_INT_ID, V.VEI_STR_PLACA, V.EMP_INT_ID FROM TBL_VEICULO AS V
INNER JOIN TBL_SAIDA AS S ON S.VEI_INT_ID = V.VEI_INT_ID
WHERE  V.EMP_INT_ID = 1 AND S.SAI_INT_ID = 2 OR (V.VEI_STR_SITUACAO = 'Disponivel' AND V.EMP_INT_ID = 1)



WHERE VEI_STR_SITUACAO = 'disponivel' and EMP_INT_ID = " + idEmp;





UPDATE TBL_MOTORISTA SET MOT_STR_SITUACAO = 'Viagem' WHERE MOT_INT_ID = 

SELECT MOT_INT_ID, MOT_STR_NOME FROM TBL_MOTORISTA WHERE EMP_INT_ID = 1 AND S.SAI_INT_ID = 2 OR M.MOT_STR_SITUACAO = 'Disponivel'

SELECT E.EMP_STR_NOME,M.MOT_STR_NOME, C.CNH_STR_REGISTRO, V.VEI_STR_PLACA, V.VEI_STR_MARCA, V.VEI_STR_MODELO, V.VEI_STR_CHASSI, V.VEI_DOUBLE_KM ,CONVERT(VARCHAR(10),S.SAI_DATE_DATA,103) AS DATA FROM TBL_SAIDA AS S
INNER JOIN TBL_MOTORISTA AS M ON S.MOT_INT_ID = M.MOT_INT_ID
INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID
INNER JOIN TBL_CNH AS C ON C.CNH_INT_ID = M.MOT_INT_ID
INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID WHERE S.SAI_INT_ID = 2



SELECT S.SAI_INT_ID AS ID, V.VEI_STR_PLACA AS Placa, V.VEI_STR_MODELO AS Modelo, M.MOT_STR_NOME AS Motorista,E.EMP_STR_NOME AS Empresa, CONVERT(VARCHAR(10), S.SAI_DATE_DATA, 103) AS DATA FROM TBL_SAIDA AS S
INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID
INNER JOIN TBL_MOTORISTA AS M ON M.MOT_INT_ID = S.MOT_INT_ID
INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID  WHERE S.SAI_DATE_DATA =  '2019-11-24'

SELECT S.SAI_INT_ID AS ID, V.VEI_STR_PLACA AS Placa, V.VEI_STR_MODELO AS Modelo, M.MOT_STR_NOME AS Motorista,E.EMP_STR_NOME AS Empresa, CONVERT(VARCHAR(10),S.SAI_DATE_DATA,103) AS DATA FROM TBL_SAIDA AS S
INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID
INNER JOIN TBL_MOTORISTA AS M ON M.MOT_INT_ID = S.MOT_INT_ID
INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID ORDER BY S.SAI_DATE_DATA DESC 
-----------------------------------------------------------------------------------------------------------------------------------
SELECT S.SAI_INT_ID AS ID, V.VEI_STR_PLACA AS Placa, V.VEI_STR_MODELO AS Modelo, M.MOT_STR_NOME AS Motorista,E.EMP_STR_NOME AS Empresa, CONVERT(VARCHAR(10),S.SAI_DATE_DATA,103) AS DATA FROM TBL_SAIDA AS S
INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID
INNER JOIN TBL_MOTORISTA AS M ON M.MOT_INT_ID = S.MOT_INT_ID
INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID WHERE E.EMP_STR_NOME = 'Embratel' ORDER BY S.SAI_DATE_DATA DESC 



SELECT S.SAI_INT_ID AS ID, V.VEI_STR_PLACA AS Placa, V.VEI_STR_MODELO AS Modelo, M.MOT_STR_NOME AS Motorista,E.EMP_STR_NOME AS Empresa, CONVERT(VARCHAR(10),S.SAI_DATE_DATA,103) AS DATA FROM TBL_SAIDA AS S
INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID
INNER JOIN TBL_MOTORISTA AS M ON M.MOT_INT_ID = S.MOT_INT_ID
INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID ORDER BY DATA DESC 



--DELETE TBL_ENDERECO_FUNCIONARIO WHERE FUN_INT_ID = 9
--DELETE TBL_ENDERECO WHERE END_INT_ID = 7
--DELETE TBL_FUNCIONARIO WHERE FUN_INT_ID = 7
--DELETE TBL_FOTO WHERE FOT_INT_ID = 7
--DELETE TBL_TELEFONE WHERE TEL_INT_ID = 7
--DELETE TBL_LOGINS WHERE LOG_INT_ID = 7




--select DO CONSULTAR USUARIO
SELECT F.FUN_STR_NOME, CONVERT(VARCHAR(10),F.FUN_DATE_NASC,103) AS NASC, F.FUN_STR_CPF, F.FUN_STR_RG, F.FUN_STR_CARGO, F.FUN_STR_SEXO, F.FUN_STR_EMAIL, T.TEL_INT_DDD, T.TEL_INT_CELULAR, 
T.TEL_INT_FIXO, T.TEL_STR_OPERADORA, E.END_STR_RUA, E.END_INT_NUMERO, E.END_STR_COMPLEMENTO, E.END_STR_BAIRRO, E.END_INT_CEP, ES.EST_STR_NOME, C.CID_STR_NOME, 
FT.FOTO FROM TBL_FUNCIONARIO AS F
INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = F.TEL_INT_ID 
INNER JOIN TBL_ENDERECO_FUNCIONARIO AS EF ON EF.FUN_INT_ID = F.FUN_INT_ID
INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EF.END_INT_ID
INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = E.EST_INT_CODUF
INNER JOIN TBL_CIDADE AS C ON C.CID_INT_ID = E.CID_INT_ID
INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = F.FOT_INT_ID
WHERE F.FUN_INT_ID = 4

--select DO CONSULTAR EMPRESA
SELECT EP.EMP_INT_ID, EP.EMP_STR_NOME,EP.EMP_STR_CNPJ,EP.EMP_STR_DESC,EP.EMP_STR_EMAIL,EP.EMP_STR_STATUS,
T.TEL_INT_CELULAR,T.TEL_STR_OPERADORA,T.TEL_INT_DDD, T.TEL_INT_FIXO,E.END_STR_RUA,E.END_INT_NUMERO,E.END_STR_BAIRRO, 
E.END_STR_COMPLEMENTO,E.END_INT_CEP, ES.EST_STR_NOME, C.CID_STR_NOME FROM TBL_EMPRESA AS EP
INNER JOIN TBL_TELEFONE AS T ON EP.TEL_INT_ID = T.TEL_INT_ID 
INNER JOIN TBL_ENDERECO_EMPRESA AS EE ON EE.EMP_INT_ID = EP.EMP_INT_ID
INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EE.END_INT_ID
INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = E.EST_INT_CODUF
INNER JOIN TBL_CIDADE AS C ON C.CID_INT_ID = E.CID_INT_ID
WHERE  EP.EMP_INT_ID = 1

--select DO CONSULTAR MOTORISTA
SELECT v.VEI_INT_ID, E.EMP_INT_ID, S.SEG_INT_ID,V.VEI_STR_MARCA,V.VEI_STR_MODELO,V.VEI_STR_PLACA,V.VEI_STR_RENAVAM,V.VEI_STR_COR,V.VEI_STR_COMBUSTIVEL,V.VEI_STR_LUGARES
,V.VEI_DOUBLE_KM,V.VEI_DATE_FAB,V.VEI_DATE_ANO_MODELO,V.VEI_STR_TIPO,E.EMP_STR_NOME,S.SEG_STR_NOME,S.SEG_STR_TIPO,CONVERT(VARCHAR(10),S.SEG_DATE_INICIAL,103) AS DATEINI,CONVERT(VARCHAR(10),S.SEG_DATE_FINAL,103) AS DATEFIN, 
ES.EST_STR_NOME FROM TBL_VEICULO AS V
INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID 
INNER JOIN TBL_SEGURO_VEICULO AS SV ON v.VEI_INT_ID = SV.VEI_INT_ID
INNER JOIN TBL_SEGURO AS S ON S.SEG_INT_ID = SV.SEG_INT_ID
INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = V.EST_INT_CODUF
WHERE V.VEI_INT_ID = 2

--select DO CONSULTAR MOTORISTA
SELECT M.MOT_INT_ID, M.MOT_STR_NOME,CONVERT(VARCHAR(10),M.MOT_DATE_NASC,103),M.MOT_STR_CPF,M.MOT_STR_RG,M.MOT_STR_SEXO,M.MOT_STR_EMAIL,C.CNH_STR_REGISTRO,CONVERT(VARCHAR(10),c.CNH_DATE_VALIDADE,103),C.CNH_STR_CATEGORIA, 
T.TEL_INT_CELULAR,T.TEL_STR_OPERADORA,T.TEL_INT_FIXO,T.TEL_INT_DDD, EP.EMP_STR_NOME AS EMPRESA, ED.END_STR_RUA, ED.END_INT_NUMERO,ED.END_STR_COMPLEMENTO,
ED.END_STR_BAIRRO, ED.END_INT_CEP, ES.EST_STR_NOME, CD.CID_STR_NOME, FT.FOTO FROM TBL_MOTORISTA AS M
INNER JOIN TBL_CNH AS C ON C.CNH_INT_ID = M.CNH_INT_ID
INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = M.MOT_INT_ID
INNER JOIN TBL_EMPRESA AS EP ON EP.EMP_INT_ID = M.EMP_INT_ID
INNER JOIN TBL_ENDERECO_MOTORISTA AS EM ON EM.MOT_INT_ID = M.MOT_INT_ID
INNER JOIN TBL_ENDERECO AS ED ON ED.END_INT_ID = EM.END_INT_ID
INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = ED.EST_INT_CODUF
INNER JOIN TBL_CIDADE AS CD ON CD.CID_INT_ID = ED.CID_INT_ID
INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = M.FOT_INT_ID
WHERE M.MOT_INT_ID = 2

--TRAZ TODOS OS ID DO VEICULO
SELECT v.VEI_INT_ID, E.EMP_INT_ID, S.SEG_INT_ID FROM TBL_VEICULO AS V 
INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID 
INNER JOIN TBL_SEGURO_VEICULO AS SV ON v.VEI_INT_ID = SV.VEI_INT_ID
INNER JOIN TBL_SEGURO AS S ON S.SEG_INT_ID = SV.SEG_INT_ID
WHERE V.VEI_INT_ID = 3

--TRAZ TODOS OS ID DO MOTORISTA
SELECT T.TEL_INT_ID, EM.MOT_INT_ID, E.END_INT_ID, FT.FOT_INT_ID, CH.CNH_INT_ID,EP.EMP_INT_ID FROM TBL_MOTORISTA AS M 
INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = M.TEL_INT_ID 
INNER JOIN TBL_ENDERECO_MOTORISTA AS EM ON M.MOT_INT_ID = EM.MOT_INT_ID
INNER JOIN TBL_ENDERECO AS E ON EM.END_INT_ID = E.END_INT_ID
INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = M.FOT_INT_ID
INNER JOIN TBL_CNH AS CH ON CH.CNH_INT_ID = M.CNH_INT_ID
INNER JOIN TBL_EMPRESA AS EP ON EP.EMP_INT_ID = M.EMP_INT_ID
WHERE M.MOT_INT_ID = 1

--TRAZ TODOS OS ID DO FUNCIONARIO
SELECT F.FUN_INT_ID, T.TEL_INT_ID, E.END_INT_ID, FT.FOT_INT_ID, L.LOG_INT_ID  FROM TBL_FUNCIONARIO AS F 
INNER JOIN TBL_ENDERECO_FUNCIONARIO AS EF ON EF.FUN_INT_ID = F.FUN_INT_ID
INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EF.END_INT_ID
INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = F.TEL_INT_ID
INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = F.FOT_INT_ID
INNER JOIN TBL_LOGINS AS L ON L.LOG_INT_ID = F.LOG_INT_ID
WHERE F.FUN_INT_ID = 1


select VEI_STR_MARCA from tbl_veiculo

select VEI_STR_MODELO from TBL_VEICULO where VEI_STR_MARCA = 'fiat'

UPDATE TBL_FUNCIONARIO SET LOG_INT_ID = 6, TEL_INT_ID = 6, FOT_INT_ID = 6 WHERE FUN_INT_ID = 6

-- update Usuario
UPDATE TBL_FUNCIONARIO
SET FUN_STR_NOME = '', FUN_DATE_NASC = '', FUN_STR_CPF = '' , FUN_STR_RG = '',FUN_STR_CNH = '', FUN_STR_CARGO = '', FUN_STR_SEXO = '' , FUN_STR_EMAIL='' WHERE FUN_INT_ID = 1


-- update Motorista
UPDATE TBL_MOTORISTA SET MOT_STR_NOME = '', MOT_DATE_NASC = '', MOT_STR_CPF = '' , MOT_STR_RG = '', MOT_STR_SEXO = '' , MOT_STR_EMAIL='' WHERE MOT_INT_ID = 1

-- update TELEFONE

UPDATE TBL_TELEFONE
SET TEL_INT_DDD = 030 , TEL_INT_FIXO = 81395412, TEL_INT_CELULAR = 555555588 ,TEL_STR_OPERADORA= 'Nextel' WHERE TEL_INT_ID = 5

-- update ENDERECO
UPDATE TBL_ENDERECO SET END_STR_RUA ='Madalena' , END_INT_NUMERO= 30, END_STR_COMPLEMENTO='Travessa Z' , END_STR_BAIRRO='Agua Preta' , END_INT_CEP= 05037020 , EST_INT_CODUF= 26 , CID_INT_ID= 5270 WHERE END_INT_ID = 2

-- update CNH
UPDATE TBL_CNH SET CNH_STR_REGISTRO = '', CNH_DATE_VALIDADE = '', CNH_STR_CATEGORIA = '' WHERE CNH_INT_ID = 


-- update EMPRESA
UPDATE TBL_EMPRESA SET EMP_STR_NOME = '', EMP_STR_CNPJ ='',EMP_STR_DESC = '',EMP_STR_EMAIL = '',EMP_STR_STATUS ='' WHERE EMP_INT_ID = 


sp_helpconstraint 'TBL_foto','nomsg'



--SELECT v.VEI_INT_ID, E.EMP_INT_ID, S.SEG_INT_ID,V.VEI_STR_MARCA,V.VEI_STR_MODELO,V.VEI_STR_PLACA,V.VEI_STR_RENAVAM,
--V.VEI_STR_CHASSI,V.VEI_STR_COR,V.VEI_STR_COMBUSTIVEL,V.VEI_STR_LUGARES, V.VEI_DOUBLE_KM,V.VEI_DATE_FAB,V.VEI_DATE_ANO_MODELO,
--V.VEI_STR_TIPO,E.EMP_STR_NOME,S.SEG_STR_NOME,S.SEG_STR_TIPO,CONVERT(VARCHAR(10), S.SEG_DATE_INICIAL, 103) AS DATEINI, CONVERT(VARCHAR(10), S.SEG_DATE_FINAL, 103) AS DATEFIN, ES.EST_STR_NOME 
--FROM TBL_VEICULO AS V 
--INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID 
--INNER JOIN TBL_SEGURO_VEICULO AS SV ON v.VEI_INT_ID = SV.VEI_INT_ID 
--INNER JOIN TBL_SEGURO AS S ON S.SEG_INT_ID = SV.SEG_INT_ID 
--INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = V.EST_INT_CODUF WHERE V.VEI_INT_ID = 4