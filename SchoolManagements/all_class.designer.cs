﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagements
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="School")]
	public partial class all_classDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertNote(Note instance);
    partial void UpdateNote(Note instance);
    partial void DeleteNote(Note instance);
    partial void InsertTeacher(Teacher instance);
    partial void UpdateTeacher(Teacher instance);
    partial void DeleteTeacher(Teacher instance);
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    #endregion
		
		public all_classDataContext() : 
				base(global::SchoolManagements.Properties.Settings.Default.SchoolConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public all_classDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public all_classDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public all_classDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public all_classDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Note> Notes
		{
			get
			{
				return this.GetTable<Note>();
			}
		}
		
		public System.Data.Linq.Table<Teacher> Teachers
		{
			get
			{
				return this.GetTable<Teacher>();
			}
		}
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Courses")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Course_Id;
		
		private string _Name;
		
		private System.Nullable<int> _TID;
		
		private System.Nullable<int> _SID;
		
		private System.Nullable<int> _NID;
		
		private EntityRef<Note> _Note;
		
		private EntityRef<Teacher> _Teacher;
		
		private EntityRef<student> _student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCourse_IdChanging(int value);
    partial void OnCourse_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTIDChanging(System.Nullable<int> value);
    partial void OnTIDChanged();
    partial void OnSIDChanging(System.Nullable<int> value);
    partial void OnSIDChanged();
    partial void OnNIDChanging(System.Nullable<int> value);
    partial void OnNIDChanged();
    #endregion
		
		public Course()
		{
			this._Note = default(EntityRef<Note>);
			this._Teacher = default(EntityRef<Teacher>);
			this._student = default(EntityRef<student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Course_Id
		{
			get
			{
				return this._Course_Id;
			}
			set
			{
				if ((this._Course_Id != value))
				{
					this.OnCourse_IdChanging(value);
					this.SendPropertyChanging();
					this._Course_Id = value;
					this.SendPropertyChanged("Course_Id");
					this.OnCourse_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TID", DbType="Int")]
		public System.Nullable<int> TID
		{
			get
			{
				return this._TID;
			}
			set
			{
				if ((this._TID != value))
				{
					if (this._Teacher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTIDChanging(value);
					this.SendPropertyChanging();
					this._TID = value;
					this.SendPropertyChanged("TID");
					this.OnTIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SID", DbType="Int")]
		public System.Nullable<int> SID
		{
			get
			{
				return this._SID;
			}
			set
			{
				if ((this._SID != value))
				{
					if (this._student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSIDChanging(value);
					this.SendPropertyChanging();
					this._SID = value;
					this.SendPropertyChanged("SID");
					this.OnSIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NID", DbType="Int")]
		public System.Nullable<int> NID
		{
			get
			{
				return this._NID;
			}
			set
			{
				if ((this._NID != value))
				{
					if (this._Note.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNIDChanging(value);
					this.SendPropertyChanging();
					this._NID = value;
					this.SendPropertyChanged("NID");
					this.OnNIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Note_Course", Storage="_Note", ThisKey="NID", OtherKey="Note_Id", IsForeignKey=true)]
		public Note Note
		{
			get
			{
				return this._Note.Entity;
			}
			set
			{
				Note previousValue = this._Note.Entity;
				if (((previousValue != value) 
							|| (this._Note.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Note.Entity = null;
						previousValue.Courses.Remove(this);
					}
					this._Note.Entity = value;
					if ((value != null))
					{
						value.Courses.Add(this);
						this._NID = value.Note_Id;
					}
					else
					{
						this._NID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Note");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_Course", Storage="_Teacher", ThisKey="TID", OtherKey="teacher_Id", IsForeignKey=true)]
		public Teacher Teacher
		{
			get
			{
				return this._Teacher.Entity;
			}
			set
			{
				Teacher previousValue = this._Teacher.Entity;
				if (((previousValue != value) 
							|| (this._Teacher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teacher.Entity = null;
						previousValue.Courses.Remove(this);
					}
					this._Teacher.Entity = value;
					if ((value != null))
					{
						value.Courses.Add(this);
						this._TID = value.teacher_Id;
					}
					else
					{
						this._TID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Teacher");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_Course", Storage="_student", ThisKey="SID", OtherKey="Student_Id", IsForeignKey=true)]
		public student student
		{
			get
			{
				return this._student.Entity;
			}
			set
			{
				student previousValue = this._student.Entity;
				if (((previousValue != value) 
							|| (this._student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student.Entity = null;
						previousValue.Courses.Remove(this);
					}
					this._student.Entity = value;
					if ((value != null))
					{
						value.Courses.Add(this);
						this._SID = value.Student_Id;
					}
					else
					{
						this._SID = default(Nullable<int>);
					}
					this.SendPropertyChanged("student");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Note")]
	public partial class Note : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _Course_Id;
		
		private int _Note_Id;
		
		private System.Nullable<int> _Tech_Id;
		
		private System.Nullable<int> _Stu_Id;
		
		private string _Note_link;
		
		private EntitySet<Course> _Courses;
		
		private EntityRef<Teacher> _Teacher;
		
		private EntityRef<student> _student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourse_IdChanging(System.Nullable<int> value);
    partial void OnCourse_IdChanged();
    partial void OnNote_IdChanging(int value);
    partial void OnNote_IdChanged();
    partial void OnTech_IdChanging(System.Nullable<int> value);
    partial void OnTech_IdChanged();
    partial void OnStu_IdChanging(System.Nullable<int> value);
    partial void OnStu_IdChanged();
    partial void OnNote_linkChanging(string value);
    partial void OnNote_linkChanged();
    #endregion
		
		public Note()
		{
			this._Courses = new EntitySet<Course>(new Action<Course>(this.attach_Courses), new Action<Course>(this.detach_Courses));
			this._Teacher = default(EntityRef<Teacher>);
			this._student = default(EntityRef<student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course_Id", DbType="Int")]
		public System.Nullable<int> Course_Id
		{
			get
			{
				return this._Course_Id;
			}
			set
			{
				if ((this._Course_Id != value))
				{
					this.OnCourse_IdChanging(value);
					this.SendPropertyChanging();
					this._Course_Id = value;
					this.SendPropertyChanged("Course_Id");
					this.OnCourse_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Note_Id
		{
			get
			{
				return this._Note_Id;
			}
			set
			{
				if ((this._Note_Id != value))
				{
					this.OnNote_IdChanging(value);
					this.SendPropertyChanging();
					this._Note_Id = value;
					this.SendPropertyChanged("Note_Id");
					this.OnNote_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tech_Id", DbType="Int")]
		public System.Nullable<int> Tech_Id
		{
			get
			{
				return this._Tech_Id;
			}
			set
			{
				if ((this._Tech_Id != value))
				{
					if (this._Teacher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTech_IdChanging(value);
					this.SendPropertyChanging();
					this._Tech_Id = value;
					this.SendPropertyChanged("Tech_Id");
					this.OnTech_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stu_Id", DbType="Int")]
		public System.Nullable<int> Stu_Id
		{
			get
			{
				return this._Stu_Id;
			}
			set
			{
				if ((this._Stu_Id != value))
				{
					if (this._student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStu_IdChanging(value);
					this.SendPropertyChanging();
					this._Stu_Id = value;
					this.SendPropertyChanged("Stu_Id");
					this.OnStu_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note_link", DbType="VarChar(MAX)")]
		public string Note_link
		{
			get
			{
				return this._Note_link;
			}
			set
			{
				if ((this._Note_link != value))
				{
					this.OnNote_linkChanging(value);
					this.SendPropertyChanging();
					this._Note_link = value;
					this.SendPropertyChanged("Note_link");
					this.OnNote_linkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Note_Course", Storage="_Courses", ThisKey="Note_Id", OtherKey="NID")]
		public EntitySet<Course> Courses
		{
			get
			{
				return this._Courses;
			}
			set
			{
				this._Courses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_Note", Storage="_Teacher", ThisKey="Tech_Id", OtherKey="teacher_Id", IsForeignKey=true)]
		public Teacher Teacher
		{
			get
			{
				return this._Teacher.Entity;
			}
			set
			{
				Teacher previousValue = this._Teacher.Entity;
				if (((previousValue != value) 
							|| (this._Teacher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teacher.Entity = null;
						previousValue.Notes.Remove(this);
					}
					this._Teacher.Entity = value;
					if ((value != null))
					{
						value.Notes.Add(this);
						this._Tech_Id = value.teacher_Id;
					}
					else
					{
						this._Tech_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Teacher");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_Note", Storage="_student", ThisKey="Stu_Id", OtherKey="Student_Id", IsForeignKey=true)]
		public student student
		{
			get
			{
				return this._student.Entity;
			}
			set
			{
				student previousValue = this._student.Entity;
				if (((previousValue != value) 
							|| (this._student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student.Entity = null;
						previousValue.Notes.Remove(this);
					}
					this._student.Entity = value;
					if ((value != null))
					{
						value.Notes.Add(this);
						this._Stu_Id = value.Student_Id;
					}
					else
					{
						this._Stu_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("student");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.Note = this;
		}
		
		private void detach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.Note = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Teacher")]
	public partial class Teacher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _teacher_Id;
		
		private string _Name;
		
		private string _Password;
		
		private System.Nullable<int> _Note_Id;
		
		private EntitySet<Course> _Courses;
		
		private EntitySet<Note> _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onteacher_IdChanging(int value);
    partial void Onteacher_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNote_IdChanging(System.Nullable<int> value);
    partial void OnNote_IdChanged();
    #endregion
		
		public Teacher()
		{
			this._Courses = new EntitySet<Course>(new Action<Course>(this.attach_Courses), new Action<Course>(this.detach_Courses));
			this._Notes = new EntitySet<Note>(new Action<Note>(this.attach_Notes), new Action<Note>(this.detach_Notes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int teacher_Id
		{
			get
			{
				return this._teacher_Id;
			}
			set
			{
				if ((this._teacher_Id != value))
				{
					this.Onteacher_IdChanging(value);
					this.SendPropertyChanging();
					this._teacher_Id = value;
					this.SendPropertyChanged("teacher_Id");
					this.Onteacher_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note_Id", DbType="Int")]
		public System.Nullable<int> Note_Id
		{
			get
			{
				return this._Note_Id;
			}
			set
			{
				if ((this._Note_Id != value))
				{
					this.OnNote_IdChanging(value);
					this.SendPropertyChanging();
					this._Note_Id = value;
					this.SendPropertyChanged("Note_Id");
					this.OnNote_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_Course", Storage="_Courses", ThisKey="teacher_Id", OtherKey="TID")]
		public EntitySet<Course> Courses
		{
			get
			{
				return this._Courses;
			}
			set
			{
				this._Courses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_Note", Storage="_Notes", ThisKey="teacher_Id", OtherKey="Tech_Id")]
		public EntitySet<Note> Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				this._Notes.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = this;
		}
		
		private void detach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = null;
		}
		
		private void attach_Notes(Note entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = this;
		}
		
		private void detach_Notes(Note entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Student_Id;
		
		private string _Name;
		
		private string _Password;
		
		private EntitySet<Course> _Courses;
		
		private EntitySet<Note> _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnStudent_IdChanging(int value);
    partial void OnStudent_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public student()
		{
			this._Courses = new EntitySet<Course>(new Action<Course>(this.attach_Courses), new Action<Course>(this.detach_Courses));
			this._Notes = new EntitySet<Note>(new Action<Note>(this.attach_Notes), new Action<Note>(this.detach_Notes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Student_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Student_Id
		{
			get
			{
				return this._Student_Id;
			}
			set
			{
				if ((this._Student_Id != value))
				{
					this.OnStudent_IdChanging(value);
					this.SendPropertyChanging();
					this._Student_Id = value;
					this.SendPropertyChanged("Student_Id");
					this.OnStudent_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_Course", Storage="_Courses", ThisKey="Student_Id", OtherKey="SID")]
		public EntitySet<Course> Courses
		{
			get
			{
				return this._Courses;
			}
			set
			{
				this._Courses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_Note", Storage="_Notes", ThisKey="Student_Id", OtherKey="Stu_Id")]
		public EntitySet<Note> Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				this._Notes.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.student = this;
		}
		
		private void detach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.student = null;
		}
		
		private void attach_Notes(Note entity)
		{
			this.SendPropertyChanging();
			entity.student = this;
		}
		
		private void detach_Notes(Note entity)
		{
			this.SendPropertyChanging();
			entity.student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Admin_Id;
		
		private string _Name;
		
		private string _Password;
		
		private int _id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdmin_IdChanging(int value);
    partial void OnAdmin_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Admin_Id
		{
			get
			{
				return this._Admin_Id;
			}
			set
			{
				if ((this._Admin_Id != value))
				{
					this.OnAdmin_IdChanging(value);
					this.SendPropertyChanging();
					this._Admin_Id = value;
					this.SendPropertyChanged("Admin_Id");
					this.OnAdmin_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
