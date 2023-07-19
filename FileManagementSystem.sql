

CREATE DATABASE IncedoFMSDb;

Use IncedoFMSDb;

Drop TABLE FileDetailsMaster;

CREATE TABLE FileDetailsMaster (
		FileMasterId UNIQUEIDENTIFIER PRIMARY KEY
		, [FileName] varchar (100) NULL
		, SourcePath varchar (255) NOT NULL
		, FileTypeID int NULL
		, Delimeter varchar (2) NULL
		, FixedLength char(1) 
		, TemplateName varchar (50) NULL
		, EmailID varchar(50) NULL
		, ClientID bigint NULL
		, FileDate char(15) NULL
		, InsertionMode char(10) NULL
		, IsActive char(1) 
	);

     ALTER TABLE FileDetailsMaster ALTER COLUMN FileDate char(15);

SELECT *FROM FileDetailsMaster;
CREATE PROCEDURE InsertIntoFileDetailsMaster(

    @FileName varchar (100),
    @SourcePath varchar (255),
    @FileTypeID int,
    @Delimeter varchar (2),
    @FixedLength char(1),
    @TemplateName varchar (50),
    @EmailID varchar(50),
    @ClientID bigint,
    @FileDate char(20),
    @InsertionMode char(10),
    @IsActive char(1)
)
AS
DECLARE @Id UNIQUEIDENTIFIER;
SET @Id = NEWID();
BEGIN
    SET NOCOUNT ON;

    INSERT INTO FileDetailsMaster (FileMasterId,[FileName], SourcePath,FileTypeID,Delimeter,FixedLength,TemplateName,EmailID,ClientID,FileDate,InsertionMode,IsActive)
    VALUES (@Id,@FileName,@SourcePath,@FileTypeID,@Delimeter,@FixedLength,@TemplateName,@EmailID,@ClientID,@FileDate,@InsertionMode,@IsActive);

    SELECT * FROM FileDetailsMaster WHERE FileMasterId = @Id;
END;


EXEC InsertIntoFileDetailsMaster 'Sample1.txt','source/file/sample1.txt',101,'//','N','template1.json','sample@gmail.com',1001,'12 Jul 2023','SP','N';




Create table VendorDetailsMaster(
	Id int primary key identity,
	Name varchar(30)
)

SELECT *FROM VendorDetailsMaster;
INSERT INTO VendorDetailsMaster VALUES('BlackDiamond'),('Bloomberg'),('CIBC'),('Fidelity'),('Pershing')



Create table DelimiterDetailsMaster(
	Id int primary key identity,
	Name varchar(30),
	Symbol varchar(5)
)
SELECT *FROM DelimiterDetailsMaster;

INSERT INTO DelimiterDetailsMaster VALUES('Semicolon','{;}'),('tab','{t}'),('Comma','{,}'),('vertical bar','{|}'),('Colon','{:}')