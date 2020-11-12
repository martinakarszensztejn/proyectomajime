# PRIMER CONSULTA PRIORIZADA

SELECT cliente.ci_cliente, mascota.num_mascota, mascota.nombre_mascota, mascota.raza_mascota, mascota.fnac_mascota, mascota.sexo_mascota, mascota.peso_mascota FROM cliente , pertenece , mascota
WHERE ((pertenece.ci_cliente = cliente.ci_cliente) 
AND (pertenece.num_mascota = mascota.num_mascota)) ORDER BY nombre_mascota; 

# SEGUNDA CONSULTA PRIORIZADA

SELECT DISTINCT hospeda.num_reserva, hospeda.momento_reserva, curdate(), hospeda.ci_oficinista, hospeda.ci_gerente, mascota.num_mascota, cliente.ci_cliente FROM hospeda,mascota,cliente,pertenece 
WHERE ((((cliente.ci_cliente = pertenece.ci_cliente) AND (mascota.num_mascota = pertenece.num_mascota)) AND mascota.num_mascota = hospeda.num_mascota)
AND datediff(curdate(),hospeda.momento_reserva) >= 1) AND (hospeda.estado_reserva = 'En Pie')
ORDER BY num_reserva ASC
;

# TERCERA CONSULTA PRIORIZADA

SELECT num_reserva,ci_gerente,ci_oficinista,momento_reserva,momento_arribo_reserva,momento_partida_reserva,precio_reserva FROM hospeda WHERE 
(month(curdate()) <> 12 AND (month(curdate())+1)=month(momento_arribo_reserva)) XOR  (month(momento_arribo_reserva)=1 AND month(curdate()) = 1)
;

# CUARTA CONSULTA PRIORIZADA 

SELECT mascota.num_mascota,mascota.nombre_mascota,mascota.peso_mascota,hospeda.num_hab,telefono_cliente,nombre_cliente,celular_cliente FROM hospeda,mascota,cliente,pertenece
WHERE
((mascota.num_mascota=hospeda.num_mascota) AND (hospeda.nombre_tipo_habitacion = 'Mini Suite') AND (mascota.peso_mascota > 12))
 AND (mascota.num_mascota = pertenece.num_mascota AND pertenece.ci_cliente = cliente.ci_cliente)
;

# QUINTA CONSULTA PRIORIZADA 

SELECT  count(num_reserva) AS resultado FROM hospeda WHERE
datediff(curdate(), momento_arribo_reserva)>0 AND datediff(curdate(), momento_partida_reserva) < 0
UNION ALL
SELECT nombre_tipo_habitacion AS ada FROM hospeda WHERE
datediff(curdate(), momento_arribo_reserva)>0 AND datediff(curdate(), momento_partida_reserva) < 0

;

# SEXTA CONSULTA PRIORIZADA 

SELECT  cuesta.nombre_tipo_habitacion,precio.* FROM precio,cuesta 
WHERE cuesta.num_precio = precio.num_precio ORDER BY nombre_tipo_habitacion;

# SEPTIMA CONSULTA PRIORIZADA

SELECT DISTINCT cliente.ci_cliente, datediff(hospeda.momento_partida_reserva,hospeda.momento_arribo_reserva)
FROM pertenece,cliente,recibe,hospeda,mascota
WHERE
((((pertenece.ci_cliente=cliente.ci_cliente) AND (mascota.num_mascota = pertenece.num_mascota)) AND pertenece.num_mascota = hospeda.num_mascota)) GROUP BY cliente.ci_cliente

;

# OCTAVA CONSULTA PRIORIZADA


SELECT mascota.num_mascota,mascota.nombre_mascota,cliente.ci_cliente,cliente.nombre_cliente  FROM hospeda,pertenece,mascota,cliente WHERE
((mascota.num_mascota = pertenece.num_mascota) AND (pertenece.ci_cliente = cliente.ci_cliente)) AND hospeda.num_mascota=pertenece.num_mascota
 AND((
datediff(curdate(), momento_arribo_reserva)>0 )AND( datediff(curdate(), momento_partida_reserva) < 0)) GROUP BY ci_cliente
;

# NOVENA CONSULTA PRIORIZADA 

SELECT medicacion.*,consume.num_mascota,mascota.nombre_mascota FROM consume,mascota,medicacion WHERE 
(consume.num_mascota = mascota.num_mascota) AND (consume.num_medicacion=medicacion.num_medicacion) ORDER BY num_mascota ;	

# DECIMA CONSULTA PRIORIZADA 

SELECT * FROM hospeda  
WHERE hospeda.num_mascota NOT IN(SELECT consume.num_mascota FROM consume) GROUP BY hospeda.num_mascota;

# ONCEAVA CONSULTA PRIORIZADA


SELECT hospeda.num_mascota,mascota.nombre_mascota,pertenece.ci_cliente FROM hospeda,mascota,pertenece  
WHERE ((hospeda.num_mascota NOT IN(SELECT consume.num_mascota FROM consume)) 
AND hospeda.num_mascota=mascota.num_mascota) 
AND (mascota.num_mascota = pertenece.num_mascota) 
GROUP BY hospeda.num_mascota ORDER BY ci_cliente; 

# DOCEAVA CONSULTA PRIORIZADA 

Select `confirma e-s`.num_mascota,mascota.nombre_mascota,pertenece.ci_cliente,curdate() AS fechaHoy,`confirma e-s`.`momento_e-s`
from `confirma e-s`,`mascota`,pertenece WHERE
(CAST(`confirma e-s`.`momento_e-s` as date)=CURDATE() ) AND
( `confirma e-s`.num_mascota=mascota.num_mascota ) AND
(pertenece.num_mascota = `confirma e-s`.num_mascota)
 ;

# DECIMOTERCERA CONSULTA PRIORIZADA 

Select `mascota`.`nombre_mascota`,`pertenece`.`ci_cliente`
from `mascota`,`pertenece` WHERE
`pertenece`.`num_mascota` = `mascota`.`num_mascota` AND
`mascota`.`num_mascota` NOT IN(SELECT `confirma e-s`.`num_mascota` FROM  `confirma e-s`)  AND

(`pertenece`.`num_mascota` NOT IN(SELECT `confirma e-s`.`num_mascota` FROM `confirma e-s` ))

 ;


# DECIMOCUARTA CONSULTA PRIORIZADA

SELECT ci_recepcionista,nombre_mascota,`confirma e-s`.`momento_e-s`  FROM `confirma e-s`,`mascota` WHERE
`mascota`.`num_mascota`=`confirma e-s`.`num_mascota` AND
nombre_mascota='popi'
;

# DECIMOQUINTA CONSULTA PRIORIZADA

SELECT  b.ci_cliente AS Cliente,count((SELECT COUNT(b.num_mascota) FROM pertenece b )) as CantidadMasc FROM pertenece b 
WHERE (SELECT count((SELECT b.num_mascota Where b.num_mascota>=2 GROUP BY b.ci_cliente)) ) 
  GROUP BY b.ci_cliente 
  HAVING CantidadMasc>=2 
  ORDER by b.ci_cliente;






