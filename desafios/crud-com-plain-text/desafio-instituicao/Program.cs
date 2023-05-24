using desafio_instituicao.controllers;

do
{
    try
    {
        Dashboard.Inicio();
        Dashboard.Menu();
    }
    catch (System.Exception ex)
    {
        throw new Exception(ex.Message);
    }

} while (true);