----------------------------------------------------------------------------
------TblUrunler2 select iþlemi
create proc PrcTblUrunler_Select as begin
Select * from TblUrunler2
end

select * from TblUrunler
--ürün güncelleme iþlemi
alter proc PrcTblUrunler2_Update (@Barkod nvarchar(15), @UrunAdi nvarchar(50),@GelisFiyat money,@SatisFiyat money,@Stok int) 
as begin
update TblUrunler2 
set UrunAdi=@UrunAdi, GelisFiyat=@GelisFiyat, SatisFiyat=@SatisFiyat, Stok=Stok+@Stok 
where Barkod=@Barkod
end


--yeni ürün ekleme iþlemi
alter proc PrcTblUrunler2_Insert(@Barkod nvarchar(15), @UrunAdi nvarchar(50),@GelisFiyat money,@SatisFiyat money,@Stok int) 
as begin
insert into TblUrunler2 values(@Barkod,@UrunAdi,@GelisFiyat,@SatisFiyat,@Stok)
end

--kayýt eklerken stoktan ürün düþür.
--ürün alýndýðýnda veri tabanýnda kayýt tutuyoruz.
alter proc PrcTblIslemler_Insert
(@KulId tinyint,@islemtarih datetime,@urunid int,@barkod nvarchar(15),@adet int) as begin 
update TblUrunler2 set Stok=Stok-@adet where Barkod=@barkod
insert into TblIslemler values(@KulId,@islemtarih,@urunid,@adet)
end

select * from TblIslemler
select * from TblUrunler2

alter proc PrcTblIslemler_Select
as begin 
select islem.IslemId, kul.KulAd, islem.IslemTarih,urun.UrunAdi,urun.GelisFiyat,urun.SatisFiyat,islem.adet
from TblIslemler islem join TblUrunler2 urun on islem.UrunId=urun.UrunId join TblKullanici kul on kul.KulId=islem.KulId
end




create proc PrcTblUrunler2_Delete(@barkod nvarchar(15)) as begin
delete from TblUrunler2 where Barkod=@barkod
end


create proc PrcTblUrunler2_Update2 (
@Barkod nvarchar(15), 
@UrunAdi nvarchar(50),
@GelisFiyat money,
@SatisFiyat money,
@Stok int
) 
as begin
update TblUrunler2 
set UrunAdi=@UrunAdi, GelisFiyat=@GelisFiyat, SatisFiyat=@SatisFiyat, Stok=@Stok 
where Barkod=@Barkod
end

select * from TblKullanici