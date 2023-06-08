using Microsoft.EntityFrameworkCore;
using PhongKham.Core.Entities;

namespace PhongKham.Infrastructure.Data.Context
{
    public class PhongKhamDbContext : DbContext
    {
        public PhongKhamDbContext(DbContextOptions<PhongKhamDbContext> options)
          : base(options)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Specialize> Specializes { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
  


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            /*
            builder.Entity<Doctor>().ToTable("Doctor");
            builder.Entity<Patient>().ToTable("Patient");
            builder.Entity<Payment>().ToTable("Payment");
            builder.Entity<Appointment>().ToTable("Appointment");
            builder.Entity<Invoice>().ToTable("Invoice");
            builder.Entity<Specialize>().ToTable("Specialize");
            builder.Entity<Medicine>().ToTable("Medicine");
            */
           
            var appointment = builder.Entity<Appointment>();
            appointment.HasKey(x => x.Id); //PK
            
            var invoice = builder.Entity<Invoice>();
            invoice.HasKey(x => x.Id);
            invoice.HasOne(x => x.Appointment).WithOne(x => x.Invoice).HasForeignKey<Invoice>(fk => fk.AppointmentId);
        }

    }
}
