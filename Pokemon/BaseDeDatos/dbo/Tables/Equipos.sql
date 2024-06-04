CREATE TABLE [dbo].[Equipos] (
    [IdEquipo]     UNIQUEIDENTIFIER NOT NULL,
    [IdEntrenador] UNIQUEIDENTIFIER NOT NULL,
    [Nombre]       VARCHAR (MAX)    NOT NULL,
    PRIMARY KEY CLUSTERED ([IdEquipo] ASC),
    FOREIGN KEY ([IdEntrenador]) REFERENCES [dbo].[Entrenadores] ([Id])
);

