﻿using ConsultaAlumnos.API.Entities;

namespace ConsultaAlumnos.API.Data
{
    public interface IProfessorRepository
    {
        IOrderedQueryable<Question> GetPendingQuestions(int userId);
    }
}