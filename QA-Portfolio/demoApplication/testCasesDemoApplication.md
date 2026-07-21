# Login Test Cases

##  TC-001 : Erfolgreicher Login

**Testziel:**
Prüfen, ob ein Benutzer sich mit gültigen Zugangsdaten anmelden kann.

**Vorbedingungen:**
- Benutzer existiert in der Datenbank 
- Login-Seite ist erreichbar

**Testdaten:**
- Email: test@test.com </br>
- Passwort: 1234

**Testschritte:**
1. Login-Seite öffnen
2. Email eingeben
3. Passwort eingeben
4. Login Button klicken

**Erwartetes Ergebnis:**
- Benutzer wird erfolgreich angemeldet
- Meldung "Login erfolgreich" wird angezeigt

**Status:**
[x] Passed

## TC-002 : Login mit falschem Passwort

**Testziel:**
Prüfen, ob das System einen Login mit falschen Passwort ablehnt.

**Vorbedingungen:**
- Benutzer ist in der Datenbank vorhanden
- Login-Seite ist erreichbar

**Testdaten:**
- Email: test@test.com
- Passwort: falsch123

**Testschritte:**
1. Login-Seite öffnen
2. Gültige E-mail-Adresse eingeben
3. Falsches Passwort eingeben
4. Login Button klicken

**Erwartetes Ergebnis:**
- Login wird abgelehnt
- Eine Fehlermeldung wird angezeigt
- Benutzer wird nicht eingeloggt

**Tatsächles Ergebnis:**
- Wird nach Testdurchführung eingetragen

**Status:**
[ ] Open

## TC-003 : Login mit leeren Eingabefeldern

**Testziel:**
Prüfen, ob das System einen Login verhindert, wenn Email und Passwort nicht eingegeben werden.

**Vorbedingungen:**
- Login-Seite ist erreichbar

**Testdaten:**
- Email: leer
- Passwort: leer

**Testschritte:**
1. Login-Seite öffnen
2. Email-Feld leer lassen
3. Passwort-Feld leer lassen
4. Login Button klicken

**Erwartetes Ergebnis:**
- Der Login wird nicht durchgeführt
- Eine Fehlermeldung wird angzeigt
- Der Benutzer bleibt auf der Login-Seite

**Tatsächliches Ergebnis:**
- Wird nach der Testdurchführung eingetragen

**Status:**
[ ] Open

##  Enviroment
- Browser: Chrome
- Framework: Playwright
- Language: C#
- Database: SQLite
- OS macOS