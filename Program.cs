Autor a1 = new Autor("Alonso", "Brasileiro");
a1.mostrarInfo();

Livro livro1 = new Livro("Livro12", a1, 20.50);
livro1.mostrarInfo();
livro1.aplicarDesconto(10.0);
livro1.mostrarInfo();
livro1.aplicarDesconto(10);
livro1.mostrarInfo();