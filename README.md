# UD27-EJ1

#### 1. Description
```
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
```

#### 2. Link a un demo con el proyecto desplegado: https://github.com/weixinxu12333/UD27-API-ER-SQL/tree/main/UD27-EJ1

```
* Nombre de la App: [GIT] (https://github.com/)
```
#### 3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.

###### Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
```
###### packages Nuget 
```
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
###### Cadena de Conexión Base de datos 
```
"AllowedHosts": "*",
  "ConnectionStrings": {
    "UD27-EJ1": "Server=localhost;Database=UD27-EJ1;User ID=sa;Password=yourStrong(!)Password"
  }
```
#### 4. URIs endpoints.
```
Piezas
GET       /api/Piezas
POST      /api/Piezas
GET       /api/Piezas/{id}
PUT       /api/Piezas/{id}
DELETE    /api/Piezas/{id}

Proveedores
GET       /api/Proveedores
POST      /api/Proveedores
GET       /api/Proveedores/{id}
PUT       /api/Proveedores/{id}
DELETE    /api/Proveedores/{id}

Suministras
GET       /api/Suministras
POST      /api/Suministras
GET       /api/Suministras/{id}
PUT       /api/Suministras/{id}
DELETE    /api/Suministras/{id}
```

#### 5. Screenshot imagen que indique cómo debe verse el proyecto.
![UD27-EJ1](https://user-images.githubusercontent.com/26082587/107993715-63ee1380-6fdb-11eb-9a25-c4ec862488ee.PNG)


# UD27-EJ2


#### 1. Description
```
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
```

#### 2. Link a un demo con el proyecto desplegado: https://github.com/weixinxu12333/UD27-API-ER-SQL/tree/main/UD27-EJ2

```
* Nombre de la App: [GIT] (https://github.com/)
```
#### 3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.

###### Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
```
###### packages Nuget 
```
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
###### Cadena de Conexión Base de datos 
```
"AllowedHosts": "*",
  "ConnectionStrings": {
    "UD27-EJ2": "Server=localhost;Database=UD27-EJ1;User ID=sa;Password=yourStrong(!)Password"
  }
```
#### 4. URIs endpoints.
```
Cientificos
GET       /api/Cientificos
POST      /api/Cientificos
GET       /api/Cientificos/{id}
PUT       /api/Cientificos/{id}
DELETE    /api/Cientificos/{id}

Proyectos
GET       /api/Proyectos
POST      /api/Proyectos
GET       /api/Proyectos/{id}
PUT       /api/Proyectos/{id}
DELETE    /api/Proyectos/{id}

Asignados_a
GET       /api/Asignados_a
POST      /api/Asignados_a
GET       /api/Asignados_a/{id}
PUT       /api/Asignados_a/{id}
DELETE    /api/Asignados_a/{id}
```

#### 5. Screenshot imagen que indique cómo debe verse el proyecto.
![UD27-EJ2](https://user-images.githubusercontent.com/26082587/107993901-d7902080-6fdb-11eb-8b3b-36487cc849c6.PNG)

# UD27-EJ3

#### 1. Description
```
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
```

#### 2. Link a un demo con el proyecto desplegado: https://github.com/weixinxu12333/UD27-API-ER-SQL/tree/EJ3

```
* Nombre de la App: [GIT] (https://github.com/)
```
#### 3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.

###### Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
```
###### packages Nuget 
```
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
###### Cadena de Conexión Base de datos 
```
"AllowedHosts": "*",
  "ConnectionStrings": {
    "UD27-EJ3": "Server=localhost;Database=UD27-EJ1;User ID=sa;Password=yourStrong(!)Password"
  }
```
#### 4. URIs endpoints.
```
Cajeros
GET       /api/Cajeros
POST      /api/Cajeros
GET       /api/Cajeros/{id}
PUT       /api/Cajeros/{id}
DELETE    /api/Cajeros/{id}

Productos
GET       /api/Productos
POST      /api/Productos
GET       /api/Productos/{id}
PUT       /api/Productos/{id}
DELETE    /api/Productos/{id}

Maquinas_registradoras
GET       /api/Maquinas_registradoras
POST      /api/Maquinas_registradoras
GET       /api/Maquinas_registradoras/{id}
PUT       /api/Maquinas_registradoras/{id}
DELETE    /api/Maquinas_registradoras/{id}

Venta
GET       /api/Venta
POST      /api/Venta
GET       /api/Venta/{id}
PUT       /api/Venta/{id}
DELETE    /api/Venta/{id}
```

#### 5. Screenshot imagen que indique cómo debe verse el proyecto.
![UD27-EJ3](https://user-images.githubusercontent.com/26082587/107994157-5be2a380-6fdc-11eb-89da-c2e5d12f92cf.PNG)

# UD27-E4


#### 1. Description
```
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
```

#### 2. Link a un demo con el proyecto desplegado: https://github.com/weixinxu12333/UD27-API-ER-SQL/tree/EJ3

```
* Nombre de la App: [GIT] (https://github.com/)
```
#### 3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.

###### Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
```
###### packages Nuget 
```
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
###### Cadena de Conexión Base de datos 
```
"AllowedHosts": "*",
  "ConnectionStrings": {
    "UD27-EJ4": "Server=localhost;Database=UD27-EJ1;User ID=sa;Password=yourStrong(!)Password"
  }
```
#### 4. URIs endpoints.
```
Investigadores
GET       /api/Investigadores
POST      /api/Investigadores
GET       /api/Investigadores/{id}
PUT       /api/Investigadores/{id}
DELETE    /api/Investigadores/{id}

Facultades
GET       /api/Facultades
POST      /api/Facultades
GET       /api/Facultades/{id}
PUT       /api/Facultades/{id}
DELETE    /api/Facultades/{id}

Equipos
GET       /api/Equipos
POST      /api/Equipos
GET       /api/Equipos/{id}
PUT       /api/Equipos/{id}
DELETE    /api/Equipos/{id}

Reservas
GET       /api/Reservas
POST      /api/Reservas
GET       /api/Reservas/{id}
PUT       /api/Reservas/{id}
DELETE    /api/Reservas/{id}
```

#### 5. Screenshot imagen que indique cómo debe verse el proyecto.
![UD27-EJ4](https://user-images.githubusercontent.com/26082587/107994161-5d13d080-6fdc-11eb-965a-78c53063ddfe.PNG)

