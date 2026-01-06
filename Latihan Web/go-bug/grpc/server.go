package grpc

import (
	"context"
	"fmt"
	"net"

	"github.com/StevenLie14/go-bug/proto"
	"github.com/StevenLie14/go-bug/service"
	"google.golang.org/grpc"
)

type grpcServer struct {
	grpcPort int
	server   *grpc.Server
	userService service.UserService
	proto.UserControllerServer
}

func NewGrpcServer(grpcPort int, userService service.UserService) *grpcServer {
	return &grpcServer{
		grpcPort:     grpcPort,
		server:       grpc.NewServer(),
		userService:  userService,
	}
}

func (s *grpcServer) Start() {
	listener, err := net.Listen("tcp", fmt.Sprintf(":%d", s.grpcPort))
	if err != nil {
		panic(err)
	}
	
	proto.RegisterUserControllerServer(s.server, s)
	err = s.server.Serve(listener)
	if err != nil {
		panic(err)
	}
}

func (s *grpcServer) Stop() {
	s.server.GracefulStop()
}

func (s *grpcServer) CreateUser(ctx context.Context, in *proto.User) (*proto.UserResponse, error) {
	newUser, err := s.userService.CreateUser(in.Name, in.Email, in.Password);
	if err != nil {
		return nil, err
	}

	return &proto.UserResponse{
		Message: "User created successfully",
		User: &proto.User{
			Name:     newUser.Name,
			Email:    newUser.Email,
			Password: newUser.Password,
		},
	}, nil
}

