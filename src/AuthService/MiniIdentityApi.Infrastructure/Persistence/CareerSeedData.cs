using Microsoft.EntityFrameworkCore;
using MiniIdentityApi.Domain.Entities;

namespace MiniIdentityApi.Infrastructure.Persistence;

public static class CareerSeedData
{
    public static async Task SeedAsync(AppDbContext dbContext)
    {
        if (await dbContext.Careers.AnyAsync())
            return;

        var careers = new List<Career>();

        // ===================== Ingeniería de Sistemas =====================
        var ingSistemas = new Career("Ingeniería de Sistemas", 10);
        careers.Add(ingSistemas);

        var ingSistemasSubjects = new Dictionary<int, string[]>
        {
            [1] = ["Algoritmia y programación", "Introducción a la ingeniería de sistemas", "Cálculo diferencial", "Procesos comunicativos", "Desarrollo del pensamiento lógico matemático"],
            [2] = ["Programación orientada a objetos", "Sistemas digitales", "Cálculo integral", "Álgebra lineal", "Física mecánica"],
            [3] = ["Democracia y paz", "Estructuras de datos", "Máquinas digitales", "Cálculo multivariado", "Electricidad y magnetismo"],
            [4] = ["Bases de datos", "Sistemas operativos", "Ecuaciones diferenciales y modelado matemático", "Estadística y probabilidad", "Oscilaciones y ondas"],
            [5] = ["Ingeniería de software I", "Pensamiento sistémico", "Matemáticas especiales", "Procesos estocásticos", "Sistemas de comunicación", "Ciencia, tecnología y desarrollo"],
            [6] = ["Ingeniería de software II", "Métodos numéricos", "Procesamiento de señales e imágenes", "Optimización", "Redes de computadores", "Administración financiera para ingeniería"],
            [7] = ["Metodología de la investigación", "Tecnologías avanzadas", "Ética y humanística", "Sistemas distribuidos", "Seguridad de la información", "Formulación y gestión de proyectos"],
            [8] = ["Simulación computacional", "Arquitectura empresarial", "Trabajo de grado 1", "Cátedra de la Orinoquia"],
            [9] = ["Lenguaje de programación", "Cátedra de la Orinoquia"],
            [10] = ["Trabajo de grado 2"]
        };

        foreach (var (semester, subjects) in ingSistemasSubjects)
        {
            foreach (var subjectName in subjects)
            {
                var subject = await GetOrCreateSubject(dbContext, subjectName);
                dbContext.CareerSubjects.Add(new CareerSubject(ingSistemas, subject, semester));
            }
        }

        // ===================== Licenciatura en Educación Física y Deporte =====================
        var eduFisica = new Career("Licenciatura en Educación Física y Deporte", 10);
        careers.Add(eduFisica);

        var eduFisicaSubjects = new Dictionary<int, string[]>
        {
            [1] = ["Procesos comunicativos", "Bioquímica y nutrición", "Seminario de investigación I", "Problemas históricos de la pedagogía", "Expresiones motrices I"],
            [2] = ["Desarrollo cognitivo", "Pensamiento lógico matemático", "Morfología funcional del aparato locomotor", "Sujeto y educación", "Problemas epistemológicos de la pedagogía", "Expresiones motrices II"],
            [3] = ["Motricidad y desarrollo humano", "Expresiones motrices III", "Fisiología humana", "Historia y epistemología de la educación física", "Ciencia, tecnología y desarrollo", "Corrientes pedagógicas contemporáneas de la educación física", "Cátedra democracia y paz"],
            [4] = ["Seminario de investigación II", "Práctica educativa escolar", "Motricidad y fases sensibles", "Educación e interculturalidad", "Expresiones motrices IV"],
            [5] = ["Fisiología del esfuerzo", "Expresiones motrices V", "Didáctica general y de la educación física", "Pedagogía lúdica", "Escuela e inclusión", "Gestión de la educación física y el deporte", "Mediaciones pedagógicas"],
            [6] = ["Biomecánica y análisis del movimiento", "Expresiones motrices VI", "Cátedra Orinoquía", "Práctica educativa media", "Investigación I"],
            [7] = ["Fundamentos del entrenamiento y preparación deportiva", "Expresiones motrices VII", "Currículo y evaluación de la educación física", "Ocio y tiempo libre", "Cuerpo, sujeto y cultura"],
            [8] = ["Necesidades educativas especiales", "Educación física y ambientalismo", "Expresiones motrices VIII", "Investigación II"],
            [9] = ["Práctica educativa extraescolar", "Deontología del campo profesoral"],
            [10] = ["Trabajo de grado", "Práctica profesional docente"]
        };

        foreach (var (semester, subjects) in eduFisicaSubjects)
        {
            foreach (var subjectName in subjects)
            {
                var subject = await GetOrCreateSubject(dbContext, subjectName);
                dbContext.CareerSubjects.Add(new CareerSubject(eduFisica, subject, semester));
            }
        }

        // ===================== Medicina Veterinaria y Zootecnia =====================
        var vetZootecnia = new Career("Medicina Veterinaria y Zootecnia", 10);
        careers.Add(vetZootecnia);

        var vetZootecniaSubjects = new Dictionary<int, string[]>
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
            [10] = ["Práctica profesional", "Desarrollo rural", "Gestión de la calidad alimentaria", "Trabajo de grado"]
        };

        foreach (var (semester, subjects) in vetZootecniaSubjects)
        {
            foreach (var subjectName in subjects)
            {
                var subject = await GetOrCreateSubject(dbContext, subjectName);
                dbContext.CareerSubjects.Add(new CareerSubject(vetZootecnia, subject, semester));
            }
        }

        dbContext.Careers.AddRange(careers);
        await dbContext.SaveChangesAsync();
    }

    private static async Task<Subject> GetOrCreateSubject(AppDbContext dbContext, string subjectName)
    {
        var subject = await dbContext.Subjects.FirstOrDefaultAsync(s => s.SubjectName == subjectName);
        if (subject is null)
        {
            subject = new Subject(subjectName);
            dbContext.Subjects.Add(subject);
        }
        return subject;
    }
}
