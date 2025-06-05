CREATE DATABASE Discos
USE Discos

CREATE TABLE INFO(
Codigo VARCHAR(15) NOT NULL PRIMARY KEY,
Nombre VARCHAR(100),
Artista VARCHAR(100),
Genero VARCHAR(20),
Año Int,
No_Pistas int,
Imagen VARBINARY(MAX)
);

CREATE TABLE ENLACES (
Codigo VARCHAR(15) NOT NULL,
Spotify VARCHAR(255),
AppleMusic VARCHAR(255),
FOREIGN KEY (Codigo) REFERENCES INFO(Codigo)
);

CREATE TABLE ADMINS (
ID INT IDENTITY(1,1) PRIMARY KEY,
Usuario VARCHAR(50) NOT NULL,
Contraseña VARCHAR(50) NOT NULL
);

INSERT INTO INFO VALUES ('PTVCWTS','Collide With The Sky','Pierce The Veil', 'Post-Hardcore',2012,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\PTVCWTS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('BMTHSS','Suicide Season','Bring Me The Horizon','Metalcore',2008,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\BMTHSS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('TOPV','Vessel','Twenty One Pilots','Alternativo',2013,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\TOPV.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('ORG','GUTS','Olivia Rodrigo','Pop',2023,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\ORG.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('PMTIW','This Is Why','Paramore','Alternativo',2023,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\PMTIW.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('BMTHCYB','Count Your Blessings','Bring Me The Horizon','Deathcore',2006,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\BMTHCYB.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('MCRTBP','The Black Parade','My Chemical Romance','Rock',2006,14,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\MCRTBP.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('EF','Fallen','Evanescence','Rock',2003,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\EF.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('NNM','Nevermind','Nirvana','Grunge',1991,13,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\NNM.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('HYPAS','You''d Prefer An Astronaut','Hum','Grunge',1995,9,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\HYPAS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('FOBTTTYG','Take This To Your Grave', 'Fall Out Boy','Punk',2003,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\FOBTTTYG.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('TOSS','Smash','The Offspring','Punk',1994,14,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\TOSS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('SWSWETSAETH','With Ears To See And Eyes To Hear','Sleeping With Sirens','Post-Hardcore',2010,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\SWSWETSAETH.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('TCNNTA','No Need To Argue','The Cranberries','Rock',1994,13,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\TCNNTA.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('TBDMN','Nocturnal','The Black Dahlia Murder','Deathcore',2007,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\TBDMN.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('ADTRHS','Homesick','A Day To Remember','Metalcore',2009,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\ADTRHS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('ALLTKWTTMO','The Kids Will Take Their Monsters On','Automatic Loveletter','Rock',2011,9,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\ALLTKWTTMO.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('ADTRWSMFY','What Separates Me From You','A Day To Remember','Metalcore',2010,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\ADTRWSMFY.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('TOPBF','Blurryface','Twenty One Pilots','Alternativo',2015,14,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\TOPBF.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('BMTHTTS','That''s The Spirit','Bring Me The Horizon','Alternativo',2015,11,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\BMTHTTS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('UTDTKUS','To Keep Us Safe','Upon This Dawning','Post-Hardcore',2012,13,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\UTDTKUS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('AASUAS','Stand Up And Scream','Asking Alexandria','Metalcore',2009,13,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\AASUAS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('ASAS','Avenged Sevenfold','Avenged Sevenfold','Metal',2007,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\ASAS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('CXCXB','BRAT','Charli xcx','Pop',2024,15,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\CXCXB.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('B182EOTS','Enema Of The State','blink-182','Punk',1999,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\B182EOTS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('SSTC','The Cleansing','Suicide Silence','Deathcore',2008,13,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\SSTC.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('PTVSM','Selfish Machines','Pierce The Veil','Post-Hardcore',2010,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\PTVSM.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('TS1989','1989','Taylor Swift','Pop',2014,13,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\TS1989.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('BMTHS','Sempiternal','Bring Me The Horizon','Metalcore',2013,13,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\BMTHS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('BT','Twilight','bôa','Rock',2001,14,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\BT.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('TSTTPD','THE TORTURED POETS DEPARTMENT','Taylor Swift','Pop',2024,16,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\TSTTPD.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('NIU','In Utero','Nirvana','Grunge',1993,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\NIU.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('CKYIDR','Infiltrate-Destroy-Rebuild','CKY','Metal',2002,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\CKYIDR.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('LMA','Aries','Luis Miguel','Pop',1993,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\LMA.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('KFTL','Follow The Leader','Korn','Metal',1998,14,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\KFTL.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('EPNMP','Música Popular','Enrique Peña Nieto','Pop',2011,12,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\EPNMP.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('SSMANS','Scary Monsters And Nice Sprites','Skrillex','Dubstep',2010,9,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\SSMANS.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('LCV','Vivid','Living Colour','Rock',1988,11,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\LCV.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('BPD','Desvelado','Bobby Pulido','Pop',1995,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\BPD.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('WWB','Weezer','Weezer','Alternativo',1994,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\WWB.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('AA','Adolescents','Adolescents','Punk',1981,16,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\AA.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('CTETF','The Fallout','Crown The Empire','Post-hardcore',2012,11,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\CTETF.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('PMR','Riot!','Paramore','Punk',2007,14,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\PMR.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('PPG','GÉNESIS','Peso Pluma','Regional Mexicano',2023,17,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\PPG.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('CKYV1','Vol. 1','CKY','Metal',1999,10,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\CKYV1.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('FOBABAP','American Beauty/American Psycho','Fall Out Boy','Alternativo',2015,11,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\FOBABAP.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('SWSM','Madness','Sleeping With Sirens','Post-Hardcore',2015,15,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\SWSM.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('PTVMA','Misadventures','Pierce The Veil','Post-Hardcore',2016,11,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\PTVMA.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('PATDPFTW','Pray For The Wicked','Panic! at the Disco','Pop',2018,11,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\PATDPFTW.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('MNREEC','Rebelión En El Chiquero','Marraneitors','Grindcore',2019,9,
(SELECT * FROM OPENROWSET(BULK 'E:\Noveno Semestre\ProyectoFinal\ProyectoFinal\Portadas\MNREEC.jpg', SINGLE_BLOB) AS Imagen))

INSERT INTO INFO VALUES ('1','1','1','1',1,1,1)


INSERT INTO ADMINS VALUES ('Michell','Aneliz')
 
 
 INSERT INTO ENLACES VALUES ('BMTHCYB','https://open.spotify.com/intl-es/album/718kbp0LCMGFNG3JuEu0Th','https://music.apple.com/us/album/count-your-blessings/1485061858')
INSERT INTO ENLACES(Codigo) VALUES
('PTVCWTS'),
('BMTHSS'),
('TOPV'),
('ORG'),
('PMTIW'),
('BMTHCYB'),
('MCRTBP'),
('EF'),
('NNM'),
('HYPAS'),
('FOBTTTYG'),
('TOSS'),
('SWSWETSAETH'),
('TCNNTA'),
('TBDMN'),
('ADTRHS'),
('ALLTKWTTMO'),
('ADTRWSMFY'),
('TOPBF'),
('BMTHTTS'),
('UTDTKUS'),
('AASUAS'),
('ASAS'),
('CXCXB'),
('B182EOTS'),
('SSTC'),
('PTVSM'),
('TS1989'),
('BMTHS'),
('BT'),
('TSTTPD'),
('NIU'),
('CKYIDR'),
('LMA'),
('KFTL'),
('EPNMP'),
('SSMANS'),
('LCV'),
('BPD'),
('WWB'),
('AA'),
('CTETF'),
('PMR'),
('PPG'),
('CKYV1'),
('FOBABAP'),
('SWSM'),
('PTVMA'),
('PATDPFTW'),
('MNREEC')
DELETE FROM ENLACES WHERE Codigo = 'BMTHCYB'
SELECT * FROM INFO
SELECT * FROM ENLACES
SELECT * FROM ADMINS
DELETE FROM INFO
DROP TABLE INFO
DROP TABLE ENLACES