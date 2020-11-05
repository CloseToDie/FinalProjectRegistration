using System;
using System.Collections.Generic;
using FinalProjectRegistration.Core.DomainServices;
using Moq;
using Xunit;

namespace XUnitTest
{
    public class StudentServiceTest
    {
        private Mock<IStudentRepository> repoMock;

        public StudentServiceTest()
        {
            repoMock = new Mock<IStudentRepository>();
        }
    }
}