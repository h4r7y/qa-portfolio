#  Testfälle - Zeiterfassung Demo

##  TC-001 Zeit erfassen

**System:**
Zeiterfassungs-Demo Anwendung

**Vorrausetzung:**
Benutzer ist angemeldet

**Schritte:**
1.  Zeiterfassung öffnen
2.  Datum auswählen
3.  Arbeitszeit eintragen
4.  Speichern klicken

**Erwartetes Ergebnis:**
-  Eintrag wird gespeichert
-  Zeit erscheint in der Übersicht

---
## TC-002 - Zeiterfassung mit ungültiger Uhrzeit

**System:**
Zeiterfassungs-Demo Anwendung

**Vorraussetzung:**
-  Benutzer ist angemeldet
-  Zeiterfassung ist geöffnet
  
**Schritte:**
1.  Datum auswählen
2.  Startzeit eingeben 16:00
3.  Endzeit eingeben 08:00
4.  Speichern klicken

**Erwartetes Ergebnis:**
-  System erkennt die ungültige Zeitspanne
-  Fehlermeldung wird angezeigt
-  Eintrag wird nicht gespeichert

---
##  TC--003 - Zeiteintrag bearbeiten und speichern

**System:**
Zeiterfassungs-Demo Anwendung

**Vorraussetzung:**
-  Benutzer ist angemeldet
-  EIn Zeiteintrag existiert bereits

**Schritte:**
1.  Vorhandenen Zeiteintrag öffnen
2.  Abreitszeit ändern (z.B von 8 Stunden auf 7 Stunden)
