CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "Categories" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Categories" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL,
    "ColorHex" TEXT NOT NULL
);

CREATE TABLE "Todos" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Todos" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL,
    "Created" TEXT NOT NULL,
    "Deadline" TEXT NOT NULL,
    "Importance" INTEGER NOT NULL,
    "CreatorId" INTEGER NOT NULL,
    CONSTRAINT "FK_Todos_Users_CreatorId" FOREIGN KEY ("CreatorId") REFERENCES "Users" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Users" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Users" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL,
    "ToDoId" INTEGER NULL,
    CONSTRAINT "FK_Users_Todos_ToDoId" FOREIGN KEY ("ToDoId") REFERENCES "Todos" ("Id")
);

CREATE INDEX "IX_Todos_CreatorId" ON "Todos" ("CreatorId");

CREATE INDEX "IX_Users_ToDoId" ON "Users" ("ToDoId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20240213093516_init', '8.0.1');

COMMIT;

BEGIN TRANSACTION;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20240213093748_String lengh performance fix', '8.0.1');

COMMIT;

