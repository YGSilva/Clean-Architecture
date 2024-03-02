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

        [Fact(DisplayName = "Create Category with negative id")]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");

            action.Should()
                  .Throw<DomainExceptionValidation>()
                  .WithMessage("Invalid Id value.");
        }

        [Fact(DisplayName = "Create Category with short category name")]
        public void CreateCategory_ShortCategoryName_DomainExceptionValidation()
        {
            Action action = () => new Category(1, "Ca");

            action.Should()
                  .Throw<DomainExceptionValidation>()
                  .WithMessage("Invalid name. Too short. Minimun 3 characters!");
        }

    }
}