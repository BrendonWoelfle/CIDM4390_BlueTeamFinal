#nullable disable
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using WebApp1.Data;

using WebApp1.Models;

namespace WebApp1.Models {
    
    public static class SeedData {
        public static void Initialize(IServiceProvider serviceProvider){
            using (var context = new ApbetProjectContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApbetProjectContext>>()))
                {
                    context.Database.EnsureCreated();
                    if (context.Instructor.Any()){
                        return;
                    }
//                 //list intructor
//                     List<Instructor> instructors = null;
                    
                    
//                 //list for instructor
//                 Task<Instructor> inst = context.Instructor.FirstOrDefaultAsync (i => i.InstructorID ==1 );

//                 if (inst.Result == null)
//                 {
//                     instructors = new List<Instructor>(){
//                         new Instructor{
//                             InstructorID=1,
//                             FirstName = "Jeffrey",
//                             LastName = "Babb",
//                             CourseID = 1

//                         }
                        
//                     };
//                     context.Instructor.AddRange(instructors);
//                     context.SaveChanges();


//                  }//end instructor if statement

//                 //  //List for ProgramAdmin
//                 //  List <ProgramAdmin> programAdmins = null;
//                 //  //Information about ProgramAdmin
//                 //  Task<ProgramAdmin> pa = context.ProgramAdmin.FirstOrDefaultAsync(pa => pa.ProgramAdminID==1);
//                 //  if (pa.Result == null){
//                 //      programAdmins = new List<ProgramAdmin>(){
//                 //          new ProgramAdmin{
//                 //              ProgramAdminID =1,
//                 //              FirstName ="Jeffery",
//                 //              LastName ="Babb"
//                 //          }
//                 //      };//end Program admin
//                 //      context.ProgramAdmin.AddRange(programAdmins);
//                 //      context.SaveChanges();

//                 //  }//if statement for programadmin

//                 //  List<ProgramEvaluator> programEvaluators =null;
//                 //  //info for ProgramEva
//                 //  Task<ProgramEvaluator> pe = context.ProgramEvaluator.FirstOrDefaultAsync(e => e.ProgramEvaluatorID==1);

//                 //  if(pe.Result== null){
//                 //      programEvaluators = new List<ProgramEvaluator>{
//                 //          new ProgramEvaluator{
//                 //              ProgramEvaluatorID =1,
//                 //              FirstName="Jeffery",
//                 //              LastName="Babb"
//                 //          }
                         
//                 //      };
//                 //      context.ProgramEvaluator.AddRange(programEvaluators);
//                 //      context.SaveChanges();
//                 //  }//end if statement for PE

//                 //  List<SystemAdmin>systemAdmins = null;
//                 //  //info about systemadmin
//                 //  Task<SystemAdmin> sa = context.SystemAdmin.FirstOrDefaultAsync(sa => sa.SystemAdminID==1);

//                 //  if (sa.Result == null){
//                 //      systemAdmins = new List<SystemAdmin>(){
//                 //         new SystemAdmin{
//                 //             SystemAdminID =1,
//                 //             FirstName ="Jeffery",
//                 //             LastName="Babb"
//                 //         }

//                 //      };//end systemad
//                 //      context.SystemAdmin.AddRange(systemAdmins);
//                 //      context.SaveChanges();
//                 //  }
            }
        }

    }
}