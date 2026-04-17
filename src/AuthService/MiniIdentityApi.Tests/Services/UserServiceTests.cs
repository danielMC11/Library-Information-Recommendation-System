using MiniIdentityApi.Application.Services;
using MiniIdentityApi.Domain.Entities;
using MiniIdentityApi.Domain.Enums;
using MiniIdentityApi.Infrastructure.Repositories;
using Xunit;

namespace MiniIdentityApi.Tests.Services;

public class UserServiceTests
{
    [Fact]
    public void AssignRole_ShouldAddRoleToUser()
    {
        // Arrange
        var userRepository = new InMemoryUserRepository();
        var roleRepository = new InMemoryRoleRepository();

        var service = new UserService(userRepository, roleRepository);

        var credential = new Credential("hash", "salt");
        var user = new User("wolfang", "wolfang@example.com", 1, 1, credential);
        var role = new Role("Admin");

        userRepository.Save(user);
        roleRepository.Save(role);

        // Act
        service.AssignRole(user.Id, "Admin");

        // Assert
        var updatedUser = userRepository.FindById(user.Id);
        Assert.NotNull(updatedUser);
        Assert.Single(updatedUser!.Roles);
        Assert.Equal("Admin", updatedUser.Roles[0].Name);
    }

    [Fact]
    public void Deactivate_ShouldChangeUserStatusToInactive()
    {
        // Arrange
        var userRepository = new InMemoryUserRepository();
        var roleRepository = new InMemoryRoleRepository();

        var service = new UserService(userRepository, roleRepository);

        var credential = new Credential("hash", "salt");
        var user = new User("wolfang", "wolfang@example.com", 1, 1, credential);

        userRepository.Save(user);

        // Act
        service.Deactivate(user.Id);

        // Assert
        var updatedUser = userRepository.FindById(user.Id);
        Assert.NotNull(updatedUser);
        Assert.Equal(UserStatus.Inactive, updatedUser!.Status);
    }

    [Fact]
    public void Activate_ShouldChangeUserStatusToActive()
    {
        // Arrange
        var userRepository = new InMemoryUserRepository();
        var roleRepository = new InMemoryRoleRepository();

        var service = new UserService(userRepository, roleRepository);

        var credential = new Credential("hash", "salt");
        var user = new User("wolfang", "wolfang@example.com", 1, 1, credential);

        user.Deactivate();
        userRepository.Save(user);

        // Act
        service.Activate(user.Id);

        // Assert
        var updatedUser = userRepository.FindById(user.Id);
        Assert.NotNull(updatedUser);
        Assert.Equal(UserStatus.Active, updatedUser!.Status);
    }

    [Fact]
    public void UpdateCareerAndSemester_ShouldUpdateUserCareerAndSemester()
    {
        // Arrange
        var userRepository = new InMemoryUserRepository();
        var roleRepository = new InMemoryRoleRepository();

        var service = new UserService(userRepository, roleRepository);

        var credential = new Credential("hash", "salt");
        var user = new User("wolfang", "wolfang@example.com", 1, 1, credential);

        userRepository.Save(user);

        // Act
        service.UpdateCareerAndSemester(user.Id, 2, 4);

        // Assert
        var updatedUser = userRepository.FindById(user.Id);
        Assert.NotNull(updatedUser);
        Assert.Equal(2, updatedUser!.Career);
        Assert.Equal(4, updatedUser.Semester);
    }
}