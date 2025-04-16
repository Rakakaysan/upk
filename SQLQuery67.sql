CREATE TABLE "manajemen_pengguna"(
    "nip" BIGINT NOT NULL,
    "nama" VARCHAR(255) NOT NULL,
    "email" VARCHAR(255) NOT NULL,
    "jabatan" VARCHAR(255) NOT NULL,
    "status" NVARCHAR(255) CHECK
        (
            "status" IN(N'aktif', N'tidak aktif')
        ) NOT NULL,
        "username" VARCHAR(255) NOT NULL,
        "password" VARCHAR(255) NOT NULL
);
ALTER TABLE
    "manajemen_pengguna" ADD CONSTRAINT "manajemen_pengguna_nip_primary" PRIMARY KEY("nip");