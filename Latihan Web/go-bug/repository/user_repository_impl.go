package repository

import (
	"github.com/StevenLie14/go-bug/model"
	"gorm.io/gorm"
)

type UserRepositoryImpl struct {
	db *gorm.DB
}

func NewUserRepository(db *gorm.DB) *UserRepositoryImpl {
	return &UserRepositoryImpl{
		db: db,
	}
}

func (u *UserRepositoryImpl) CreateUser(user *model.User) error{
	result := u.db.Create(user)
	return result.Error
}