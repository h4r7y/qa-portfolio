#  Testfälle - Zeiterfassung Demo

##  TC-001 Zeit erfassen

**System:** <br>
Zeiterfassungs-Demo Anwendung

**Vorrausetzung:** <br>
Benutzer ist angemeldet

**Schritte:** <br>
1.  Zeiterfassung öffnen
2.  Datum auswählen
3.  Arbeitszeit eintragen
4.  Speichern klicken

**Erwartetes Ergebnis:** <br>
-  Eintrag wird gespeichert
-  Zeit erscheint in der Übersicht

---
## TC-002 - Zeiterfassung mit ungültiger Uhrzeit

**System:** <br>
Zeiterfassungs-Demo Anwendung

**Vorraussetzung:** <br>
-  Benutzer ist angemeldet
-  Zeiterfassung ist geöffnet
  
**Schritte:** <br>
1.  Datum auswählen
2.  Startzeit eingeben 16:00
3.  Endzeit eingeben 08:00
4.  Speichern klicken

**Erwartetes Ergebnis:** <br>
-  System erkennt die ungültige Zeitspanne
-  Fehlermeldung wird angezeigt
-  Eintrag wird nicht gespeichert

---
##  TC--003 - Zeiteintrag bearbeiten und speichern

**System:** <br>
Zeiterfassungs-Demo Anwendung

**Vorraussetzung:** <br>
-  Benutzer ist angemeldet
-  EIn Zeiteintrag existiert bereits

**Schritte:** <br>
1.  Vorhandenen Zeiteintrag öffnen
2.  Abreitszeit ändern (z.B von 8 Stunden auf 7 Stunden)

**Erwartetes Ergebnis:** <br>
-  Zeiteinträge öffnen sich
-  Arbeitszeit wird geändert
