package service

import (
	"github.com/StevenLie14/go-bug/model"
	"github.com/StevenLie14/go-bug/repository"
)

type UserServiceImpl struct {
	userRepo repository.UserRepository
}

func NewUserService(userRepo repository.UserRepository) *UserServiceImpl {
	return &UserServiceImpl{
		userRepo: userRepo,
	}
}

func (u *UserServiceImpl) CreateUser(name, email, password string) (*model.User, error) {
	user := &model.User{
		Name:     name,
		Email:    email,
		Password: password,
	}
	err := u.userRepo.CreateUser(user)
	if err != nil {
		return nil, err
	}
	return user, nil
}
