﻿using _0._0.DataTransfer.DTO;
using _4._0.Repository.Repository;
using _5._0.DataAcces.Connection;
using _5._0.DataAcces.Entity;

namespace _5._0.DataAcces.Query
{
    public class QStudent : IRepoStudent
    {
        //Query para realizar la inserción de nuevos estudiantes 
        public int Insert(DtoStudent dto)
        {
            using DataBaseContext dbc = new();
            dbc.Students.Add(InitAutoMapper.mapper.Map<Student>(dto));
            return dbc.SaveChanges();
        }

        //Query para realizar el listado de los estudiantes de la base de datos
        public List<DtoStudent> GetAll()
        {
            using DataBaseContext dbc = new();
            return InitAutoMapper.mapper.Map<List<DtoStudent>>(dbc.Students.OrderBy(ob => ob.name).ToList());
        }

        //Query para realizar el listado de los estudiantes por su id de estudiante
        public List<DtoStudent> GetById(string id) 
        { 
            using DataBaseContext dbc = new();
            return InitAutoMapper.mapper.Map<List<DtoStudent>>(dbc.Students.Where(w => w.idStudent == id).ToList());
        }

        //Query para verificar la existencia del estudiante por su código
        public bool ExistsByCode(string code)
        {
            using DataBaseContext dbc = new();
            return dbc.Students.Where(w => w.code == code).Any();
        }
        
        //Query para verificar la existencia del estudiante por su id
        public bool ExistsById(string idStudent)
        {
            using DataBaseContext dbc = new();
            return dbc.Students.Where(w => w.idStudent == idStudent).Any();
        }

        //Query para realizar la eliminación del estudiante
        public int Delete(string idStudent)
        {
            using DataBaseContext dbc = new();
            Student student = dbc.Students.Find(idStudent);

            if (student is null)
            {
                return 0;
            }

            dbc.Students.Remove(student);
            return dbc.SaveChanges();
        }

        //Query para realizar la actualización de la información del estudiante
        public int Update(DtoStudent dto)
        {
            using DataBaseContext dbc = new();
            Student student = dbc.Students.Find(dto.idStudent);
            student.dni = dto.dni;
            student.name = dto.name;
            student.lastName = dto.lastName;
            student.condition = dto.condition;
            student.school = dto.school;
            student.faculty = dto.faculty;
            student.disability = dto.disability;
            student.phone = dto.phone;
            student.address = dto.address;
            student.sex = dto.sex;
            student.studentState = dto.studentState;
            student.password = dto.password;
            student.mail = dto.mail;
            student.code = dto.code;
            return dbc.SaveChanges();
        }

        public string Login(string mail, string password)
        {
            using DataBaseContext dbc = new();
            return dbc.Students.Where(w => w.mail == mail && w.password == password).Select(s => s.idStudent).FirstOrDefault();
        }

    }
}