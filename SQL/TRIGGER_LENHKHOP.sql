ALTER TRIGGER [dbo].[TRIGGER_LENHKHOP]
ON [dbo].[LENHKHOP] AFTER INSERT
AS
DECLARE @MACP CHAR(7)
BEGIN
		SET @MACP = (SELECT a.MACP FROM LENHDAT a, inserted b WHERE a.ID = b.IDLENHDAT)
		UPDATE BANGGIATRUCTUYEN SET GIAKHOP = (SELECT GIAKHOP
				FROM inserted) WHERE BANGGIATRUCTUYEN.MACP = @MACP
		UPDATE BANGGIATRUCTUYEN SET KLKHOP = (SELECT SOLUONGKHOP FROM inserted) 
			WHERE BANGGIATRUCTUYEN.MACP = @MACP
END