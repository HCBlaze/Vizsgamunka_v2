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

Projekt lemásolása (Clone)

```bash
git@github.com:HCBlaze/Vizsgamunka_v2.git

```
Navigálás a webes alkalmazás mappába

```bash
cd Webes alkalmazss

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

- Az alkalmazás úgy írtam meg hogy helyi gépen kell futatni egy mysql adatbázist aminek a felhasználóneve root kell hogy legyen és nem lehet jelszava.

		Paraméterek:

		server=localhost
		port=3306
		database=local_store_project_23
		user=root

		ha más beállításokat használunk az alakalmazás nem fog működni.

		Az adatbázist nem kell létrehozni, a mellékelt .sql fájlt be importálva létrehozza az adatbázist, a táblákat és a teszt adatokat is!


- Telepítő (.exe) futtatása
- Ahhoz hogy a program minden funkciója működjön MS Office -ra és egy .pdf megtekintő programra is szükség lesz.
---

Készítette:
Csóbor Sándor Erik
