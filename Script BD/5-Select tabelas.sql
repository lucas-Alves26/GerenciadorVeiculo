USE DB_GER_VEICULO

SELECT * FROM TBL_LOGINS
SELECT * FROM TBL_FUNCIONARIO
SELECT * FROM TBL_TELEFONE
SELECT * FROM TBL_ENDERECO
SELECT * FROM TBL_FOTO
SELECT * FROM TBL_ENDERECO_FUNCIONARIO



--select DO CONSULTAR USUARIO
SELECT F.FUN_STR_NOME AS NOME, F.FUN_DATE_NASC AS NASC, F.FUN_STR_CPF AS CPF, F.FUN_STR_CNH AS CNH, F.FUN_STR_RG AS RG,
F.FUN_STR_CARGO AS CARGO, F.FUN_STR_SEXO AS SEXO,FUN_STR_EMAIL AS EMAIL, T.TEL_INT_DDD AS DDD, T.TEL_INT_CELULAR AS TEL, T.TEL_INT_FIXO AS FIX,
T.TEL_STR_OPERADORA AS OPE, E.END_STR_RUA AS RUA, E.END_INT_NUMERO AS NUMERO, E.END_STR_COMPLEMENTO AS COMPLEMENTO, E.END_STR_BAIRRO AS BAIRRO,
E.END_INT_CEP AS CEP, ES.EST_STR_NOME AS ESTADO, C.CID_STR_NOME AS CIDADE, FT.FOTO AS FOTO
FROM TBL_FUNCIONARIO  AS F 
INNER JOIN TBL_TELEFONE AS T ON T.FUN_INT_ID = F.FUN_INT_ID 
INNER JOIN TBL_ENDERECO_FUNCIONARIO AS EF ON EF.END_INT_ID = F.FUN_INT_ID
INNER JOIN TBL_ENDERECO AS E ON EF.END_INT_ID = E.END_INT_ID
INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = E.EST_INT_CODUF
INNER JOIN TBL_CIDADE AS C ON E.CID_INT_ID = C.CID_INT_ID
INNER JOIN TBL_FOTO AS FT ON FT.FUN_INT_ID = F.FUN_INT_ID
WHERE F.FUN_INT_ID = 1

-- update Usuario
UPDATE TBL_FUNCIONARIO
SET FUN_STR_NOME = '', FUN_DATE_NASC = '', FUN_STR_CPF = '' , FUN_STR_RG = '',FUN_STR_CNH = '', FUN_STR_CARGO = '', FUN_STR_SEXO = '' , FUN_STR_EMAIL='' WHERE FUN_INT_ID = 1

