create procedure uspDistritosList
as
begin
	select dis.distrito_id, dis.nombre from Distritos dis
end

--exec uspDistritosList