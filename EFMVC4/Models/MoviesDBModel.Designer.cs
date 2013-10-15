﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
namespace EFMVC4.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MoviesDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MoviesDBEntities object using the connection string found in the 'MoviesDBEntities' section of the application configuration file.
        /// </summary>
        public MoviesDBEntities() : base("name=MoviesDBEntities", "MoviesDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MoviesDBEntities object.
        /// </summary>
        public MoviesDBEntities(string connectionString) : base(connectionString, "MoviesDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MoviesDBEntities object.
        /// </summary>
        public MoviesDBEntities(EntityConnection connection) : base(connection, "MoviesDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Movie> Movies
        {
            get
            {
                if ((_Movies == null))
                {
                    _Movies = base.CreateObjectSet<Movie>("Movies");
                }
                return _Movies;
            }
        }
        private ObjectSet<Movie> _Movies;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Movies EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMovies(Movie movie)
        {
            base.AddObject("Movies", movie);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MoviesDBModel", Name="Movie")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Movie : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Movie object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="director">Initial value of the Director property.</param>
        public static Movie CreateMovie(global::System.Int32 id, global::System.String title, global::System.String director)
        {
            Movie movie = new Movie();
            movie.Id = id;
            movie.Title = title;
            movie.Director = director;
            return movie;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
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
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Director
        {
            get
            {
                return _Director;
            }
            set
            {
                OnDirectorChanging(value);
                ReportPropertyChanging("Director");
                _Director = StructuralObject.SetValidValue(value, false, "Director");
                ReportPropertyChanged("Director");
                OnDirectorChanged();
            }
        }
        private global::System.String _Director;
        partial void OnDirectorChanging(global::System.String value);
        partial void OnDirectorChanged();

        #endregion

    }

    #endregion

}
