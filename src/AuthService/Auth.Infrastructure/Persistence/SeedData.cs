using Microsoft.EntityFrameworkCore;
using Auth.Domain.Entities;

namespace Auth.Infrastructure.Persistence;

public static class SeedData
{
    public static void Seed(ModelBuilder builder)
    {
        var subjectId = 0;
        var careerSubjectId = 0;
        var careerId = 0;

        var subjects = new Dictionary<string, int>();

        int GetOrCreateSubjectId(string name)
        {
            if (subjects.TryGetValue(name, out var id))
                return id;
            subjectId++;
            subjects[name] = subjectId;
            return subjectId;
        }

        void SeedCareer(string name, int duration, Dictionary<int, string[]> semesters)
        {
            careerId++;
            builder.Entity<Career>().HasData(new { Id = careerId, CareerName = name, DurationSemesters = duration });

            var careerSubjectData = new List<object>();
            foreach (var (semester, subjectNames) in semesters)
            {
                foreach (var subjectName in subjectNames)
                {
                    var sid = GetOrCreateSubjectId(subjectName);
                    careerSubjectId++;
                    careerSubjectData.Add(new { Id = careerSubjectId, SemesterNumber = semester, CareerId = careerId, SubjectId = sid });
                }
            }
            builder.Entity<CareerSubject>().HasData(careerSubjectData.ToArray());
        }

        // ============================================================
        // INGENIERÍA AGROINDUSTRIAL
        // ============================================================
        SeedCareer("Ingeniería Agroindustrial", 10, new Dictionary<int, string[]>
        {
            [1] = ["Pensamiento lógico matemático", "Matemáticas I", "Química general", "Biología", "Introducción a la ingeniería agroindustrial", "Dibujo de ingeniería"],
            [2] = ["Procesos comunicativos", "Álgebra lineal", "Matemáticas II", "Física I", "Química orgánica", "Aplicaciones informáticas"],
            [3] = ["Cátedra de la Orinoquia", "Matemáticas III (modelamiento matemático para ingenieros)", "Física II", "Termodinámica", "Bioquímica", "Producción agropecuaria", "Ciencia, tecnología y desarrollo"],
            [4] = ["Métodos numéricos para ingenieros", "Probabilidad y estadística", "Fisicoquímica", "Microbiología industrial", "Química agroindustrial", "Cátedra democracia y paz"],
            [5] = ["Diseño experimental", "Materias primas", "Mecánica de fluidos e hidráulica", "Balance de materia y energía", "Transferencia de calor", "Economía"],
            [6] = ["Metodología de la investigación", "Procesos agrícolas I", "Operaciones unitarias I", "Procesos no alimentarios I", "Mercadeo agroindustrial", "Administración"],
            [7] = ["Procesos pecuarios", "Biotecnología agroindustrial", "Procesos agrícolas II", "Operaciones unitarias II", "Investigación de operaciones"],
            [8] = ["Gestión ambiental", "Procesos no alimentarios II", "Diseño de planta y equipos", "Contabilidad y costos"],
            [9] = ["Desarrollo rural", "Aseguramiento de la calidad", "Formulación y evaluación de proyectos", "Administración de la producción", "Derecho para ingenieros"],
            [10] = ["Práctica empresarial", "Trabajo de grado"],
        });

        // ============================================================
        // INGENIERÍA AGRONÓMICA
        // ============================================================
        SeedCareer("Ingeniería Agronómica", 10, new Dictionary<int, string[]>
        {
            [1] = ["Química básica", "Biología celular", "Matemáticas I", "Procesos comunicativos", "Introducción a la ingeniería agronómica", "Pensamiento lógico matemático"],
            [2] = ["Química orgánica", "Morfofisiología vegetal", "Matemáticas II", "Física mecánica", "Sociología rural", "Cátedra de la Orinoquia", "Cátedra democracia y paz"],
            [3] = ["Bioquímica vegetal", "Taxonomía vegetal", "Matemáticas III", "Termodinámica y energética", "Agroclimatología", "Economía agraria", "Ciencia, tecnología y desarrollo"],
            [4] = ["Biología molecular", "Ecosistemas tropicales", "Diseño y desarrollo de experimentos agrícolas I", "Fisiología vegetal", "Administración y gestión de empresas agrarias", "Geomática agrícola"],
            [5] = ["Genética vegetal", "Reproducción de plantas", "Diseño y desarrollo de experimentos agrícolas II", "Microbiología agrícola", "Entomología agrícola", "Suelos I: Geología y génesis de suelos"],
            [6] = ["Fitomejoramiento", "Fundamentos de sanidad vegetal en los sistemas de producción agrícola", "Suelos II: Física y química de suelos", "Mecánica de fluidos", "Agroecología"],
            [7] = ["Manejo sanitario de los sistemas de producción agrícola", "Suelos III: Fertilidad y manejo sostenible de suelos", "Política y legislación agraria", "Uso y manejo del agua en los sistemas de producción agrícola"],
            [8] = ["Sistemas agrarios de producción agrícola de clima medio y frío", "Construcciones rurales", "Maquinaria y mecanización agrícola"],
            [9] = ["Sistemas de producción agrícola de clima cálido", "Mercadeo de productos agrícolas", "Desarrollo y extensión rural"],
            [10] = ["Práctica profesional", "Trabajo de grado"],
        });

        // ============================================================
        // MEDICINA VETERINANA ZOOTECNIA
        // ============================================================
        SeedCareer("Medicina Veterinaria y Zootecnia", 10, new Dictionary<int, string[]>
        {
            [1] = ["Procesos comunicativos", "Bioquímica", "Biología", "Introducción a las ciencias animales", "Anatomía general", "Desarrollo del pensamiento lógico matemático"],
            [2] = ["Economía agropecuaria", "Bioética y bienestar animal", "Ecología", "Bioquímica metabólica", "Anatomía comparada"],
            [3] = ["Fisiología I", "Microbiología y virología", "Histología", "Sociedad rural", "Bioestadística", "Producción tropical sostenible"],
            [4] = ["Diseño experimental", "Suelos y forrajes", "Fisiología II", "Ciencia, tecnología y desarrollo", "Parasitología", "Genética y mejoramiento"],
            [5] = ["Nutrición animal", "Semiología", "Farmacología", "Patología clínica", "Inmunología", "Producción de especies menores"],
            [6] = ["Cirugía", "Enfermedades infecciosas", "Patología general", "Reproducción", "Producción avícola", "Alimentación animal"],
            [7] = ["Medicina interna", "Epidemiología", "Producción porcina", "Toxicología veterinaria", "Patología sistémica"],
            [8] = ["Administración y mercadeo agropecuario", "Salud pública", "Producción acuícola", "Producción de rumiantes", "Lácteos y cárnicos"],
            [9] = ["Extensión rural", "Clínica de grandes animales", "Clínica de pequeños animales", "Producción de balanceados y suplementos", "Gestión empresarial agropecuaria"],
            [10] = ["Práctica profesional", "Desarrollo rural", "Gestión de la calidad alimentaria", "Trabajo de grado"],
        });

        // ============================================================
        // INGENIERÍA FORESTAL
        // ============================================================
        SeedCareer("Ingeniería Forestal", 10, new Dictionary<int, string[]>
        {
            [1] = ["Matemáticas I", "Química básica", "Biología", "Introducción a la ingeniería forestal", "Procesos comunicativos"],
            [2] = ["Matemáticas II", "Física I", "Química orgánica", "Botánica taxonómica", "Agroclimatología", "Cátedra de la Orinoquia"],
            [3] = ["Álgebra lineal", "Física II", "Bioquímica vegetal", "Suelos I", "Dendrología", "Ecología forestal"],
            [4] = ["Bioestadística forestal", "Fisiología vegetal", "Suelos II", "Flora y fauna de la Orinoquia y Amazonía", "Hidrología", "Cátedra democracia y paz"],
            [5] = ["Geomática básica", "Diseño y desarrollo de experimentos forestales", "Anatomía y tecnología de la madera", "Suelos III", "Dendrometría y mediciones forestales"],
            [6] = ["Sistemas de información geográfica", "Metodología de la investigación", "Viveros y mejoramiento genético", "Mecanización y maquinaria forestal", "Aprovechamiento forestal", "Ciencia, tecnología y desarrollo"],
            [7] = ["Cuencas hidrográficas", "Áreas protegidas", "Silvicultura de plantaciones", "Política y legislación forestal", "Silvicultura del bosque natural", "Entomología y sanidad forestal"],
            [8] = ["Ordenación forestal", "Bioeconomía forestal", "Emprendimiento y formulación de proyectos", "Manejo sostenible de bosque natural", "Trabajo de grado I"],
            [9] = ["Restauración ecológica", "Gestión de industrias forestales", "Trabajo de grado II"],
            [10] = ["Práctica profesional"],
        });

        // ============================================================
        // BIOLOGÍA
        // ============================================================
        SeedCareer("Biología", 10, new Dictionary<int, string[]>
        {
            [1] = ["Principios químicos de la vida", "Matemáticas I", "Introducción a los sistemas biológicos", "Estructura celular", "Pensamiento lógico matemático", "Procesos comunicativos"],
            [2] = ["Matemáticas II", "Principios físicos de la vida", "Compuestos orgánicos", "Biología de plantas inferiores", "Cátedra democracia y paz"],
            [3] = ["Matemáticas III", "Análisis químico", "Biología de invertebrados", "Geología y suelos tropicales", "Cátedra de la Orinoquia"],
            [4] = ["Bioestadística", "Bioquímica y función celular", "Morfología de vertebrados", "Morfología de plantas superiores", "Ciencia, tecnología y desarrollo"],
            [5] = ["Diseño experimental", "Genética", "Fisiología animal", "Sistemas ecológicos", "Sistemas de información"],
            [6] = ["Biología del desarrollo", "Biología molecular", "Genética de poblaciones", "Fisiología vegetal", "Elementos de la comunicación científica"],
            [7] = ["Biología de la conservación", "Microbiología", "Sistemática y evolución", "Dinámica de poblaciones", "Formulación de proyectos"],
            [8] = ["Valoración y manejo de ecosistemas", "Taxonomía vegetal", "Taxonomía animal", "Ecosistemas acuáticos", "Etnobiología"],
            [9] = ["Bioética"],
            [10] = ["Trabajo de grado"],
        });

        // ============================================================
        // INGENIERÍA AMBIENTAL
        // ============================================================
        SeedCareer("Ingeniería Ambiental", 10, new Dictionary<int, string[]>
        {
            [1] = ["Biología general y laboratorio", "Química general y laboratorio", "Cálculo diferencial", "Física mecánica", "Introducción a la ingeniería ambiental"],
            [2] = ["Ecología", "Química orgánica y laboratorio", "Cálculo integral", "Física calor y ondas", "Álgebra lineal"],
            [3] = ["Cálculo multivariado", "Estadística", "Bioquímica", "Topografía y cartografía", "Termodinámica", "Pensamiento lógico matemático"],
            [4] = ["Ecuaciones diferenciales", "Diseño experimental", "Microbiología y laboratorio", "Mecánica de fluidos y laboratorio", "Geología y geomorfología laboratorio", "Química analítica"],
            [5] = ["Balance de materia y energía", "Sistemas de información geográfica", "Hidráulica y laboratorio", "Climatología", "Química ambiental y laboratorio", "Procesos comunicativos"],
            [6] = ["Hidrología", "Suelos y laboratorio", "Legislación ambiental", "Gestión del agua y laboratorio", "Emisiones atmosféricas y calidad del aire", "Ciencia, tecnología y desarrollo"],
            [7] = ["Manejo de los recursos naturales", "Impacto ambiental", "Gestión del agua residual", "Gestión de residuos sólidos", "Sistema de gestión ambiental", "Economía ambiental"],
            [8] = ["Ordenamiento territorial", "Saneamiento básico", "Modelación ambiental", "Tecnologías ambientales", "Cátedra democracia y paz"],
            [9] = ["Ética y ambiente", "Gestión del riesgo y prevención de desastres", "Toxicología ambiental", "Anteproyecto de grado"],
            [10] = ["Proyecto de grado"],
        });

        // ============================================================
        // INGENIERÍA DE PROCESOS
        // ============================================================
        SeedCareer("Ingeniería de Procesos", 10, new Dictionary<int, string[]>
        {
            [1] = ["Cálculo diferencial", "Química básica", "Procesos comunicativos", "Desarrollo del pensamiento lógico matemático", "Fundamentos de programación", "Introducción a la ingeniería de procesos"],
            [2] = ["Cálculo integral", "Física mecánica", "Biología general", "Química orgánica", "Química analítica e instrumental"],
            [3] = ["Cálculo multivariado", "Electricidad y magnetismo", "Álgebra lineal", "Química inorgánica", "Termodinámica"],
            [4] = ["Ecuaciones diferenciales", "Dinámica de sistemas", "Balance de materia y energía", "Fisicoquímica", "Geoquímica del petróleo", "Probabilidad y estadística"],
            [5] = ["Ciencia, tecnología y desarrollo", "Métodos numéricos", "Mecánica de fluidos", "Ingeniería de yacimientos", "Diseño de experimentos", "Fenómenos de transporte", "Economía para ingenieros"],
            [6] = ["Ingeniería de las reacciones", "Operaciones unitarias", "Procesos industriales", "Gestión de producción", "Transferencia de masa y energía", "Manejo de sólidos"],
            [7] = ["Ciencia de los materiales", "Costos y presupuesto", "Gestión de calidad", "Diseño de productos"],
            [8] = ["Cátedra democracia y paz", "Diseño de procesos", "Metodología de investigación"],
            [9] = ["Formulación y evaluación de proyectos", "Simulación y optimización", "Logística industrial"],
            [10] = ["Trabajo de grado"],
        });

        // ============================================================
        // INGENIERÍA DE SISTEMAS
        // ============================================================
        SeedCareer("Ingeniería de Sistemas", 10, new Dictionary<int, string[]>
        {
            [1] = ["Algoritmia y programación", "Introducción a la ingeniería de sistemas", "Cálculo diferencial", "Procesos comunicativos", "Desarrollo del pensamiento lógico matemático"],
            [2] = ["Programación orientada a objetos", "Sistemas digitales", "Cálculo integral", "Álgebra lineal", "Física mecánica"],
            [3] = ["Democracia y paz", "Estructuras de datos", "Máquinas digitales", "Cálculo multivariado", "Electricidad y magnetismo"],
            [4] = ["Bases de datos", "Sistemas operativos", "Ecuaciones diferenciales y modelado matemático", "Estadística y probabilidad", "Oscilaciones y ondas"],
            [5] = ["Ingeniería de software I", "Pensamiento sistémico", "Matemáticas especiales", "Procesos estocásticos", "Sistemas de comunicación", "Ciencia, tecnología y desarrollo"],
            [6] = ["Ingeniería de software II", "Métodos numéricos", "Procesamiento de señales e imágenes", "Optimización", "Redes de computadores", "Administración financiera para ingeniería"],
            [7] = ["Metodología de la investigación", "Tecnologías avanzadas", "Ética y humanística", "Sistemas distribuidos", "Seguridad de la información", "Formulación y gestión de proyectos"],
            [8] = ["Simulación computacional", "Arquitectura empresarial", "Trabajo de grado 1", "Cátedra de la Orinoquia"],
            [9] = ["Lenguajes de programación", "Cátedra de la Orinoquia"],
            [10] = ["Trabajo de grado 2"],
        });

        // ============================================================
        // INGENIERÍA ELECTRÓNICA
        // ============================================================
        SeedCareer("Ingeniería Electrónica", 10, new Dictionary<int, string[]>
        {
            [1] = ["CÁLCULO DIFERENCIAL", "PENSAMIENTO LÓGICO MATEMÁTICO", "PROCESOS COMUNICATIVOS", "INTRODUCCIÓN A LA INGENIERÍA ELECTRÓNICA", "PROGRAMACIÓN I", "LABORATORIO DE ELECTRÓNICA BÁSICA"],
            [2] = ["CÁLCULO INTEGRAL", "ÁLGEBRA LINEAL", "FÍSICA MECÁNICA", "CIRCUITOS ELÉCTRICOS I", "PROGRAMACIÓN II"],
            [3] = ["CÁLCULO MULTIVARIADO", "ECUACIONES DIFERENCIALES", "ELECTRICIDAD Y MAGNETISMO", "ELECTRÓNICA ANÁLOGA I"],
            [4] = ["MATEMÁTICAS ESPECIALES", "CIRCUITOS ELÉCTRICOS II", "OSCILACIONES Y ONDAS", "ELECTRÓNICA ANÁLOGA II", "CIRCUITOS DIGITALES I"],
            [5] = ["ANÁLISIS DE SEÑALES", "PROBABILIDAD Y ESTADÍSTICA", "SEMICONDUCTORES Y MATERIALES", "MÉTODOS NUMÉRICOS", "CIRCUITOS DIGITALES II"],
            [6] = ["MODELAMIENTO DE SISTEMAS", "OPTIMIZACIÓN Y PROCESOS ESTOCÁSTICOS", "CAMPOS ELECTROMAGNÉTICOS", "INSTRUMENTACIÓN ELECTRÓNICA I", "CIRCUITOS DIGITALES III", "CÁTEDRA DEMOCRACIA Y PAZ"],
            [7] = ["CONTROL ANÁLOGO", "LÍNEAS Y ANTENAS", "SISTEMAS DE COMUNICACIÓN I", "INSTRUMENTACIÓN ELECTRÓNICA II", "METODOLOGÍA DE LA INVESTIGACIÓN", "CÁTEDRA DE LA ORINOQUIA", "CONTROL DIGITAL"],
            [8] = ["SISTEMAS DE COMUNICACIÓN II", "MÁQUINAS ELÉCTRICAS", "FORMULACIÓN Y GESTIÓN DE PROYECTOS DE TI", "ÉTICA EN LA INGENIERÍA"],
            [9] = ["ELECTRÓNICA INDUSTRIAL"],
            [10] = ["PROYECTO DE GRADO"],
        });

        // ============================================================
        // TECNOLOGÍA EN DESARROLLO DE SOFTWARE
        // ============================================================
        SeedCareer("Tecnología en desarrollo de software", 6, new Dictionary<int, string[]>
        {
            [1] = ["Algoritmia", "Introducción a la Tecnología en Desarrollo de Software", "Herramientas digitales", "Matemáticas discretas", "Procesos comunicativos", "Pensamiento lógico matemático"],
            [2] = ["Programación", "Ética en la Tecnología de la información", "Cálculo diferencial", "Álgebra lineal", "Democracia y paz", "Cátedra de la Orinoquia"],
            [3] = ["Estructuras de datos", "Metodologías ágiles", "Sistemas operativos", "Desarrollo Back-end", "Física"],
            [4] = ["Fundamentos de IA", "Análisis y diseño de software", "Infraestructura de TI", "Desarrollo Front-end", "Bases de datos", "Estadística"],
            [5] = ["Testing", "Desarrollo y despliegue de software", "Investigación, innovación y emprendimiento", "Desarrollo de software seguro", "Gestión de bases de datos", "Introducción a la Analítica de datos"],
            [6] = ["Agromática. Tecnología para el agro", "Seguridad de la información", "Opción de grado"],
        });

        // ============================================================
        // ENFERMERÍA
        // ============================================================
        SeedCareer("Enfermería", 9, new Dictionary<int, string[]>
        {
            [1] = ["Fundamentos de bioquímica I", "Morfofisiología", "Socioantropología", "Pensamiento lógico matemático", "Procesos comunicativos", "Historia y desarrollo de enfermería"],
            [2] = ["Fundamentos de bioquímica II", "Microbiología y parasitología", "Fisiopatología", "Fundamentos y técnicas para el cuidado I"],
            [3] = ["Fundamentos éticos y bioéticos", "Farmacología", "Ciencia, tecnología y desarrollo", "Psicología y desarrollo humano", "Fundamentos y técnicas para el cuidado II"],
            [4] = ["Bioestadística", "Ecobiología de poblaciones", "Promoción de la salud y prevención de la enfermedad", "Cuidado desarrollo prenatal, nacimiento y recién nacido", "Sistema general de seguridad social", "Cátedra de la Orinoquia"],
            [5] = ["Epidemiología", "Cuidado de la salud de colectivos I", "Cuidado de la salud al niño", "Tendencias en enfermería", "Cátedra democracia y paz"],
            [6] = ["Metodología de la investigación I", "Cuidado de la salud de colectivos II", "Cuidado de la salud al adolescente", "Fundamentos de gerencia y gestión"],
            [7] = ["Metodología de la investigación II", "Cuidado del adulto I", "Dilemas éticos"],
            [8] = ["Cuidado del adulto II", "Cuidado de la salud mental y psiquiatría"],
            [9] = ["Gestión del cuidado y servicios de enfermería", "Gestión de los planes y programas en salud", "Trabajo de grado"],
        });

        // ============================================================
        // FISIOTERAPIA
        // ============================================================
        SeedCareer("Fisioterapia", 9, new Dictionary<int, string[]>
        {
            [1] = ["Ciencias básicas integradas", "Morfofisiología I", "Socioantropología", "Procesos comunicativos", "Contexto de Fisioterapia, Cuerpo y Movimiento"],
            [2] = ["Morfofisiología II", "Neuromorfofisiología", "Fisiopatología", "Educación para la salud", "Pensamiento lógico matemático", "Psicología", "Herramientas informáticas"],
            [3] = ["Farmacología", "Fundamentos éticos", "Prescripción del ejercicio en fisioterapia", "Biomecánica", "Neurodesarrollo y control motor", "Ciencia, tecnología y desarrollo"],
            [4] = ["Bioestadística", "Evaluación, análisis y diagnóstico del movimiento corporal humano I", "Salud pública, comunidad y discapacidad", "Fisioterapia en Salud y seguridad en el trabajo", "Cátedra de la Orinoquia"],
            [5] = ["Epidemiología", "Tecnología en fisioterapia", "Evaluación, análisis y diagnóstico del movimiento corporal humano II", "Intervención fisioterapéutica I"],
            [6] = ["Bioética", "Práctica de formación integral", "Intervención fisioterapéutica II"],
            [7] = ["Metodología de la investigación I", "Práctica de formación integral fisioterapia en pediatría", "Cátedra democracia y paz"],
            [8] = ["Metodología de la investigación II", "Práctica de formación fisioterapia en adulto", "Fundamentos de administración en salud"],
            [9] = ["Redacción de textos científicos y opción de grado", "Práctica de formación especializada", "Gestión de proyectos", "Emprendimiento"],
        });

        // ============================================================
        // FONOAUDIOLOGÍA
        // ============================================================
        SeedCareer("Fonoaudiología", 9, new Dictionary<int, string[]>
        {
            [1] = ["Morfofisiología", "Socioantropología", "Lingüística", "Pensamiento Lógico Matemático", "Comunicación Oral y Escrita", "Fundamentos de Fonoaudiología"],
            [2] = ["Morfofisiología de cabeza, cuello y tórax", "Comunicación Oral y Escrita II", "Acústica", "Adquisición y desarrollo del lenguaje escrito", "Adquisición y desarrollo del lenguaje oral", "Cátedra Ciencia, Tecnología y Desarrollo", "Bioética y marco legal en salud"],
            [3] = ["Psicología y desarrollo humano", "Diversidad e inclusión social", "Fundamentos del habla y deglución", "Fundamentos del lenguaje", "Fundamentos de la audición", "Desórdenes en la comunicación", "Cátedra de la Orinoquia"],
            [4] = ["Psicolingüística", "Bioestadística", "Diagnóstico de desórdenes del habla", "Lenguaje en primera infancia y del adolescente", "Diagnóstico de desórdenes de la audición", "Sistema de seguridad social en salud", "Cátedra para la Democracia"],
            [5] = ["Epidemiología", "Planes de promoción, prevención e intervención de desórdenes del habla", "Planes de promoción, prevención e intervención de desórdenes del lenguaje", "Planes de promoción, prevención e intervención de desórdenes de la audición", "Abordaje interdisciplinario en discapacidad"],
            [6] = ["Metodología de Investigación I", "Gerencia y gestión", "Intervención en desórdenes del proceso de comunicación en la primera infancia", "Lenguaje en el aprendizaje I", "Rehabilitación basada en comunidad"],
            [7] = ["Investigación en salud", "Intervención en desórdenes del proceso de comunicación en el adulto y trabajadores", "Lenguaje en el aprendizaje II", "Rehabilitación basada en comunidad en el adulto/discapacidad"],
            [8] = ["Intervención en desórdenes del proceso de comunicación en el adulto y adulto mayor", "Audiología", "Lenguaje en el aprendizaje III"],
            [9] = ["Campo de acción comunitario", "Campo de acción asistencial"],
        });

        // ============================================================
        // TECNOLOGÍA EN REGENCIA DE FARMACIA
        // ============================================================
        SeedCareer("Tecnología en Regencia de Farmacia", 6, new Dictionary<int, string[]>
        {
            [1] = ["Biología básica", "Química básica", "Matemáticas", "Procesos comunicativos", "Introducción a la Regencia de Farmacia", "Herramientas ofimáticas para regencia", "Democracia y paz"],
            [2] = ["Fisioanatomía", "Pensamiento lógico matemático", "Bioestadística", "Bioquímica farmacéutica", "Ética y Bioética", "Cátedra de la Orinoquia"],
            [3] = ["Microbiología", "Farmacia Magistral", "Farmacología I", "Fundamentos de administración y mercadeo", "Metodología de la investigación"],
            [4] = ["Legislación farmacéutica", "Gestión administrativa en farmacia", "Dispositivos médicos", "Farmacología II", "Contabilidad y presupuesto"],
            [5] = ["Farmacovigilancia y tecnovigilancia", "Promoción de la salud y APS", "Gestión integral de recursos en los establecimientos y servicios farmacéuticos", "Farmacia veterinaria", "Farmacia vegetal"],
            [6] = ["Prácticas en regencia de farmacia", "Opción de grado"],
        });

        // ============================================================
        // ADMINISTRACIÓN DE EMPRESAS
        // ============================================================
        SeedCareer("Administración de Empresas", 9, new Dictionary<int, string[]>
        {
            [1] = ["Fundamentos de administración", "Pensamiento administrativo", "Microeconomía", "Matemáticas aplicadas a los negocios", "Pensamiento lógico matemático", "Procesos comunicativos"],
            [2] = ["Planeación", "Tendencias administrativas", "Emprendimiento empresarial", "Macroeconomía", "Estadística aplicada a los negocios", "Derecho constitucional"],
            [3] = ["Organización", "Desarrollo empresarial", "Competitividad empresarial", "Matemáticas financiera", "Contabilidad empresarial", "Ciencia, tecnología y desarrollo"],
            [4] = ["Cátedra de la Orinoquia", "Dirección", "Principios de mercadeo", "Costos y presupuestos", "Habilidades directivas", "Derecho empresarial"],
            [5] = ["Control", "Pronósticos en los negocios", "Investigación de mercados", "Metodología de la investigación", "Legislación tributaria", "Gestión de operaciones y logística"],
            [6] = ["Gestión de negocios internacionales", "Comportamiento organizacional", "Análisis financiero", "Gestión pública", "Gestión de la calidad", "Sistema de información gerencial"],
            [7] = ["Responsabilidad social y ambiental", "Gerencia comercial", "Gestión del talento humano I", "Gestión financiera", "Inglés de negocios I"],
            [8] = ["Gerencia estratégica", "Formulación y evaluación de proyectos", "Gestión del talento humano II", "Inglés de negocios II"],
            [9] = ["Consultorio empresarial", "Gerencia de proyectos", "Simulación gerencial", "Inglés de negocios III", "Trabajo de grado"],
        });

        // ============================================================
        // CONTADURÍA PÚBLICA
        // ============================================================
        SeedCareer("Contaduría Pública", 9, new Dictionary<int, string[]>
        {
            [1] = ["Introducción a la contaduría", "Matemáticas aplicadas", "Procesos comunicativos", "Fundamentos de administración", "Pensamiento lógico matemático"],
            [2] = ["Contabilidad financiera I", "Sociología empresarial", "Estadística", "Fundamentos de economía", "Derecho constitucional"],
            [3] = ["Contabilidad financiera II", "Matemáticas financieras", "Emprendimiento", "Derecho comercial", "Microeconomía"],
            [4] = ["Contabilidad financiera III", "Derecho laboral", "Macroeconomía", "Ciencia, tecnología y desarrollo"],
            [5] = ["Contabilidad financiera IV", "Legislación tributaria I", "Sistemas de información contable", "Teoría e investigación contable", "Gestión de operaciones"],
            [6] = ["Costos I", "Contabilidad y presupuesto público", "Legislación tributaria II", "Investigación de mercados"],
            [7] = ["Costos II", "Análisis financiero", "Legislación tributaria III", "Control interno y auditoría"],
            [8] = ["Contabilidad internacional", "Presupuestos", "Auditoría financiera y NIAS", "Gerencia financiera"],
            [9] = ["Contabilidades especiales", "Formulación y evaluación de proyectos", "Revisoría fiscal"],
        });

        // ============================================================
        // ECONOMÍA
        // ============================================================
        SeedCareer("Economía", 10, new Dictionary<int, string[]>
        {
            [1] = ["Ciencia, tecnología y desarrollo", "Derecho constitucional colombiano", "Pensamiento lógico matemático", "Introducción a la economía", "Procesos comunicativos", "Cálculo I"],
            [2] = ["Contabilidad", "Microeconomía I", "Economía política I", "Fundamentos de administración", "Cálculo II", "Cátedra de la Orinoquia"],
            [3] = ["Álgebra lineal y programación lineal", "Microeconomía II", "Economía política II", "Nueva geografía económica", "Costos y presupuestos", "Sociología"],
            [4] = ["Historia económica de Colombia", "Matemáticas financieras", "Macroeconomía I", "Teoría de juegos", "Estadística I"],
            [5] = ["Estadística II", "Macroeconomía II", "Cuentas nacionales", "Metodología de la investigación", "Análisis financiero"],
            [6] = ["Economía latinoamericana", "Teoría y política monetaria y bancaria", "Econometría I", "Economía regional", "Teoría de las finanzas públicas"],
            [7] = ["Planeación del desarrollo", "Econometría II", "Teoría y política agraria", "Pensamiento económico", "Teoría y política fiscal"],
            [8] = ["Derecho económico", "Formulación y evaluación financiera de proyectos", "Teoría y política del comercio internacional", "Economía ambiental"],
            [9] = ["Desarrollo económico y social", "Opción de grado I", "Evaluación socioeconómica de proyectos"],
            [10] = ["Política industrial y de servicios", "Opción de grado II", "Seminario políticas de coyuntura"],
        });

        // ============================================================
        // MERCADEO
        // ============================================================
        SeedCareer("Mercadeo", 9, new Dictionary<int, string[]>
        {
            [1] = ["Matemáticas", "Procesos comunicativos", "Principios de mercadeo", "Fundamentos de administración", "Antropología", "Psicología"],
            [2] = ["Estadística I", "Contabilidad empresarial", "Estrategias de producto", "Microeconomía", "Sociología", "Pensamiento lógico matemático"],
            [3] = ["Estadística II", "Costos y presupuesto", "Comportamiento del consumidor", "Macroeconomía", "Cátedra democracia y paz"],
            [4] = ["Cátedra de la Orinoquia", "Investigación cuantitativa de mercados", "Matemáticas financieras", "Estrategia de precio", "Ciencia, tecnología y desarrollo"],
            [5] = ["Investigación cualitativa de mercados", "Análisis financiero", "Distribución y logística", "Entornos globales", "Metodología de la investigación"],
            [6] = ["Mercadeo agroindustrial", "Mercadeo internacional", "Publicidad", "Mercadeo de servicios", "Planeación estratégica de marketing", "Ética"],
            [7] = ["Merchandising y promoción de venta", "Relaciones públicas y organización de eventos", "Gestión de la calidad"],
            [8] = ["Marketing electrónico", "Derecho empresarial", "Formulación y evaluación de proyectos"],
            [9] = ["Gerencia comercial", "Servicio al cliente", "Marketing social", "Gerencia estratégica de marketing", "Trabajo de grado"],
        });

        // ============================================================
        // COMUNICACIÓN AUDIOVISUAL
        // ============================================================
        SeedCareer("Comunicación Audiovisual", 8, new Dictionary<int, string[]>
        {
            [1] = ["Procesos comunicativos", "Introducción a la Narratología", "Fundamentos de Apreciación cinematográfica", "Cultura, comunicación y territorio", "Procesos creativos", "Taller I: Introducción al audiovisual", "Escritura de Guiones"],
            [2] = ["Argumentación y debate: Historia contemporánea", "Taller II: Dirección", "Teorías del cine", "Preparación de actores", "Tecnología del video I", "Apreciación Audiovisual I", "Historia de las artes"],
            [3] = ["Cátedra democracia y paz", "Taller III: Producción de audiovisuales", "Teorías de la comunicación I", "Mercadeo y diseño", "Tecnología del video II", "Exploración investigativa", "Pensamiento lógico matemático"],
            [4] = ["Ciencia, tecnología y desarrollo", "Taller IV: Dirección de fotografía", "Teorías de la comunicación II", "Historia de la imagen", "Apreciación Audiovisual II", "Documental I"],
            [5] = ["Taller V: Dirección de sonido", "Investigación en comunicación", "Fundamentos de música", "Ética", "Documental II", "Audiovisual comunitario I"],
            [6] = ["Taller VI: Dirección de arte", "Investigación creación", "Semiótica", "Animación I", "Apreciación Audiovisual III", "Audiovisual comunitario II"],
            [7] = ["Taller VII: Montaje", "Opción de grado I", "Colorización y Efectos visuales", "Televisión y otros formatos audiovisuales", "Animación II"],
            [8] = ["Medios informativos", "Bases de programación", "Opción de grado II", "Transmedia", "Innovación en comunicación", "Cátedra de la Orinoquia"],
        });

        // ============================================================
        // LICENCIATURA EN EDUCACIÓN CAMPESINA Y RURAL
        // ============================================================
        SeedCareer("Licenciatura en Educación Campesina y Rural", 10, new Dictionary<int, string[]>
        {
            [1] = ["Procesos comunicativos", "Fundamentos de antropología", "Epistemología de la educación", "Biología", "Fundamentos de la producción agropecuaria"],
            [2] = ["Desarrollo del pensamiento lógico matemático", "Fundamentos de sociología", "Desarrollo humano y social", "Bioquímica", "Suelos, fertilidad y manejo"],
            [3] = ["Aprendizaje y educación", "Zoología", "Botánica", "Recursos naturales", "Ingeniería para las explotaciones agropecuarias", "Modelos pedagógicos de educación rural"],
            [4] = ["Sanidad vegetal", "Nutrición animal", "Bioestadística", "Diversidad y educación rural. Práctica de observación", "Didáctica de la educación rural", "Cátedra de la Orinoquia"],
            [5] = ["Genética y mejoramiento animal y vegetal", "Horticultura y seguridad alimentaria", "Proyectos pedagógicos productivos (práctica de intervención I)", "Didáctica de la educación comunitaria", "Ciencia, tecnología y desarrollo"],
            [6] = ["Geografía humana y social", "Sanidad animal", "Economía y finanzas", "Educación y extensión rural (práctica de intervención II)", "Investigación y sistematización de experiencias", "Cátedra democracia y paz"],
            [7] = ["Ambientes, mediaciones pedagógicas y evaluación", "Política agraria y legislación educativa", "Cultivos agrícolas", "Proyecto escuelas saludables (práctica de investigación I)"],
            [8] = ["Ética y docencia", "Producción de especies menores", "Administración y agro negocios", "Contextos educativos rurales (práctica de investigación II)"],
            [9] = ["Producción de especies mayores", "Organización comunitaria y emprendimiento agroindustrial (práctica de intervención III)", "Contextos rurales comunitarios (práctica de investigación III)"],
            [10] = ["Práctica profesional docente", "Opción de grado"],
        });

        // ============================================================
        // LICENCIATURA EN EDUCACIÓN FÍSICA Y DEPORTE
        // ============================================================
        SeedCareer("Licenciatura en Educación Física y Deporte", 10, new Dictionary<int, string[]>
        {
            [1] = ["Procesos comunicativos", "Bioquímica y nutrición", "Seminario de investigación I", "Problemas históricos de la pedagogía", "Expresiones motrices I"],
            [2] = ["Desarrollo cognitivo", "Pensamiento lógico matemático", "Morfología funcional del aparato locomotor", "Sujeto y educación", "Problemas epistemológicos de la pedagogía", "Expresiones motrices II"],
            [3] = ["Motricidad y desarrollo humano", "Expresiones motrices III", "Fisiología humana", "Historia y epistemología de la educación física", "Ciencia, tecnología y desarrollo", "Corrientes pedagógicas contemporáneas de la educación física", "Cátedra democracia y paz"],
            [4] = ["Seminario de investigación II", "Práctica educativa escolar", "Motricidad y fases sensibles", "Educación e interculturalidad", "Expresiones motrices IV"],
            [5] = ["Fisiología del esfuerzo", "Expresiones motrices V", "Didáctica general y de la educación física", "Pedagogía lúdica", "Escuela e inclusión", "Gestión de la educación física y el deporte", "Mediaciones pedagógicas"],
            [6] = ["Biomecánica y análisis del movimiento", "Expresiones motrices VI", "Cátedra de la Orinoquia", "Práctica educativa media", "Investigación I"],
            [7] = ["Fundamentos del entrenamiento y preparación deportiva", "Expresiones motrices VII", "Currículo y evaluación de la educación física", "Ocio y tiempo libre", "Cuerpo, sujeto y cultura"],
            [8] = ["Necesidades educativas especiales", "Educación física y ambientalismo", "Expresiones motrices VIII", "Investigación II"],
            [9] = ["Práctica educativa extraescolar", "Deontología del campo profesoral"],
            [10] = ["Trabajo de grado", "Práctica profesional docente"],
        });

        // ============================================================
        // LICENCIATURA EN EDUCACIÓN INFANTIAL
        // ============================================================
        SeedCareer("Licenciatura en Educación Infantil", 10, new Dictionary<int, string[]>
        {
            [1] = ["Historia y epistemología de la pedagogía I", "Identidad docente y constitución de si", "Procesos comunicativos", "Pensamiento lógico matemático", "Juego y educación infantil", "Educación, cuerpo y movimiento", "Seminario de pis, investigación biográfica-narrativa"],
            [2] = ["Historia y epistemología de la pedagogía II", "Ética, interacción humana y educación", "Matemática I", "Desarrollo humano, aprendizaje y educación", "Expresión musical y didáctica", "Seminario de práctica: infancia, escuela y maestro", "Seminario de pis: investigación biográfico-narrativa"],
            [3] = ["Neuropedagogía", "Didáctica del juego dramático y coreográfico", "Práctica: entornos educativos y socioculturales de la infancia", "Escenarios de socialización del niño", "Representaciones sociales de infancia", "Seminario de pis. Cartografía social", "Cátedra de la Orinoquia"],
            [4] = ["Género, cultura y educación", "Tecnologías de la comunicación como mediaciones", "Expresión plástica y didáctica", "Práctica: entornos protectores de infancia", "Filosofía para niños", "Seminario de pis. Cartografía social", "Cátedra democracia y paz"],
            [5] = ["Literatura infantil", "Evaluación del desarrollo y aprendizaje", "Práctica: primera infancia I", "Perspectivas pedagógicas de la educación infantil", "Desarrollo y formación del niño en los años iniciales", "Seminario de pis. Estudio de caso"],
            [6] = ["Didáctica de las matemáticas", "Didáctica de la lectura, la escritura y la oralidad", "Práctica: primera infancia II", "Desarrollo y formación en la infancia", "Seminario de pis. Estudio de caso"],
            [7] = ["Diversidad funcional y sociocultural", "Práctica: educación y diversidad", "Metodología. La infancia como campo de investigación I", "Seminario de pis. Etnografía"],
            [8] = ["Práctica: escuela y entornos de aprendizaje", "Metodología. La infancia como campo de investigación II", "Seminario. Investigación acción"],
            [9] = ["Legislación, gestión y currículo", "Seminario de investigación acción", "Práctica: la escuela como escenario de investigación I"],
            [10] = ["Práctica educativa: la escuela como escenario de investigación II", "Trabajo de grado"],
        });

        // ============================================================
        // LICENCIATURA EN ESPAÑOL E INGLES
        // ============================================================
        SeedCareer("Licenciatura en Español e Inglés", 10, new Dictionary<int, string[]>
        {
            [1] = ["Pensamiento Lógico – Matemático", "Psicolingüística", "Literatura general", "Lingüística", "Listening and speaking in second language I", "Reading and writing in second language I"],
            [2] = ["Cátedra de la Orinoquia", "Ética Educativa", "Ciencia, Tecnología y Desarrollo", "Literatura hispanoamericana", "Morfosintaxis", "Listening and speaking in second language II", "Reading and writing in second language II"],
            [3] = ["Cátedra democracia y paz", "Sociología de la educación", "Sociolingüística", "Listening and speaking in second language III", "Reading and writing in second language III", "Phonetics and phonology"],
            [4] = ["Administración, currículo y legislación", "English language history and culture", "Listening and speaking in second language IV", "Reading and writing in second language IV", "Linguistics", "Corrientes pedagógicas contemporáneas: Práctica de Observación 1"],
            [5] = ["Etnoeducación", "English Literature", "Listening and speaking in second language V", "Reading and writing in second language V", "Educación inclusiva", "Tendencias educativas de la enseñanza de una segunda lengua: Práctica de observación 2"],
            [6] = ["Advanced grammar", "Academic writing", "Quantitative and qualitative research", "Strategies and approaches for ICT-enhanced learning", "Didactics I", "Didáctica de la Lengua Castellana"],
            [7] = ["Educational research", "Didactics II", "Práctica I", "Práctica de la lengua castellana"],
            [8] = ["Language teaching and learning research", "Didactics III", "Práctica II", "Enseñanza del Español como L2"],
            [9] = ["Práctica investigativa y trabajo de grado", "Práctica III"],
            [10] = ["Práctica docente"],
        });

        // ============================================================
        // LICENCIATURA EN MATEMÁTICAS
        // ============================================================
        SeedCareer("Licenciatura en Matemáticas", 10, new Dictionary<int, string[]>
        {
            [1] = ["Precálculo", "Geometría euclidiana", "Fundamentos de matemáticas", "Procesos comunicativos", "Epistemología de la educación"],
            [2] = ["Cálculo diferencial", "Geometría analítica", "Teoría de conjuntos", "Física introductoria", "Corrientes pedagógicas contemporáneas: práctica de observación I"],
            [3] = ["Cálculo integral", "Teoría de números", "Tendencias educativas en matemáticas: práctica de observación II", "Mecánica I"],
            [4] = ["Cálculo multivariado", "Álgebra lineal", "Didáctica de la aritmética", "Mecánica II", "Desarrollo humano, aprendizaje y educación"],
            [5] = ["Ecuaciones diferenciales", "Didáctica de la geometría", "Práctica I: enseñanza de la aritmética", "Estadística I", "Sociedad, cultura y educación"],
            [6] = ["Etnomatemática: práctica de observación III", "Didáctica del álgebra", "Estadística II", "Práctica II: enseñanza de la geometría", "Administración educativa y currículo", "Cátedra de la Orinoquia"],
            [7] = ["Álgebra moderna", "Práctica III: enseñanza del álgebra", "Educación en la diversidad: práctica de observación IV", "Didáctica de la probabilidad y la estadística"],
            [8] = ["Análisis matemático", "Didáctica del cálculo", "Didáctica de la trigonometría", "Práctica IV: enseñanza probabilidad y la estadística"],
            [9] = ["Historia de la matemática", "Práctica V: enseñanza del cálculo y la trigonometría", "Práctica pedagógica investigativa", "Cátedra democracia y paz"],
            [10] = ["Práctica profesional docente", "Trabajo de grado"],
        });

        // ============================================================
        // SOCIOLOGÍA
        // ============================================================
        SeedCareer("Sociología", 9, new Dictionary<int, string[]>
        {
            [1] = ["Introducción a la sociología", "Geografía social y humana", "Comunicación y sociedad", "Geopolítica y geocultura", "Pensamiento lógico-matemático", "Introducción a la investigación en ciencias sociales", "Cátedra democracia y paz"],
            [2] = ["Historia del pensamiento social moderno", "Fundamentos de antropología", "Introducción a la psicología social", "Ecología social y política", "Procesos comunicativos", "Teoría clásica I", "Ciencia, tecnología y desarrollo"],
            [3] = ["Historia social de Colombia", "Organización social y sociología", "Fundamentos de economía", "Población y demografía", "Teoría clásica II", "Diseños de investigación social", "Cátedra de la Orinoquia"],
            [4] = ["Políticas públicas", "Teoría clásica III", "Sociología latinoamericana", "Métodos y técnicas de investigación social cuantitativa I", "Métodos y técnicas de investigación social cualitativa y participativa I", "Sociedad, migración y género"],
            [5] = ["Teoría contemporánea I", "Análisis sociológico de Colombia", "Sociología del desarrollo", "Sociología especial I", "Métodos y técnicas de investigación social cuantitativa II", "Métodos y técnicas de investigación social cualitativa y participativa II"],
            [6] = ["Teoría contemporánea II", "Sociología de la cultura", "Sociología especial II", "Estadística para Ciencias sociales", "Actores sociales y territorio", "Taller de escritura científica"],
            [7] = ["Teoría contemporánea III", "Sociología del conflicto", "Sociología especial III", "Práctica de investigación social", "Planeación participativa y desarrollo territorial"],
            [8] = ["Sociología ambiental", "Sociología especial IV", "Intervención social y comunitaria", "Seminario Proyecto Opción de grado"],
            [9] = ["Práctica profesional", "Opción de grado"],
        });

        // Seed all subjects at the end
        var subjectData = subjects.Select(kv => new { Id = kv.Value, SubjectName = kv.Key }).ToArray();
        builder.Entity<Subject>().HasData(subjectData);
    }
}
