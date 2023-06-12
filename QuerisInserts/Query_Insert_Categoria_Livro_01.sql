--Insert categorias e livros

INSERT INTO Livros (Titulo, AnoDePublicacao, ISBN)
VALUES  ('Panico', '2023-06-07 10:30:00 -07:00', '321654465'),
        ('Panico', '2023-06-07 10:30:00 -07:00', '321654465'),
        ('American Pie', '2023-06-07 10:30:00 -07:00', '1236547'),
        ('Lost', '2023-06-07 10:30:00 -07:00', '1236547'),
        ('Mario World', '2023-06-07 10:30:00 -07:00', '46879879'),
        ('Panico 2', '2023-06-07 10:30:00 -07:00', '79879789');

INSERT INTO Categorias(Nome)
VALUES ('Terror'),
        ('Humor'),
        ('Romance'),
        ('Avendtura');


INSERT INTO CategoriaLivro( LivrosLivroId, CategoriasCategoriaId)
VALUES (7,1),
       (3,4),
       (3,3),
       (6,4),
       (3,1),
       (4,1),
       (5,1),
       (5,3),
       (7,3);


