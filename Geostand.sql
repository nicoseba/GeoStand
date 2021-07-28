/*--------------SECTOR DE USUARIOS--------------*/

CREATE TABLE [Role] (
[id]    INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[name]  VARCHAR(50) NOT NULL
);

CREATE TABLE [User] (
[id]            INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[username]      VARCHAR(50) UNIQUE NOT NULL,
[name]          VARCHAR(50) NOT NULL,
[pass]          VARCHAR(100) NOT NULL,
[mail]          VARCHAR(100) UNIQUE NOT NULL,
[regist_date]   DATETIME NOT NULL DEFAULT GETDATE(),
[confirm_date]  DATETIME NULL,
[role_id]       INT NOT NULL,
CONSTRAINT [fk_user_role] FOREIGN KEY ([role_id]) REFERENCES [Role] (id)
);


/*----------------SECTOR PUBLICACIONES Y PRODUCTOS----------------------*/

CREATE TABLE [Multimedia](
[id]  INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[url] VARCHAR(100) NOT NULL
);

CREATE TABLE [Publication](
[id]	            INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[title]           VARCHAR(50) NOT NULL,
[content]         TEXT NOT NULL,
[date_published]  DATETIME NOT NULL DEFAULT GETDATE(),
[user_id]	        INT NOT NULL,
[multimedia_id]	  INT NOT NULL,
CONSTRAINT fk_publication_user FOREIGN KEY (user_id) REFERENCES [User](id),
CONSTRAINT fk_publication_multimedia FOREIGN KEY (multimedia_id) REFERENCES [Multimedia](id)
);

CREATE TABLE [Comment](
[id]              INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[user_id]         INT NOT NULL,
[publication_id]  INT NOT NULL,
[content]         TEXT NOT NULL,
[date_published]  DATETIME NOT NULL,
CONSTRAINT fk_comment_user FOREIGN KEY (user_id) REFERENCES [User] (id),
CONSTRAINT fk_comment_publication FOREIGN KEY (publication_id) REFERENCES [Publication] (id)
);

CREATE TABLE [ExchangeMode](
[id]    INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[name]  VARCHAR(50) NOT NULL
);

CREATE TABLE [Product](
[id]              INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[characteristic]  TEXT NOT NULL,
[exchangemode_id] INT NOT NULL,
[user_id]         INT NOT NULL,
[multimedia_id]   INT NOT NULL,
CONSTRAINT fk_product_exchangemode FOREIGN KEY (exchangemode_id) REFERENCES [exchangemode] (id),
CONSTRAINT fk_product_user FOREIGN KEY (user_id) REFERENCES [user] (id),
CONSTRAINT fk_product_multimedia FOREIGN KEY (multimedia_id) REFERENCES [multimedia] (id)
);

/*-----------------SECTOR CHAT------------------*/
CREATE TABLE [Chat](
[id]        INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[create_at] DATETIME NOT NULL 
);

CREATE TABLE [ChatUser](
[chat_id] INT NOT NULL,
[user_id] INT NOT NULL,
CONSTRAINT pk_chat_user PRIMARY KEY ([chat_id],[user_id]),
CONSTRAINT fk_chatuser_chat FOREIGN KEY (chat_id) REFERENCES [Chat] (id),
CONSTRAINT fk_chatuser_user FOREIGN KEY (user_id) REFERENCES [User] (id)
);

CREATE TABLE [Message](
[id]            INT IDENTITY(1,1) PRIMARY KEY  NOT NULL,
[user_id]       INT NOT NULL,
[chat_id]       INT NOT NULL,
[content]       TEXT NULL,
[send_on]       DATE NOT NULL DEFAULT GETDATE(),
[multimedia_id] INT NULL,
[status]        BIT NOT NULL DEFAULT 1,
CONSTRAINT fk_message_user FOREIGN KEY (user_id) REFERENCES [User] (id),
CONSTRAINT fk_message_chat FOREIGN KEY (chat_id) REFERENCES [Chat] (id),
CONSTRAINT fk_message_multimedia FOREIGN KEY (multimedia_id) REFERENCES [Multimedia] (id)
);


/*------------------------------REPORTES---------------------------------- */
CREATE TABLE [ReportType](
[id]    INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[name]  VARCHAR(50) NOT NULL
);

CREATE TABLE[Report](
[id]                      INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
[reportType_id]           INT NOT NULL,
[role_id]                 INT NOT NULL default 2,
[reportingUser_id]        INT NOT NULL,
[reportedUser_id]         INT NULL,
[reportedPublication_id]  INT NULL,
[reportedComment_id]      INT NULL,
[reportedProduct_id]      INT NULL,
CONSTRAINT fk_report_type FOREIGN KEY (reportType_id) REFERENCES [ReportType](id),
CONSTRAINT fk_report_role FOREIGN KEY (role_id) REFERENCES [Role](id),
CONSTRAINT fk_report_reporting_user FOREIGN KEY (reportingUser_id) REFERENCES [User](id),
CONSTRAINT fk_report_reported_user FOREIGN KEY (reportedUser_id) REFERENCES [User](id),
CONSTRAINT fk_report_reported_publication FOREIGN KEY (reportedPublication_id) REFERENCES [Publication](id),
CONSTRAINT fk_report_reported_comment FOREIGN KEY (reportedComment_id) REFERENCES [Comment](id),
CONSTRAINT fk_report_reported_product FOREIGN KEY (reportedProduct_id) REFERENCES [Product](id)
);
