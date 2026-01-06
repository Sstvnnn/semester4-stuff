package database

import (
	"github.com/StevenLie14/go-bug/model"
	"gorm.io/driver/postgres"
	"gorm.io/gorm"
)

func ConnectDatabase() *gorm.DB {
	//TODO
	dsn := "postgres://postgres:admin@localhost:5432/go-bug"
	db, err := gorm.Open(postgres.Open(dsn), &gorm.Config{})
	
	if err != nil {
		panic(err)
	}

	err = db.AutoMigrate(
		&model.User{},
	)

	if err != nil {
		panic(err)
	}

	return db

}
