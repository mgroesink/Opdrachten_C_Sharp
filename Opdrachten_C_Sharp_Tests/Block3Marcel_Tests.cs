using Opdrachten_C_Sharp.Models.Block1;
using Opdrachten_C_Sharp.Models.Block2;
using Opdrachten_C_Sharp.Models.Block3;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_C_Sharp_Tests
{
    public partial class Block3Tests
    {

        [Fact]
        public void GeneratePassword_ValidLength_PasswordIsCorrectLength()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 10,
                UppercaseLetters = 2,
                LowercaseLetters = 2,
                Digits = 2,
                SpecialCharacters = 2
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.Equal(10, result.Length);
        }

        [Fact]
        public void GeneratePassword_MinimumLengthPassword_UsesAllCharacterTypes()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 8,
                UppercaseLetters = 1,
                LowercaseLetters = 1,
                Digits = 1,
                SpecialCharacters = 1
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.Contains(result, c => char.IsUpper(c));
            Assert.Contains(result, c => char.IsLower(c));
            Assert.Contains(result, c => char.IsDigit(c));
            Assert.Contains(result, c => "+-=%@$&?!".Contains(c));
            Assert.Equal(8, result.Length);
        }

        [Fact]
        public void GeneratePassword_OnlyUppercaseCharacters_GeneratesOnlyUppercase()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 5,
                UppercaseLetters = 5,
                LowercaseLetters = 0,
                Digits = 0,
                SpecialCharacters = 0
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.All(result, c => Assert.True(char.IsUpper(c)));
            Assert.Equal(5, result.Length);
        }

        [Fact]
        public void GeneratePassword_OnlyLowercaseCharacters_GeneratesOnlyLowercase()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 5,
                UppercaseLetters = 0,
                LowercaseLetters = 5,
                Digits = 0,
                SpecialCharacters = 0
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.All(result, c => Assert.True(char.IsLower(c)));
            Assert.Equal(5, result.Length);
        }

        [Fact]
        public void GeneratePassword_OnlyDigits_GeneratesOnlyDigits()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 4,
                UppercaseLetters = 0,
                LowercaseLetters = 0,
                Digits = 4,
                SpecialCharacters = 0
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.All(result, c => Assert.True(char.IsDigit(c)));
            Assert.Equal(4, result.Length);
        }

        [Fact]
        public void GeneratePassword_WithSpecialCharacters_GeneratesSpecialCharacters()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 6,
                UppercaseLetters = 0,
                LowercaseLetters = 0,
                Digits = 0,
                SpecialCharacters = 6
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.All(result, c => Assert.Contains(c, "+-=%@$&?!"));
            Assert.Equal(6, result.Length);
        }

        [Fact]
        public void GeneratePassword_PasswordExceedsMinLength_AddsExtraCharacters()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 6,
                UppercaseLetters = 2,
                LowercaseLetters = 2,
                Digits = 1,
                SpecialCharacters = 1
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.True(result.Length >= 6); // At least minimum length
        }

        [Fact]
        public void GeneratePassword_ExactlyMinLength_CreatesCorrectlySizedPassword()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 8,
                UppercaseLetters = 2,
                LowercaseLetters = 2,
                Digits = 2,
                SpecialCharacters = 2
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.Equal(8, result.Length); // Exactly minimum length
        }

        [Fact]
        public void GeneratePassword_ExceedingCharacterCounts_FillsWithRandomCharacters()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 10,
                UppercaseLetters = 5,
                LowercaseLetters = 5,
                Digits = 5,
                SpecialCharacters = 5
            };

            // Act
            var result = options.GeneratePassword();

            // Assert
            Assert.True(result.Length >= 10); // Should generate at least the minimum length
        }

        [Fact]
        public void GeneratePassword_ValidatesCorrectInputRange()
        {
            // Arrange
            var options = new PasswordOptions
            {
                MinLength = 5, // Invalid: below minimum allowed length
                UppercaseLetters = 1,
                LowercaseLetters = 1,
                Digits = 1,
                SpecialCharacters = 1
            };

            // Act and Assert
            var exception = Assert.Throws<ValidationException>(() => ValidateModel(options));
            Assert.Contains("De minimum lengte moet tussen 6 en 50 liggen.", exception.Message);
        }

        private void ValidateModel(object model)
        {
            var validationContext = new ValidationContext(model);
            Validator.ValidateObject(model, validationContext, validateAllProperties: true);
        }

    }
}
