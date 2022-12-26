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

### Indítás weboldal

A projektet a C: meghajtóra kell másolni mivel csak így fogja tudni kezelni a képeket az alkalmazás. Másold ki az alábbi parancsot és létrejön a mappaszerkezet

```bash
cd c:
mkdir laragon\www\Vizsgamunka_23_v2\Vizsgamunka_v2\

```

Projekt lemásolása (Clone)(A fent létrehozott mappába kell lemásolni!!!)

```bash
git@github.com:HCBlaze/Vizsgamunka_v2.git

```
NPM feltelepítése 

```bash
npm install

```

Szerver elindítása

```bash
npm start

```	

### Asztali alkalmazás indítása

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
