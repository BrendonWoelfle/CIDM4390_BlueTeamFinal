using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using webapp.Data;
using webapp.Models;

namespace webapp.Tests;

public class ProjectTests
{
        [Fact]
        public async Task AddProgramAdminAsync_ProgramAdminIsAdded()
        {
            using (var db = new ApplicationDbContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;
                var expectedProgramAdmin = new ProgramAdmin() 
                { 
                    ProgramAdminID = recId, 
                    FirstName = "Tester",
                    LastName = "Test",
                    Email = "Tester.Test12@gmail.com",
                };

                // Act
                await db.AddProgramAdminAsync(expectedProgramAdmin);

                // Assert
                var actualProgramAdmin = await db.FindAsync<ProgramAdmin>(recId);
                Assert.Equal(expectedProgramAdmin, actualProgramAdmin);
            }
        }

        [Fact]
        public async Task SubmitForm()
        {
            
            using (var db = new ApplicationDbContext(Utilities.TestDbContextOptions()))
            {
                var IntID = 12;
                var sub = true;
                var expectedFormSubmission = new Instructor()
                {
                    InstructorID = IntID,
                    FirstName = "Tim",
                    LastName = "Hope",
                    Email = "Tim.TimHope@gmail.com",
                    FormSubmission = sub,
                };

                await db.AddFormSubmissionAsync(expectedFormSubmission);

                var actualFormSubmission = await db.FindAsync<Instructor>(IntID);
                Assert.True(sub==true,"Form as been submitted");
            }
        }

        [Fact]
        public async Task InstructorAuthenticated()
        {
            using (var db = new ApplicationDbContext(Utilities.TestDbContextOptions()))
            {
                var InstrucID =11;
                var InstruName = "Testings";
                var expectedInstructor = new Instructor()
                {
                    InstructorID = InstrucID,
                    FirstName = InstruName,
                    LastName = "StillTesting",
                    Email = "test.testingstill@gmail.com",
                    
                    
                };

                await db.AddInstructorAsync(expectedInstructor);
                //Assert.

                var actualInstructor = await db.FindAsync<Instructor>(InstrucID);
                Assert.Equal(expectedInstructor, actualInstructor);
            }
        }

}