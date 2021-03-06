# Anforderungen Lagerliste

## Produkte

- [x] Produkt speichern:
	Produkt wird mit Name, Kosten, Details, Kategorie und Anzahl in die (DB) eingespeichert

- [x] Benötigte Attribute sind nicht angegeben worden:
	Messagefenster weißt auf die benötigten Attribute hin (Name, kosten, Kategorie, Anzahl), zudem werden Textfelder der fehlenden attribute eingefärbt

- [x] Produktname ist bereits vorhanden:
	Messagefenster weißt darauf hin das es bereits ein Produkt mit dem eingegebenen Namen gibt. 
	Entweder Löschung des vorhandenen Produkts oder anderer Name.
	Produkte dürfen in allen Attributen außer dem Namen identisch sein.

- [x] Produkte entfernen: 
	Produkt wird aus der Produktliste und aus der DB entfernt.

- [x] Kategorie nicht vorhanden
	Falls kategorie aufgrund eines Netzwerkfehlers nicht richtig aus der DB ausgelesen wurde wird Produktliste aktualisiert

- [x] Produkt bearbeiten:
	Produkt wird in der vorhandenen Maske zur hinzufügung eines Produktes eingesetzt.

## Kategorien

- [x] Kategorie in Produktliste löschen: 
	Kategorien und Produkte können nur in ihren jeweiligen Listen gelöscht oder bearbeitet werden

- [x] Kategorie speichern:
	Kategorie wird mit Name und Farbe in DB eingespeichert

- [x] Kein Kategoriename
	Eingabeaufforderung für Kategoriename wird angezeigt

- [x] Kategorie entfernen:
	Kategorie wird aus DB entfernt
	
- [x] Produkte sind dieser Kategorie zugeordnet
	Fenster mit Hinweis darauf das noch Produkte mit dieser Kategorie versehen sind
	Kategorien müssen leer sein um sie löschen zu können
	
- [x] Kategorie bearbeiten:
	Nur Name und Farbe der Kategorie ist bearbeitbar
