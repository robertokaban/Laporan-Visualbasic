create database db_akademik

use db_akademik

create table tb_mahasiswa(nim char(7) primary key not null,
nama varchar(50), jenis_kelamin varchar(9), alamat text, no_telp varchar(13))

insert into tb_mahasiswa values('1702001','Alfa Bravo','Laki-Laki','Jl. Jamin Ginting No.258 Medan','081260329842')
insert into tb_mahasiswa values('1702002','Juliet Delta Echo','Perempuan','Jl. Jamin Ginting No.258 Medan','081260000002')
insert into tb_mahasiswa values('1702003','Foxtrot Gamma','Laki-Laki','Jl. Jamin Ginting No.258 Medan','081260000001')

create table tb_matakuliah(kode_mk char(7) primary key not null,
nama_mk varchar(35), jlh_sks char(1))

insert into tb_matakuliah values('MKK101','Logika dan Algoritma Pemrograman','4') 
insert into tb_matakuliah values('MKK102','Pemrograman Web I','4') 
insert into tb_matakuliah values('MKK103','Pemrograman Visual I','4')

create table tb_dosen(nidn char(13) primary key not null,nama_dosen varchar(35),
jenis_kelamin varchar(9), alamat text)

insert into tb_dosen values ('1234567890001','Roberto Kaban','Laki-laki','Jl. Jamin Ginting No. 10 Medan')
insert into tb_dosen values ('1234567890002','Feodora Ovalyn K','Laki-laki','Jl. Jamin Ginting No. 11 Medan')
insert into tb_dosen values ('1234567890003','Freeze AD K','Perempuan','Jl. Jamin Ginting No. 11 Medan')

create table tb_perkuliahan(id int identity(1,9) primary key not null,
nidn char(13) foreign key references tb_dosen(nidn),
kode_mk char(7) foreign key references tb_matakuliah(kode_mk),
hari char(10), jam char(15), ruangan char(15))

insert into tb_perkuliahan values('1234567890001','MKK101','Senin','09.00 - 12.00','Lab. 1')
insert into tb_perkuliahan values('1234567890001','MKK102','Selasa','09.00 - 12.00','Lab. 2')
insert into tb_perkuliahan values('1234567890002','MKK101','Rabu','09.00 - 12.00','Lab. 1')


create view vw_perkuliahan 
(nidn,nama_dosen,kode_mk,nama_mk,hari,jam,ruangan) as
select tb_dosen.nidn, tb_dosen.nama_dosen,
tb_matakuliah.kode_mk,tb_matakuliah.nama_mk,
tb_perkuliahan.hari,tb_perkuliahan.jam,tb_perkuliahan.ruangan 
from tb_dosen,tb_matakuliah, tb_perkuliahan
where tb_dosen.nidn=tb_perkuliahan.nidn and 
tb_matakuliah.kode_mk=tb_perkuliahan.kode_mk


select * from tb_mahasiswa
select * from tb_matakuliah
select * from tb_dosen
select * from tb_perkuliahan
select * from vw_perkuliahan

exec sp_columns tb_dosen



