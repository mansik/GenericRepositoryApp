CREATE TABLE [dbo].[Student] (
    [StudentID]   INT            IDENTITY (1, 1) NOT NULL,
    [FullName]    NVARCHAR (50)  NULL,
    [Gender]      BIT            NULL,
    [Age]         INT            NULL,
    [Address]     NVARCHAR (250) NULL,
    [ModifedDate] DATETIME       NULL DEFAULT getdate()
);