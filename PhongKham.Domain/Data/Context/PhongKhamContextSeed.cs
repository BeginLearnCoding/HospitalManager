using Microsoft.EntityFrameworkCore;
using PhongKham.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.Infrastructure.Data.Context
{
    public static class PhongKhamContextSeed
    {
        public static async Task SeedAsync(PhongKhamDbContext phongKhamDbContext)
        {
            /*
            await SeedPatientAsync(phongKhamDbContext);
            await SeedDoctorAsync(phongKhamDbContext);
            */
            await SeedMedicineAsync(phongKhamDbContext);
            await SeedSpecializeAsync(phongKhamDbContext);
            await SeedAppointmentAsync(phongKhamDbContext);
            await SeedInvoiceAsync(phongKhamDbContext);
            await SeedPaymentAsync(phongKhamDbContext);


        }

        private static async Task SeedSpecializeAsync(PhongKhamDbContext phongKhamDbContext)
        {
            // Check if data already exists
            if (phongKhamDbContext.Specializes.Any())
            {
                return;
            }

            // Create new data
            var specialize = new List<Specialize>
        {
                                            new Specialize {specName = "Hồi sức tích cực"},
                                            new Specialize {specName = "Gây mê"},
                                            new Specialize {specName = "Tâm thần"},
                                            new Specialize {specName = "Bệnh truyền nhiễm"},
                                            new Specialize {specName ="Chấn thương chỉnh hình"}
        };

            // Add data to the database
            await phongKhamDbContext.Specializes.AddRangeAsync(specialize);
            await phongKhamDbContext.SaveChangesAsync();
        }

        private static async Task SeedMedicineAsync(PhongKhamDbContext phongKhamDbContext)
        {
            // Check if data already exists
            if (phongKhamDbContext.Medicines.Any())
            {
                return;
            }

            var specializes = await phongKhamDbContext.Specializes.ToListAsync();

            // Create new data
            var medicines = new List<Medicine>
        {
            new Medicine { medName = "Thuốc Hồi sức tích cực 1", medOutdate = DateTime.Now.AddMonths(6), medPrice = 10.0, SpecializeId = specializes[0].Id },
            new Medicine { medName = "Thuốc Hồi sức tích cực 2", medOutdate = DateTime.Now.AddMonths(8), medPrice = 20.0, SpecializeId =  specializes[0].Id },
            new Medicine { medName = "Thuốc Hồi sức tích cực 3", medOutdate = DateTime.Now.AddMonths(9), medPrice = 30.0, SpecializeId =  specializes[0].Id},
              new Medicine { medName = "Thuốc Gây mê 1", medOutdate = DateTime.Now.AddMonths(6), medPrice = 10.0, SpecializeId = specializes[1].Id },
            new Medicine { medName = "Thuốc Gây mê  2", medOutdate = DateTime.Now.AddMonths(8), medPrice = 20.0, SpecializeId =  specializes[1].Id },
            new Medicine { medName = "Thuốc Gây mê 3", medOutdate = DateTime.Now.AddMonths(9), medPrice = 30.0, SpecializeId =  specializes[1].Id},
              new Medicine { medName = "Thuốc Tâm thần 1", medOutdate = DateTime.Now.AddMonths(6), medPrice = 10.0, SpecializeId = specializes[2].Id },
            new Medicine { medName = "Thuốc Tâm thần 2", medOutdate = DateTime.Now.AddMonths(8), medPrice = 20.0, SpecializeId =  specializes[2].Id },
            new Medicine { medName = "Thuốc Tâm thần 3", medOutdate = DateTime.Now.AddMonths(9), medPrice = 30.0, SpecializeId =  specializes[2].Id},
              new Medicine { medName = "Thuốc Bệnh truyền nhiễm 1", medOutdate = DateTime.Now.AddMonths(6), medPrice = 10.0, SpecializeId = specializes[3].Id },
            new Medicine { medName = "Thuốc Bệnh truyền nhiễm 2", medOutdate = DateTime.Now.AddMonths(8), medPrice = 20.0, SpecializeId =  specializes[3].Id },
            new Medicine { medName = "Thuốc Bệnh truyền nhiễm 3", medOutdate = DateTime.Now.AddMonths(9), medPrice = 30.0, SpecializeId =  specializes[3].Id},
              new Medicine { medName = "Thuốc Chấn thương chỉnh hình 1", medOutdate = DateTime.Now.AddMonths(6), medPrice = 10.0, SpecializeId = specializes[4].Id },
            new Medicine { medName = "Thuốc Chấn thương chỉnh hình  2", medOutdate = DateTime.Now.AddMonths(8), medPrice = 20.0, SpecializeId =  specializes[4].Id },
            new Medicine { medName = "Thuốc Chấn thương chỉnh hình  3", medOutdate = DateTime.Now.AddMonths(9), medPrice = 30.0, SpecializeId =  specializes[4].Id}
        };

            // Add data to the database
            await phongKhamDbContext.Medicines.AddRangeAsync(medicines);
            await phongKhamDbContext.SaveChangesAsync();
        }

        private static async Task SeedInvoiceAsync(PhongKhamDbContext phongKhamDbContext)
        {
            if (phongKhamDbContext.Invoices.Any())
            {
                return;
            }

            // Get all appointment
            var appointments = await phongKhamDbContext.Appointments.ToListAsync();

            // Create new data
            var invoices = new List<Invoice>
        {
            new Invoice { InNote = "Invoice 1", InDatetime = DateTime.Now, AppointmentId = appointments[0].Id },
            new Invoice { InNote = "Invoice 2", InDatetime = DateTime.Now.AddDays(1), AppointmentId = appointments[1].Id },
            new Invoice { InNote = "Invoice 3", InDatetime = DateTime.Now.AddDays(2), AppointmentId = appointments[2].Id }
        };
            // Get all medicines
            var medicines = await phongKhamDbContext.Medicines.ToListAsync();

            // Assign the list of medicines to each invoice
            foreach (var invoice in invoices)
            {
                invoice.Medicines = medicines;
            }

            // Add data to the database
            await phongKhamDbContext.Invoices.AddRangeAsync(invoices);
            await phongKhamDbContext.SaveChangesAsync();
        }

        private static async Task SeedPaymentAsync(PhongKhamDbContext phongKhamDbContext)
        {
            if (phongKhamDbContext.Payments.Any())
            {
                return;
            }

            // Get all invoice
            var invoices = await phongKhamDbContext.Invoices.ToListAsync();

            // Create new data
            var payments = new List<Payment>
        {
            new Payment { payDate = DateTime.Now, payAmount = 100.0, PaymentMethod = PaymentMethod.cash, InvoiceId = invoices[0].Id },
            new Payment { payDate = DateTime.Now.AddDays(1), payAmount = 200.0, PaymentMethod = PaymentMethod.banktransfer, InvoiceId = invoices[1].Id },
            new Payment { payDate = DateTime.Now.AddDays(2), payAmount = 300.0, PaymentMethod = PaymentMethod.cash, InvoiceId = invoices[2].Id }
        };

            // Add data to the database
            await phongKhamDbContext.Payments.AddRangeAsync(payments);
            await phongKhamDbContext.SaveChangesAsync();
        }

        private static async Task SeedAppointmentAsync(PhongKhamDbContext phongKhamDbContext)
        {
            if (phongKhamDbContext.Appointments.Any())
            {
                return;
            }

            // Create new data
            var appointments = new List<Appointment>
        {
            new Appointment { appDate = DateTime.Now, appNote = "Appointment 1", appType = AppType.TiemPhong },
            new Appointment { appDate = DateTime.Now.AddDays(1), appNote = "Appointment 2", appType = AppType.XetNghiem },
            new Appointment { appDate = DateTime.Now.AddDays(2), appNote = "Appointment 3", appType = AppType.ChuanDoan }
        };

            // Add data to the database
            await phongKhamDbContext.Appointments.AddRangeAsync(appointments);
            await phongKhamDbContext.SaveChangesAsync();
        }

        private static Task SeedDoctorAsync(PhongKhamDbContext phongKhamDbContext)
        {
            throw new NotImplementedException();
        }

        private static Task SeedPatientAsync(PhongKhamDbContext phongKhamDbContext)
        {
            throw new NotImplementedException();
        }
    }
}
