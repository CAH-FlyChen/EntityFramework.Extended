﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tracker.SqlServer.CodeFirst.Mapping
{
    public partial class StatusMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tracker.SqlServer.CodeFirst.Entities.Status>
    {
        public StatusMap()
        {
            // table
            ToTable("Status", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .IsOptional();
            Property(t => t.Order)
                .HasColumnName("Order")
                .IsRequired();
            Property(t => t.CreatedDate)
                .HasColumnName("CreatedDate")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
            Property(t => t.RowVersion)
                .HasColumnName("RowVersion")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .IsRowVersion()
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}

