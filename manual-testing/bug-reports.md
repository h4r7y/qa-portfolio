#  Bug Reports - Zeiterfassungs-Demo

##  Bug-001 - Speichern-Button ohne Funktion

System:
Zeiterfassungs-Demo Anwendung

Titel:
Speichern-Button ohne Funktion

Umgebung:
Browser:Chrome

Voraussetzung:
- Benutzer ist angemeldet
- Zeiterfassung ist geöffnet

Schritte:
1.  Zeit eintragen
2.  Speichern klicken

Erwartetes Ergebnis:
-  Eintrag wird gespeichert

Tatsächliches Ergebnis:
-  Keine Speicherung

Schweregrad:
High

Status:
Open



## Bug-002 - Speichern ohne Arbeitszeit möglich

System:
Zeiterfassungs-Demo Anwendung

Titel:
Zeiteintrag kann ohne Arbeitszeit gespeichert werden

Umgebung:
Browser:Safari

Voraussetzung:
-  Benutzer ist angemeldet
-  Zeiterfassung ist geöffnet

Schritte:
1.  Neues Zeitfenster öffnen
2.  Keine Start- und Endzeit eingeben
3.  Speichern klicken

Erwartetes Ergebnis:
- System zeigt eine Fehlermeldung
- Eintrag wird nicht gespeichert

Tatsächliches Ergebnis:
-  Leerer Eintrag wird gespeichert

Schweregrad:
Medium

Status:
Open


##  Bug-003 - Ungültige Zeitspanne wird akzeptiert

System:
Zeiterfasssungs-Demo Anwendung

Titel:
Endzeit liegt vor Startzeit

Umgebung:
Browser:Firefox

Voraussetzung:
-  Benutzer ist angemeldet

Schritte:
1.  Startzeit 16:00 eingeben
2.  Endzeit 08:00 eingeben
3.  Speichern klicken

Erwartetes Ergebnis:
-  Fehlermeldung erscheint
-  Speicherung wird verhindert

Tatsächliches Ergebnis:
-  Eintrag wird gespeichert

Schweregrad:
High

Status:
Open

