package main

import (
	"github.com/StevenLie14/go-bug/database"
	"github.com/StevenLie14/go-bug/grpc"
	"github.com/StevenLie14/go-bug/repository"
	"github.com/StevenLie14/go-bug/service"
)

func main() {
	db := database.ConnectDatabase()
	userRepository := repository.NewUserRepository(db)
	userService := service.NewUserService(userRepository)
	server := grpc.NewGrpcServer(8080, userService)

	defer server.Stop()
	server.Start()
}
