using ArchMvc.Domain.Entities;
using ArchMvc.Domain.Validation;
using FluentAssertions;
using Xunit;

namespace ArchMvc.Domain.Test {
    public class CategoryUnitTest1 {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState() 
        {
            Action action = () => new Category(1, "Category Name");

            action.Should()
                  .NotThrow<DomainExceptionValidation>();
        }
    }
}