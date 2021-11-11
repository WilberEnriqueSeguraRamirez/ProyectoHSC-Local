-- ------------------------
# LMD Cuentas - Jaime López
-- ------------------------
use hotelSanCarlos;
# Tipos de Cuenta
insert into tipoCuenta values
('1','Activo','A'),('2','Pasivo','A'),('3','Capital','A'),('4','Ingresos','A'),('5','Egresos','A'),('6','Gastos','A');

#Cuentas padre y cuentas básicas
insert into cuenta values 
('1','Activo','1','0','0','0','A',null), #cuenta padre Activo
('2','Activo Corriente','1','0','0','0','A','1'), #Cuenta padre e hijo Activo Corriente 
('3','Activo No Corriente','1','0','0','0','A','1'), #Cuenta padre e hijo Activo no Corriente
('4','Pasivo','1','0','0','0','A',null), #Cuenta padre Pasivo
('5','Pasivo Corriente','2','0','0','0','A','4'),  #Cuenta padre e hijo Pasivo Corriente
('6','Pasivo No Corriente','2','0','0','0','A','4'), #Cuenta padre e hijo pasivo no corriente
('7','Capital','3','0','0','0','A',null), #cuenta padre Capital
('8','Ingresos','4','0','0','0','A',null), #cuenta padre Ingresos
('9','Egresos','5','0','0','0','A',null), #cuenta padre Egresos
('10','Gastos','6','0','0','0','A',null); #cuenta padre Gastos

#Cuentas básicas:
insert into cuenta values
('11','Caja','1','0','0','0','A','2'), #Caja, es hijo de activo corriente
('12','Bancos','1','0','0','0','A','2'); #Bancos, es hijo de activo corriente
#Faltan algunas otras cuentas, crearlas según necesidad de pólizas y otros módulos

#Tipos de Operación:
insert into tipooperacion values ('1','Cargo','A'), ('2','Abono','A');#Cargos y Abonos

#Algunos Impuestos Básicos:
insert into impuesto values 
('1','IVA','0.12','A'), #IVA, 12% = 0.12
('2','IGGS Empleador','0.1067','A'), #el jefe paga IGGS de 10.67% = 0.1067
('3','IGGS Empleado','0.0483','A'); #El iggs del empleado es de 4.83% = 0.0483
-- Modificado el: 06/11/21 - 1PM - Jaime López

-- ------------------------
# LMD Reporte, Ayuda - 	Patrick Bernard
-- ------------------------
USE hotelSanCarlos;

insert into aplicacion values ("7301","7","Mantenimiento Presupuesto","1","","");
insert into usuarioaplicacion values ("1","7301","1","1","1","1","1");

#Ayuda
update aplicacion set rutaChm = "C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\App\\Prueba\\bin\\Debug\\ayuda\\presupuesto\\AyudaPresupuesto.chm", rutaHtml="C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\App\\Prueba\\bin\\Debug\\ayuda\\presupuesto\\Manual-de-Técnico-Presupuesto.html" where pkId = "7301";

#Reporte
insert into reporte values ("7","7301","C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\Presupuesto\\CapaVistaPresupuestos\\ReportePresupuesto.rpt","7301","A");

-- ---------------------------------------------------------------------------------------------------------------
# LMD Permisos, Reporte, Ayuda - 	Gabriel Coyoy
-- ---------------------------------------------------------------------------------------------------------------

insert into aplicacion values ("7403","7","Mantenimiento Tipo Activo","1","","");
insert into aplicacion values ("7404","7","Mantenimiento Activo","1","","");

insert into usuarioaplicacion values ("1","7403","1","1","1","1","1");
insert into usuarioaplicacion values ("1","7404","1","1","1","1","1");

#Ayuda
update aplicacion set rutaChm = "C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\App\\Prueba\\bin\\Debug\\ayuda\\activosFijos\\AyudaActivosFijos.chm", rutaHtml="C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\App\\Prueba\\bin\\Debug\\ayuda\\activosFijos\\Ayuda-mantenimiento-activo.html" where pkId = "7404";
update aplicacion set rutaChm = "C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\App\\Prueba\\bin\\Debug\\ayuda\\activosFijos\\AyudaActivosFijos2.chm", rutaHtml="C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\App\\Prueba\\bin\\Debug\\ayuda\\activosFijos\\Ayuda-mantenimiento-tipo-activo.html" where pkId = "7403";

#Reporte
insert into reporte values ("9","7403","C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\ActivosFijos\\CapaVistaActivosFijos\\RPTTipoActivo.rpt","7403","A");
insert into reporte values ("11","7404","C:\\Users\\alecz\\Desktop\\FINAL\\ProyectoHSC-Local\\ProyectoHSC22021\\Modulos\\Contabilidad\\ActivosFijos\\CapaVistaActivosFijos\\RPTActivo.rpt","7404","A");