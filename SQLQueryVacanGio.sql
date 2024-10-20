CREATE TABLE Destinazione (
	idDestinazione INT PRIMARY KEY IDENTITY (1,1),
	codDestinazione VARCHAR(50) UNIQUE NOT NULL,
	nome VARCHAR ( 250 ) NOT NULL,
	descrizione TEXT,
	paese VARCHAR (250),
	imgUrl VARCHAR(250)NOT NULL,

);

CREATE TABLE PacchettoVacanza(
	idPacchetto INT PRIMARY KEY IDENTITY(1,1),
	codPacchetto VARCHAR (50) NOT NULL,
	nome VARCHAR ( 250 ) NOT NULL,
	prezzo DECIMAL (8,2) NOT NULL CHECK (prezzo >0),
	durata INT DEFAULT 0,
	dataInizio DATE,
	dataFine DATE,
);
CREATE TABLE Destinazione_Pacchetto(
	 destinazionePacchettoId INT PRIMARY KEY IDENTITY(1,1),
	 destinazioneRiff INT NOT NULL,
	 pacchettoRiff INT NOT NULL,
	 
	 FOREIGN KEY (destinazioneRiff) REFERENCES Destinazione(idDestinazione) ON DELETE CASCADE,
	 FOREIGN KEY (pacchettoRiff) REFERENCES PacchettoVacanza(idPacchetto) ON DELETE CASCADE,
	 UNIQUE (destinazioneRiff,pacchettoRiff)

); 
CREATE TABLE Recensione(
	idRecensione INT PRIMARY KEY IDENTITY(1,1),
	codRecensione VARCHAR (50)NOT NULL,
	nomeUtente VARCHAR (250) NOT NULL,
	voto INT CHECK (voto BETWEEN 1 AND 5),
	commento TEXT,
	dataRecensione DATE,
	pacchettoRiff INT NOT NULL,
	FOREIGN KEY (pacchettoRiff) REFERENCES PacchettoVacanza(idPacchetto) ON DELETE CASCADE,
	UNIQUE (nomeUtente,pacchettoRiff)
);

INSERT INTO Destinazione (codDestinazione, nome, descrizione, paese, imgUrl)
VALUES 
('D001', 'Roma', 'Città eterna, ricca di storia e cultura.', 'Italia', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D002', 'Parigi', 'La città romantica e delle luci.', 'Francia', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D003', 'Londra', 'Capitale del Regno Unito, ricca di musei e parchi.', 'Regno Unito', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D004', 'Tokyo', 'Famosa per la sua modernità e la cultura antica.', 'Giappone', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D005', 'New York', 'La città che non dorme mai.', 'USA', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D006', 'Barcellona', 'Città famosa per la sua arte e architettura di Gaudí.', 'Spagna', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D007', 'Dubai', 'Città moderna nel deserto con grattacieli iconici.', 'EAU', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D008', 'Sydney', 'Famosa per la sua Opera House e le spiagge.', 'Australia', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D009', 'Firenze', 'Culla del Rinascimento.', 'Italia', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU'),
('D010', 'Amsterdam', 'Famosa per i suoi canali e musei.', 'Paesi Bassi', 'https://fastly.picsum.photos/id/471/200/300.jpg?hmac=N_ZXTRU2OGQ7b_1b8Pz2X8e6Qyd84Q7xAqJ90bju2WU');


INSERT INTO PacchettoVacanza (codPacchetto, nome, prezzo, durata, dataInizio, dataFine)
VALUES 
('PAC001', 'Weekend Europeo', 350.50, 3, '2024-05-01', '2024-05-04'),
('PAC002', 'Settimana della moda', 1200.99, 7, '2024-06-10', '2024-06-17'),
('PAC003', 'Tokyo moderno e antico', 2000.00, 10, '2024-07-20', '2024-07-30'),
('PAC004', 'Tour di New York', 1500.75, 5, '2024-08-05', '2024-08-10'),
('PAC005', 'Vacanze Orientali', 1800.25, 8, '2024-09-01', '2024-09-09'),
('PAC006', 'Storia e cultura Europea', 900.60, 4, '2024-04-15', '2024-04-19'),
('PAC007', 'Esplora Londra', 1100.40, 5, '2024-10-10', '2024-10-15'),
('PAC008', 'Carnevale a Rio', 2500.99, 7, '2024-02-20', '2024-02-27'),
('PAC009', 'Arte e architettura Europea', 950.30, 5, '2024-03-05', '2024-03-10'),
('PAC010', 'Tour Antichità Greco Romana', 1400.50, 6, '2024-11-01', '2024-11-07');

-- Pacchetto 'Weekend Europeo' collega Roma, Parigi e Londra
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(1, 1), -- Roma
(2, 1), -- Parigi
(3, 1); -- Londra

-- Pacchetto 'Settimana della moda' collega Parigi e Milano (Milano può essere aggiunta in futuro se necessario)
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(2, 2); -- Parigi

-- Pacchetto 'Tokyo moderno e antico' collega Tokyo e Dubai
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(4, 3), -- Tokyo
(7, 3); -- Dubai

-- Pacchetto 'Tour di New York' collega New York e Londra
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(5, 4), -- New York
(3, 4); -- Londra

-- Pacchetto 'Vacanze Orientali' collega Tokyo e Dubai
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(4, 5), -- Tokyo
(7, 5); -- Dubai

-- Pacchetto 'Storia e cultura Europea' collega Roma, Parigi e Londra
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(1, 6), -- Roma
(2, 6), -- Parigi
(3, 6); -- Londra

-- Pacchetto 'Esplora Londra' collega Londra
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(3, 7); -- Londra

-- Pacchetto 'Carnevale a Rio' può avere una nuova destinazione in futuro, nessuna collegata ora

-- Pacchetto 'Arte e architettura Europea' collega Firenze e Barcellona
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(9, 9), -- Firenze
(6, 9); -- Barcellona

-- Pacchetto 'Tour Antichità Greco Romana' collega Roma e Atene (potresti aggiungere Atene in futuro)
INSERT INTO Destinazione_Pacchetto (destinazioneRiff, pacchettoRiff)
VALUES 
(1, 10); -- Roma

-- Recensioni per il pacchetto 'Weekend Europeo' (pacchettoRiff = 1)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R001', 'Luca Rossi', 5, 'Esperienza fantastica, le città erano bellissime e ben organizzate!', '2024-05-10', 1),
('R002', 'Maria Verdi', 4, 'Ottimo tour, ma avrei preferito più tempo a Parigi.', '2024-05-15', 1);

-- Recensioni per il pacchetto 'Settimana della moda' (pacchettoRiff = 2)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R003', 'Giulia Bianchi', 5, 'Un sogno diventato realtà! Parigi durante la settimana della moda è magica.', '2024-06-20', 2),
('R004', 'Alessandro Neri', 4, 'Ottimo viaggio, ma un po’ costoso.', '2024-06-25', 2);

-- Recensioni per il pacchetto 'Tokyo moderno e antico' (pacchettoRiff = 3)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R005', 'Sara Gallo', 5, 'Tokyo è incredibile, un perfetto mix di antico e moderno!', '2024-08-01', 3),
('R006', 'Davide Ferrari', 4, 'Bella esperienza, ma troppo poco tempo a Tokyo.', '2024-08-03', 3);

-- Recensioni per il pacchetto 'Tour di New York' (pacchettoRiff = 4)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R007', 'Claudia Marino', 5, 'New York è pazzesca! Viaggio ben organizzato.', '2024-08-15', 4),
('R008', 'Francesco Russo', 3, 'Bellissima città, ma avrei preferito più giorni.', '2024-08-18', 4);

-- Recensioni per il pacchetto 'Vacanze Orientali' (pacchettoRiff = 5)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R009', 'Elena Conti', 5, 'Un viaggio da sogno! Tokyo e Dubai erano incredibili.', '2024-09-15', 5),
('R010', 'Marco Esposito', 4, 'Ottimo viaggio, ma troppo caldo a Dubai.', '2024-09-20', 5);

-- Recensioni per il pacchetto 'Storia e cultura Europea' (pacchettoRiff = 6)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R011', 'Lucia Gallo', 5, 'Un tour fantastico tra Roma, Parigi e Londra.', '2024-04-20', 6),
('R012', 'Andrea Barone', 4, 'Bellissimo tour, ma un po’ affollato.', '2024-04-22', 6);

-- Recensioni per il pacchetto 'Esplora Londra' (pacchettoRiff = 7)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R013', 'Giovanni Rizzo', 5, 'Londra è stupenda, soprattutto i musei. Viaggio top!', '2024-10-20', 7),
('R014', 'Martina Bellini', 4, 'Ottima esperienza, ma il meteo non era il massimo.', '2024-10-25', 7);

-- Recensioni per il pacchetto 'Arte e architettura Europea' (pacchettoRiff = 9)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R015', 'Francesca Pini', 5, 'Firenze e Barcellona sono state meravigliose! Arte ovunque.', '2024-03-15', 9),
('R016', 'Antonio De Luca', 4, 'Tour ben organizzato, ma troppe camminate.', '2024-03-17', 9);

-- Recensioni per il pacchetto 'Tour Antichità Greco Romana' (pacchettoRiff = 10)
INSERT INTO Recensione (codRecensione, nomeUtente, voto, commento, dataRecensione, pacchettoRiff)
VALUES 
('R017', 'Sofia Greco', 5, 'Roma è fantastica, piena di storia. Un viaggio indimenticabile.', '2024-11-10', 10),
('R018', 'Lorenzo Bruni', 4, 'Bellissima esperienza, ma avrei preferito più giorni.', '2024-11-12', 10);


SELECT * FROM Destinazione 
JOIN Destinazione_Pacchetto ON Destinazione.idDestinazione =Destinazione_Pacchetto.destinazioneRiff
 JOIN PacchettoVacanza ON Destinazione_Pacchetto.pacchettoRiff=PacchettoVacanza.idPacchetto;


SELECT * FROM Destinazione;
SELECT * FROM PacchettoVacanza;
SELECT * FROM Destinazione_Pacchetto;
SELECT * FROM Recensione;





