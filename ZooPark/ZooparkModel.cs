using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ZooPark
{
    public partial class ZooparkModel : DbContext
    {
        public ZooparkModel()
            : base("name=ZooparkModel")
        {
        }

        public virtual DbSet<Болезнь> Болезнь { get; set; }
        public virtual DbSet<Вольер> Вольер { get; set; }
        public virtual DbSet<Должность> Должность { get; set; }
        public virtual DbSet<Животное> Животное { get; set; }
        public virtual DbSet<Журнал_осмотров> Журнал_осмотров { get; set; }
        public virtual DbSet<Журнал_прививок> Журнал_прививок { get; set; }
        public virtual DbSet<Заболевание> Заболевание { get; set; }
        public virtual DbSet<Проверка_вольеров> Проверка_вольеров { get; set; }
        public virtual DbSet<Сотрудник> Сотрудник { get; set; }
        public virtual DbSet<Тип> Тип { get; set; }
        public virtual DbSet<Учетные_записи> Учетные_записи { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Вольер>()
                .Property(e => e.Тип)
                .IsUnicode(false);

            modelBuilder.Entity<Вольер>()
                .Property(e => e.Статус)
                .IsUnicode(false);

            modelBuilder.Entity<Вольер>()
                .HasMany(e => e.Животное)
                .WithRequired(e => e.Вольер1)
                .HasForeignKey(e => e.Вольер)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Вольер>()
                .HasMany(e => e.Проверка_вольеров)
                .WithRequired(e => e.Вольер1)
                .HasForeignKey(e => e.Вольер)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Должность>()
                .Property(e => e.Название)
                .IsUnicode(false);

            modelBuilder.Entity<Должность>()
                .Property(e => e.Заработная_плата)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Должность>()
                .HasMany(e => e.Сотрудник)
                .WithRequired(e => e.Должность1)
                .HasForeignKey(e => e.Должность)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Животное>()
                .Property(e => e.Название)
                .IsUnicode(false);

            modelBuilder.Entity<Животное>()
                .Property(e => e.Тип_среды_обитания)
                .IsUnicode(false);

            modelBuilder.Entity<Животное>()
                .HasMany(e => e.Болезнь)
                .WithRequired(e => e.Животное1)
                .HasForeignKey(e => e.Животное)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Животное>()
                .HasMany(e => e.Журнал_осмотров)
                .WithRequired(e => e.Животное1)
                .HasForeignKey(e => e.Животное)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Животное>()
                .HasMany(e => e.Журнал_прививок)
                .WithRequired(e => e.Животное1)
                .HasForeignKey(e => e.Животное)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Журнал_осмотров>()
                .Property(e => e.Комментарий)
                .IsUnicode(false);

            modelBuilder.Entity<Заболевание>()
                .Property(e => e.Название)
                .IsUnicode(false);

            modelBuilder.Entity<Заболевание>()
                .Property(e => e.Симптомы)
                .IsUnicode(false);

            modelBuilder.Entity<Заболевание>()
                .Property(e => e.Описание)
                .IsUnicode(false);

            modelBuilder.Entity<Заболевание>()
                .HasMany(e => e.Болезнь)
                .WithRequired(e => e.Заболевание1)
                .HasForeignKey(e => e.Заболевание)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Проверка_вольеров>()
                .Property(e => e.Комментарий)
                .IsUnicode(false);

            modelBuilder.Entity<Сотрудник>()
                .Property(e => e.Фамилия)
                .IsUnicode(false);

            modelBuilder.Entity<Сотрудник>()
                .Property(e => e.Имя)
                .IsUnicode(false);

            modelBuilder.Entity<Сотрудник>()
                .Property(e => e.Отчество)
                .IsUnicode(false);

            modelBuilder.Entity<Сотрудник>()
                .Property(e => e.Пол)
                .IsUnicode(false);

            modelBuilder.Entity<Сотрудник>()
                .Property(e => e.Телефон)
                .IsUnicode(false);

            modelBuilder.Entity<Сотрудник>()
                .Property(e => e.Адрес)
                .IsUnicode(false);

            modelBuilder.Entity<Сотрудник>()
                .Property(e => e.Паспорт)
                .IsUnicode(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Журнал_осмотров)
                .WithRequired(e => e.Сотрудник1)
                .HasForeignKey(e => e.Сотрудник)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Журнал_прививок)
                .WithRequired(e => e.Сотрудник1)
                .HasForeignKey(e => e.Сотрудник)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Проверка_вольеров)
                .WithRequired(e => e.Сотрудник1)
                .HasForeignKey(e => e.Сотрудник)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Учетные_записи)
                .WithRequired(e => e.Сотрудник)
                .HasForeignKey(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Тип>()
                .Property(e => e.Код)
                .IsUnicode(false);

            modelBuilder.Entity<Тип>()
                .Property(e => e.Название)
                .IsUnicode(false);

            modelBuilder.Entity<Тип>()
                .HasMany(e => e.Журнал_прививок)
                .WithRequired(e => e.Тип1)
                .HasForeignKey(e => e.Тип)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Учетные_записи>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Учетные_записи>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
