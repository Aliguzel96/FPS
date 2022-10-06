# FPS
First Person Shoot kapsamında sahne kurulumu Standart Assetts yardımıyla yapıldı,
Karakterin ateş etmesi için Raycast metodları kullanıldı;
Raycastin çıkış hedefi elle ayarlanmak yerine obje içerisinde bulunan kamera seçildi böylelikle kameranın tam orta noktasına bir ışın gönderilmiş oldu
Bu yöntemle ışın gönderme işlemi hedefi tam noktasından vurdu ve isabetsizlik durumu ortadan kalktı
Yine ekranın hemen ortasında beliren crossHair Canvas UI - Anchor - Center yardımıyla konumlandırıldı
Hem ışının hem de cross hair'in aynı noktada bulunması, istediğimiz isabeti ve görsel tutarlılığı sağladı
Silahın hemen uç noktasına hazır bir patlama efekti eklendi ve silah scriptinde yer alan mouse0 anahtar.Key'ine ilişkilendirildi
Silaha ateş etme efekti dışarıdan eklendi çalışılabilirliği için;
  -nesneye bir AudioSource eklendi ve buraya indirilen ses atandı,
  -daha sonra bu audio source scripte public olarak eklenmiş kısma verildi
  -yine ateş edildiğinde çalışması için belirtilen fonksiyonda mouse0 butonuna ilişkilendirildi ve Play() edildi.
