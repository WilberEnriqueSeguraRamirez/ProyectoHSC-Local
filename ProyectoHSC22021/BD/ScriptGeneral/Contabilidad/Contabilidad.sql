-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO CONTABILIDAD - PÓLIZAS
-- ------------------------------------------------------------------------------------------------------------
use hotelSanCarlos;

-- Tabla de históricos donde se almacenará la información al hacer un cierre

-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO CONTABILIDAD - CIERRE CONTABLE
-- ------------------------------------------------------------------------------------------------------------
create table guardarReportecierre(
	idReporte varchar(15),
	rutaReporte varchar (100),
	estado varchar(1),

	primary key (idReporte)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- Tabla de históricos donde se almacenará la información al hacer un cierre
-- o terminar el ejercicio
create table historico(
	idCuenta varchar(15), -- Id de la cuenta
	fechaHistorico date, -- fecha en que se hace el cierre para poder ubicarlo después
	nombre varchar(65), -- Nombre de la cuenta
	idTipoCuenta varchar(15), -- foránea con Tipo Cuenta
    cargo float default 0, -- cargo de la cuenta
    abono float default 0, -- abono de la cuenta
    saldoAcumulado float default 0, -- Saldo acumulado en la cuenta
	estado varchar(1) ,-- A-Activo , I-Inactivo
    -- Se usa Recursividad -> Para indicar el padre de la cuenta
    idCuentaPadre varchar(15) default null,
    -- Primaria
	primary key (idCuenta, fechaHistorico),
	-- Foránea
    foreign key (idTipoCuenta) references tipoCuenta (idTipoCuenta),
	-- Foránea
    foreign key (idCuentaPadre) references cuenta (idCuenta)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table balanceSaldos(
	idBalance varchar(15),
	nombre varchar(20),
	sumas float,
	saldos float,
	estado varchar(1),

	primary key (idBalance)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table ajusteContable(
	idAjusteContable varchar(15),
	descripcion varchar(20),
	estado varchar(1),

primary key (idAjusteContable)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;
-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO CONTABILIDAD - PRESUPUESTOS
-- ------------------------------------------------------------------------------------------------------------

create table presupuesto(
	idPresupuesto varchar(15),
	nomPresupuesto varchar(20),
	anioPresupuesto varchar(20),
    mesPresupuesto varchar(20),
	ingresoPresupuesto float,
	gastoPresupuesto float,
	totalPresupuesto float,
    estadoPresupuesto varchar(1),
    
	primary key (idPresupuesto)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;


-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO CONTABILIDAD - ESTADOS FINANCIEROS
-- ------------------------------------------------------------------------------------------------------------
create table cuentaEstado(
	numCuenta varchar(15),
	nombreEstado varchar(20),
	saldo float,
	fecha date,

	primary key (numCuenta)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table reporteEstado(
	idReporteEstado varchar(15),
	rutaEstado varchar(20),

	primary key (idReporteEstado)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table registroActividad(
	idActividad varchar(45),
	nombreActividad varchar(45),
	credito varchar(45),
    debito Varchar(45),
    fecha date,

	primary key (idActividad)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table estadoSaldo(
	idEstadoSaldo varchar(15),
	fechaSaldo date,
	estado varchar(1),

	primary key (idEstadoSaldo)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;


-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO CONTABILIDAD - ACTIVOS FIJOS
-- ------------------------------------------------------------------------------------------------------------

create table tipoActivo(
	idTipoactivo varchar(10),
    nombreTipoactivo varchar (45),
    tasaDepreciacion float,
    estado varchar(1),
    primary key (idTipoactivo)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table activosFijos(
	idActivo int,
    nombreActivo varchar (45),
    marca varchar (45),
    modelo varchar (45),
    descripcion varchar (45),
    fkidTipoactivo varchar(10),
    estado varchar(1),
    primary key (idActivo),
    foreign key (fkidTipoactivo) references tipoActivo (idTipoactivo)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table depreciacionActivo(
	idDepreciacion int,
	costoActivo float,
    valorRescate float,
    fechaAdquisicion date,
    fechaDepreciacion date,
    vidaUtil int,
    idActivo int,
    primary key (idDepreciacion),
    foreign key (idActivo) references activosFijos (idActivo)
)ENGINE = InnoDB DEFAULT CHARSET=latin1;