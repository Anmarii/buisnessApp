#  Cyberbezpieczeństwo aplikacji / Anwendungssicherheit

Projekt zawiera szereg zabezpieczeń zgodnych z zasadami bezpiecznego projektowania aplikacji webowych i zgodności z RODO.  
Das Projekt enthält Sicherheitsfunktionen gemäß den Prinzipien sicherer Webentwicklung und DSGVO-Konformität.

## Uwierzytelnianie i autoryzacja / Authentifizierung und Autorisierung
- Logowanie z haszowaniem (bcrypt)  
  Passwort-Hashing mit bcrypt
- Role: admin, manager, pracownik, klient  
  Benutzerrollen: Admin, Manager, Mitarbeiter, Kunde
- Kontrola dostępu na poziomie kontrolerów  
  Zugriffskontrolle auf Controller-Ebene

## Bezpieczeństwo danych / Datenschutz
- Parametryzowane zapytania (ORM)  
  Parametrisierte Datenbankabfragen
- Walidacja danych wejściowych  
  Validierung der Eingabedaten
- Szyfrowanie danych wrażliwych  
  Verschlüsselung sensibler Daten

## RODO i prywatność / DSGVO & Datenschutz
- Zgody użytkownika (checkbox + zapis w bazie)  
  Einwilligungserklärungen (Checkbox + Speicherung)
- Prawo do usunięcia danych (endpoint DELETE)  
  Recht auf Vergessenwerden
- Logowanie operacji (audyt zmian)  
  Änderungsprotokollierung (Audit Trail)

## Ciągłość działania / Betriebskontinuität
- Codzienne backupy lokalne  
  Tägliche lokale Backups
- System logowania błędów i alertów  
  Fehler- und Alarmlogging
- Zabezpieczenie przed brute-force (limit logowań)  
  Brute-Force-Schutz (Login-Limitierung)

## Testowanie i aktualizacje / Tests und Updates
- Manualne testy penetracyjne endpointów  
  Manuelle Penetrationstests der Endpunkte
- Wersjonowanie API  
  API-Versionierung
- Plan aktualizacji i łatek bezpieczeństwa  
  Update- und Patchplan
