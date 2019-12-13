-- Database: DeMariaEric

-- DROP DATABASE "DeMariaEric";

CREATE DATABASE "DeMariaEric"
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;


-- NAO É POSSIVEL EXECUTAR OS COMANDOS ABAIXOS ANTES DE CRIAR O BANDO DE DADOS;
-- NO POSTGRES NÃO É POSSIVEL TROCAR DE BANCO DE DADOS COMO EM OUTROS SGDB 
-- USANDO O COMANDO "USE DATABASE" POR EXEMPLO;
-- POR ESTE MOTIVO É NESSECARIO FAZER UMA NOVA CONEXAO COM O BANCO DE DADOS CRIADO;
-- PELO CONSOLE DE COMANDO USANDO "\connect test;";
-- OU PELO PGADMIN SELECIONANDO O NOVO BANCO DE DADOS.

-- SCHEMA: cafeteria

-- DROP SCHEMA cafeteria ;

CREATE SCHEMA cafeteria
    AUTHORIZATION postgres;


-- Table: cafeteria.capsulas

-- DROP TABLE cafeteria.capsulas;

CREATE TABLE cafeteria.capsulas
(
    capsula_id integer NOT NULL DEFAULT nextval('cafeteria.capsulas_capsula_id_seq'::regclass),
    descricao character varying(200) COLLATE pg_catalog."default" NOT NULL,
    forca integer NOT NULL,
    CONSTRAINT capsulas_pkey PRIMARY KEY (capsula_id)
)

TABLESPACE pg_default;

ALTER TABLE cafeteria.capsulas
    OWNER to postgres;


-- Table: cafeteria.estoque

-- DROP TABLE cafeteria.estoque;

CREATE TABLE cafeteria.estoque
(
    capsula_id integer NOT NULL,
    data_entrada date NOT NULL,
    data_saida date,
    validade date NOT NULL,
    estoque_id integer NOT NULL DEFAULT nextval('cafeteria.estoque_estoque_id_seq'::regclass),
    CONSTRAINT estoque_pkey PRIMARY KEY (estoque_id)
)

TABLESPACE pg_default;

ALTER TABLE cafeteria.estoque
    OWNER to postgres;

-- A CRIACAO DA VIEW SERIA NECESSARIA SOMENTE PARA LISTAR AS CAPSULAS
-- INFELIZMENTE NÃO TIVE TEMPO HÁBIL PARA REALIZAR ESTA TAREFA
-- PORTANTO ELA NÃO SERÁ NECESSARIA PARA EXECUÇÃO DO PROGRAMA AINDA.    

create view cafeteria.estoque_capsulas as
select 	A."capsula_id", 
		A."descricao",
		A."forca",
		B."data_entrada",
		B."data_saida"
from cafeteria."capsulas" as A
inner join cafeteria."estoque" as B
ON A."capsula_id" = B."capsula_id";    