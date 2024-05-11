# SQLServerControleDDL
Projeto em Angular e .Net que usa scripts XML para cada alteração do banco de dados controlando as alterações que cada usuário do banco realizou em tabelas, procedures, funções, etc. Permitindo manter um histórico de alterações dos objetos de banco de dados

![image](https://github.com/miguelvasp/SQLServerControleDDL/assets/14856283/e64a83b9-a369-4913-9797-d49b3f4eb02c)


Scripts para o banco de dados

Criação da Tabela

/****** Object:  Table [dbo].[Trace_Alteracao_Objeto]    Script Date: 03/07/2018 07:27:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Trace_Alteracao_Objeto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tp_Evento] [varchar](255) NULL,
	[Dt_Alteracao] [datetime] NULL,
	[Nm_Servidor] [varchar](255) NULL,
	[Nm_Login] [varchar](255) NULL,
	[Nm_Database] [varchar](255) NULL,
	[Nm_Objeto] [varchar](255) NULL,
	[Ds_Evento] [xml] NULL,
 CONSTRAINT [PK_Trace_Alteracao_Objeto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



Trigger para lançamento dos dados de alterações DDL


CREATE TRIGGER trgTrace_Alteracao_Objeto

ON DATABASE

FOR DDL_DATABASE_LEVEL_EVENTS

AS

BEGIN 
    SET NOCOUNT ON 
    DECLARE @Evento XML 
    SET @Evento = EVENTDATA() 
    INSERT INTO Trace_Alteracao_Objeto(Tp_Evento, Dt_Alteracao, Nm_Servidor, Nm_Login, Nm_Database, Nm_Objeto,Ds_Evento) 
    SELECT  @Evento.value('(/EVENT_INSTANCE/EventType/text())[1]','varchar(50)') Tipo_Evento, 
            @Evento.value('(/EVENT_INSTANCE/PostTime/text())[1]','datetime') PostTime, 
            @Evento.value('(/EVENT_INSTANCE/ServerName/text())[1]','varchar(50)') ServerName, 
            @Evento.value('(/EVENT_INSTANCE/LoginName/text())[1]','varchar(50)') LoginName, 
            @Evento.value('(/EVENT_INSTANCE/DatabaseName/text())[1]','varchar(50)') DatabaseName, 
            @Evento.value('(/EVENT_INSTANCE/ObjectName/text())[1]','varchar(50)') ObjectName, @Evento
						  
END

 
