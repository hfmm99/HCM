CREATE 
//Crear Personas
(hMorales:Persona { nombre: "Heiner", apellidos: "Morales Morera", fechaDeNacimiento: "1981-02-13", email: "hmorales@builderhomesite.com", teléfono: "+506 8712-4821" }),
(jSolano:Persona { nombre: "Jose David", apellidos: "Solano Montoya", fechaDeNacimiento: "1999-03-17", email: "dsolano@builderhomesite.com",  teléfono: "+506 8388-9439" }),
(aDuran:Persona { nombre: "Andrés", apellidos: "Durán Vega", email: "aduran@outcoding.com", teléfono: "+506 8927-0118" }),
(mGranados:Persona { nombre: "Mario", apellidos: "Granados Sevilla", email: "mgranados@builderhomesite.com" }),
(jVelasquez:Persona { nombre: "Jonathan", apellidos: "Velasquez", email: "jvelasquez@builderhomesite.com" }),
(jAchio:Persona { nombre: "Juan Pablo", apellidos: "Achío", email: "jachio@builderhomesite.com" }),
(mTorres:Persona { nombre: "Mario", apellidos: "Torres", email: "mtorres@builderhomesite.com" }),

//Relacionar Personas (Sólo como ejemplo)
(mGranados)-[:JEFE_DE]->(hMorales),
(mGranados)-[:JEFE_DE]->(jVelasquez),

(hMorales)-[:JEFE_DE]->(jSolano),
(hMorales)-[:JEFE_DE]->(aDuran),

(jVelasquez)-[:JEFE_DE]->(jAchio),
(jVelasquez)-[:JEFE_DE]->(mTorres),

//Crear Roles
(entry:Rol {nombre: "Entry Level"}),
    (entry)-[:PUEDE_OPTAR_POR]->(juniorA:Rol:Junior {nombre: "Junior A"}),
        (juniorA)-[:PUEDE_OPTAR_POR]->(juniorB:Rol:Junior {nombre: "Junior B"}),            
            (juniorB)-[:PUEDE_OPTAR_POR]->(juniorC:Rol:Junior {nombre: "Junior C"}),
                (juniorC)-[:PUEDE_OPTAR_POR]->(mid:Rol:Mid {nombre: "Mid"}),
                    (mid)-[:PUEDE_OPTAR_POR]->(midDevOps:Rol:Mid {nombre: "Mid DevOps"}),
                    (mid)-[:PUEDE_OPTAR_POR]->(midFeatureDev:Rol:Mid {nombre: "Mid Feature Developer"}),
                    (mid)-[:PUEDE_OPTAR_POR]->(midPrincipalDev:Rol:Mid {nombre: "Mid Principal Developer"}),
                    (mid)-[:PUEDE_OPTAR_POR]->(midSM:Rol:Mid {nombre: "Mid Scrum/Build Master"}),
                        (midDevOps)-[:PUEDE_OPTAR_POR]->(seniorDevOps:Rol:Senior {nombre: "Senior DevOps"}),

                        (midFeatureDev)-[:PUEDE_OPTAR_POR]->(senior:Rol:Senior {nombre: "Senior"}),
                        (midPrincipalDev)-[:PUEDE_OPTAR_POR]->(senior),
                        (midSM)-[:PUEDE_OPTAR_POR]->(senior),
                            (senior)-[:PUEDE_OPTAR_POR]->(seniorD:Rol:Senior {nombre: "Senior Developer"}),
                                (seniorD)-[:PUEDE_OPTAR_POR]->(techLead:Rol:Lead {nombre: "Tech Lead"}),
                                    (techLead)-[:PUEDE_OPTAR_POR]->(productArchitect:Rol:Lead {nombre: "Product Architect"}),
                                        (productArchitect)-[:PUEDE_OPTAR_POR]->(:Rol:Lead {nombre: "Senior Product Architect"}),
                                    (techLead)-[:PUEDE_OPTAR_POR]->(solutionArchitect:Rol:Lead {nombre: "Solution Architect"}),
                                        (solutionArchitect)-[:PUEDE_OPTAR_POR]->(:Rol:Lead {nombre: "Senior Solution Architect"}),
                            (senior)-[:PUEDE_OPTAR_POR]->(seniorSM:Rol:Senior {nombre: "Senior Scrum Master"}),
                                (seniorSM)-[:PUEDE_OPTAR_POR]->(teamLead:Rol:Lead {nombre: "Team Lead"}),
                                    (teamLead)-[:PUEDE_OPTAR_POR]->(devManager:Rol:Lead {nombre: "Dev Manager"}),
                                        (devManager)-[:PUEDE_OPTAR_POR]->(:Rol:Lead {nombre: "Senior Dev Manager"}),

                                (seniorDevOps)-[:PUEDE_OPTAR_POR]->(techLead),

//Asignar Roles
(hMorales)-[:EJERCIÓ {desde: 2010, hasta: 2013}]->(mid),
(hMorales)-[:EJERCIÓ {desde: 2013, hasta: 2017}]->(senior),
(hMorales)-[:EJERCE {desde: 2017}]->(techLead),

(aDuran)-[:EJERCIÓ {desde: 2018, hasta: 2019}]->(entry),
(aDuran)-[:EJERCE {desde: 2019}]->(juniorB),

(jSolano)-[:EJERCIÓ {desde: 2016, hasta: 2018}]->(juniorB),
(jSolano)-[:EJERCE {desde: 2018}]->(mid),

(jVelasquez)-[:EJERCIÓ {desde: 2012, hasta: 2015}]->(senior),
(jVelasquez)-[:EJERCE {desde: 2015}]->(techLead),

(jAchio)-[:EJERCE {desde: 2017}]->(mid),
(mTorres)-[:EJERCE {desde: 2017}]->(mid),

(mGranados)-[:EJERCE {desde: 2015}]->(teamLead),

//Crear Equipos
(api:Equipo {nombre: "Web API Team"}),
(nhs:Equipo {nombre: "NHS Team"}),
(bdxL:Equipo {nombre: "BDX Live Team"}),
(mgr:Equipo {nombre: "BHI Managers"}),

//Asignar Personas a Equipos
(hMorales)-[:FUE_MIEMBRO_DE {desde: 2010, hasta: 2017}]->(bdxL),
(hMorales)-[:ES_MIEMBRO_DE {desde: 2017}]->(api),

(jSolano)-[:ES_MIEMBRO_DE {desde: 2017}]->(api),

(aDuran)-[:ES_MIEMBRO_DE {desde: 2018}]->(api),

(mGranados)-[:FUE_MIEMBRO_DE {desde: 2013, hasta: 2017}]->(nhs),
(mGranados)-[:ES_MIEMBRO_DE {desde: 2017}]->(mgr),

(jVelasquez)-[:ES_MIEMBRO_DE]->(nhs),

(jAchio)-[:ES_MIEMBRO_DE]->(nhs),

(mTorres)-[:ES_MIEMBRO_DE]->(nhs),

//Asignar roles a equipos
(api)-[:REQUIERE {cantidad: 1}]->(juniorB),
(api)-[:REQUIERE {cantidad: 1}]->(mid),
(api)-[:REQUIERE {cantidad: 2}]->(senior),
(api)-[:REQUIERE {cantidad: 1}]->(techLead),

(nhs)-[:REQUIERE {cantidad: 3}]->(juniorB),
(nhs)-[:REQUIERE {cantidad: 5}]->(mid),
(nhs)-[:REQUIERE {cantidad: 3}]->(senior),
(nhs)-[:REQUIERE {cantidad: 1}]->(techLead),

//Crear Habilidades
(trabajoEquipo:Habilidad {nombre: "Team work", valorMáximo: 5}),
(habTécnicas:Habilidad {nombre: "Technical Skills", valorMáximo: 10}),
(comunicación:Habilidad {nombre: "Communication", valorMáximo: 3}),
(iEmocional:Habilidad {nombre: "Emotional Intelligence", valorMáximo: 3}),
(conNegocio:Habilidad {nombre: "Business Knowledge", valorMáximo: 5}),
(crecimientoPersonal:Habilidad {nombre: "Personal Growth", valorMáximo: 10}),
(dailyBasics:Habilidad {nombre: "Daily Basis", valorMáximo: 5}),

//Asignar Habilidades a Personas
(hMorales)-[:POSEE {valorActual: 4}]->(trabajoEquipo),
(hMorales)-[:POSEE {valorActual: 8}]->(habTécnicas),
(hMorales)-[:POSEE {valorActual: 2}]->(comunicación),
(hMorales)-[:POSEE {valorActual: 2}]->(iEmocional),
(hMorales)-[:POSEE {valorActual: 4}]->(conNegocio),

(jSolano)-[:POSEE {valorActual: 4}]->(trabajoEquipo),
(jSolano)-[:POSEE {valorActual: 7}]->(habTécnicas),
(jSolano)-[:POSEE {valorActual: 3}]->(comunicación),
(jSolano)-[:POSEE {valorActual: 2}]->(iEmocional),
(jSolano)-[:POSEE {valorActual: 3}]->(conNegocio),

(aDuran)-[:POSEE {valorActual: 7}]->(habTécnicas),

(jVelasquez)-[:POSEE {valorActual: 3}]->(iEmocional),
(mGranados)-[:POSEE {valorActual: 5}]->(conNegocio),

//Asignar Habilidades de Roles
(juniorA)-[:REQUIERE {valorMinimo: 1}]->(trabajoEquipo),
(juniorA)-[:REQUIERE {valorMinimo: 2}]->(habTécnicas),
(juniorA)-[:REQUIERE {valorMinimo: 1}]->(comunicación),
(juniorA)-[:REQUIERE {valorMinimo: 1}]->(iEmocional),
(juniorA)-[:REQUIERE {valorMinimo: 0}]->(conNegocio),

(mid)-[:REQUIERE {valorMinimo: 3}]->(trabajoEquipo),
(mid)-[:REQUIERE {valorMinimo: 4}]->(habTécnicas),
(mid)-[:REQUIERE {valorMinimo: 2}]->(comunicación),
(mid)-[:REQUIERE {valorMinimo: 2}]->(iEmocional),
(mid)-[:REQUIERE {valorMinimo: 2}]->(conNegocio);

/////////////////////////////////////////Crear Constraints/////////////////////////////////////////

//Nombre de equipo único
Create Constraint On (e:Equipo)
Assert e.nombre Is Unique;

/////////////////////////////////////////Consultas/////////////////////////////////////////
//Esquema de BD
Call db.schema();

//Career Path Lineal
Match (r:Rol)-[p:PUEDE_OPTAR_POR]->(r2:Rol) Return r, p, r2;

//Miembros de un Equipo y su respectivo Rol
Match (e:Equipo)-[es:ES_MIEMBRO_DE]-(p:Persona)-[ej:EJERCE]-(r:Rol)
Where  e.nombre = "Web API Team" 
Return e, es, p, ej, r

//Cantidad de miembros por equipo
Match (p:Persona)-[:ES_MIEMBRO_DE]-(e:Equipo)
Return e.nombre As equipo, Count(*) As miembros

//Habilidades que contiene un equipo
Match (e:Equipo)-[:ES_MIEMBRO_DE]-(:Persona)-[po:POSEE]-(h:Habilidad)
Where e.nombre = "Web API Team"
Return h.nombre As habilidad, Max(po.valorActual) + " de " + h.valorMáximo as valor
Order By h.nombre

//Lead de...
Match (j:Persona)-[jf:JEFE_DE]-(p:Persona) Where p.nombre = "Jose David" Return j, jf, p;

//Limpiar BD
Match (n)
Detach Delete n

//// Otras Personas

//Adrian Ovares
//Alejandra Ponce
//Allan Quirós
//Andrés Durán Vega
//Alexander Solozano
//Braulio Alpizar
//Bruno Gatjens
//carlos Torres
//Cesar Morales
//Danny Pérez
//Davis Gomez
//Dorian Andrés
//Elizabeth Gamboa
//Esteban Leandro Marín
//Esteban Sanchez
//Evelyn Fallas
//Fabián Vargas
//Fernando Solano
//Gary Valverde
//Geovanny Vargas
//Guillermo Ramirez
//Héctor Vargas
//Heiner Morales Morera
//Johan Aguero
//Jean Carlo Zuñiga
//Jefferson Loria Chacón
//Johnny Jirón
//Jonathan Velásquez
//Jorge Velásquez
//Jose Morales
//Jose David Solano
//Juan Pablo Achio
//Karen Chinchilla
//Kendall Piedra
//Kim Granados
//Luis González
//Luis Herrera
//Luis Diego Peytrequín
//Marconey Arguedas
//Mario Granados
//Mario Torres
//Marjorie Guevara
//Marlon Rivera
//Montserrat Esquivel
//Miguel Borja
//Marco Porras
//Natalia Alpizar
//Natalie Cedeno
//Pablo Barrientos
//Ricardo Alfaro
//Ronald Jiménez
//Roy Ramos
//Ricardo Sanchez
//Stephany Barrantes
//Sileny Murrillo
//Stanley Vargas
//Vanessa Carpio
//Wendy zuniga

//Delete DB
    Match (n)
    Detach Delete n;

// Load Employees
    LOAD CSV WITH HEADERS FROM 'file:///Employees.csv' AS line

    MERGE (e:Employee { name: line.Name, email: line.Email  })
    MERGE (t:Team { name: line.Team })
    MERGE (c:Country { name: line.Country })

    MERGE (e)-[:LIVES_IN]-(c)
    MERGE (e)-[:IS_MEMBER_OF { percent: line.Percent }]-(t)

    WITH e, SPLIT(line.Role, ",") AS roles
    UNWIND roles as role
    MERGE (r:Role {name: role})
    MERGE (e)-[:WORKS_AS]-(r);

// Associate Teams with Roles
    Match (t:Team)<-[:IS_MEMBER_OF]-(e:Employee)-[:WORKS_AS]-(r:Role)
    With t, r, Count(r) As Quantity
    Merge (t)-[:REQUIRES { quantity: Quantity }]->(r)
    Return t.name As Team, r.name As Role, Quantity;


// Set Leads
Match (t:Team)<-[:IS_MEMBER_OF]-(l:Employee)-[:WORKS_AS]->(r:Role {name: "Lead"})
Match (m:Employee {name: "Mario Granados"})
Merge (m)-[:MANAGES]->(l)
With m, l, t
Match (t)<-[:IS_MEMBER_OF]-(e:Employee)-[:WORKS_AS]->(r2:Role) Where r2.name <> "Lead" And l.name <> e.name
Merge (l)-[:MANAGES]->(e)
Return Distinct m, l, e;

// Set Client
Merge (c:Client { name: "BHI" })
With  c
Match (e:Employee)
Merge (e)-[:WORKS_FOR]->(c)
Return c, e;


// Learning Management System
Create (:LearningPath { name: "JavaScript Developer I", description: "The first few tutorials work on basic JavaScript concepts like strings, variables, arrays and if-statements — along with quizzes to check your understanding. Towards the end of the section, you will learn about more involved topics like functions and loops — and also do a lot of coding exercises"})
-[:CONTENT]->
(li1:LearningItem { name: "Numbers and Strings", duration: "11 mins"})
-[:NEXT]->
(:LearningItem { name: "Variables, Arrays and Objects", duration: "21 mins" })
-[:NEXT]->
(:LearningItem { name: "Conditional Statements and Comments", duration: "16 mins" })
-[:NEXT]->
(:LearningItem { name: "Loops, break and continue", duration: "16 mins" })
-[:NEXT]->
(:LearningItem { name: "Functions", duration: "14 mins" });

Create (:LearningPath { name: "JavaScript Developer II", description: "This 9-part course consists of tutorials on the most important concepts in advanced JavaScript including many code-snippets and hands-on examples"})
-[:CONTENT]->
(LearningItem { name: "Understanding Scope in JavaScript", duration: "18 mins"})
-[:NEXT]->
(:LearningItem { name: "Advanced Scope: Execution Context and Why it Matters", duration: "27 mins" })
-[:NEXT]->
(:LearningItem { name: "Cheating Scope: Eval, Try-Catch, Let, and Const", duration: "26 mins" });

//
Match (lp1:LearningPath { name: "JavaScript Developer I"} )
Match (lp2:LearningPath { name: "JavaScript Developer II"} )
Match (hm: Employee { name: "Heiner Morales" })
Match (li1: LearningItem { name: "Numbers and Strings" })
Merge (lp2)-[:IS_PREREQUISITE]->(lp1)
Merge (hm)-[:COMPLETED]->(li1);

//
Match (r:Role { name: 'Developer' })
Match (lp:LearningPath { name: "JavaScript Developer I"} )
Merge (r)-[:REQUIRES]-(lp)
Return *;

//Sub Schema for LMS:
call apoc.meta.subGraph( {labels: ['Employee', 'Role', 'LearningPath', 'LearningItem']} );









Load CSV With Headers From "file:///Brands.csv" As line
Create (b:Brand {id: toInteger(line.BrandID), name: line.BrandName, logoSmall: line.LogoSmall, logoMedium: line.LogoMedium, siteUrl: line.SiteURL})
Create Index On :Brand(id)

Match (b:Brand {id: 33}) Return b.id, b.name, b.logoSmall, b.logoMedium

Match (b:Brand) Where b.name Starts With "To" Return b