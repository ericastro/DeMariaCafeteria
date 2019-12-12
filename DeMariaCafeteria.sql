-- Database: Cafeteria

-- DROP DATABASE "Cafeteria";

CREATE DATABASE "DeMariaEric"
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;


-- NAO É POSSIVEL EXECUTAR OS COMANDOS ABAIXOS ANTES DE CRIAR O BANDO DE DADOS;
-- NO POSTGRES NÃO É POSSIVEL TROCAR DE BANCO DE DADOS COMO EM OUTROS SGDB USANDO "USE DATABASE"
-- POR ESTE MOTIVO É NESSECARIO FAZER UMA NOVA CONEXAO COM O BANCO DE DADOS CRIADO
-- PELO CONSOLE DE COMANDO USANDO "\connect test;"
-- OU PELO PGADMIN SELECIONANDO O NOVO BANCO DE DADOS

CREATE SCHEMA IF NOT EXISTS "cafeteria" AUTHORIZATION postgres;

CREATE TABLE IF NOT EXISTS cafeteria.capsulas
(
	capsula_id serial,
	descricao varchar(200) NOT NULL,
	forca integer NOT NULL,
	PRIMARY KEY (capsula_id)
)

TABLESPACE pg_default;

ALTER TABLE cafeteria.capsulas
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS cafeteria.estoque
(
    capsula_id integer NOT NULL,
    data_entrada date NOT NULL,
    data_saida date NOT NULL
)

TABLESPACE pg_default;

ALTER TABLE cafeteria.estoque
    OWNER to postgres;

create view cafeteria.estoque_capsulas as
select 	A."capsula_id", 
		A."descricao",
		A."forca",
		B."data_entrada",
		B."data_saida"
from cafeteria."capsulas" as A
inner join cafeteria."estoque" as B
ON A."capsula_id" = B."capsula_id";    