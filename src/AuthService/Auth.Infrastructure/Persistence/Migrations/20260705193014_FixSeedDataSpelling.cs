using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Auth.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedDataSpelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Careers",
                columns: new[] { "Id", "CareerName", "DurationSemesters" },
                values: new object[,]
                {
                    { 1, "Ingeniería Agroindustrial", 10 },
                    { 2, "Ingeniería Agronómica", 10 },
                    { 3, "Medicina Veterinaria y Zootecnia", 10 },
                    { 4, "Ingeniería Forestal", 10 },
                    { 5, "Biología", 10 },
                    { 6, "Ingeniería Ambiental", 10 },
                    { 7, "Ingeniería de Procesos", 10 },
                    { 8, "Ingeniería de Sistemas", 10 },
                    { 9, "Ingeniería Electrónica", 10 },
                    { 10, "Tecnología en desarrollo de software", 6 },
                    { 11, "Enfermería", 9 },
                    { 12, "Fisioterapia", 9 },
                    { 13, "Fonoaudiología", 9 },
                    { 14, "Tecnología en Regencia de Farmacia", 6 },
                    { 15, "Administración de Empresas", 9 },
                    { 16, "Contaduría Pública", 9 },
                    { 17, "Economía", 10 },
                    { 18, "Mercadeo", 9 },
                    { 19, "Comunicación Audiovisual", 8 },
                    { 20, "Licenciatura en Educación Campesina y Rural", 10 },
                    { 21, "Licenciatura en Educación Física y Deporte", 10 },
                    { 22, "Licenciatura en Educación Infantil", 10 },
                    { 23, "Licenciatura en Español e Inglés", 10 },
                    { 24, "Licenciatura en Matemáticas", 10 },
                    { 25, "Sociología", 9 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "SubjectName" },
                values: new object[,]
                {
                    { 1, "Pensamiento lógico matemático" },
                    { 2, "Matemáticas I" },
                    { 3, "Química general" },
                    { 4, "Biología" },
                    { 5, "Introducción a la ingeniería agroindustrial" },
                    { 6, "Dibujo de ingeniería" },
                    { 7, "Procesos comunicativos" },
                    { 8, "Álgebra lineal" },
                    { 9, "Matemáticas II" },
                    { 10, "Física I" },
                    { 11, "Química orgánica" },
                    { 12, "Aplicaciones informáticas" },
                    { 13, "Cátedra de la Orinoquia" },
                    { 14, "Matemáticas III (modelamiento matemático para ingenieros)" },
                    { 15, "Física II" },
                    { 16, "Termodinámica" },
                    { 17, "Bioquímica" },
                    { 18, "Producción agropecuaria" },
                    { 19, "Ciencia, tecnología y desarrollo" },
                    { 20, "Métodos numéricos para ingenieros" },
                    { 21, "Probabilidad y estadística" },
                    { 22, "Fisicoquímica" },
                    { 23, "Microbiología industrial" },
                    { 24, "Química agroindustrial" },
                    { 25, "Cátedra democracia y paz" },
                    { 26, "Diseño experimental" },
                    { 27, "Materias primas" },
                    { 28, "Mecánica de fluidos e hidráulica" },
                    { 29, "Balance de materia y energía" },
                    { 30, "Transferencia de calor" },
                    { 31, "Economía" },
                    { 32, "Metodología de la investigación" },
                    { 33, "Procesos agrícolas I" },
                    { 34, "Operaciones unitarias I" },
                    { 35, "Procesos no alimentarios I" },
                    { 36, "Mercadeo agroindustrial" },
                    { 37, "Administración" },
                    { 38, "Procesos pecuarios" },
                    { 39, "Biotecnología agroindustrial" },
                    { 40, "Procesos agrícolas II" },
                    { 41, "Operaciones unitarias II" },
                    { 42, "Investigación de operaciones" },
                    { 43, "Gestión ambiental" },
                    { 44, "Procesos no alimentarios II" },
                    { 45, "Diseño de planta y equipos" },
                    { 46, "Contabilidad y costos" },
                    { 47, "Desarrollo rural" },
                    { 48, "Aseguramiento de la calidad" },
                    { 49, "Formulación y evaluación de proyectos" },
                    { 50, "Administración de la producción" },
                    { 51, "Derecho para ingenieros" },
                    { 52, "Práctica empresarial" },
                    { 53, "Trabajo de grado" },
                    { 54, "Química básica" },
                    { 55, "Biología celular" },
                    { 56, "Introducción a la ingeniería agronómica" },
                    { 57, "Morfofisiología vegetal" },
                    { 58, "Física mecánica" },
                    { 59, "Sociología rural" },
                    { 60, "Bioquímica vegetal" },
                    { 61, "Taxonomía vegetal" },
                    { 62, "Matemáticas III" },
                    { 63, "Termodinámica y energética" },
                    { 64, "Agroclimatología" },
                    { 65, "Economía agraria" },
                    { 66, "Biología molecular" },
                    { 67, "Ecosistemas tropicales" },
                    { 68, "Diseño y desarrollo de experimentos agrícolas I" },
                    { 69, "Fisiología vegetal" },
                    { 70, "Administración y gestión de empresas agrarias" },
                    { 71, "Geomática agrícola" },
                    { 72, "Genética vegetal" },
                    { 73, "Reproducción de plantas" },
                    { 74, "Diseño y desarrollo de experimentos agrícolas II" },
                    { 75, "Microbiología agrícola" },
                    { 76, "Entomología agrícola" },
                    { 77, "Suelos I: Geología y génesis de suelos" },
                    { 78, "Fitomejoramiento" },
                    { 79, "Fundamentos de sanidad vegetal en los sistemas de producción agrícola" },
                    { 80, "Suelos II: Física y química de suelos" },
                    { 81, "Mecánica de fluidos" },
                    { 82, "Agroecología" },
                    { 83, "Manejo sanitario de los sistemas de producción agrícola" },
                    { 84, "Suelos III: Fertilidad y manejo sostenible de suelos" },
                    { 85, "Política y legislación agraria" },
                    { 86, "Uso y manejo del agua en los sistemas de producción agrícola" },
                    { 87, "Sistemas agrarios de producción agrícola de clima medio y frío" },
                    { 88, "Construcciones rurales" },
                    { 89, "Maquinaria y mecanización agrícola" },
                    { 90, "Sistemas de producción agrícola de clima cálido" },
                    { 91, "Mercadeo de productos agrícolas" },
                    { 92, "Desarrollo y extensión rural" },
                    { 93, "Práctica profesional" },
                    { 94, "Introducción a las ciencias animales" },
                    { 95, "Anatomía general" },
                    { 96, "Desarrollo del pensamiento lógico matemático" },
                    { 97, "Economía agropecuaria" },
                    { 98, "Bioética y bienestar animal" },
                    { 99, "Ecología" },
                    { 100, "Bioquímica metabólica" },
                    { 101, "Anatomía comparada" },
                    { 102, "Fisiología I" },
                    { 103, "Microbiología y virología" },
                    { 104, "Histología" },
                    { 105, "Sociedad rural" },
                    { 106, "Bioestadística" },
                    { 107, "Producción tropical sostenible" },
                    { 108, "Suelos y forrajes" },
                    { 109, "Fisiología II" },
                    { 110, "Parasitología" },
                    { 111, "Genética y mejoramiento" },
                    { 112, "Nutrición animal" },
                    { 113, "Semiología" },
                    { 114, "Farmacología" },
                    { 115, "Patología clínica" },
                    { 116, "Inmunología" },
                    { 117, "Producción de especies menores" },
                    { 118, "Cirugía" },
                    { 119, "Enfermedades infecciosas" },
                    { 120, "Patología general" },
                    { 121, "Reproducción" },
                    { 122, "Producción avícola" },
                    { 123, "Alimentación animal" },
                    { 124, "Medicina interna" },
                    { 125, "Epidemiología" },
                    { 126, "Producción porcina" },
                    { 127, "Toxicología veterinaria" },
                    { 128, "Patología sistémica" },
                    { 129, "Administración y mercadeo agropecuario" },
                    { 130, "Salud pública" },
                    { 131, "Producción acuícola" },
                    { 132, "Producción de rumiantes" },
                    { 133, "Lácteos y cárnicos" },
                    { 134, "Extensión rural" },
                    { 135, "Clínica de grandes animales" },
                    { 136, "Clínica de pequeños animales" },
                    { 137, "Producción de balanceados y suplementos" },
                    { 138, "Gestión empresarial agropecuaria" },
                    { 139, "Gestión de la calidad alimentaria" },
                    { 140, "Introducción a la ingeniería forestal" },
                    { 141, "Botánica taxonómica" },
                    { 142, "Suelos I" },
                    { 143, "Dendrología" },
                    { 144, "Ecología forestal" },
                    { 145, "Bioestadística forestal" },
                    { 146, "Suelos II" },
                    { 147, "Flora y fauna de la Orinoquia y Amazonía" },
                    { 148, "Hidrología" },
                    { 149, "Geomática básica" },
                    { 150, "Diseño y desarrollo de experimentos forestales" },
                    { 151, "Anatomía y tecnología de la madera" },
                    { 152, "Suelos III" },
                    { 153, "Dendrometría y mediciones forestales" },
                    { 154, "Sistemas de información geográfica" },
                    { 155, "Viveros y mejoramiento genético" },
                    { 156, "Mecanización y maquinaria forestal" },
                    { 157, "Aprovechamiento forestal" },
                    { 158, "Cuencas hidrográficas" },
                    { 159, "Áreas protegidas" },
                    { 160, "Silvicultura de plantaciones" },
                    { 161, "Política y legislación forestal" },
                    { 162, "Silvicultura del bosque natural" },
                    { 163, "Entomología y sanidad forestal" },
                    { 164, "Ordenación forestal" },
                    { 165, "Bioeconomía forestal" },
                    { 166, "Emprendimiento y formulación de proyectos" },
                    { 167, "Manejo sostenible de bosque natural" },
                    { 168, "Trabajo de grado I" },
                    { 169, "Restauración ecológica" },
                    { 170, "Gestión de industrias forestales" },
                    { 171, "Trabajo de grado II" },
                    { 172, "Principios químicos de la vida" },
                    { 173, "Introducción a los sistemas biológicos" },
                    { 174, "Estructura celular" },
                    { 175, "Principios físicos de la vida" },
                    { 176, "Compuestos orgánicos" },
                    { 177, "Biología de plantas inferiores" },
                    { 178, "Análisis químico" },
                    { 179, "Biología de invertebrados" },
                    { 180, "Geología y suelos tropicales" },
                    { 181, "Bioquímica y función celular" },
                    { 182, "Morfología de vertebrados" },
                    { 183, "Morfología de plantas superiores" },
                    { 184, "Genética" },
                    { 185, "Fisiología animal" },
                    { 186, "Sistemas ecológicos" },
                    { 187, "Sistemas de información" },
                    { 188, "Biología del desarrollo" },
                    { 189, "Genética de poblaciones" },
                    { 190, "Elementos de la comunicación científica" },
                    { 191, "Biología de la conservación" },
                    { 192, "Microbiología" },
                    { 193, "Sistemática y evolución" },
                    { 194, "Dinámica de poblaciones" },
                    { 195, "Formulación de proyectos" },
                    { 196, "Valoración y manejo de ecosistemas" },
                    { 197, "Taxonomía animal" },
                    { 198, "Ecosistemas acuáticos" },
                    { 199, "Etnobiología" },
                    { 200, "Bioética" },
                    { 201, "Biología general y laboratorio" },
                    { 202, "Química general y laboratorio" },
                    { 203, "Cálculo diferencial" },
                    { 204, "Introducción a la ingeniería ambiental" },
                    { 205, "Química orgánica y laboratorio" },
                    { 206, "Cálculo integral" },
                    { 207, "Física calor y ondas" },
                    { 208, "Cálculo multivariado" },
                    { 209, "Estadística" },
                    { 210, "Topografía y cartografía" },
                    { 211, "Ecuaciones diferenciales" },
                    { 212, "Microbiología y laboratorio" },
                    { 213, "Mecánica de fluidos y laboratorio" },
                    { 214, "Geología y geomorfología laboratorio" },
                    { 215, "Química analítica" },
                    { 216, "Hidráulica y laboratorio" },
                    { 217, "Climatología" },
                    { 218, "Química ambiental y laboratorio" },
                    { 219, "Suelos y laboratorio" },
                    { 220, "Legislación ambiental" },
                    { 221, "Gestión del agua y laboratorio" },
                    { 222, "Emisiones atmosféricas y calidad del aire" },
                    { 223, "Manejo de los recursos naturales" },
                    { 224, "Impacto ambiental" },
                    { 225, "Gestión del agua residual" },
                    { 226, "Gestión de residuos sólidos" },
                    { 227, "Sistema de gestión ambiental" },
                    { 228, "Economía ambiental" },
                    { 229, "Ordenamiento territorial" },
                    { 230, "Saneamiento básico" },
                    { 231, "Modelación ambiental" },
                    { 232, "Tecnologías ambientales" },
                    { 233, "Ética y ambiente" },
                    { 234, "Gestión del riesgo y prevención de desastres" },
                    { 235, "Toxicología ambiental" },
                    { 236, "Anteproyecto de grado" },
                    { 237, "Proyecto de grado" },
                    { 238, "Fundamentos de programación" },
                    { 239, "Introducción a la ingeniería de procesos" },
                    { 240, "Biología general" },
                    { 241, "Química analítica e instrumental" },
                    { 242, "Electricidad y magnetismo" },
                    { 243, "Química inorgánica" },
                    { 244, "Dinámica de sistemas" },
                    { 245, "Geoquímica del petróleo" },
                    { 246, "Métodos numéricos" },
                    { 247, "Ingeniería de yacimientos" },
                    { 248, "Diseño de experimentos" },
                    { 249, "Fenómenos de transporte" },
                    { 250, "Economía para ingenieros" },
                    { 251, "Ingeniería de las reacciones" },
                    { 252, "Operaciones unitarias" },
                    { 253, "Procesos industriales" },
                    { 254, "Gestión de producción" },
                    { 255, "Transferencia de masa y energía" },
                    { 256, "Manejo de sólidos" },
                    { 257, "Ciencia de los materiales" },
                    { 258, "Costos y presupuesto" },
                    { 259, "Gestión de calidad" },
                    { 260, "Diseño de productos" },
                    { 261, "Diseño de procesos" },
                    { 262, "Metodología de investigación" },
                    { 263, "Simulación y optimización" },
                    { 264, "Logística industrial" },
                    { 265, "Algoritmia y programación" },
                    { 266, "Introducción a la ingeniería de sistemas" },
                    { 267, "Programación orientada a objetos" },
                    { 268, "Sistemas digitales" },
                    { 269, "Democracia y paz" },
                    { 270, "Estructuras de datos" },
                    { 271, "Máquinas digitales" },
                    { 272, "Bases de datos" },
                    { 273, "Sistemas operativos" },
                    { 274, "Ecuaciones diferenciales y modelado matemático" },
                    { 275, "Estadística y probabilidad" },
                    { 276, "Oscilaciones y ondas" },
                    { 277, "Ingeniería de software I" },
                    { 278, "Pensamiento sistémico" },
                    { 279, "Matemáticas especiales" },
                    { 280, "Procesos estocásticos" },
                    { 281, "Sistemas de comunicación" },
                    { 282, "Ingeniería de software II" },
                    { 283, "Procesamiento de señales e imágenes" },
                    { 284, "Optimización" },
                    { 285, "Redes de computadores" },
                    { 286, "Administración financiera para ingeniería" },
                    { 287, "Tecnologías avanzadas" },
                    { 288, "Ética y humanística" },
                    { 289, "Sistemas distribuidos" },
                    { 290, "Seguridad de la información" },
                    { 291, "Formulación y gestión de proyectos" },
                    { 292, "Simulación computacional" },
                    { 293, "Arquitectura empresarial" },
                    { 294, "Trabajo de grado 1" },
                    { 295, "Lenguajes de programación" },
                    { 296, "Trabajo de grado 2" },
                    { 297, "CÁLCULO DIFERENCIAL" },
                    { 298, "PENSAMIENTO LÓGICO MATEMÁTICO" },
                    { 299, "PROCESOS COMUNICATIVOS" },
                    { 300, "INTRODUCCIÓN A LA INGENIERÍA ELECTRÓNICA" },
                    { 301, "PROGRAMACIÓN I" },
                    { 302, "LABORATORIO DE ELECTRÓNICA BÁSICA" },
                    { 303, "CÁLCULO INTEGRAL" },
                    { 304, "ÁLGEBRA LINEAL" },
                    { 305, "FÍSICA MECÁNICA" },
                    { 306, "CIRCUITOS ELÉCTRICOS I" },
                    { 307, "PROGRAMACIÓN II" },
                    { 308, "CÁLCULO MULTIVARIADO" },
                    { 309, "ECUACIONES DIFERENCIALES" },
                    { 310, "ELECTRICIDAD Y MAGNETISMO" },
                    { 311, "ELECTRÓNICA ANÁLOGA I" },
                    { 312, "MATEMÁTICAS ESPECIALES" },
                    { 313, "CIRCUITOS ELÉCTRICOS II" },
                    { 314, "OSCILACIONES Y ONDAS" },
                    { 315, "ELECTRÓNICA ANÁLOGA II" },
                    { 316, "CIRCUITOS DIGITALES I" },
                    { 317, "ANÁLISIS DE SEÑALES" },
                    { 318, "PROBABILIDAD Y ESTADÍSTICA" },
                    { 319, "SEMICONDUCTORES Y MATERIALES" },
                    { 320, "MÉTODOS NUMÉRICOS" },
                    { 321, "CIRCUITOS DIGITALES II" },
                    { 322, "MODELAMIENTO DE SISTEMAS" },
                    { 323, "OPTIMIZACIÓN Y PROCESOS ESTOCÁSTICOS" },
                    { 324, "CAMPOS ELECTROMAGNÉTICOS" },
                    { 325, "INSTRUMENTACIÓN ELECTRÓNICA I" },
                    { 326, "CIRCUITOS DIGITALES III" },
                    { 327, "CÁTEDRA DEMOCRACIA Y PAZ" },
                    { 328, "CONTROL ANÁLOGO" },
                    { 329, "LÍNEAS Y ANTENAS" },
                    { 330, "SISTEMAS DE COMUNICACIÓN I" },
                    { 331, "INSTRUMENTACIÓN ELECTRÓNICA II" },
                    { 332, "METODOLOGÍA DE LA INVESTIGACIÓN" },
                    { 333, "CÁTEDRA DE LA ORINOQUIA" },
                    { 334, "CONTROL DIGITAL" },
                    { 335, "SISTEMAS DE COMUNICACIÓN II" },
                    { 336, "MÁQUINAS ELÉCTRICAS" },
                    { 337, "FORMULACIÓN Y GESTIÓN DE PROYECTOS DE TI" },
                    { 338, "ÉTICA EN LA INGENIERÍA" },
                    { 339, "ELECTRÓNICA INDUSTRIAL" },
                    { 340, "PROYECTO DE GRADO" },
                    { 341, "Algoritmia" },
                    { 342, "Introducción a la Tecnología en Desarrollo de Software" },
                    { 343, "Herramientas digitales" },
                    { 344, "Matemáticas discretas" },
                    { 345, "Programación" },
                    { 346, "Ética en la Tecnología de la información" },
                    { 347, "Metodologías ágiles" },
                    { 348, "Desarrollo Back-end" },
                    { 349, "Física" },
                    { 350, "Fundamentos de IA" },
                    { 351, "Análisis y diseño de software" },
                    { 352, "Infraestructura de TI" },
                    { 353, "Desarrollo Front-end" },
                    { 354, "Testing" },
                    { 355, "Desarrollo y despliegue de software" },
                    { 356, "Investigación, innovación y emprendimiento" },
                    { 357, "Desarrollo de software seguro" },
                    { 358, "Gestión de bases de datos" },
                    { 359, "Introducción a la Analítica de datos" },
                    { 360, "Agromática. Tecnología para el agro" },
                    { 361, "Opción de grado" },
                    { 362, "Fundamentos de bioquímica I" },
                    { 363, "Morfofisiología" },
                    { 364, "Socioantropología" },
                    { 365, "Historia y desarrollo de enfermería" },
                    { 366, "Fundamentos de bioquímica II" },
                    { 367, "Microbiología y parasitología" },
                    { 368, "Fisiopatología" },
                    { 369, "Fundamentos y técnicas para el cuidado I" },
                    { 370, "Fundamentos éticos y bioéticos" },
                    { 371, "Psicología y desarrollo humano" },
                    { 372, "Fundamentos y técnicas para el cuidado II" },
                    { 373, "Ecobiología de poblaciones" },
                    { 374, "Promoción de la salud y prevención de la enfermedad" },
                    { 375, "Cuidado desarrollo prenatal, nacimiento y recién nacido" },
                    { 376, "Sistema general de seguridad social" },
                    { 377, "Cuidado de la salud de colectivos I" },
                    { 378, "Cuidado de la salud al niño" },
                    { 379, "Tendencias en enfermería" },
                    { 380, "Metodología de la investigación I" },
                    { 381, "Cuidado de la salud de colectivos II" },
                    { 382, "Cuidado de la salud al adolescente" },
                    { 383, "Fundamentos de gerencia y gestión" },
                    { 384, "Metodología de la investigación II" },
                    { 385, "Cuidado del adulto I" },
                    { 386, "Dilemas éticos" },
                    { 387, "Cuidado del adulto II" },
                    { 388, "Cuidado de la salud mental y psiquiatría" },
                    { 389, "Gestión del cuidado y servicios de enfermería" },
                    { 390, "Gestión de los planes y programas en salud" },
                    { 391, "Ciencias básicas integradas" },
                    { 392, "Morfofisiología I" },
                    { 393, "Contexto de Fisioterapia, Cuerpo y Movimiento" },
                    { 394, "Morfofisiología II" },
                    { 395, "Neuromorfofisiología" },
                    { 396, "Educación para la salud" },
                    { 397, "Psicología" },
                    { 398, "Herramientas informáticas" },
                    { 399, "Fundamentos éticos" },
                    { 400, "Prescripción del ejercicio en fisioterapia" },
                    { 401, "Biomecánica" },
                    { 402, "Neurodesarrollo y control motor" },
                    { 403, "Evaluación, análisis y diagnóstico del movimiento corporal humano I" },
                    { 404, "Salud pública, comunidad y discapacidad" },
                    { 405, "Fisioterapia en Salud y seguridad en el trabajo" },
                    { 406, "Tecnología en fisioterapia" },
                    { 407, "Evaluación, análisis y diagnóstico del movimiento corporal humano II" },
                    { 408, "Intervención fisioterapéutica I" },
                    { 409, "Práctica de formación integral" },
                    { 410, "Intervención fisioterapéutica II" },
                    { 411, "Práctica de formación integral fisioterapia en pediatría" },
                    { 412, "Práctica de formación fisioterapia en adulto" },
                    { 413, "Fundamentos de administración en salud" },
                    { 414, "Redacción de textos científicos y opción de grado" },
                    { 415, "Práctica de formación especializada" },
                    { 416, "Gestión de proyectos" },
                    { 417, "Emprendimiento" },
                    { 418, "Lingüística" },
                    { 419, "Pensamiento Lógico Matemático" },
                    { 420, "Comunicación Oral y Escrita" },
                    { 421, "Fundamentos de Fonoaudiología" },
                    { 422, "Morfofisiología de cabeza, cuello y tórax" },
                    { 423, "Comunicación Oral y Escrita II" },
                    { 424, "Acústica" },
                    { 425, "Adquisición y desarrollo del lenguaje escrito" },
                    { 426, "Adquisición y desarrollo del lenguaje oral" },
                    { 427, "Cátedra Ciencia, Tecnología y Desarrollo" },
                    { 428, "Bioética y marco legal en salud" },
                    { 429, "Diversidad e inclusión social" },
                    { 430, "Fundamentos del habla y deglución" },
                    { 431, "Fundamentos del lenguaje" },
                    { 432, "Fundamentos de la audición" },
                    { 433, "Desórdenes en la comunicación" },
                    { 434, "Psicolingüística" },
                    { 435, "Diagnóstico de desórdenes del habla" },
                    { 436, "Lenguaje en primera infancia y del adolescente" },
                    { 437, "Diagnóstico de desórdenes de la audición" },
                    { 438, "Sistema de seguridad social en salud" },
                    { 439, "Cátedra para la Democracia" },
                    { 440, "Planes de promoción, prevención e intervención de desórdenes del habla" },
                    { 441, "Planes de promoción, prevención e intervención de desórdenes del lenguaje" },
                    { 442, "Planes de promoción, prevención e intervención de desórdenes de la audición" },
                    { 443, "Abordaje interdisciplinario en discapacidad" },
                    { 444, "Metodología de Investigación I" },
                    { 445, "Gerencia y gestión" },
                    { 446, "Intervención en desórdenes del proceso de comunicación en la primera infancia" },
                    { 447, "Lenguaje en el aprendizaje I" },
                    { 448, "Rehabilitación basada en comunidad" },
                    { 449, "Investigación en salud" },
                    { 450, "Intervención en desórdenes del proceso de comunicación en el adulto y trabajadores" },
                    { 451, "Lenguaje en el aprendizaje II" },
                    { 452, "Rehabilitación basada en comunidad en el adulto/discapacidad" },
                    { 453, "Intervención en desórdenes del proceso de comunicación en el adulto y adulto mayor" },
                    { 454, "Audiología" },
                    { 455, "Lenguaje en el aprendizaje III" },
                    { 456, "Campo de acción comunitario" },
                    { 457, "Campo de acción asistencial" },
                    { 458, "Biología básica" },
                    { 459, "Matemáticas" },
                    { 460, "Introducción a la Regencia de Farmacia" },
                    { 461, "Herramientas ofimáticas para regencia" },
                    { 462, "Fisioanatomía" },
                    { 463, "Bioquímica farmacéutica" },
                    { 464, "Ética y Bioética" },
                    { 465, "Farmacia Magistral" },
                    { 466, "Farmacología I" },
                    { 467, "Fundamentos de administración y mercadeo" },
                    { 468, "Legislación farmacéutica" },
                    { 469, "Gestión administrativa en farmacia" },
                    { 470, "Dispositivos médicos" },
                    { 471, "Farmacología II" },
                    { 472, "Contabilidad y presupuesto" },
                    { 473, "Farmacovigilancia y tecnovigilancia" },
                    { 474, "Promoción de la salud y APS" },
                    { 475, "Gestión integral de recursos en los establecimientos y servicios farmacéuticos" },
                    { 476, "Farmacia veterinaria" },
                    { 477, "Farmacia vegetal" },
                    { 478, "Prácticas en regencia de farmacia" },
                    { 479, "Fundamentos de administración" },
                    { 480, "Pensamiento administrativo" },
                    { 481, "Microeconomía" },
                    { 482, "Matemáticas aplicadas a los negocios" },
                    { 483, "Planeación" },
                    { 484, "Tendencias administrativas" },
                    { 485, "Emprendimiento empresarial" },
                    { 486, "Macroeconomía" },
                    { 487, "Estadística aplicada a los negocios" },
                    { 488, "Derecho constitucional" },
                    { 489, "Organización" },
                    { 490, "Desarrollo empresarial" },
                    { 491, "Competitividad empresarial" },
                    { 492, "Matemáticas financiera" },
                    { 493, "Contabilidad empresarial" },
                    { 494, "Dirección" },
                    { 495, "Principios de mercadeo" },
                    { 496, "Costos y presupuestos" },
                    { 497, "Habilidades directivas" },
                    { 498, "Derecho empresarial" },
                    { 499, "Control" },
                    { 500, "Pronósticos en los negocios" },
                    { 501, "Investigación de mercados" },
                    { 502, "Legislación tributaria" },
                    { 503, "Gestión de operaciones y logística" },
                    { 504, "Gestión de negocios internacionales" },
                    { 505, "Comportamiento organizacional" },
                    { 506, "Análisis financiero" },
                    { 507, "Gestión pública" },
                    { 508, "Gestión de la calidad" },
                    { 509, "Sistema de información gerencial" },
                    { 510, "Responsabilidad social y ambiental" },
                    { 511, "Gerencia comercial" },
                    { 512, "Gestión del talento humano I" },
                    { 513, "Gestión financiera" },
                    { 514, "Inglés de negocios I" },
                    { 515, "Gerencia estratégica" },
                    { 516, "Gestión del talento humano II" },
                    { 517, "Inglés de negocios II" },
                    { 518, "Consultorio empresarial" },
                    { 519, "Gerencia de proyectos" },
                    { 520, "Simulación gerencial" },
                    { 521, "Inglés de negocios III" },
                    { 522, "Introducción a la contaduría" },
                    { 523, "Matemáticas aplicadas" },
                    { 524, "Contabilidad financiera I" },
                    { 525, "Sociología empresarial" },
                    { 526, "Fundamentos de economía" },
                    { 527, "Contabilidad financiera II" },
                    { 528, "Matemáticas financieras" },
                    { 529, "Derecho comercial" },
                    { 530, "Contabilidad financiera III" },
                    { 531, "Derecho laboral" },
                    { 532, "Contabilidad financiera IV" },
                    { 533, "Legislación tributaria I" },
                    { 534, "Sistemas de información contable" },
                    { 535, "Teoría e investigación contable" },
                    { 536, "Gestión de operaciones" },
                    { 537, "Costos I" },
                    { 538, "Contabilidad y presupuesto público" },
                    { 539, "Legislación tributaria II" },
                    { 540, "Costos II" },
                    { 541, "Legislación tributaria III" },
                    { 542, "Control interno y auditoría" },
                    { 543, "Contabilidad internacional" },
                    { 544, "Presupuestos" },
                    { 545, "Auditoría financiera y NIAS" },
                    { 546, "Gerencia financiera" },
                    { 547, "Contabilidades especiales" },
                    { 548, "Revisoría fiscal" },
                    { 549, "Derecho constitucional colombiano" },
                    { 550, "Introducción a la economía" },
                    { 551, "Cálculo I" },
                    { 552, "Contabilidad" },
                    { 553, "Microeconomía I" },
                    { 554, "Economía política I" },
                    { 555, "Cálculo II" },
                    { 556, "Álgebra lineal y programación lineal" },
                    { 557, "Microeconomía II" },
                    { 558, "Economía política II" },
                    { 559, "Nueva geografía económica" },
                    { 560, "Sociología" },
                    { 561, "Historia económica de Colombia" },
                    { 562, "Macroeconomía I" },
                    { 563, "Teoría de juegos" },
                    { 564, "Estadística I" },
                    { 565, "Estadística II" },
                    { 566, "Macroeconomía II" },
                    { 567, "Cuentas nacionales" },
                    { 568, "Economía latinoamericana" },
                    { 569, "Teoría y política monetaria y bancaria" },
                    { 570, "Econometría I" },
                    { 571, "Economía regional" },
                    { 572, "Teoría de las finanzas públicas" },
                    { 573, "Planeación del desarrollo" },
                    { 574, "Econometría II" },
                    { 575, "Teoría y política agraria" },
                    { 576, "Pensamiento económico" },
                    { 577, "Teoría y política fiscal" },
                    { 578, "Derecho económico" },
                    { 579, "Formulación y evaluación financiera de proyectos" },
                    { 580, "Teoría y política del comercio internacional" },
                    { 581, "Desarrollo económico y social" },
                    { 582, "Opción de grado I" },
                    { 583, "Evaluación socioeconómica de proyectos" },
                    { 584, "Política industrial y de servicios" },
                    { 585, "Opción de grado II" },
                    { 586, "Seminario políticas de coyuntura" },
                    { 587, "Antropología" },
                    { 588, "Estrategias de producto" },
                    { 589, "Comportamiento del consumidor" },
                    { 590, "Investigación cuantitativa de mercados" },
                    { 591, "Estrategia de precio" },
                    { 592, "Investigación cualitativa de mercados" },
                    { 593, "Distribución y logística" },
                    { 594, "Entornos globales" },
                    { 595, "Mercadeo internacional" },
                    { 596, "Publicidad" },
                    { 597, "Mercadeo de servicios" },
                    { 598, "Planeación estratégica de marketing" },
                    { 599, "Ética" },
                    { 600, "Merchandising y promoción de venta" },
                    { 601, "Relaciones públicas y organización de eventos" },
                    { 602, "Marketing electrónico" },
                    { 603, "Servicio al cliente" },
                    { 604, "Marketing social" },
                    { 605, "Gerencia estratégica de marketing" },
                    { 606, "Introducción a la Narratología" },
                    { 607, "Fundamentos de Apreciación cinematográfica" },
                    { 608, "Cultura, comunicación y territorio" },
                    { 609, "Procesos creativos" },
                    { 610, "Taller I: Introducción al audiovisual" },
                    { 611, "Escritura de Guiones" },
                    { 612, "Argumentación y debate: Historia contemporánea" },
                    { 613, "Taller II: Dirección" },
                    { 614, "Teorías del cine" },
                    { 615, "Preparación de actores" },
                    { 616, "Tecnología del video I" },
                    { 617, "Apreciación Audiovisual I" },
                    { 618, "Historia de las artes" },
                    { 619, "Taller III: Producción de audiovisuales" },
                    { 620, "Teorías de la comunicación I" },
                    { 621, "Mercadeo y diseño" },
                    { 622, "Tecnología del video II" },
                    { 623, "Exploración investigativa" },
                    { 624, "Taller IV: Dirección de fotografía" },
                    { 625, "Teorías de la comunicación II" },
                    { 626, "Historia de la imagen" },
                    { 627, "Apreciación Audiovisual II" },
                    { 628, "Documental I" },
                    { 629, "Taller V: Dirección de sonido" },
                    { 630, "Investigación en comunicación" },
                    { 631, "Fundamentos de música" },
                    { 632, "Documental II" },
                    { 633, "Audiovisual comunitario I" },
                    { 634, "Taller VI: Dirección de arte" },
                    { 635, "Investigación creación" },
                    { 636, "Semiótica" },
                    { 637, "Animación I" },
                    { 638, "Apreciación Audiovisual III" },
                    { 639, "Audiovisual comunitario II" },
                    { 640, "Taller VII: Montaje" },
                    { 641, "Colorización y Efectos visuales" },
                    { 642, "Televisión y otros formatos audiovisuales" },
                    { 643, "Animación II" },
                    { 644, "Medios informativos" },
                    { 645, "Bases de programación" },
                    { 646, "Transmedia" },
                    { 647, "Innovación en comunicación" },
                    { 648, "Fundamentos de antropología" },
                    { 649, "Epistemología de la educación" },
                    { 650, "Fundamentos de la producción agropecuaria" },
                    { 651, "Fundamentos de sociología" },
                    { 652, "Desarrollo humano y social" },
                    { 653, "Suelos, fertilidad y manejo" },
                    { 654, "Aprendizaje y educación" },
                    { 655, "Zoología" },
                    { 656, "Botánica" },
                    { 657, "Recursos naturales" },
                    { 658, "Ingeniería para las explotaciones agropecuarias" },
                    { 659, "Modelos pedagógicos de educación rural" },
                    { 660, "Sanidad vegetal" },
                    { 661, "Diversidad y educación rural. Práctica de observación" },
                    { 662, "Didáctica de la educación rural" },
                    { 663, "Genética y mejoramiento animal y vegetal" },
                    { 664, "Horticultura y seguridad alimentaria" },
                    { 665, "Proyectos pedagógicos productivos (práctica de intervención I)" },
                    { 666, "Didáctica de la educación comunitaria" },
                    { 667, "Geografía humana y social" },
                    { 668, "Sanidad animal" },
                    { 669, "Economía y finanzas" },
                    { 670, "Educación y extensión rural (práctica de intervención II)" },
                    { 671, "Investigación y sistematización de experiencias" },
                    { 672, "Ambientes, mediaciones pedagógicas y evaluación" },
                    { 673, "Política agraria y legislación educativa" },
                    { 674, "Cultivos agrícolas" },
                    { 675, "Proyecto escuelas saludables (práctica de investigación I)" },
                    { 676, "Ética y docencia" },
                    { 677, "Administración y agro negocios" },
                    { 678, "Contextos educativos rurales (práctica de investigación II)" },
                    { 679, "Producción de especies mayores" },
                    { 680, "Organización comunitaria y emprendimiento agroindustrial (práctica de intervención III)" },
                    { 681, "Contextos rurales comunitarios (práctica de investigación III)" },
                    { 682, "Práctica profesional docente" },
                    { 683, "Bioquímica y nutrición" },
                    { 684, "Seminario de investigación I" },
                    { 685, "Problemas históricos de la pedagogía" },
                    { 686, "Expresiones motrices I" },
                    { 687, "Desarrollo cognitivo" },
                    { 688, "Morfología funcional del aparato locomotor" },
                    { 689, "Sujeto y educación" },
                    { 690, "Problemas epistemológicos de la pedagogía" },
                    { 691, "Expresiones motrices II" },
                    { 692, "Motricidad y desarrollo humano" },
                    { 693, "Expresiones motrices III" },
                    { 694, "Fisiología humana" },
                    { 695, "Historia y epistemología de la educación física" },
                    { 696, "Corrientes pedagógicas contemporáneas de la educación física" },
                    { 697, "Seminario de investigación II" },
                    { 698, "Práctica educativa escolar" },
                    { 699, "Motricidad y fases sensibles" },
                    { 700, "Educación e interculturalidad" },
                    { 701, "Expresiones motrices IV" },
                    { 702, "Fisiología del esfuerzo" },
                    { 703, "Expresiones motrices V" },
                    { 704, "Didáctica general y de la educación física" },
                    { 705, "Pedagogía lúdica" },
                    { 706, "Escuela e inclusión" },
                    { 707, "Gestión de la educación física y el deporte" },
                    { 708, "Mediaciones pedagógicas" },
                    { 709, "Biomecánica y análisis del movimiento" },
                    { 710, "Expresiones motrices VI" },
                    { 711, "Práctica educativa media" },
                    { 712, "Investigación I" },
                    { 713, "Fundamentos del entrenamiento y preparación deportiva" },
                    { 714, "Expresiones motrices VII" },
                    { 715, "Currículo y evaluación de la educación física" },
                    { 716, "Ocio y tiempo libre" },
                    { 717, "Cuerpo, sujeto y cultura" },
                    { 718, "Necesidades educativas especiales" },
                    { 719, "Educación física y ambientalismo" },
                    { 720, "Expresiones motrices VIII" },
                    { 721, "Investigación II" },
                    { 722, "Práctica educativa extraescolar" },
                    { 723, "Deontología del campo profesoral" },
                    { 724, "Historia y epistemología de la pedagogía I" },
                    { 725, "Identidad docente y constitución de si" },
                    { 726, "Juego y educación infantil" },
                    { 727, "Educación, cuerpo y movimiento" },
                    { 728, "Seminario de pis, investigación biográfica-narrativa" },
                    { 729, "Historia y epistemología de la pedagogía II" },
                    { 730, "Ética, interacción humana y educación" },
                    { 731, "Matemática I" },
                    { 732, "Desarrollo humano, aprendizaje y educación" },
                    { 733, "Expresión musical y didáctica" },
                    { 734, "Seminario de práctica: infancia, escuela y maestro" },
                    { 735, "Seminario de pis: investigación biográfico-narrativa" },
                    { 736, "Neuropedagogía" },
                    { 737, "Didáctica del juego dramático y coreográfico" },
                    { 738, "Práctica: entornos educativos y socioculturales de la infancia" },
                    { 739, "Escenarios de socialización del niño" },
                    { 740, "Representaciones sociales de infancia" },
                    { 741, "Seminario de pis. Cartografía social" },
                    { 742, "Género, cultura y educación" },
                    { 743, "Tecnologías de la comunicación como mediaciones" },
                    { 744, "Expresión plástica y didáctica" },
                    { 745, "Práctica: entornos protectores de infancia" },
                    { 746, "Filosofía para niños" },
                    { 747, "Literatura infantil" },
                    { 748, "Evaluación del desarrollo y aprendizaje" },
                    { 749, "Práctica: primera infancia I" },
                    { 750, "Perspectivas pedagógicas de la educación infantil" },
                    { 751, "Desarrollo y formación del niño en los años iniciales" },
                    { 752, "Seminario de pis. Estudio de caso" },
                    { 753, "Didáctica de las matemáticas" },
                    { 754, "Didáctica de la lectura, la escritura y la oralidad" },
                    { 755, "Práctica: primera infancia II" },
                    { 756, "Desarrollo y formación en la infancia" },
                    { 757, "Diversidad funcional y sociocultural" },
                    { 758, "Práctica: educación y diversidad" },
                    { 759, "Metodología. La infancia como campo de investigación I" },
                    { 760, "Seminario de pis. Etnografía" },
                    { 761, "Práctica: escuela y entornos de aprendizaje" },
                    { 762, "Metodología. La infancia como campo de investigación II" },
                    { 763, "Seminario. Investigación acción" },
                    { 764, "Legislación, gestión y currículo" },
                    { 765, "Seminario de investigación acción" },
                    { 766, "Práctica: la escuela como escenario de investigación I" },
                    { 767, "Práctica educativa: la escuela como escenario de investigación II" },
                    { 768, "Pensamiento Lógico – Matemático" },
                    { 769, "Literatura general" },
                    { 770, "Listening and speaking in second language I" },
                    { 771, "Reading and writing in second language I" },
                    { 772, "Ética Educativa" },
                    { 773, "Ciencia, Tecnología y Desarrollo" },
                    { 774, "Literatura hispanoamericana" },
                    { 775, "Morfosintaxis" },
                    { 776, "Listening and speaking in second language II" },
                    { 777, "Reading and writing in second language II" },
                    { 778, "Sociología de la educación" },
                    { 779, "Sociolingüística" },
                    { 780, "Listening and speaking in second language III" },
                    { 781, "Reading and writing in second language III" },
                    { 782, "Phonetics and phonology" },
                    { 783, "Administración, currículo y legislación" },
                    { 784, "English language history and culture" },
                    { 785, "Listening and speaking in second language IV" },
                    { 786, "Reading and writing in second language IV" },
                    { 787, "Linguistics" },
                    { 788, "Corrientes pedagógicas contemporáneas: Práctica de Observación 1" },
                    { 789, "Etnoeducación" },
                    { 790, "English Literature" },
                    { 791, "Listening and speaking in second language V" },
                    { 792, "Reading and writing in second language V" },
                    { 793, "Educación inclusiva" },
                    { 794, "Tendencias educativas de la enseñanza de una segunda lengua: Práctica de observación 2" },
                    { 795, "Advanced grammar" },
                    { 796, "Academic writing" },
                    { 797, "Quantitative and qualitative research" },
                    { 798, "Strategies and approaches for ICT-enhanced learning" },
                    { 799, "Didactics I" },
                    { 800, "Didáctica de la Lengua Castellana" },
                    { 801, "Educational research" },
                    { 802, "Didactics II" },
                    { 803, "Práctica I" },
                    { 804, "Práctica de la lengua castellana" },
                    { 805, "Language teaching and learning research" },
                    { 806, "Didactics III" },
                    { 807, "Práctica II" },
                    { 808, "Enseñanza del Español como L2" },
                    { 809, "Práctica investigativa y trabajo de grado" },
                    { 810, "Práctica III" },
                    { 811, "Práctica docente" },
                    { 812, "Precálculo" },
                    { 813, "Geometría euclidiana" },
                    { 814, "Fundamentos de matemáticas" },
                    { 815, "Geometría analítica" },
                    { 816, "Teoría de conjuntos" },
                    { 817, "Física introductoria" },
                    { 818, "Corrientes pedagógicas contemporáneas: práctica de observación I" },
                    { 819, "Teoría de números" },
                    { 820, "Tendencias educativas en matemáticas: práctica de observación II" },
                    { 821, "Mecánica I" },
                    { 822, "Didáctica de la aritmética" },
                    { 823, "Mecánica II" },
                    { 824, "Didáctica de la geometría" },
                    { 825, "Práctica I: enseñanza de la aritmética" },
                    { 826, "Sociedad, cultura y educación" },
                    { 827, "Etnomatemática: práctica de observación III" },
                    { 828, "Didáctica del álgebra" },
                    { 829, "Práctica II: enseñanza de la geometría" },
                    { 830, "Administración educativa y currículo" },
                    { 831, "Álgebra moderna" },
                    { 832, "Práctica III: enseñanza del álgebra" },
                    { 833, "Educación en la diversidad: práctica de observación IV" },
                    { 834, "Didáctica de la probabilidad y la estadística" },
                    { 835, "Análisis matemático" },
                    { 836, "Didáctica del cálculo" },
                    { 837, "Didáctica de la trigonometría" },
                    { 838, "Práctica IV: enseñanza probabilidad y la estadística" },
                    { 839, "Historia de la matemática" },
                    { 840, "Práctica V: enseñanza del cálculo y la trigonometría" },
                    { 841, "Práctica pedagógica investigativa" },
                    { 842, "Introducción a la sociología" },
                    { 843, "Geografía social y humana" },
                    { 844, "Comunicación y sociedad" },
                    { 845, "Geopolítica y geocultura" },
                    { 846, "Pensamiento lógico-matemático" },
                    { 847, "Introducción a la investigación en ciencias sociales" },
                    { 848, "Historia del pensamiento social moderno" },
                    { 849, "Introducción a la psicología social" },
                    { 850, "Ecología social y política" },
                    { 851, "Teoría clásica I" },
                    { 852, "Historia social de Colombia" },
                    { 853, "Organización social y sociología" },
                    { 854, "Población y demografía" },
                    { 855, "Teoría clásica II" },
                    { 856, "Diseños de investigación social" },
                    { 857, "Políticas públicas" },
                    { 858, "Teoría clásica III" },
                    { 859, "Sociología latinoamericana" },
                    { 860, "Métodos y técnicas de investigación social cuantitativa I" },
                    { 861, "Métodos y técnicas de investigación social cualitativa y participativa I" },
                    { 862, "Sociedad, migración y género" },
                    { 863, "Teoría contemporánea I" },
                    { 864, "Análisis sociológico de Colombia" },
                    { 865, "Sociología del desarrollo" },
                    { 866, "Sociología especial I" },
                    { 867, "Métodos y técnicas de investigación social cuantitativa II" },
                    { 868, "Métodos y técnicas de investigación social cualitativa y participativa II" },
                    { 869, "Teoría contemporánea II" },
                    { 870, "Sociología de la cultura" },
                    { 871, "Sociología especial II" },
                    { 872, "Estadística para Ciencias sociales" },
                    { 873, "Actores sociales y territorio" },
                    { 874, "Taller de escritura científica" },
                    { 875, "Teoría contemporánea III" },
                    { 876, "Sociología del conflicto" },
                    { 877, "Sociología especial III" },
                    { 878, "Práctica de investigación social" },
                    { 879, "Planeación participativa y desarrollo territorial" },
                    { 880, "Sociología ambiental" },
                    { 881, "Sociología especial IV" },
                    { 882, "Intervención social y comunitaria" },
                    { 883, "Seminario Proyecto Opción de grado" }
                });

            migrationBuilder.InsertData(
                table: "CareerSubjects",
                columns: new[] { "Id", "CareerId", "SemesterNumber", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 1, 2 },
                    { 3, 1, 1, 3 },
                    { 4, 1, 1, 4 },
                    { 5, 1, 1, 5 },
                    { 6, 1, 1, 6 },
                    { 7, 1, 2, 7 },
                    { 8, 1, 2, 8 },
                    { 9, 1, 2, 9 },
                    { 10, 1, 2, 10 },
                    { 11, 1, 2, 11 },
                    { 12, 1, 2, 12 },
                    { 13, 1, 3, 13 },
                    { 14, 1, 3, 14 },
                    { 15, 1, 3, 15 },
                    { 16, 1, 3, 16 },
                    { 17, 1, 3, 17 },
                    { 18, 1, 3, 18 },
                    { 19, 1, 3, 19 },
                    { 20, 1, 4, 20 },
                    { 21, 1, 4, 21 },
                    { 22, 1, 4, 22 },
                    { 23, 1, 4, 23 },
                    { 24, 1, 4, 24 },
                    { 25, 1, 4, 25 },
                    { 26, 1, 5, 26 },
                    { 27, 1, 5, 27 },
                    { 28, 1, 5, 28 },
                    { 29, 1, 5, 29 },
                    { 30, 1, 5, 30 },
                    { 31, 1, 5, 31 },
                    { 32, 1, 6, 32 },
                    { 33, 1, 6, 33 },
                    { 34, 1, 6, 34 },
                    { 35, 1, 6, 35 },
                    { 36, 1, 6, 36 },
                    { 37, 1, 6, 37 },
                    { 38, 1, 7, 38 },
                    { 39, 1, 7, 39 },
                    { 40, 1, 7, 40 },
                    { 41, 1, 7, 41 },
                    { 42, 1, 7, 42 },
                    { 43, 1, 8, 43 },
                    { 44, 1, 8, 44 },
                    { 45, 1, 8, 45 },
                    { 46, 1, 8, 46 },
                    { 47, 1, 9, 47 },
                    { 48, 1, 9, 48 },
                    { 49, 1, 9, 49 },
                    { 50, 1, 9, 50 },
                    { 51, 1, 9, 51 },
                    { 52, 1, 10, 52 },
                    { 53, 1, 10, 53 },
                    { 54, 2, 1, 54 },
                    { 55, 2, 1, 55 },
                    { 56, 2, 1, 2 },
                    { 57, 2, 1, 7 },
                    { 58, 2, 1, 56 },
                    { 59, 2, 1, 1 },
                    { 60, 2, 2, 11 },
                    { 61, 2, 2, 57 },
                    { 62, 2, 2, 9 },
                    { 63, 2, 2, 58 },
                    { 64, 2, 2, 59 },
                    { 65, 2, 2, 13 },
                    { 66, 2, 2, 25 },
                    { 67, 2, 3, 60 },
                    { 68, 2, 3, 61 },
                    { 69, 2, 3, 62 },
                    { 70, 2, 3, 63 },
                    { 71, 2, 3, 64 },
                    { 72, 2, 3, 65 },
                    { 73, 2, 3, 19 },
                    { 74, 2, 4, 66 },
                    { 75, 2, 4, 67 },
                    { 76, 2, 4, 68 },
                    { 77, 2, 4, 69 },
                    { 78, 2, 4, 70 },
                    { 79, 2, 4, 71 },
                    { 80, 2, 5, 72 },
                    { 81, 2, 5, 73 },
                    { 82, 2, 5, 74 },
                    { 83, 2, 5, 75 },
                    { 84, 2, 5, 76 },
                    { 85, 2, 5, 77 },
                    { 86, 2, 6, 78 },
                    { 87, 2, 6, 79 },
                    { 88, 2, 6, 80 },
                    { 89, 2, 6, 81 },
                    { 90, 2, 6, 82 },
                    { 91, 2, 7, 83 },
                    { 92, 2, 7, 84 },
                    { 93, 2, 7, 85 },
                    { 94, 2, 7, 86 },
                    { 95, 2, 8, 87 },
                    { 96, 2, 8, 88 },
                    { 97, 2, 8, 89 },
                    { 98, 2, 9, 90 },
                    { 99, 2, 9, 91 },
                    { 100, 2, 9, 92 },
                    { 101, 2, 10, 93 },
                    { 102, 2, 10, 53 },
                    { 103, 3, 1, 7 },
                    { 104, 3, 1, 17 },
                    { 105, 3, 1, 4 },
                    { 106, 3, 1, 94 },
                    { 107, 3, 1, 95 },
                    { 108, 3, 1, 96 },
                    { 109, 3, 2, 97 },
                    { 110, 3, 2, 98 },
                    { 111, 3, 2, 99 },
                    { 112, 3, 2, 100 },
                    { 113, 3, 2, 101 },
                    { 114, 3, 3, 102 },
                    { 115, 3, 3, 103 },
                    { 116, 3, 3, 104 },
                    { 117, 3, 3, 105 },
                    { 118, 3, 3, 106 },
                    { 119, 3, 3, 107 },
                    { 120, 3, 4, 26 },
                    { 121, 3, 4, 108 },
                    { 122, 3, 4, 109 },
                    { 123, 3, 4, 19 },
                    { 124, 3, 4, 110 },
                    { 125, 3, 4, 111 },
                    { 126, 3, 5, 112 },
                    { 127, 3, 5, 113 },
                    { 128, 3, 5, 114 },
                    { 129, 3, 5, 115 },
                    { 130, 3, 5, 116 },
                    { 131, 3, 5, 117 },
                    { 132, 3, 6, 118 },
                    { 133, 3, 6, 119 },
                    { 134, 3, 6, 120 },
                    { 135, 3, 6, 121 },
                    { 136, 3, 6, 122 },
                    { 137, 3, 6, 123 },
                    { 138, 3, 7, 124 },
                    { 139, 3, 7, 125 },
                    { 140, 3, 7, 126 },
                    { 141, 3, 7, 127 },
                    { 142, 3, 7, 128 },
                    { 143, 3, 8, 129 },
                    { 144, 3, 8, 130 },
                    { 145, 3, 8, 131 },
                    { 146, 3, 8, 132 },
                    { 147, 3, 8, 133 },
                    { 148, 3, 9, 134 },
                    { 149, 3, 9, 135 },
                    { 150, 3, 9, 136 },
                    { 151, 3, 9, 137 },
                    { 152, 3, 9, 138 },
                    { 153, 3, 10, 93 },
                    { 154, 3, 10, 47 },
                    { 155, 3, 10, 139 },
                    { 156, 3, 10, 53 },
                    { 157, 4, 1, 2 },
                    { 158, 4, 1, 54 },
                    { 159, 4, 1, 4 },
                    { 160, 4, 1, 140 },
                    { 161, 4, 1, 7 },
                    { 162, 4, 2, 9 },
                    { 163, 4, 2, 10 },
                    { 164, 4, 2, 11 },
                    { 165, 4, 2, 141 },
                    { 166, 4, 2, 64 },
                    { 167, 4, 2, 13 },
                    { 168, 4, 3, 8 },
                    { 169, 4, 3, 15 },
                    { 170, 4, 3, 60 },
                    { 171, 4, 3, 142 },
                    { 172, 4, 3, 143 },
                    { 173, 4, 3, 144 },
                    { 174, 4, 4, 145 },
                    { 175, 4, 4, 69 },
                    { 176, 4, 4, 146 },
                    { 177, 4, 4, 147 },
                    { 178, 4, 4, 148 },
                    { 179, 4, 4, 25 },
                    { 180, 4, 5, 149 },
                    { 181, 4, 5, 150 },
                    { 182, 4, 5, 151 },
                    { 183, 4, 5, 152 },
                    { 184, 4, 5, 153 },
                    { 185, 4, 6, 154 },
                    { 186, 4, 6, 32 },
                    { 187, 4, 6, 155 },
                    { 188, 4, 6, 156 },
                    { 189, 4, 6, 157 },
                    { 190, 4, 6, 19 },
                    { 191, 4, 7, 158 },
                    { 192, 4, 7, 159 },
                    { 193, 4, 7, 160 },
                    { 194, 4, 7, 161 },
                    { 195, 4, 7, 162 },
                    { 196, 4, 7, 163 },
                    { 197, 4, 8, 164 },
                    { 198, 4, 8, 165 },
                    { 199, 4, 8, 166 },
                    { 200, 4, 8, 167 },
                    { 201, 4, 8, 168 },
                    { 202, 4, 9, 169 },
                    { 203, 4, 9, 170 },
                    { 204, 4, 9, 171 },
                    { 205, 4, 10, 93 },
                    { 206, 5, 1, 172 },
                    { 207, 5, 1, 2 },
                    { 208, 5, 1, 173 },
                    { 209, 5, 1, 174 },
                    { 210, 5, 1, 1 },
                    { 211, 5, 1, 7 },
                    { 212, 5, 2, 9 },
                    { 213, 5, 2, 175 },
                    { 214, 5, 2, 176 },
                    { 215, 5, 2, 177 },
                    { 216, 5, 2, 25 },
                    { 217, 5, 3, 62 },
                    { 218, 5, 3, 178 },
                    { 219, 5, 3, 179 },
                    { 220, 5, 3, 180 },
                    { 221, 5, 3, 13 },
                    { 222, 5, 4, 106 },
                    { 223, 5, 4, 181 },
                    { 224, 5, 4, 182 },
                    { 225, 5, 4, 183 },
                    { 226, 5, 4, 19 },
                    { 227, 5, 5, 26 },
                    { 228, 5, 5, 184 },
                    { 229, 5, 5, 185 },
                    { 230, 5, 5, 186 },
                    { 231, 5, 5, 187 },
                    { 232, 5, 6, 188 },
                    { 233, 5, 6, 66 },
                    { 234, 5, 6, 189 },
                    { 235, 5, 6, 69 },
                    { 236, 5, 6, 190 },
                    { 237, 5, 7, 191 },
                    { 238, 5, 7, 192 },
                    { 239, 5, 7, 193 },
                    { 240, 5, 7, 194 },
                    { 241, 5, 7, 195 },
                    { 242, 5, 8, 196 },
                    { 243, 5, 8, 61 },
                    { 244, 5, 8, 197 },
                    { 245, 5, 8, 198 },
                    { 246, 5, 8, 199 },
                    { 247, 5, 9, 200 },
                    { 248, 5, 10, 53 },
                    { 249, 6, 1, 201 },
                    { 250, 6, 1, 202 },
                    { 251, 6, 1, 203 },
                    { 252, 6, 1, 58 },
                    { 253, 6, 1, 204 },
                    { 254, 6, 2, 99 },
                    { 255, 6, 2, 205 },
                    { 256, 6, 2, 206 },
                    { 257, 6, 2, 207 },
                    { 258, 6, 2, 8 },
                    { 259, 6, 3, 208 },
                    { 260, 6, 3, 209 },
                    { 261, 6, 3, 17 },
                    { 262, 6, 3, 210 },
                    { 263, 6, 3, 16 },
                    { 264, 6, 3, 1 },
                    { 265, 6, 4, 211 },
                    { 266, 6, 4, 26 },
                    { 267, 6, 4, 212 },
                    { 268, 6, 4, 213 },
                    { 269, 6, 4, 214 },
                    { 270, 6, 4, 215 },
                    { 271, 6, 5, 29 },
                    { 272, 6, 5, 154 },
                    { 273, 6, 5, 216 },
                    { 274, 6, 5, 217 },
                    { 275, 6, 5, 218 },
                    { 276, 6, 5, 7 },
                    { 277, 6, 6, 148 },
                    { 278, 6, 6, 219 },
                    { 279, 6, 6, 220 },
                    { 280, 6, 6, 221 },
                    { 281, 6, 6, 222 },
                    { 282, 6, 6, 19 },
                    { 283, 6, 7, 223 },
                    { 284, 6, 7, 224 },
                    { 285, 6, 7, 225 },
                    { 286, 6, 7, 226 },
                    { 287, 6, 7, 227 },
                    { 288, 6, 7, 228 },
                    { 289, 6, 8, 229 },
                    { 290, 6, 8, 230 },
                    { 291, 6, 8, 231 },
                    { 292, 6, 8, 232 },
                    { 293, 6, 8, 25 },
                    { 294, 6, 9, 233 },
                    { 295, 6, 9, 234 },
                    { 296, 6, 9, 235 },
                    { 297, 6, 9, 236 },
                    { 298, 6, 10, 237 },
                    { 299, 7, 1, 203 },
                    { 300, 7, 1, 54 },
                    { 301, 7, 1, 7 },
                    { 302, 7, 1, 96 },
                    { 303, 7, 1, 238 },
                    { 304, 7, 1, 239 },
                    { 305, 7, 2, 206 },
                    { 306, 7, 2, 58 },
                    { 307, 7, 2, 240 },
                    { 308, 7, 2, 11 },
                    { 309, 7, 2, 241 },
                    { 310, 7, 3, 208 },
                    { 311, 7, 3, 242 },
                    { 312, 7, 3, 8 },
                    { 313, 7, 3, 243 },
                    { 314, 7, 3, 16 },
                    { 315, 7, 4, 211 },
                    { 316, 7, 4, 244 },
                    { 317, 7, 4, 29 },
                    { 318, 7, 4, 22 },
                    { 319, 7, 4, 245 },
                    { 320, 7, 4, 21 },
                    { 321, 7, 5, 19 },
                    { 322, 7, 5, 246 },
                    { 323, 7, 5, 81 },
                    { 324, 7, 5, 247 },
                    { 325, 7, 5, 248 },
                    { 326, 7, 5, 249 },
                    { 327, 7, 5, 250 },
                    { 328, 7, 6, 251 },
                    { 329, 7, 6, 252 },
                    { 330, 7, 6, 253 },
                    { 331, 7, 6, 254 },
                    { 332, 7, 6, 255 },
                    { 333, 7, 6, 256 },
                    { 334, 7, 7, 257 },
                    { 335, 7, 7, 258 },
                    { 336, 7, 7, 259 },
                    { 337, 7, 7, 260 },
                    { 338, 7, 8, 25 },
                    { 339, 7, 8, 261 },
                    { 340, 7, 8, 262 },
                    { 341, 7, 9, 49 },
                    { 342, 7, 9, 263 },
                    { 343, 7, 9, 264 },
                    { 344, 7, 10, 53 },
                    { 345, 8, 1, 265 },
                    { 346, 8, 1, 266 },
                    { 347, 8, 1, 203 },
                    { 348, 8, 1, 7 },
                    { 349, 8, 1, 96 },
                    { 350, 8, 2, 267 },
                    { 351, 8, 2, 268 },
                    { 352, 8, 2, 206 },
                    { 353, 8, 2, 8 },
                    { 354, 8, 2, 58 },
                    { 355, 8, 3, 269 },
                    { 356, 8, 3, 270 },
                    { 357, 8, 3, 271 },
                    { 358, 8, 3, 208 },
                    { 359, 8, 3, 242 },
                    { 360, 8, 4, 272 },
                    { 361, 8, 4, 273 },
                    { 362, 8, 4, 274 },
                    { 363, 8, 4, 275 },
                    { 364, 8, 4, 276 },
                    { 365, 8, 5, 277 },
                    { 366, 8, 5, 278 },
                    { 367, 8, 5, 279 },
                    { 368, 8, 5, 280 },
                    { 369, 8, 5, 281 },
                    { 370, 8, 5, 19 },
                    { 371, 8, 6, 282 },
                    { 372, 8, 6, 246 },
                    { 373, 8, 6, 283 },
                    { 374, 8, 6, 284 },
                    { 375, 8, 6, 285 },
                    { 376, 8, 6, 286 },
                    { 377, 8, 7, 32 },
                    { 378, 8, 7, 287 },
                    { 379, 8, 7, 288 },
                    { 380, 8, 7, 289 },
                    { 381, 8, 7, 290 },
                    { 382, 8, 7, 291 },
                    { 383, 8, 8, 292 },
                    { 384, 8, 8, 293 },
                    { 385, 8, 8, 294 },
                    { 386, 8, 8, 13 },
                    { 387, 8, 9, 295 },
                    { 388, 8, 9, 13 },
                    { 389, 8, 10, 296 },
                    { 390, 9, 1, 297 },
                    { 391, 9, 1, 298 },
                    { 392, 9, 1, 299 },
                    { 393, 9, 1, 300 },
                    { 394, 9, 1, 301 },
                    { 395, 9, 1, 302 },
                    { 396, 9, 2, 303 },
                    { 397, 9, 2, 304 },
                    { 398, 9, 2, 305 },
                    { 399, 9, 2, 306 },
                    { 400, 9, 2, 307 },
                    { 401, 9, 3, 308 },
                    { 402, 9, 3, 309 },
                    { 403, 9, 3, 310 },
                    { 404, 9, 3, 311 },
                    { 405, 9, 4, 312 },
                    { 406, 9, 4, 313 },
                    { 407, 9, 4, 314 },
                    { 408, 9, 4, 315 },
                    { 409, 9, 4, 316 },
                    { 410, 9, 5, 317 },
                    { 411, 9, 5, 318 },
                    { 412, 9, 5, 319 },
                    { 413, 9, 5, 320 },
                    { 414, 9, 5, 321 },
                    { 415, 9, 6, 322 },
                    { 416, 9, 6, 323 },
                    { 417, 9, 6, 324 },
                    { 418, 9, 6, 325 },
                    { 419, 9, 6, 326 },
                    { 420, 9, 6, 327 },
                    { 421, 9, 7, 328 },
                    { 422, 9, 7, 329 },
                    { 423, 9, 7, 330 },
                    { 424, 9, 7, 331 },
                    { 425, 9, 7, 332 },
                    { 426, 9, 7, 333 },
                    { 427, 9, 7, 334 },
                    { 428, 9, 8, 335 },
                    { 429, 9, 8, 336 },
                    { 430, 9, 8, 337 },
                    { 431, 9, 8, 338 },
                    { 432, 9, 9, 339 },
                    { 433, 9, 10, 340 },
                    { 434, 10, 1, 341 },
                    { 435, 10, 1, 342 },
                    { 436, 10, 1, 343 },
                    { 437, 10, 1, 344 },
                    { 438, 10, 1, 7 },
                    { 439, 10, 1, 1 },
                    { 440, 10, 2, 345 },
                    { 441, 10, 2, 346 },
                    { 442, 10, 2, 203 },
                    { 443, 10, 2, 8 },
                    { 444, 10, 2, 269 },
                    { 445, 10, 2, 13 },
                    { 446, 10, 3, 270 },
                    { 447, 10, 3, 347 },
                    { 448, 10, 3, 273 },
                    { 449, 10, 3, 348 },
                    { 450, 10, 3, 349 },
                    { 451, 10, 4, 350 },
                    { 452, 10, 4, 351 },
                    { 453, 10, 4, 352 },
                    { 454, 10, 4, 353 },
                    { 455, 10, 4, 272 },
                    { 456, 10, 4, 209 },
                    { 457, 10, 5, 354 },
                    { 458, 10, 5, 355 },
                    { 459, 10, 5, 356 },
                    { 460, 10, 5, 357 },
                    { 461, 10, 5, 358 },
                    { 462, 10, 5, 359 },
                    { 463, 10, 6, 360 },
                    { 464, 10, 6, 290 },
                    { 465, 10, 6, 361 },
                    { 466, 11, 1, 362 },
                    { 467, 11, 1, 363 },
                    { 468, 11, 1, 364 },
                    { 469, 11, 1, 1 },
                    { 470, 11, 1, 7 },
                    { 471, 11, 1, 365 },
                    { 472, 11, 2, 366 },
                    { 473, 11, 2, 367 },
                    { 474, 11, 2, 368 },
                    { 475, 11, 2, 369 },
                    { 476, 11, 3, 370 },
                    { 477, 11, 3, 114 },
                    { 478, 11, 3, 19 },
                    { 479, 11, 3, 371 },
                    { 480, 11, 3, 372 },
                    { 481, 11, 4, 106 },
                    { 482, 11, 4, 373 },
                    { 483, 11, 4, 374 },
                    { 484, 11, 4, 375 },
                    { 485, 11, 4, 376 },
                    { 486, 11, 4, 13 },
                    { 487, 11, 5, 125 },
                    { 488, 11, 5, 377 },
                    { 489, 11, 5, 378 },
                    { 490, 11, 5, 379 },
                    { 491, 11, 5, 25 },
                    { 492, 11, 6, 380 },
                    { 493, 11, 6, 381 },
                    { 494, 11, 6, 382 },
                    { 495, 11, 6, 383 },
                    { 496, 11, 7, 384 },
                    { 497, 11, 7, 385 },
                    { 498, 11, 7, 386 },
                    { 499, 11, 8, 387 },
                    { 500, 11, 8, 388 },
                    { 501, 11, 9, 389 },
                    { 502, 11, 9, 390 },
                    { 503, 11, 9, 53 },
                    { 504, 12, 1, 391 },
                    { 505, 12, 1, 392 },
                    { 506, 12, 1, 364 },
                    { 507, 12, 1, 7 },
                    { 508, 12, 1, 393 },
                    { 509, 12, 2, 394 },
                    { 510, 12, 2, 395 },
                    { 511, 12, 2, 368 },
                    { 512, 12, 2, 396 },
                    { 513, 12, 2, 1 },
                    { 514, 12, 2, 397 },
                    { 515, 12, 2, 398 },
                    { 516, 12, 3, 114 },
                    { 517, 12, 3, 399 },
                    { 518, 12, 3, 400 },
                    { 519, 12, 3, 401 },
                    { 520, 12, 3, 402 },
                    { 521, 12, 3, 19 },
                    { 522, 12, 4, 106 },
                    { 523, 12, 4, 403 },
                    { 524, 12, 4, 404 },
                    { 525, 12, 4, 405 },
                    { 526, 12, 4, 13 },
                    { 527, 12, 5, 125 },
                    { 528, 12, 5, 406 },
                    { 529, 12, 5, 407 },
                    { 530, 12, 5, 408 },
                    { 531, 12, 6, 200 },
                    { 532, 12, 6, 409 },
                    { 533, 12, 6, 410 },
                    { 534, 12, 7, 380 },
                    { 535, 12, 7, 411 },
                    { 536, 12, 7, 25 },
                    { 537, 12, 8, 384 },
                    { 538, 12, 8, 412 },
                    { 539, 12, 8, 413 },
                    { 540, 12, 9, 414 },
                    { 541, 12, 9, 415 },
                    { 542, 12, 9, 416 },
                    { 543, 12, 9, 417 },
                    { 544, 13, 1, 363 },
                    { 545, 13, 1, 364 },
                    { 546, 13, 1, 418 },
                    { 547, 13, 1, 419 },
                    { 548, 13, 1, 420 },
                    { 549, 13, 1, 421 },
                    { 550, 13, 2, 422 },
                    { 551, 13, 2, 423 },
                    { 552, 13, 2, 424 },
                    { 553, 13, 2, 425 },
                    { 554, 13, 2, 426 },
                    { 555, 13, 2, 427 },
                    { 556, 13, 2, 428 },
                    { 557, 13, 3, 371 },
                    { 558, 13, 3, 429 },
                    { 559, 13, 3, 430 },
                    { 560, 13, 3, 431 },
                    { 561, 13, 3, 432 },
                    { 562, 13, 3, 433 },
                    { 563, 13, 3, 13 },
                    { 564, 13, 4, 434 },
                    { 565, 13, 4, 106 },
                    { 566, 13, 4, 435 },
                    { 567, 13, 4, 436 },
                    { 568, 13, 4, 437 },
                    { 569, 13, 4, 438 },
                    { 570, 13, 4, 439 },
                    { 571, 13, 5, 125 },
                    { 572, 13, 5, 440 },
                    { 573, 13, 5, 441 },
                    { 574, 13, 5, 442 },
                    { 575, 13, 5, 443 },
                    { 576, 13, 6, 444 },
                    { 577, 13, 6, 445 },
                    { 578, 13, 6, 446 },
                    { 579, 13, 6, 447 },
                    { 580, 13, 6, 448 },
                    { 581, 13, 7, 449 },
                    { 582, 13, 7, 450 },
                    { 583, 13, 7, 451 },
                    { 584, 13, 7, 452 },
                    { 585, 13, 8, 453 },
                    { 586, 13, 8, 454 },
                    { 587, 13, 8, 455 },
                    { 588, 13, 9, 456 },
                    { 589, 13, 9, 457 },
                    { 590, 14, 1, 458 },
                    { 591, 14, 1, 54 },
                    { 592, 14, 1, 459 },
                    { 593, 14, 1, 7 },
                    { 594, 14, 1, 460 },
                    { 595, 14, 1, 461 },
                    { 596, 14, 1, 269 },
                    { 597, 14, 2, 462 },
                    { 598, 14, 2, 1 },
                    { 599, 14, 2, 106 },
                    { 600, 14, 2, 463 },
                    { 601, 14, 2, 464 },
                    { 602, 14, 2, 13 },
                    { 603, 14, 3, 192 },
                    { 604, 14, 3, 465 },
                    { 605, 14, 3, 466 },
                    { 606, 14, 3, 467 },
                    { 607, 14, 3, 32 },
                    { 608, 14, 4, 468 },
                    { 609, 14, 4, 469 },
                    { 610, 14, 4, 470 },
                    { 611, 14, 4, 471 },
                    { 612, 14, 4, 472 },
                    { 613, 14, 5, 473 },
                    { 614, 14, 5, 474 },
                    { 615, 14, 5, 475 },
                    { 616, 14, 5, 476 },
                    { 617, 14, 5, 477 },
                    { 618, 14, 6, 478 },
                    { 619, 14, 6, 361 },
                    { 620, 15, 1, 479 },
                    { 621, 15, 1, 480 },
                    { 622, 15, 1, 481 },
                    { 623, 15, 1, 482 },
                    { 624, 15, 1, 1 },
                    { 625, 15, 1, 7 },
                    { 626, 15, 2, 483 },
                    { 627, 15, 2, 484 },
                    { 628, 15, 2, 485 },
                    { 629, 15, 2, 486 },
                    { 630, 15, 2, 487 },
                    { 631, 15, 2, 488 },
                    { 632, 15, 3, 489 },
                    { 633, 15, 3, 490 },
                    { 634, 15, 3, 491 },
                    { 635, 15, 3, 492 },
                    { 636, 15, 3, 493 },
                    { 637, 15, 3, 19 },
                    { 638, 15, 4, 13 },
                    { 639, 15, 4, 494 },
                    { 640, 15, 4, 495 },
                    { 641, 15, 4, 496 },
                    { 642, 15, 4, 497 },
                    { 643, 15, 4, 498 },
                    { 644, 15, 5, 499 },
                    { 645, 15, 5, 500 },
                    { 646, 15, 5, 501 },
                    { 647, 15, 5, 32 },
                    { 648, 15, 5, 502 },
                    { 649, 15, 5, 503 },
                    { 650, 15, 6, 504 },
                    { 651, 15, 6, 505 },
                    { 652, 15, 6, 506 },
                    { 653, 15, 6, 507 },
                    { 654, 15, 6, 508 },
                    { 655, 15, 6, 509 },
                    { 656, 15, 7, 510 },
                    { 657, 15, 7, 511 },
                    { 658, 15, 7, 512 },
                    { 659, 15, 7, 513 },
                    { 660, 15, 7, 514 },
                    { 661, 15, 8, 515 },
                    { 662, 15, 8, 49 },
                    { 663, 15, 8, 516 },
                    { 664, 15, 8, 517 },
                    { 665, 15, 9, 518 },
                    { 666, 15, 9, 519 },
                    { 667, 15, 9, 520 },
                    { 668, 15, 9, 521 },
                    { 669, 15, 9, 53 },
                    { 670, 16, 1, 522 },
                    { 671, 16, 1, 523 },
                    { 672, 16, 1, 7 },
                    { 673, 16, 1, 479 },
                    { 674, 16, 1, 1 },
                    { 675, 16, 2, 524 },
                    { 676, 16, 2, 525 },
                    { 677, 16, 2, 209 },
                    { 678, 16, 2, 526 },
                    { 679, 16, 2, 488 },
                    { 680, 16, 3, 527 },
                    { 681, 16, 3, 528 },
                    { 682, 16, 3, 417 },
                    { 683, 16, 3, 529 },
                    { 684, 16, 3, 481 },
                    { 685, 16, 4, 530 },
                    { 686, 16, 4, 531 },
                    { 687, 16, 4, 486 },
                    { 688, 16, 4, 19 },
                    { 689, 16, 5, 532 },
                    { 690, 16, 5, 533 },
                    { 691, 16, 5, 534 },
                    { 692, 16, 5, 535 },
                    { 693, 16, 5, 536 },
                    { 694, 16, 6, 537 },
                    { 695, 16, 6, 538 },
                    { 696, 16, 6, 539 },
                    { 697, 16, 6, 501 },
                    { 698, 16, 7, 540 },
                    { 699, 16, 7, 506 },
                    { 700, 16, 7, 541 },
                    { 701, 16, 7, 542 },
                    { 702, 16, 8, 543 },
                    { 703, 16, 8, 544 },
                    { 704, 16, 8, 545 },
                    { 705, 16, 8, 546 },
                    { 706, 16, 9, 547 },
                    { 707, 16, 9, 49 },
                    { 708, 16, 9, 548 },
                    { 709, 17, 1, 19 },
                    { 710, 17, 1, 549 },
                    { 711, 17, 1, 1 },
                    { 712, 17, 1, 550 },
                    { 713, 17, 1, 7 },
                    { 714, 17, 1, 551 },
                    { 715, 17, 2, 552 },
                    { 716, 17, 2, 553 },
                    { 717, 17, 2, 554 },
                    { 718, 17, 2, 479 },
                    { 719, 17, 2, 555 },
                    { 720, 17, 2, 13 },
                    { 721, 17, 3, 556 },
                    { 722, 17, 3, 557 },
                    { 723, 17, 3, 558 },
                    { 724, 17, 3, 559 },
                    { 725, 17, 3, 496 },
                    { 726, 17, 3, 560 },
                    { 727, 17, 4, 561 },
                    { 728, 17, 4, 528 },
                    { 729, 17, 4, 562 },
                    { 730, 17, 4, 563 },
                    { 731, 17, 4, 564 },
                    { 732, 17, 5, 565 },
                    { 733, 17, 5, 566 },
                    { 734, 17, 5, 567 },
                    { 735, 17, 5, 32 },
                    { 736, 17, 5, 506 },
                    { 737, 17, 6, 568 },
                    { 738, 17, 6, 569 },
                    { 739, 17, 6, 570 },
                    { 740, 17, 6, 571 },
                    { 741, 17, 6, 572 },
                    { 742, 17, 7, 573 },
                    { 743, 17, 7, 574 },
                    { 744, 17, 7, 575 },
                    { 745, 17, 7, 576 },
                    { 746, 17, 7, 577 },
                    { 747, 17, 8, 578 },
                    { 748, 17, 8, 579 },
                    { 749, 17, 8, 580 },
                    { 750, 17, 8, 228 },
                    { 751, 17, 9, 581 },
                    { 752, 17, 9, 582 },
                    { 753, 17, 9, 583 },
                    { 754, 17, 10, 584 },
                    { 755, 17, 10, 585 },
                    { 756, 17, 10, 586 },
                    { 757, 18, 1, 459 },
                    { 758, 18, 1, 7 },
                    { 759, 18, 1, 495 },
                    { 760, 18, 1, 479 },
                    { 761, 18, 1, 587 },
                    { 762, 18, 1, 397 },
                    { 763, 18, 2, 564 },
                    { 764, 18, 2, 493 },
                    { 765, 18, 2, 588 },
                    { 766, 18, 2, 481 },
                    { 767, 18, 2, 560 },
                    { 768, 18, 2, 1 },
                    { 769, 18, 3, 565 },
                    { 770, 18, 3, 258 },
                    { 771, 18, 3, 589 },
                    { 772, 18, 3, 486 },
                    { 773, 18, 3, 25 },
                    { 774, 18, 4, 13 },
                    { 775, 18, 4, 590 },
                    { 776, 18, 4, 528 },
                    { 777, 18, 4, 591 },
                    { 778, 18, 4, 19 },
                    { 779, 18, 5, 592 },
                    { 780, 18, 5, 506 },
                    { 781, 18, 5, 593 },
                    { 782, 18, 5, 594 },
                    { 783, 18, 5, 32 },
                    { 784, 18, 6, 36 },
                    { 785, 18, 6, 595 },
                    { 786, 18, 6, 596 },
                    { 787, 18, 6, 597 },
                    { 788, 18, 6, 598 },
                    { 789, 18, 6, 599 },
                    { 790, 18, 7, 600 },
                    { 791, 18, 7, 601 },
                    { 792, 18, 7, 508 },
                    { 793, 18, 8, 602 },
                    { 794, 18, 8, 498 },
                    { 795, 18, 8, 49 },
                    { 796, 18, 9, 511 },
                    { 797, 18, 9, 603 },
                    { 798, 18, 9, 604 },
                    { 799, 18, 9, 605 },
                    { 800, 18, 9, 53 },
                    { 801, 19, 1, 7 },
                    { 802, 19, 1, 606 },
                    { 803, 19, 1, 607 },
                    { 804, 19, 1, 608 },
                    { 805, 19, 1, 609 },
                    { 806, 19, 1, 610 },
                    { 807, 19, 1, 611 },
                    { 808, 19, 2, 612 },
                    { 809, 19, 2, 613 },
                    { 810, 19, 2, 614 },
                    { 811, 19, 2, 615 },
                    { 812, 19, 2, 616 },
                    { 813, 19, 2, 617 },
                    { 814, 19, 2, 618 },
                    { 815, 19, 3, 25 },
                    { 816, 19, 3, 619 },
                    { 817, 19, 3, 620 },
                    { 818, 19, 3, 621 },
                    { 819, 19, 3, 622 },
                    { 820, 19, 3, 623 },
                    { 821, 19, 3, 1 },
                    { 822, 19, 4, 19 },
                    { 823, 19, 4, 624 },
                    { 824, 19, 4, 625 },
                    { 825, 19, 4, 626 },
                    { 826, 19, 4, 627 },
                    { 827, 19, 4, 628 },
                    { 828, 19, 5, 629 },
                    { 829, 19, 5, 630 },
                    { 830, 19, 5, 631 },
                    { 831, 19, 5, 599 },
                    { 832, 19, 5, 632 },
                    { 833, 19, 5, 633 },
                    { 834, 19, 6, 634 },
                    { 835, 19, 6, 635 },
                    { 836, 19, 6, 636 },
                    { 837, 19, 6, 637 },
                    { 838, 19, 6, 638 },
                    { 839, 19, 6, 639 },
                    { 840, 19, 7, 640 },
                    { 841, 19, 7, 582 },
                    { 842, 19, 7, 641 },
                    { 843, 19, 7, 642 },
                    { 844, 19, 7, 643 },
                    { 845, 19, 8, 644 },
                    { 846, 19, 8, 645 },
                    { 847, 19, 8, 585 },
                    { 848, 19, 8, 646 },
                    { 849, 19, 8, 647 },
                    { 850, 19, 8, 13 },
                    { 851, 20, 1, 7 },
                    { 852, 20, 1, 648 },
                    { 853, 20, 1, 649 },
                    { 854, 20, 1, 4 },
                    { 855, 20, 1, 650 },
                    { 856, 20, 2, 96 },
                    { 857, 20, 2, 651 },
                    { 858, 20, 2, 652 },
                    { 859, 20, 2, 17 },
                    { 860, 20, 2, 653 },
                    { 861, 20, 3, 654 },
                    { 862, 20, 3, 655 },
                    { 863, 20, 3, 656 },
                    { 864, 20, 3, 657 },
                    { 865, 20, 3, 658 },
                    { 866, 20, 3, 659 },
                    { 867, 20, 4, 660 },
                    { 868, 20, 4, 112 },
                    { 869, 20, 4, 106 },
                    { 870, 20, 4, 661 },
                    { 871, 20, 4, 662 },
                    { 872, 20, 4, 13 },
                    { 873, 20, 5, 663 },
                    { 874, 20, 5, 664 },
                    { 875, 20, 5, 665 },
                    { 876, 20, 5, 666 },
                    { 877, 20, 5, 19 },
                    { 878, 20, 6, 667 },
                    { 879, 20, 6, 668 },
                    { 880, 20, 6, 669 },
                    { 881, 20, 6, 670 },
                    { 882, 20, 6, 671 },
                    { 883, 20, 6, 25 },
                    { 884, 20, 7, 672 },
                    { 885, 20, 7, 673 },
                    { 886, 20, 7, 674 },
                    { 887, 20, 7, 675 },
                    { 888, 20, 8, 676 },
                    { 889, 20, 8, 117 },
                    { 890, 20, 8, 677 },
                    { 891, 20, 8, 678 },
                    { 892, 20, 9, 679 },
                    { 893, 20, 9, 680 },
                    { 894, 20, 9, 681 },
                    { 895, 20, 10, 682 },
                    { 896, 20, 10, 361 },
                    { 897, 21, 1, 7 },
                    { 898, 21, 1, 683 },
                    { 899, 21, 1, 684 },
                    { 900, 21, 1, 685 },
                    { 901, 21, 1, 686 },
                    { 902, 21, 2, 687 },
                    { 903, 21, 2, 1 },
                    { 904, 21, 2, 688 },
                    { 905, 21, 2, 689 },
                    { 906, 21, 2, 690 },
                    { 907, 21, 2, 691 },
                    { 908, 21, 3, 692 },
                    { 909, 21, 3, 693 },
                    { 910, 21, 3, 694 },
                    { 911, 21, 3, 695 },
                    { 912, 21, 3, 19 },
                    { 913, 21, 3, 696 },
                    { 914, 21, 3, 25 },
                    { 915, 21, 4, 697 },
                    { 916, 21, 4, 698 },
                    { 917, 21, 4, 699 },
                    { 918, 21, 4, 700 },
                    { 919, 21, 4, 701 },
                    { 920, 21, 5, 702 },
                    { 921, 21, 5, 703 },
                    { 922, 21, 5, 704 },
                    { 923, 21, 5, 705 },
                    { 924, 21, 5, 706 },
                    { 925, 21, 5, 707 },
                    { 926, 21, 5, 708 },
                    { 927, 21, 6, 709 },
                    { 928, 21, 6, 710 },
                    { 929, 21, 6, 13 },
                    { 930, 21, 6, 711 },
                    { 931, 21, 6, 712 },
                    { 932, 21, 7, 713 },
                    { 933, 21, 7, 714 },
                    { 934, 21, 7, 715 },
                    { 935, 21, 7, 716 },
                    { 936, 21, 7, 717 },
                    { 937, 21, 8, 718 },
                    { 938, 21, 8, 719 },
                    { 939, 21, 8, 720 },
                    { 940, 21, 8, 721 },
                    { 941, 21, 9, 722 },
                    { 942, 21, 9, 723 },
                    { 943, 21, 10, 53 },
                    { 944, 21, 10, 682 },
                    { 945, 22, 1, 724 },
                    { 946, 22, 1, 725 },
                    { 947, 22, 1, 7 },
                    { 948, 22, 1, 1 },
                    { 949, 22, 1, 726 },
                    { 950, 22, 1, 727 },
                    { 951, 22, 1, 728 },
                    { 952, 22, 2, 729 },
                    { 953, 22, 2, 730 },
                    { 954, 22, 2, 731 },
                    { 955, 22, 2, 732 },
                    { 956, 22, 2, 733 },
                    { 957, 22, 2, 734 },
                    { 958, 22, 2, 735 },
                    { 959, 22, 3, 736 },
                    { 960, 22, 3, 737 },
                    { 961, 22, 3, 738 },
                    { 962, 22, 3, 739 },
                    { 963, 22, 3, 740 },
                    { 964, 22, 3, 741 },
                    { 965, 22, 3, 13 },
                    { 966, 22, 4, 742 },
                    { 967, 22, 4, 743 },
                    { 968, 22, 4, 744 },
                    { 969, 22, 4, 745 },
                    { 970, 22, 4, 746 },
                    { 971, 22, 4, 741 },
                    { 972, 22, 4, 25 },
                    { 973, 22, 5, 747 },
                    { 974, 22, 5, 748 },
                    { 975, 22, 5, 749 },
                    { 976, 22, 5, 750 },
                    { 977, 22, 5, 751 },
                    { 978, 22, 5, 752 },
                    { 979, 22, 6, 753 },
                    { 980, 22, 6, 754 },
                    { 981, 22, 6, 755 },
                    { 982, 22, 6, 756 },
                    { 983, 22, 6, 752 },
                    { 984, 22, 7, 757 },
                    { 985, 22, 7, 758 },
                    { 986, 22, 7, 759 },
                    { 987, 22, 7, 760 },
                    { 988, 22, 8, 761 },
                    { 989, 22, 8, 762 },
                    { 990, 22, 8, 763 },
                    { 991, 22, 9, 764 },
                    { 992, 22, 9, 765 },
                    { 993, 22, 9, 766 },
                    { 994, 22, 10, 767 },
                    { 995, 22, 10, 53 },
                    { 996, 23, 1, 768 },
                    { 997, 23, 1, 434 },
                    { 998, 23, 1, 769 },
                    { 999, 23, 1, 418 },
                    { 1000, 23, 1, 770 },
                    { 1001, 23, 1, 771 },
                    { 1002, 23, 2, 13 },
                    { 1003, 23, 2, 772 },
                    { 1004, 23, 2, 773 },
                    { 1005, 23, 2, 774 },
                    { 1006, 23, 2, 775 },
                    { 1007, 23, 2, 776 },
                    { 1008, 23, 2, 777 },
                    { 1009, 23, 3, 25 },
                    { 1010, 23, 3, 778 },
                    { 1011, 23, 3, 779 },
                    { 1012, 23, 3, 780 },
                    { 1013, 23, 3, 781 },
                    { 1014, 23, 3, 782 },
                    { 1015, 23, 4, 783 },
                    { 1016, 23, 4, 784 },
                    { 1017, 23, 4, 785 },
                    { 1018, 23, 4, 786 },
                    { 1019, 23, 4, 787 },
                    { 1020, 23, 4, 788 },
                    { 1021, 23, 5, 789 },
                    { 1022, 23, 5, 790 },
                    { 1023, 23, 5, 791 },
                    { 1024, 23, 5, 792 },
                    { 1025, 23, 5, 793 },
                    { 1026, 23, 5, 794 },
                    { 1027, 23, 6, 795 },
                    { 1028, 23, 6, 796 },
                    { 1029, 23, 6, 797 },
                    { 1030, 23, 6, 798 },
                    { 1031, 23, 6, 799 },
                    { 1032, 23, 6, 800 },
                    { 1033, 23, 7, 801 },
                    { 1034, 23, 7, 802 },
                    { 1035, 23, 7, 803 },
                    { 1036, 23, 7, 804 },
                    { 1037, 23, 8, 805 },
                    { 1038, 23, 8, 806 },
                    { 1039, 23, 8, 807 },
                    { 1040, 23, 8, 808 },
                    { 1041, 23, 9, 809 },
                    { 1042, 23, 9, 810 },
                    { 1043, 23, 10, 811 },
                    { 1044, 24, 1, 812 },
                    { 1045, 24, 1, 813 },
                    { 1046, 24, 1, 814 },
                    { 1047, 24, 1, 7 },
                    { 1048, 24, 1, 649 },
                    { 1049, 24, 2, 203 },
                    { 1050, 24, 2, 815 },
                    { 1051, 24, 2, 816 },
                    { 1052, 24, 2, 817 },
                    { 1053, 24, 2, 818 },
                    { 1054, 24, 3, 206 },
                    { 1055, 24, 3, 819 },
                    { 1056, 24, 3, 820 },
                    { 1057, 24, 3, 821 },
                    { 1058, 24, 4, 208 },
                    { 1059, 24, 4, 8 },
                    { 1060, 24, 4, 822 },
                    { 1061, 24, 4, 823 },
                    { 1062, 24, 4, 732 },
                    { 1063, 24, 5, 211 },
                    { 1064, 24, 5, 824 },
                    { 1065, 24, 5, 825 },
                    { 1066, 24, 5, 564 },
                    { 1067, 24, 5, 826 },
                    { 1068, 24, 6, 827 },
                    { 1069, 24, 6, 828 },
                    { 1070, 24, 6, 565 },
                    { 1071, 24, 6, 829 },
                    { 1072, 24, 6, 830 },
                    { 1073, 24, 6, 13 },
                    { 1074, 24, 7, 831 },
                    { 1075, 24, 7, 832 },
                    { 1076, 24, 7, 833 },
                    { 1077, 24, 7, 834 },
                    { 1078, 24, 8, 835 },
                    { 1079, 24, 8, 836 },
                    { 1080, 24, 8, 837 },
                    { 1081, 24, 8, 838 },
                    { 1082, 24, 9, 839 },
                    { 1083, 24, 9, 840 },
                    { 1084, 24, 9, 841 },
                    { 1085, 24, 9, 25 },
                    { 1086, 24, 10, 682 },
                    { 1087, 24, 10, 53 },
                    { 1088, 25, 1, 842 },
                    { 1089, 25, 1, 843 },
                    { 1090, 25, 1, 844 },
                    { 1091, 25, 1, 845 },
                    { 1092, 25, 1, 846 },
                    { 1093, 25, 1, 847 },
                    { 1094, 25, 1, 25 },
                    { 1095, 25, 2, 848 },
                    { 1096, 25, 2, 648 },
                    { 1097, 25, 2, 849 },
                    { 1098, 25, 2, 850 },
                    { 1099, 25, 2, 7 },
                    { 1100, 25, 2, 851 },
                    { 1101, 25, 2, 19 },
                    { 1102, 25, 3, 852 },
                    { 1103, 25, 3, 853 },
                    { 1104, 25, 3, 526 },
                    { 1105, 25, 3, 854 },
                    { 1106, 25, 3, 855 },
                    { 1107, 25, 3, 856 },
                    { 1108, 25, 3, 13 },
                    { 1109, 25, 4, 857 },
                    { 1110, 25, 4, 858 },
                    { 1111, 25, 4, 859 },
                    { 1112, 25, 4, 860 },
                    { 1113, 25, 4, 861 },
                    { 1114, 25, 4, 862 },
                    { 1115, 25, 5, 863 },
                    { 1116, 25, 5, 864 },
                    { 1117, 25, 5, 865 },
                    { 1118, 25, 5, 866 },
                    { 1119, 25, 5, 867 },
                    { 1120, 25, 5, 868 },
                    { 1121, 25, 6, 869 },
                    { 1122, 25, 6, 870 },
                    { 1123, 25, 6, 871 },
                    { 1124, 25, 6, 872 },
                    { 1125, 25, 6, 873 },
                    { 1126, 25, 6, 874 },
                    { 1127, 25, 7, 875 },
                    { 1128, 25, 7, 876 },
                    { 1129, 25, 7, 877 },
                    { 1130, 25, 7, 878 },
                    { 1131, 25, 7, 879 },
                    { 1132, 25, 8, 880 },
                    { 1133, 25, 8, 881 },
                    { 1134, 25, 8, 882 },
                    { 1135, 25, 8, 883 },
                    { 1136, 25, 9, 93 },
                    { 1137, 25, 9, 361 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "CareerSubjects",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 883);
        }
    }
}
