package repository

import "github.com/StevenLie14/go-bug/model"

type UserRepository interface {
	CreateUser(user *model.User) error
}
