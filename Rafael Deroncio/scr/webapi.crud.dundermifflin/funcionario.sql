DROP TABLE IF EXISTS funcionarios;

CREATE TABLE funcionarios (
    id INTEGER PRIMARY KEY,
    nome TEXT,
    sobrenome TEXT,
    data_nascimento TEXT,
    endereco TEXT,
    salario REAL,
    cargo TEXT,
    departamento TEXT,
    data_contratacao TEXT
);

INSERT INTO funcionarios (nome, sobrenome, data_nascimento, endereco, salario, cargo, departamento, data_contratacao)
VALUES
    ('Michael', 'Scott', '1964-03-15', 'Scranton, Pensilvânia', 5000.00, 'Gerente Regional', 'Gerência', '2004-03-24'),
    ('Jim', 'Halpert', '1978-10-01', 'Scranton, Pensilvânia', 3500.00, 'Vendedor', 'Vendas', '2001-09-01'),
    ('Pam', 'Beesly', '1979-03-25', 'Scranton, Pensilvânia', 3200.00, 'Recepcionista', 'Administrativo', '2002-06-01'),
    ('Dwight', 'Schrute', '1968-01-20', 'Scranton, Pensilvânia', 4000.00, 'Vendedor', 'Vendas', '2003-02-01'),
    ('Angela', 'Martin', '1971-06-25', 'Scranton, Pensilvânia', 3500.00, 'Contadora', 'Finanças', '2001-06-01'),
    ('Kevin', 'Malone', '1968-05-04', 'Scranton, Pensilvânia', 3000.00, 'Contador', 'Finanças', '2003-04-01'),
    ('Oscar', 'Martinez', '1970-11-14', 'Scranton, Pensilvânia', 3800.00, 'Contador', 'Finanças', '2002-03-01'),
    ('Stanley', 'Hudson', '1958-02-19', 'Scranton, Pensilvânia', 3800.00, 'Vendedor', 'Vendas', '2001-09-01'),
    ('Creed', 'Bratton', '1943-02-08', 'Scranton, Pensilvânia', 2500.00, 'Qualquer coisa', 'Diversos', '2003-09-01'),
    ('Andy', 'Bernard', '1973-07-22', 'Scranton, Pensilvânia', 3800.00, 'Vendedor', 'Vendas', '2004-09-01'),
    ('Toby', 'Flenderson', '1968-02-24', 'Scranton, Pensilvânia', 3500.00, 'Recursos Humanos', 'Recursos Humanos', '2005-02-01'),
    ('Ryan', 'Howard', '1979-03-05', 'Scranton, Pensilvânia', 3200.00, 'Estagiário', 'Administrativo', '2006-06-01'),
    ('Kelly', 'Kapoor', '1980-02-05', 'Scranton, Pensilvânia', 3000.00, 'Representante de Atendimento', 'Vendas', '2005-06-01'),
    ('Meredith', 'Palmer', '1962-05-12', 'Scranton, Pensilvânia', 3000.00, 'Fornecedor de suprimentos', 'Diversos', '2001-02-01'),
    ('Phyllis', 'Lapin', '1951-07-15', 'Scranton, Pensilvânia', 3500.00, 'Vendedora', 'Vendas', '2002-04-01'),
    ('Erin', 'Hannon', '1986-03-10', 'Scranton, Pensilvânia', 3200.00, 'Recepcionista', 'Administrativo', '2008-09-01'),
    ('Holly', 'Flax', '1971-09-25', 'Scranton, Pensilvânia', 3800.00, 'Representante de Recursos Humanos', 'Recursos Humanos', '2008-11-01'),
    ('David', 'Wallace', '1965-06-20', 'Nova York', 7000.00, 'CEO', 'Gerência', '2001-01-01'),
    ('Jan', 'Levinson', '1966-04-04', 'Nova York', 5500.00, 'Vice-presidente de Vendas', 'Gerência', '2002-01-01'),
    ('Karen', 'Filippelli', '1978-08-16', 'Stanford, Connecticut', 4000.00, 'Representante de Vendas', 'Vendas', '2005-06-01'),
    ('Roy', 'Anderson', '1972-09-15', 'Scranton, Pensilvânia', 3200.00, 'Vendedor', 'Vendas', '2001-01-01'),
    ('Darryl', 'Philbin', '1971-11-15', 'Scranton, Pensilvânia', 3800.00, 'Encarregado de Armazém', 'Logística', '2001-01-01'),
    ('Creed', 'Bratton', '1943-02-08', 'Scranton, Pensilvânia', 3000.00, 'Qualquer coisa', 'Diversos', '2001-01-01'),
    ('Gabe', 'Lewis', '1982-08-23', 'Scranton, Pensilvânia', 3500.00, 'Diretor de Desenvolvimento de Produtos', 'Produção', '2009-01-01'),
    ('Nellie', 'Bertram', '1970-12-01', 'Londres, Inglaterra', 4000.00, 'Diretora Regional', 'Gerência', '2011-01-01'),
    ('Robert', 'California', '1965-11-17', 'Los Angeles, Califórnia', 8000.00, 'CEO', 'Gerência', '2011-01-01'),
    ('Clark', 'Green', '1987-03-28', 'Scranton, Pensilvânia', 3200.00, 'Estagiário', 'Administrativo', '2012-01-01'),
    ('Pete', 'Miller', '1990-09-19', 'Scranton, Pensilvânia', 3000.00, 'Representante de Vendas', 'Vendas', '2013-01-01'),
    ('Val', 'Johnson', '1989-05-07', 'Scranton, Pensilvânia', 3200.00, 'Recepcionista', 'Administrativo', '2013-01-01'),
    ('Gabe', 'Lewis', '1982-08-23', 'Scranton, Pensilvânia', 3500.00, 'Diretor de Desenvolvimento de Produtos', 'Produção', '2013-01-01');
