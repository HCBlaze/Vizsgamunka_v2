# Local Store project '23
	Vizsgamunka laravel/react + c# asztali alkalmazás
	Egy kis bolt üzemeltetésének könnyítés érdekében gondoltam ki egy Weboldalt és egy asztali alkalmazást.
	Egyenlőre a Weboldal egy online shop, késöbbiekben akár teljesen kiválthatja az asztali alkalmazást is.
	Az asztali alkalmazás végzi a bolt igazgatását.(Felhasználó kezelés, Termékek kezelése, Beszállítók, stb...).
	
---
### Használt programok és csomagok

- Visual Studio 2022
- PhStorm
- MySQL Workbench
- MS Office
- Laragon
- Pichon
- DevToys
- ColorPicker
- laravel
- react
- react-router-dom
- react-bootstrap
- bootstrap
- styled
- react-phone-number-input
- @emailjs/browser

### Indítás weboldal

A projektet a C: meghajtóra kell másolni mivel csak így fogja tudni kezelni a képeket az alkalmazás. Másold ki az alábbi parancsot és létrejön a mappaszerkezet

```bash
cd c:

```

```bash
mkdir laragon\www\Vizsgamunka_23_v2\Vizsgamunka_v2\

```

Projekt lemásolása (Clone) (A fent létrehozott mappába kell lemásolni!!!)

```bash
git@github.com:HCBlaze/Vizsgamunka_v2.git

```

Ezután elnavigálunk a Webes alklamazás mappába
```bash
cd "Webes alkalmazas"

```
A webes alkalmazás mappában található egy .env fájl itt kell megadni az adatbázissal kapcsolatos adatokat! (pl. jelszó)

NPM feltelepítése 

```bash
npm install

```

Szerver elindítása(én Laragon -t használtam)

Webböngészőben padig a localhoston elérhető az oldal vagy a Vizsgamunka_23_v2.test címen.

### Asztali alkalmazás indítása
Szükséges hogy a fent is említett mappaszerkezetben bent legyen ez a git repository (c:\laragon\www\Vizsgamunka_23_v2\Vizsgamunka_v2\) csak így találja meg a képeket a program.

Alkalmazás telepítőjének letöltése(dokumentáció is itt található)

```bash
https://drive.google.com/drive/folders/1BQWhsgn9oQfvIUHINSO070bKsUlLN8hx?usp=sharing

```	
- Mappában mellékelt fontok telepítése
- Az alkalmazás úgy írtam meg hogy helyi gépen kell futatni egy mysql adatbázist.
- Az adatbázist nem kell létrehozni, a mellékelt .sql fájlt be importálva létrehozza az adatbázist, a táblákat és a teszt adatokat is!
- Telepítő (.exe) futtatása
- A telepítés után be kell állítani a helyi mysql adatokat. A program könytárában van egy connectionString.txt fájl itt kell a megfelelő adatokat átírni.
- Ezután indíthatjuk a programot.
- Ahhoz hogy a program minden funkciója működjön MS Office -ra és egy .pdf megtekintő programra is szükség lesz.
---

Készítette:
Csóbor Sándor Erik
