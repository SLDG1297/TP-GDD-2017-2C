CREATE TRIGGER dbo.HashUsuariosPassword
ON dbo.Usuario
INSTEAD OF INSERT
AS
BEGIN

  INSERT dbo.Usuario(username, contraseņa, habilitado)
    SELECT username, HASHBYTES('SHA2_256', contraseņa), habilitado
    FROM inserted;

END