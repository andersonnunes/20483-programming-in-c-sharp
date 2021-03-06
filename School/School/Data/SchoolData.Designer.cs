﻿//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadados de Relação EDM

[assembly: EdmRelationshipAttribute("SchoolDBModel", "FK__Student__ClassId__1B0907CE", "Teacher", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(School.Data.Teacher), "Student", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(School.Data.Student), true)]

#endregion

namespace School.Data
{
    #region Contextos
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    public partial class SchoolDBEntities : ObjectContext
    {
        #region Construtores
    
        /// <summary>
        /// Inicializa um novo objeto SchoolDBEntities usando a cadeia de conexão localizada na seção 'SchoolDBEntities' do arquivo de configuração do aplicativo.
        /// </summary>
        public SchoolDBEntities() : base("name=SchoolDBEntities", "SchoolDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicialize um novo objeto SchoolDBEntities.
        /// </summary>
        public SchoolDBEntities(string connectionString) : base(connectionString, "SchoolDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicialize um novo objeto SchoolDBEntities.
        /// </summary>
        public SchoolDBEntities(EntityConnection connection) : base(connection, "SchoolDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos Parciais
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propriedades de ObjectSet
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        public ObjectSet<Student> Students
        {
            get
            {
                if ((_Students == null))
                {
                    _Students = base.CreateObjectSet<Student>("Students");
                }
                return _Students;
            }
        }
        private ObjectSet<Student> _Students;
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        public ObjectSet<Teacher> Teachers
        {
            get
            {
                if ((_Teachers == null))
                {
                    _Teachers = base.CreateObjectSet<Teacher>("Teachers");
                }
                return _Teachers;
            }
        }
        private ObjectSet<Teacher> _Teachers;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método preterido para adicionar um novo objeto ao EntitySet Students. Em vez disso, experimente usar o método .Add da propriedade ObjectSet&lt;T&gt; associada.
        /// </summary>
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }
    
        /// <summary>
        /// Método preterido para adicionar um novo objeto ao EntitySet Teachers. Em vez disso, experimente usar o método .Add da propriedade ObjectSet&lt;T&gt; associada.
        /// </summary>
        public void AddToTeachers(Teacher teacher)
        {
            base.AddObject("Teachers", teacher);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SchoolDBModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Método de Fábrica
    
        /// <summary>
        /// Crie um novo objeto Student.
        /// </summary>
        /// <param name="id">Valor inicial da propriedade Id.</param>
        /// <param name="firstName">Valor inicial da propriedade FirstName.</param>
        /// <param name="lastName">Valor inicial da propriedade LastName.</param>
        /// <param name="dateOfBirth">Valor inicial da propriedade DateOfBirth.</param>
        /// <param name="classId">Valor inicial da propriedade ClassId.</param>
        public static Student CreateStudent(global::System.Int32 id, global::System.String firstName, global::System.String lastName, global::System.DateTime dateOfBirth, global::System.Int32 classId)
        {
            Student student = new Student();
            student.Id = id;
            student.FirstName = firstName;
            student.LastName = lastName;
            student.DateOfBirth = dateOfBirth;
            student.ClassId = classId;
            return student;
        }

        #endregion

        #region Propriedades Simples
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                OnDateOfBirthChanging(value);
                ReportPropertyChanging("DateOfBirth");
                _DateOfBirth = StructuralObject.SetValidValue(value, "DateOfBirth");
                ReportPropertyChanged("DateOfBirth");
                OnDateOfBirthChanged();
            }
        }
        private global::System.DateTime _DateOfBirth;
        partial void OnDateOfBirthChanging(global::System.DateTime value);
        partial void OnDateOfBirthChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassId
        {
            get
            {
                return _ClassId;
            }
            set
            {
                OnClassIdChanging(value);
                ReportPropertyChanging("ClassId");
                _ClassId = StructuralObject.SetValidValue(value, "ClassId");
                ReportPropertyChanged("ClassId");
                OnClassIdChanged();
            }
        }
        private global::System.Int32 _ClassId;
        partial void OnClassIdChanging(global::System.Int32 value);
        partial void OnClassIdChanged();

        #endregion

        #region Propriedades de Navegação
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SchoolDBModel", "FK__Student__ClassId__1B0907CE", "Teacher")]
        public Teacher Teacher
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Teacher>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Teacher").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Teacher>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Teacher").Value = value;
            }
        }
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Teacher> TeacherReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Teacher>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Teacher");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Teacher>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Teacher", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SchoolDBModel", Name="Teacher")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Teacher : EntityObject
    {
        #region Método de Fábrica
    
        /// <summary>
        /// Crie um novo objeto Teacher.
        /// </summary>
        /// <param name="id">Valor inicial da propriedade Id.</param>
        /// <param name="firstName">Valor inicial da propriedade FirstName.</param>
        /// <param name="lastName">Valor inicial da propriedade LastName.</param>
        /// <param name="class">Valor inicial da propriedade Class.</param>
        public static Teacher CreateTeacher(global::System.Int32 id, global::System.String firstName, global::System.String lastName, global::System.String @class)
        {
            Teacher teacher = new Teacher();
            teacher.Id = id;
            teacher.FirstName = firstName;
            teacher.LastName = lastName;
            teacher.Class = @class;
            return teacher;
        }

        #endregion

        #region Propriedades Simples
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Class
        {
            get
            {
                return _Class;
            }
            set
            {
                OnClassChanging(value);
                ReportPropertyChanging("Class");
                _Class = StructuralObject.SetValidValue(value, false, "Class");
                ReportPropertyChanged("Class");
                OnClassChanged();
            }
        }
        private global::System.String _Class;
        partial void OnClassChanging(global::System.String value);
        partial void OnClassChanged();

        #endregion

        #region Propriedades de Navegação
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SchoolDBModel", "FK__Student__ClassId__1B0907CE", "Student")]
        public EntityCollection<Student> Students
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Student>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Student");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Student>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Student", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
