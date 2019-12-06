--ürün listeleme sorgusu
create proc PrcUrunListele as begin
Select * from TblUrunler
end

alter proc PrcUrunEkle(
@Barkod nvarchar(15),
@UrunAdi nvarchar(50),
@Fiyat money) as begin
insert into TblUrunler values(@Barkod,@UrunAdi,@Fiyat)
end
