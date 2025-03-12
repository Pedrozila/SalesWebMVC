using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Alice Green", "alice@gmail.com", new DateTime(1985, 7, 15), 1200.0, d1);
            Seller s3 = new Seller(3, "John Doe", "john.doe@gmail.com", new DateTime(1990, 3, 5), 950.0, d2);
            Seller s4 = new Seller(4, "Jane Smith", "jane.smith@gmail.com", new DateTime(1993, 8, 22), 1150.0, d2);
            Seller s5 = new Seller(5, "Michael White", "michael.white@gmail.com", new DateTime(1988, 11, 10), 1020.0, d3);
            Seller s6 = new Seller(6, "Emily Black", "emily.black@gmail.com", new DateTime(1995, 1, 30), 1300.0, d4);

            SalesRecords r1 = new SalesRecords(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecords r2 = new SalesRecords(2, new DateTime(2019, 01, 15), 8000.0, SaleStatus.Pending, s2);
            SalesRecords r3 = new SalesRecords(3, new DateTime(2019, 03, 22), 15000.0, SaleStatus.Billed, s3);
            SalesRecords r4 = new SalesRecords(4, new DateTime(2019, 05, 10), 12000.0, SaleStatus.Canceled, s4);
            SalesRecords r5 = new SalesRecords(5, new DateTime(2019, 07, 19), 9500.0, SaleStatus.Billed, s5);
            SalesRecords r6 = new SalesRecords(6, new DateTime(2019, 08, 01), 13400.0, SaleStatus.Pending, s6);
            SalesRecords r7 = new SalesRecords(7, new DateTime(2020, 02, 03), 7000.0, SaleStatus.Billed, s1);
            SalesRecords r8 = new SalesRecords(8, new DateTime(2020, 04, 12), 11200.0, SaleStatus.Pending, s2);
            SalesRecords r9 = new SalesRecords(9, new DateTime(2020, 06, 25), 14000.0, SaleStatus.Billed, s3);
            SalesRecords r10 = new SalesRecords(10, new DateTime(2020, 09, 30), 8500.0, SaleStatus.Canceled, s4);
            SalesRecords r11 = new SalesRecords(11, new DateTime(2020, 11, 18), 10500.0, SaleStatus.Billed, s5);
            SalesRecords r12 = new SalesRecords(12, new DateTime(2021, 01, 07), 12300.0, SaleStatus.Billed, s6);
            SalesRecords r13 = new SalesRecords(13, new DateTime(2021, 03, 15), 8700.0, SaleStatus.Pending, s1);
            SalesRecords r14 = new SalesRecords(14, new DateTime(2021, 05, 20), 9700.0, SaleStatus.Billed, s2);
            SalesRecords r15 = new SalesRecords(15, new DateTime(2021, 07, 30), 10100.0, SaleStatus.Canceled, s3);
            SalesRecords r16 = new SalesRecords(16, new DateTime(2021, 10, 05), 14300.0, SaleStatus.Billed, s4);
            SalesRecords r17 = new SalesRecords(17, new DateTime(2022, 02, 10), 12000.0, SaleStatus.Billed, s5);
            SalesRecords r18 = new SalesRecords(18, new DateTime(2022, 04, 25), 9500.0, SaleStatus.Pending, s6);
            SalesRecords r19 = new SalesRecords(19, new DateTime(2022, 06, 15), 11500.0, SaleStatus.Billed, s1);
            SalesRecords r20 = new SalesRecords(20, new DateTime(2022, 08, 01), 14500.0, SaleStatus.Billed, s2);
            SalesRecords r21 = new SalesRecords(21, new DateTime(2022, 10, 12), 13300.0, SaleStatus.Canceled, s3);
            SalesRecords r22 = new SalesRecords(22, new DateTime(2023, 01, 18), 7800.0, SaleStatus.Billed, s4);
            SalesRecords r23 = new SalesRecords(23, new DateTime(2023, 03, 28), 9200.0, SaleStatus.Pending, s5);
            SalesRecords r24 = new SalesRecords(24, new DateTime(2023, 05, 14), 13700.0, SaleStatus.Billed, s6);
            SalesRecords r25 = new SalesRecords(25, new DateTime(2023, 07, 22), 9600.0, SaleStatus.Billed, s1);
            SalesRecords r26 = new SalesRecords(26, new DateTime(2023, 09, 06), 11700.0, SaleStatus.Canceled, s2);
            SalesRecords r27 = new SalesRecords(27, new DateTime(2024, 01, 01), 15000.0, SaleStatus.Billed, s3);
            SalesRecords r28 = new SalesRecords(28, new DateTime(2024, 03, 11), 8700.0, SaleStatus.Pending, s4);
            SalesRecords r29 = new SalesRecords(29, new DateTime(2024, 06, 20), 9800.0, SaleStatus.Billed, s5);
            SalesRecords r30 = new SalesRecords(30, new DateTime(2024, 09, 05), 14200.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d2, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();

        }


    }
}
