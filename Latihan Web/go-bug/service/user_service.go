package service

import "github.com/StevenLie14/go-bug/model"

type UserService interface {
	CreateUser(name, email, password string) (*model.User, error)
}
